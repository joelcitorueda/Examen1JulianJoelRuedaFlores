CREATE DATABASE EXAMEN1;


CREATE TABLE Personas (
    IDPersona INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    Estado VARCHAR(50)
);

CREATE TABLE Empleado (
    IDEmpleado INT PRIMARY KEY IDENTITY(1,1),
    IDPersona INT FOREIGN KEY REFERENCES Persona(IDPersona),
    Puesto VARCHAR(50),
    Salario DECIMAL(10, 2),
    FechaContratacion DATE
);


INSERT INTO Personas (Nombre, Apellido, Estado)
VALUES 
    ('Juan', 'Perez', 'Activo'),
    ('María', 'González', 'Inactivo'),
    ('Luis', 'Martínez', 'Activo'),
    ('Ana', 'Ramírez', 'Inactivo'),
    ('Pedro', 'Sánchez', 'Activo'),
    ('Laura', 'Díaz', 'Activo'),
    ('Carlos', 'López', 'Inactivo'),
    ('Sofía', 'Torres', 'Activo'),
    ('Jorge', 'Hernández', 'Inactivo'),
    ('Marta', 'Jiménez', 'Activo'),
    ('Andrés', 'Flores', 'Activo'),
    ('Elena', 'Vargas', 'Inactivo'),
    ('Gabriel', 'Cruz', 'Activo'),
    ('Adriana', 'Reyes', 'Inactivo'),
    ('Daniel', 'Morales', 'Activo');



	INSERT INTO Empleado (IDPersona, Puesto, Salario, FechaContratacion)
VALUES 
    (1, 'Gerente', 50000.00, '2020-01-15'),
    (2, 'Analista', 35000.00, '2019-05-20'),
    (3, 'Desarrollador', 40000.00, '2021-03-10'),
    (4, 'Contador', 45000.00, '2022-02-28'),
    (5, 'Diseñador', 38000.00, '2020-11-15'),
    (6, 'Consultor', 42000.00, '2018-09-30'),
    (7, 'Especialista', 47000.00, '2017-07-25'),
    (8, 'Supervisor', 48000.00, '2016-04-12'),
    (9, 'Coordinador', 39000.00, '2015-01-05'),
    (10, 'Técnico', 36000.00, '2023-08-18'),
    (11, 'Analista', 38000.00, '2022-06-30'),
    (12, 'Desarrollador', 41000.00, '2021-04-20'),
    (13, 'Especialista', 45000.00, '2020-02-10'),
    (14, 'Gerente', 52000.00, '2019-09-05'),
    (15, 'Consultor', 43000.00, '2018-11-28');



	select * from empleado;