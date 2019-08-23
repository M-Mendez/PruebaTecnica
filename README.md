prueba empresa contratante

#Tecnologias utilizadas El proyecto se Realizo con las siguientes tecnologias:

Para el Backend -> .net Core en su Version 2.2.401

Para el Frontend -> Razor, HTML, Bootstrap, Jquery, Javascript

Para la Parte de Base de Datos -> Mysql(MariaDB)

La Comunicacion de la base de datos con el backen se realizo mediante el ORM EntityFramework Core, en su version para Mysql el

cual es Pomelo.EntityFrameworkCore.

El editor de codigo utilizado fue VsCode

#Rutas En la Parte 1 Login = host:port/Cuentas/Index Recuperar Contraseña host:port/Cuentas/RecuperarPass Cambiar Contraseña https://host:port/Cuentas/Restaurar/?token= TokenGenerado

En parte 2 CRUD Lista de empleados = https://host:port/Empleado Crear Empleado = https://host:port/Empleado/Create Edit Empleado = https://host:port/Empleado/Edit Details Empleado = https://host:port/Empleado/Details/id

Eliminar -> funcion existe pero no se implemento por que la logica de borrado depende de las empresas y regularmente se realiza un borrado logico.

En part 3 Palindromos = https://host:port/palindromos

#Por mejorar Parte visual Implementar la logica de sesion cuando un usuario se logea ya que las rutas son accecibles sin que el usuario se loge El la parte de los palindromos unicamente se logro realizar el inciso a.

En la logica de envio de Correos por el cliente SMTP se utiliza gmail como cliente, para su funcionamiente se debe ingresar un correo y contraseña que tenga configurado el uso de aplicaciones terceras.

el usuario y contraseña del usuario de la base de datos deben colocar uno que tenga disponible en su base de datos parar que funcione.
