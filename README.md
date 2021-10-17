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
