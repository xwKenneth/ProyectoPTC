DROP DATABASE if EXISTS Datos_BancoAmericano;
CREATE DATABASE Datos_BancoAmericano;

USE Datos_BancoAmericano;

CREATE TABLE crear_cliente(
Nombre_cliente VARCHAR(100)  NOT NULL,
FechaNacimiento DATE NOT NULL,
DUI VARCHAR(100) PRIMARY KEY NOT NULL,
Direccion_cliente VARCHAR (120) NOT NULL,
LugarNacimiento VARCHAR(100) NOT NULL,
Nombre_padre VARCHAR(100) NOT NULL,
Nombre_madre VARCHAR(100) NOT NULL,
Numero_celular VARCHAR(100) NOT NULL,
Numero_Casa VARCHAR(40) NOT NULL,
LugarTrabajo VARCHAR(100) NOT NULL,
TelefonoTrabajo VARCHAR(100) NOT NULL,
Beneficiario VARCHAR(60) NOT NULL,
SalarioMensual INT(230)
);

CREATE TABLE prestamos_hipotecarios(
Usuario VARCHAR (100) NOT NULL PRIMARY KEY,
DUI VARCHAR(100) NOT NULL,
Contrasena VARCHAR (100) NOT NULL,
CONSTRAINT FK_DUI FOREIGN KEY (DUI)
REFERENCES crear_cliente(DUI),
NumeroOperacion INT (200),
FechaRegistro DATE NOT NULL,
Nombre_cliente VARCHAR(100)  NOT NULL,
TipoDocumento VARCHAR(70) NOT NULL,
NumeroDocumento VARCHAR(100) NOT NULL,
Direccion_cliente VARCHAR (120) NOT NULL,
Numero_telefono VARCHAR(50) NOT NULL,
Correo_Electronico VARCHAR(150) NOT NULL,
MontoPrestamo INT (250) NOT NULL,
Interes INT (250) NOT NULL,
Numero_Cuotas INT (250) NOT NULL,
Fondo_Pago INT (100) NOT NULL,
Tipo_Moneda VARCHAR(100) NOT NULL,
Fecha_Inicio DATE NOT NULL,
Montos_Cuota INT(250) NOT NULL,
Total_Interes INT (250) NOT NULL,
Monto_Total INT (250) NOT NULL
);

CREATE TABLE prestamos_personales(
Usuario VARCHAR (100) NOT NULL PRIMARY KEY,
DUI VARCHAR(100) NOT NULL,
Contrasena VARCHAR (100) NOT NULL,
CONSTRAINT FK_DUI2 FOREIGN KEY (DUI)
REFERENCES crear_cliente(DUI),
NumeroOperacion INT (200),
FechaRegistro DATE NOT NULL,
Nombre_cliente VARCHAR(100)  NOT NULL,
TipoDocumento VARCHAR(70) NOT NULL,
NumeroDocumento VARCHAR(100) NOT NULL,
Direccion_cliente VARCHAR (120) NOT NULL,
Numero_telefono VARCHAR(50) NOT NULL,
Correo_Electronico VARCHAR(150) NOT NULL,
MontoPrestamo INT (250) NOT NULL,
Interes INT (250) NOT NULL,
Numero_Cuotas INT (250) NOT NULL,
Fondo_Pago INT (100) NOT NULL,
Tipo_Moneda VARCHAR(100) NOT NULL,
Fecha_Inicio DATE NOT NULL,
Montos_Cuota INT(250) NOT NULL,
Total_Interes INT (250) NOT NULL,
Monto_Total INT (250) NOT NULL
);

CREATE TABLE certificados_plazo(
Usuario VARCHAR (100) NOT NULL,
DUI VARCHAR(100) NOT NULL,
CONSTRAINT FK_DUI3 FOREIGN KEY (DUI)
REFERENCES crear_cliente(DUI),
Numero_Cuenta VARCHAR (100) PRIMARY KEY NOT NULL,
DineroGuardar INT(250) NOT NULL,
Interes INT(250) NOT NULL,
Total INT (250) NOT NULL,
Fecha_Vencimiento DATE NOT NULL
);


CREATE TABLE CuentaAhorro(
Nombre VARCHAR (100) NOT NULL,
DUI VARCHAR(100) NOT NULL,
CONSTRAINT FK_DUI4 FOREIGN KEY (DUI)
REFERENCES crear_cliente(DUI),
Numero_Cuenta VARCHAR (100) PRIMARY KEY NOT NULL,
SaldoAhorrado INT(250) NOT NULL,
Saldo_Abonar INT(250) NOT NULL,
Saldo_Retirar INT(250) NOT NULL
);

CREATE TABLE CuentaInfantil(
NombrePadre VARCHAR(100) NOT NULL,
NombreMadre VARCHAR (100) NOT NULL,
NombreCuenta VARCHAR(250) PRIMARY KEY NOT NULL,
NombreBeneficiario VARCHAR(100) NOT NULL,
SaldoAhorrado INT (250) NOT NULL,
Saldo_Abonar INT (250) NOT NULL,
Saldo_Retirar INT (250) NOT NULL
);

SELECT * FROM crear_cliente;
SELECT * FROM prestamos_hipotecarios;
SELECT * FROM CuentaAhorro;