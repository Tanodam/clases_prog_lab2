--CREA LA BASE DE DATOS
create database persona

--USA LA BASE DE DATOS CREADA
use persona

--CREA LA TABLA ARTICULOS CON LOS CAMPOS CODIGO, DESCRIPCION Y CANTIDAD
CREATE TABLE Persona (
    id int IDENTITY(1,1) PRIMARY KEY,
    nombre varchar(50),
    apellido varchar(50)
);

--LEER
select * from Persona;