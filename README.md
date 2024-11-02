## API Rest con .Net 8  

## Descripción  
API Resta para gestión de Usuarios. Se requiere de .Net 8 y Docker. Dentro del proyecto se agregó el Dockerfile.

## Correr proyecto
Copiar carpeta Backend. Abrir solución Backend.sln en Visual Studio, modificar el archivo appsetting.json con la cadena de conexión a la base de datos PostgreSQL a usar.  
Se usó una BDD PostgreSQL local de la laptop, no en otro contenedor. Usar el script crear-base-de-datos.sql en la carpeta Base de datos para crear la BDD.
Correr el proyecto con el botón de ejecución Container (Dockerfile).

## Documentación de API  
Se crea automáticamente con Swagger al ejecutar el proyecto, se puede ver mediante el siguiente link:  
http://localhost:32770/swagger/index.html

