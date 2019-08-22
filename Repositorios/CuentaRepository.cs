using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaT.Models.ViewModel;
using PruebaT.Models.DAL;
using PruebaT.Models;
using PruebaT.Interfaces;
using PruebaT.LogicaN;

namespace PruebaT.Repositorios
{
    public class CuentaRepository : Icuentas
    {
        PruebaTcontext _context;
        private tokenGenerate _token = null;
        private enviarEmail _mail = null;

        public CuentaRepository(PruebaTcontext context)
        {
            _context = context;
        }

        public bool ActualizarPass(cambiarPassVmodel model)
        {
                Usuario user = _context.usuario
                        .Where(t => t.token == model.token)
                        .FirstOrDefault();

                if(user != null)
                {
                    user.password = model.password;
                    user.token = null;

                    _context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    _context.SaveChanges();
                    
                    return true;
                }
                
                return false;
        }

        public bool validarEmailCumpleanio(RestaurarPass model)
        {
            Usuario user = _context.usuario
                        .Where(usuario => usuario.Email == model.email && usuario.FechaNacimiento == model.FechaNacimiento)
                        .FirstOrDefault();
            if(user != null)
            {
                _token = new tokenGenerate();

                string token = _token.generarToken();
                
                user.token = token;

                _context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();

                _mail = new enviarEmail();

                _mail.enviarcorreo(user.Email, token);

                return true;
            }
                        
            return false;
        }

        public bool validarToken(string token)
        {
           bool flag = false; 

           var utoken = _context.usuario
                        .Where(t => t.token == token)
                        .FirstOrDefault();

            if(utoken != null)
            {
                if(utoken.token != null)
                {
                    flag = true;
                }
                    
            }else
            {
                flag = false;
            }
            return flag;
        }

        string Icuentas.obtenerUsuario(LoginVmodel model)
        {
            Usuario usua = null;

            usua = _context.usuario
            .Where(u => u.Email == model.email && u.password == model.password)
            .FirstOrDefault();
            
            if(usua != null)
            {
                return usua.Nombre;
            }else{
                return null;
            }
        }

        


    }

}