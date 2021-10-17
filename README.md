# pruebaBackend

# Arquitectura 3 capas
Se hizo uso de esta arquitectura al ser una api relativamente pequeña.


DAL: Capa de acceso a datos
BLL: Logica de negocio
Entity: Entidades de la logica de negocio
Presentación: se comunica con las otras capas para brindar servicios

# EntityFrameworkCore
Usado para gestionar la conexion y mapeo de datos con la base de datos

# Arquitectura MVC
Como estandar se utiliza el mvc para la buena comunicación de la aplicación
Modelo: hace referencia a las capas bll, entity, dal
Vista: hace referencia a la presentación donde se le brinda datos al cliente
Controlador: hace referencia a nuestra carpeta de controllers aqui se administran las peticiones
para saber hacia donde deben ir

# configuracion para funcionamiento del back
se requiere tener los siguientes softwares.
- Sql server express
- .Net 5.0

al descargar el proyecto se debe realizar el comando 'dotnet restore' en cada capa para restaurar los nutgeds

en la capa de presentación se debe ubicar el archivo 'appsettings.json' y modificar 'DefaultConnection' por la conexion del pc donde se encuentre este proyecto.

en la capa de datos 'DAL' se deben ejecutar los siguientes comandos.
en caso de no tener las herramientas de entityframework se ejecuta este comando
- dotnet tool install --global dotnet-ef

si en la capa de datos 'DAL' no se encuentra la carpeta 'Migrations' se debe realizar el siguiente comando, tambien se debe ejecutar en caso de realizar modificaciones pero para esto se reemplaza el 'InitialCreate' por cualquier otro nombre.
- dotnet ef migrations add InitialCreate -s ../pruebaWeb

este ultimo comando se debe ejecutar cada que hay una modificacion o se esta obteniendo el proyecto por primera ves 

dotnet ef database update -s ../pruebaWeb

# Arrancar la aplicación

ubicarse en la capa de presentacion 'pruebaWeb' abrir la terminal desde ahi y realizar el comando 'dotnet run'

# Realizar pruebas

ubicarse en la capa de test y abrir la terminal en este luego ejecutar el comando 'dotnet test' esto realizara una prueba a la capa de entidades 'Entity'


