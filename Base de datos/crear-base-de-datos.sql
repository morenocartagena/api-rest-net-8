-- Crea la base de datos abank
CREATE DATABASE abank2;

-- Conectar a la base de datos abank manualmente

-- Eliminarla tabla usuarios si ya existe
DROP TABLE IF EXISTS usuarios;

-- Crear la tabla usuarios
CREATE TABLE usuarios (
    id SERIAL PRIMARY KEY,
    nombres VARCHAR(255) NOT NULL,
    apellidos VARCHAR(255) NOT NULL,
    fechanacimiento DATE NOT NULL,
    direccion TEXT NOT NULL,
    password VARCHAR(120) NOT NULL,
    telefono VARCHAR(20) NOT NULL,
    email VARCHAR(255) NOT NULL,
    fechacreacion TIMESTAMP DEFAULT CURRENT_TIMESTAMP NOT NULL,
    fechamodificacion TIMESTAMP
);

-- Insertar usuarios de prueba 
INSERT INTO usuarios (nombres, apellidos, fechanacimiento, direccion, password, telefono, email) 
VALUES 
('test', 'test', '1996-05-10', 'direccion', '123', '213212656', 'test@gmail.com'), 
('Mario Efraín', 'Moreno Cartagena', '2024-01-01', 'direccion 2', '123', '23523343', 'test2@gmail.com');