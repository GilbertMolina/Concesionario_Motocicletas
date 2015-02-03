--Crear el esquema sysdba estando logueado con el usuario system

connect system/12345;

--Borrar el esquema si existe
SET SERVEROUTPUT ON
BEGIN
  EXECUTE IMMEDIATE 'DROP USER sysdba CASCADE';
EXCEPTION
  WHEN OTHERS THEN
    IF (SQLCODE = -1918) THEN
      DBMS_OUTPUT.PUT_LINE('-->No se borró el esquema porque no existía<--');
      DBMS_OUTPUT.PUT_LINE('-->Excepción de Oracle: '||SQLERRM||'<--');
    END IF;
END;
/

--Creacion de usuarios administrativos
--Crear usuario sysdba

CREATE USER sysdba
IDENTIFIED BY sysdba
DEFAULT TABLESPACE USERS
TEMPORARY TABLESPACE TEMP;

--Otorgar permisos al esquema sysdba

GRANT CREATE VIEW, CREATE PUBLIC SYNONYM, DROP PUBLIC SYNONYM,
RESOURCE, CREATE SESSION, CONNECT, CREATE TABLE, CREATE PROCEDURE
TO sysdba;

--Borrar el esquema sysdba
--DROP USER sysdba CASCADE;

--Desloguearse del usuario system

disconnect;

--Crear los objetos del esquema sysdba estando logueado con el usuario sysdba

connect sysdba/sysdba;

--Creacion de Tablas
--Crear las tablas y secuencias estando logueado con el usuario sysdba

--Creacion tabla TClientes

CREATE TABLE TClientes (
	Cod_Cliente	NUMBER(10,0) NOT NULL,
	Cedula		VARCHAR2(50) NOT NULL,
	Nombre 		VARCHAR2(20) NOT NULL,
	Apellidos 	VARCHAR2(50) NOT NULL,
	Telefono 	NUMBER(10,0),
	Direccion	VARCHAR2(200),
	Ciudad		VARCHAR2(50),
	CONSTRAINT	PK_TClientes PRIMARY KEY (Cod_Cliente),
	CONSTRAINT	UK_TClientes UNIQUE (Cedula)
);

--DROP TABLE TClientes;
--DROP TABLE TClientes CASCADE CONSTRAINSTS;

--Creacion tabla TFactura_Venta

CREATE TABLE TFactura_Venta (
	Cod_Fact_Venta	NUMBER(10,0) NOT NULL,
	Cod_Empleado 	NUMBER(10,0) NOT NULL,
	Cod_Cliente 	NUMBER(10,0) NOT NULL,
	Fecha_Venta     DATE NOT NULL,
	Total		    NUMBER(15,2) NOT NULL,
	CONSTRAINT		PK_TFactura_Venta PRIMARY KEY (Cod_Fact_Venta)
);

--DROP TABLE TFactura_Venta;
--DROP TABLE TFactura_Venta CASCADE CONSTRAINSTS;

--Creacion tabla TDetalle_Venta

CREATE TABLE TDetalle_Venta (
	Cod_Detalle_Venta	NUMBER(10,0) NOT NULL,
	Cod_Fact_Venta	  	NUMBER(10,0) NOT NULL,
	Cod_Producto 	    VARCHAR2(20) NOT NULL,
	Cantidad 	        NUMBER(5,0) NOT NULL,
	Precio_Unitario		NUMBER(15,2) NOT NULL,
	Subtotal		    NUMBER(15,2) NOT NULL,
	Comentarios 		VARCHAR2(200) NOT NULL,
	CONSTRAINT		    PK_TDetalle_Venta PRIMARY KEY (Cod_Detalle_Venta, Cod_Fact_Venta)
);

--DROP TABLE TDetalle_Venta;
--DROP TABLE TDetalle_Venta CASCADE CONSTRAINSTS;

--Creacion tabla TEmpleados

CREATE TABLE TEmpleados (
	Cod_Empleado	  NUMBER(10,0) NOT NULL,
	Cedula			  VARCHAR2(50) NOT NULL,
	Nombre 			  VARCHAR2(20) NOT NULL,
	Apellidos 		  VARCHAR2(50) NOT NULL,
	Cod_Departamento  NUMBER(10,0) NOT NULL,
	Telefono 		  NUMBER(10,0),
	Correo			  VARCHAR2(40) NOT NULL,
	Salario			  NUMBER(15,2) NOT NULL,
	Fecha_Contrato	  DATE NOT NULL,
	Fecha_Despido	  DATE,
	Estado		      NUMBER(1,0) NOT NULL,
	CONSTRAINT		  PK_TEmpleados PRIMARY KEY (Cod_Empleado),
	CONSTRAINT		  UK_TEmpleados UNIQUE (Cedula, Correo)
);
 
--DROP TABLE TEmpleados;
--DROP TABLE TEmpleados CASCADE CONSTRAINSTS;

--Creacion tabla TDepartamentos

CREATE TABLE TDepartamentos (
	Cod_Departamento	NUMBER(10,0) NOT NULL,
	Nombre 			    VARCHAR2(50) NOT NULL,
	Cod_Administrador   NUMBER(10,0),
	CONSTRAINT		    PK_TDepartamentos PRIMARY KEY (Cod_Departamento),
	CONSTRAINT		    UK_TDepartamentos UNIQUE (Cod_Administrador)
);

--DROP TABLE TDepartamentos;
--DROP TABLE TDepartamentos CASCADE CONSTRAINSTS;

--Creacion tabla TVehiculo

CREATE TABLE TVehiculo (
	Cod_Vehiculo		VARCHAR2(20) NOT NULL,
	Marca 				VARCHAR2(30) NOT NULL,
	Modelo				VARCHAR2(30) NOT NULL,
	Color				VARCHAR2(20) NOT NULL,
	Precio_Unitario		NUMBER(15,2) NOT NULL,
	Garantia			VARCHAR2(50) NOT NULL,
	Especificaciones	VARCHAR2(200) NOT NULL,
	CONSTRAINT			PK_TVehiculo PRIMARY KEY (Cod_Vehiculo)
);

--DROP TABLE TVehiculo;
--DROP TABLE TVehiculo CASCADE CONSTRAINSTS;

--Creacion tabla TVehiculo_Usado

CREATE TABLE TVehiculo_Usado (
	Cod_Vehiculo	VARCHAR2(20) NOT NULL,
	Numero_Placa	VARCHAR2(10) NOT NULL,
	Kilometraje		NUMBER(10,0) NOT NULL,
	Estado 			VARCHAR2(20) NOT NULL,
	CONSTRAINT		PK_TVehiculo_Usado PRIMARY KEY (Cod_Vehiculo),
	CONSTRAINT		UK_TVehiculo_Usado UNIQUE (Numero_Placa)
);

--DROP TABLE TVehiculo_Usado;
--DROP TABLE TVehiculo_Usado CASCADE CONSTRAINSTS;

--Creacion tabla TVehiculo_Nuevo

CREATE TABLE TVehiculo_Nuevo (
	Cod_Vehiculo			VARCHAR2(20) NOT NULL,
	Primer_Mantenimiento	VARCHAR2(50) NOT NULL,
	CONSTRAINT				PK_TVehiculo_Nuevo PRIMARY KEY (Cod_Vehiculo)
);

--DROP TABLE TVehiculo_Nuevo;
--DROP TABLE TVehiculo_Nuevo CASCADE CONSTRAINSTS;

--Creacion tabla TRepuestos

CREATE TABLE TRepuestos (
	Cod_Repuesto		VARCHAR2(20) NOT NULL,
	Descripcion		    VARCHAR2(100) NOT NULL,
	Tipo		        VARCHAR2(80) NOT NULL,
	Precio_Unitario		NUMBER(15,2) NOT NULL,
	CONSTRAINT			PK_TRepuestos PRIMARY KEY (Cod_Repuesto)
);

--DROP TABLE TRepuestos;
--DROP TABLE TRepuestos CASCADE CONSTRAINSTS;

--Creacion tabla TServicios

CREATE TABLE TServicios (
	Cod_Servicio	VARCHAR2(20) NOT NULL,
	Cod_Empleado	NUMBER(10,0) NOT NULL,
	Tipo		    VARCHAR2(50) NOT NULL,
	Precio        	NUMBER(15,2) NOT NULL,
	Descripcion		VARCHAR2(100) NOT NULL,
	CONSTRAINT		PK_TServicios PRIMARY KEY (Cod_Servicio)
);

--DROP TABLE TServicios;
--DROP TABLE TServicios CASCADE CONSTRAINSTS;

--Creacion tabla TProveedores

CREATE TABLE TProveedores (
	Cod_Proveedor			NUMBER(10,0) NOT NULL,
	Cedula_Juridica			VARCHAR2(50) NOT NULL,
	Nombre 					VARCHAR2(50) NOT NULL,
	Razon_Social			VARCHAR2(200) NOT NULL,
	Descripcion_Servicio	VARCHAR2(200),
	CONSTRAINT				PK_TProveedores PRIMARY KEY (Cod_Proveedor),
	CONSTRAINT				UK_TProveedores UNIQUE (Cedula_Juridica)
);

--DROP TABLE TProveedores;
--DROP TABLE TProveedores CASCADE CONSTRAINSTS;

--Creacion tabla TProveedor_TAdquisicion

CREATE TABLE TProveedor_TAdquisicion (
	Cod_Proveedor	  NUMBER(10,0),
	Cod_Fact_Compra	  NUMBER(10,0),
	CONSTRAINT		  PK_TProveedor_TAdquisicion PRIMARY KEY (Cod_Proveedor, Cod_Fact_Compra)
);

--DROP TABLE TProveedor_TAdquisicion;
--DROP TABLE TProveedor_TAdquisicion CASCADE CONSTRAINSTS;

--Creacion tabla TAdquisiciones

CREATE TABLE TAdquisiciones (
	Cod_Fact_Compra		  NUMBER(10,0) NOT NULL,
	Cod_Vehiculo	  	  VARCHAR2(20),
	Cod_Repuesto	  	  VARCHAR2(20),
	Cantidad_Unidades	  NUMBER(5,0) NOT NULL,
	Valor 				      NUMBER(15,2) NOT NULL,
	Fecha_Compra		    DATE NOT NULL,
	CONSTRAINT			    PK_TAdquisiciones PRIMARY KEY (Cod_Fact_Compra)
);

--DROP TABLE TAdquisiciones;
--DROP TABLE TAdquisiciones CASCADE CONSTRAINSTS;

--Creacion tabla TInventario

CREATE TABLE TInventario (
	Cod_Inventario		    NUMBER(10,0) NOT NULL,
	Cod_Fact_Compra		    NUMBER(10,0) NOT NULL,
	Cod_Repuesto		    VARCHAR2(20) NOT NULL,
	Cantidad_Disponibles	NUMBER(10,0),
	Fecha		            DATE NOT NULL,
	CONSTRAINT				PK_TInventario PRIMARY KEY (Cod_Inventario)
);

--DROP TABLE TInventario;
--DROP TABLE TInventario CASCADE CONSTRAINSTS;

--Creacion tabla TLogin

CREATE TABLE TLogin (
	Username	VARCHAR2(10) NOT NULL,
	Nombre 		VARCHAR2(20) NOT NULL,
	Apellidos 	VARCHAR2(50) NOT NULL,
	Contrasena 	VARCHAR2(20) NOT NULL,
	Estado		NUMBER(1,0) NOT NULL,
	CONSTRAINT	PK_TLogin PRIMARY KEY (Username)
);

--DROP TABLE TLogin;
--DROP TABLE TLogin CASCADE CONSTRAINSTS;

--Creacion de Constraints

--Creacion relacion TFactura_Venta

ALTER TABLE TFactura_Venta
ADD CONSTRAINT FK_TFactura_Venta_1
	FOREIGN KEY (Cod_Empleado)
	REFERENCES TEmpleados (Cod_Empleado)
	ON DELETE CASCADE;
	
ALTER TABLE TFactura_Venta
ADD CONSTRAINT FK_TFactura_Venta_2
	FOREIGN KEY (Cod_Cliente)
	REFERENCES TClientes (Cod_Cliente)
	ON DELETE CASCADE;
	
--Creacion relacion TEmpleados

ALTER TABLE TEmpleados
ADD CONSTRAINT FK_TEmpleados_1
	FOREIGN KEY (Cod_Departamento)
	REFERENCES TDepartamentos (Cod_Departamento);
	
--Creacion relacion TDepartamentos

ALTER TABLE TDepartamentos
ADD CONSTRAINT FK_TDepartamentos_1
	FOREIGN KEY (Cod_Administrador)
	REFERENCES TEmpleados (Cod_Empleado);
	
--Creacion relacion TDetalle_Venta

ALTER TABLE TDetalle_Venta
ADD CONSTRAINT FK_TDetalle_Venta_1
	FOREIGN KEY (Cod_Fact_Venta)
	REFERENCES TFactura_Venta (Cod_Fact_Venta)
	ON DELETE CASCADE;
	
ALTER TABLE TDetalle_Venta
ADD CONSTRAINT FK_TDetalle_Venta_2
	FOREIGN KEY (Cod_Producto)
	REFERENCES TVehiculo (Cod_Vehiculo)
	ON DELETE CASCADE;
	
ALTER TABLE TDetalle_Venta
ADD CONSTRAINT FK_TDetalle_Venta_3
	FOREIGN KEY (Cod_Producto)
	REFERENCES TRepuestos (Cod_Repuesto)
	ON DELETE CASCADE;
	
ALTER TABLE TDetalle_Venta
ADD CONSTRAINT FK_TDetalle_Venta_4
	FOREIGN KEY (Cod_Producto)
	REFERENCES TServicios (Cod_Servicio)
	ON DELETE CASCADE;
	
--Creacion relacion TServicios

ALTER TABLE TServicios
ADD CONSTRAINT FK_TServicios_1
	FOREIGN KEY (Cod_Empleado)
	REFERENCES TEmpleados (Cod_Empleado)
	ON DELETE CASCADE;
	
--Creacion relacion TVehiculo_Nuevo
	
ALTER TABLE TVehiculo_Nuevo
ADD CONSTRAINT FK_TVehiculo_Nuevo_1
	FOREIGN KEY (Cod_Vehiculo)
	REFERENCES TVehiculo (Cod_Vehiculo)
	ON DELETE CASCADE;
	
--Creacion relacion TVehiculo_Usado

ALTER TABLE TVehiculo_Usado
ADD CONSTRAINT FK_TVehiculo_Usado_1
	FOREIGN KEY (Cod_Vehiculo)
	REFERENCES TVehiculo (Cod_Vehiculo)
	ON DELETE CASCADE;
	
--Creacion relacion TProveedor_TAdquisicion

ALTER TABLE TProveedor_TAdquisicion
ADD CONSTRAINT FK_TProveedor_TAdquisicion_1
	FOREIGN KEY (Cod_Proveedor)
	REFERENCES TProveedores (Cod_Proveedor);
	
ALTER TABLE TProveedor_TAdquisicion
ADD CONSTRAINT FK_TProveedor_TAdquisicion_2
	FOREIGN KEY (Cod_Fact_Compra)
	REFERENCES TAdquisiciones (Cod_Fact_Compra)
	ON DELETE CASCADE;
	
--Creacion relacion TInventario

ALTER TABLE TInventario
ADD CONSTRAINT FK_TInventario_1
	FOREIGN KEY (Cod_Fact_Compra)
	REFERENCES TAdquisiciones (Cod_Fact_Compra)
	ON DELETE CASCADE;

ALTER TABLE TInventario
ADD CONSTRAINT FK_TInventario_2
	FOREIGN KEY (Cod_Repuesto)
	REFERENCES TRepuestos (Cod_Repuesto)
	ON DELETE CASCADE;
	
--Creacion relacion TAdquisiciones

ALTER TABLE TAdquisiciones
ADD CONSTRAINT FK_TAdquisiciones_1
	FOREIGN KEY (Cod_Vehiculo)
	REFERENCES TVehiculo (Cod_Vehiculo)
	ON DELETE CASCADE;

ALTER TABLE TAdquisiciones
ADD CONSTRAINT FK_TAdquisiciones_2
	FOREIGN KEY (Cod_Repuesto)
	REFERENCES TRepuestos (Cod_Repuesto)
	ON DELETE CASCADE;

--Creacion de Secuencias

--Creacion secuencia para TClientes

CREATE SEQUENCE Seq_TClientes 
  MINVALUE 1
  MAXVALUE 9999999999
  INCREMENT BY 1
  START WITH 1;

--DROP SEQUENCE Seq_TClientes;

--Creacion secuencia para TFactura_Venta

CREATE SEQUENCE Seq_TFactura_Venta
  MINVALUE 1
  MAXVALUE 9999999999
  INCREMENT BY 1
  START WITH 1;

--DROP SEQUENCE Seq_TFactura_Venta;

--Creacion secuencia para TDetalle_Venta

CREATE SEQUENCE Seq_TDetalle_Venta
  MINVALUE 1
  MAXVALUE 9999999999
  INCREMENT BY 1
  START WITH 1;

--DROP SEQUENCE Seq_TDetalle_Venta;

--Creacion secuencia para TEmpleados

CREATE SEQUENCE Seq_TEmpleados
  MINVALUE 1
  MAXVALUE 9999999999
  INCREMENT BY 1
  START WITH 1;

--DROP SEQUENCE Seq_TEmpleados;

--Creacion secuencia para TDepartamentos

CREATE SEQUENCE Seq_TDepartamentos
  MINVALUE 1
  MAXVALUE 9999999999
  INCREMENT BY 1
  START WITH 1;

--DROP SEQUENCE Seq_TDepartamentos;

--Creacion secuencia para TVehiculo

CREATE SEQUENCE Seq_TVehiculo
  MINVALUE 1
  MAXVALUE 9999999999
  INCREMENT BY 1
  START WITH 1;

--DROP SEQUENCE Seq_TVehiculo;

--Creacion secuencia para TRepuestos

CREATE SEQUENCE Seq_TRepuestos
  MINVALUE 1
  MAXVALUE 9999999999
  INCREMENT BY 1
  START WITH 1;

--DROP SEQUENCE Seq_TRepuestos;

--Creacion secuencia para TServicios

CREATE SEQUENCE Seq_TServicios
  MINVALUE 1
  MAXVALUE 9999999999
  INCREMENT BY 1
  START WITH 1;

--DROP SEQUENCE Seq_TServicios;

--Creacion secuencia para TProveedores

CREATE SEQUENCE Seq_TProveedores
  MINVALUE 1
  MAXVALUE 9999999999
  INCREMENT BY 1
  START WITH 1;

--DROP SEQUENCE Seq_TProveedores;

--Creacion secuencia para TAdquisiciones

CREATE SEQUENCE Seq_TAdquisiciones
  MINVALUE 1
  MAXVALUE 9999999999
  INCREMENT BY 1
  START WITH 1;

--DROP SEQUENCE Seq_TAdquisiciones;

--Creacion secuencia para TInventario

CREATE SEQUENCE Seq_TInventario
  MINVALUE 1
  MAXVALUE 9999999999
  INCREMENT BY 1
  START WITH 1;

--DROP SEQUENCE Seq_TInventario;

--Inserción de Datos

--Inserción de datos para la tabla TClientes
INSERT INTO TClientes VALUES (SEQ_TCLIENTES.NEXTVAL, '305470213', 'Fernando', 'Gonzalez Espinoza', 88537856, 'Barrio Lujan', 'San José');
INSERT INTO TClientes VALUES (SEQ_TCLIENTES.NEXTVAL, '504560256', 'Alvaro', 'Montoya Araya', 89853193, 'Paseo Colon', 'San José');
INSERT INTO TClientes VALUES (SEQ_TCLIENTES.NEXTVAL, '103450657', 'Viviana', 'Angulo Sancho', 25750529, 'Sabana', 'San José');
INSERT INTO TClientes VALUES (SEQ_TCLIENTES.NEXTVAL, '405670462', 'Rafael', 'Gutierrez Ramirez',68854020, 'Santa Ana', 'San José');
INSERT INTO TClientes VALUES (SEQ_TCLIENTES.NEXTVAL, '605670745', 'Luis', 'Arce Solano', 78845863, 'Lindora', 'San José');
COMMIT;

--TRUNCATE TABLE TClientes

--Inserción de datos para la tabla TDepartamentos
INSERT INTO TDepartamentos VALUES (SEQ_TDEPARTAMENTOS.NEXTVAL, 'Administración', '');
INSERT INTO TDepartamentos VALUES (SEQ_TDEPARTAMENTOS.NEXTVAL, 'Mercadeo', '');
INSERT INTO TDepartamentos VALUES (SEQ_TDEPARTAMENTOS.NEXTVAL, 'Taller', '');
INSERT INTO TDepartamentos VALUES (SEQ_TDEPARTAMENTOS.NEXTVAL, 'Ventas', '');
INSERT INTO TDepartamentos VALUES (SEQ_TDEPARTAMENTOS.NEXTVAL, 'Contabilidad', '');
COMMIT;

--TRUNCATE TABLE TDepartamentos

--TRUNCATE TABLE TProveedores

--Inserción de datos para la tabla TProveedores
INSERT INTO TProveedores VALUES (SEQ_TPROVEEDORES.NEXTVAL, '28746930156', 'Morgan el señor de las motocicletas', 'Morgan el señor de las motocicletas S.A', 'Importación de mootocicletas y repuestos Morgan S.A');
INSERT INTO TProveedores VALUES (SEQ_TPROVEEDORES.NEXTVAL, '42358187413', 'Motocicletas Gonzales', 'Motocicletas Gonzales S.A', 'Importación de mootocicletas y repuestos Gonzales S.A');
INSERT INTO TProveedores VALUES (SEQ_TPROVEEDORES.NEXTVAL, '82121423452', 'Pedro todo en motocicletas', 'Pedro todo en motocicletas S.A', 'Importación de mootocicletas y repuestos Pedro S.A');
INSERT INTO TProveedores VALUES (SEQ_TPROVEEDORES.NEXTVAL, '57378198485', 'Las mejores motocicletas Rivera', 'Las mejores motocicletas Rivera S.A', 'Importación de mootocicletas y repuestos Rivera S.A');
COMMIT;

--TRUNCATE TABLE TProveedores

--Inserción de datos para la tabla TEmpleados
INSERT INTO TEmpleados VALUES (SEQ_TEMPLEADOS.NEXTVAL, '305760468', 'Jeison', 'Picado Cordero', 1, 88675739, 'jpicado@yamaha.com', 450000, '01/01/2006', '', 1);
INSERT INTO TEmpleados VALUES (SEQ_TEMPLEADOS.NEXTVAL, '507680857', 'Gerald', 'Zuñiga Agüero', 2, 87685924, 'gzuniga@yamaha.com', 550000, '01/01/2004', '', 1);
INSERT INTO TEmpleados VALUES (SEQ_TEMPLEADOS.NEXTVAL, '105670813', 'David', 'Barboza Molina', 3, 25487945, 'dbarboza@yamaha.com', 350000, '01/01/2008', '', 1);
INSERT INTO TEmpleados VALUES (SEQ_TEMPLEADOS.NEXTVAL, '407840734', 'Jorge', 'Valverde Serrano', 3, 68765498, 'jvalverde@yamaha.com', 400000, '01/01/2007', '', 1);
INSERT INTO TEmpleados VALUES (SEQ_TEMPLEADOS.NEXTVAL, '601230784', 'Martin', 'Fuentes Vega', 4, 78927683, 'mfuentes@yamaha.com', 500000, '01/01/2005', '', 1);
INSERT INTO TEmpleados VALUES (SEQ_TEMPLEADOS.NEXTVAL, '404560481', 'Fernando', 'Lopez Guzman', 5, 81234596, 'flopez@yamaha.com', 455000, '01/01/2004', '01/01/2007', 2);
COMMIT;

--TRUNCATE TABLE TEmpleados

--Inserción de datos para la tabla TVehiculo
INSERT INTO TVehiculo VALUES ('VE_'||SEQ_TVEHICULO.NEXTVAL, 'Ducati', '2014', 'Azul', 1550000, '2 años', 'Cilindraje 150cm cúbicos');
INSERT INTO TVehiculo VALUES ('VE_'||SEQ_TVEHICULO.NEXTVAL, 'BMW', '2014', 'Rojo', 1650000, '2 años', 'Cilindraje 250cm cúbicos');
INSERT INTO TVehiculo VALUES ('VE_'||SEQ_TVEHICULO.NEXTVAL, 'Suzuki', '2011', 'Amarillo', 1100000, '2 años', 'Cilindraje 100cm cúbicos');
INSERT INTO TVehiculo VALUES ('VE_'||SEQ_TVEHICULO.NEXTVAL, 'Kawasaki', '2010', 'Verde', 1200000, '2 años', 'Cilindraje 135cm cúbicos');
INSERT INTO TVehiculo VALUES ('VE_'||SEQ_TVEHICULO.NEXTVAL, 'Honda', '2009', 'Blanco', 950000, '2 años', 'Cilindraje 125cm cúbicos');
COMMIT;

--TRUNCATE TABLE TVehiculo

--Inserción de datos para la tabla TVehiculo_Nuevo
INSERT INTO TVehiculo_Nuevo VALUES ('VE_1', '1000 Kilometros');
INSERT INTO TVehiculo_Nuevo VALUES ('VE_2', '2000 Kilometros');
COMMIT;

--TRUNCATE TABLE TVehiculo_Nuevo

--Inserción de datos para la tabla TVehiculo_Usado
INSERT INTO TVehiculo_Usado VALUES ('VE_3', '8869', 26579, 'Excelente');
INSERT INTO TVehiculo_Usado VALUES ('VE_4', '8303', 21678, 'Excelente');
INSERT INTO TVehiculo_Usado VALUES ('VE_5', '8217', 15086, 'Excelente');
COMMIT;

--TRUNCATE TABLE TVehiculo_Usado

--Inserción de datos para la tabla TServicios
INSERT INTO TServicios VALUES ('SE_'||SEQ_TSERVICIOS.NEXTVAL, 3, 'Cambio de Aceite', 25000, 'Cambio de Aceite');
INSERT INTO TServicios VALUES ('SE_'||SEQ_TSERVICIOS.NEXTVAL, 3, 'Cambio de Motor',  350000, 'Cambio de Motor');
INSERT INTO TServicios VALUES ('SE_'||SEQ_TSERVICIOS.NEXTVAL, 4, 'Cambio de frenos',  100000, 'Cambio de frenos');
COMMIT;

--TRUNCATE TABLE TServicios

--Inserción de datos para la tabla TRepuestos
INSERT INTO TRepuestos VALUES ('RE_'||SEQ_TREPUESTOS.NEXTVAL, 'Bujias', 'Repuesto Camion', 50000);
INSERT INTO TRepuestos VALUES ('RE_'||SEQ_TREPUESTOS.NEXTVAL, 'Catalizador', 'Repuesto Automovil', 30000);
INSERT INTO TRepuestos VALUES ('RE_'||SEQ_TREPUESTOS.NEXTVAL, 'Valvulas', 'Repuesto Motocicleta', 20000);
COMMIT;

--TRUNCATE TABLE TAdquisiciones

--Inserción de datos para la tabla TAdquisiciones
INSERT INTO tadquisiciones VALUES(SEQ_TADQUISICIONES.NEXTVAL, 'VE_1', '', 12, 650000, '27/04/2010');
INSERT INTO tadquisiciones VALUES(SEQ_TADQUISICIONES.NEXTVAL, 'VE_4', '', 4, 450000, '27/02/2008');
INSERT INTO tadquisiciones VALUES(SEQ_TADQUISICIONES.NEXTVAL, '', 'RE_2', 6, 120000, '27/10/2011');
INSERT INTO tadquisiciones VALUES(SEQ_TADQUISICIONES.NEXTVAL, '', 'RE_3', 5, 85000, '11/05/2005');
COMMIT;

--TRUNCATE TABLE TAdquisiciones

--Inserción de datos para la tabla TProveedor_TAdquisicion
INSERT INTO tproveedor_tadquisicion VALUES(1, 1);
INSERT INTO tproveedor_tadquisicion VALUES(1, 2);
INSERT INTO tproveedor_tadquisicion VALUES(2, 2);
INSERT INTO tproveedor_tadquisicion VALUES(2, 3);
INSERT INTO tproveedor_tadquisicion VALUES(3, 4);
INSERT INTO tproveedor_tadquisicion VALUES(3, 2);
INSERT INTO tproveedor_tadquisicion VALUES(4, 3);
INSERT INTO tproveedor_tadquisicion VALUES(4, 1);
COMMIT;

--TRUNCATE TABLE TProveedor_TAdquisicion

--Inserción de datos para la tabla TLogin
INSERT INTO TLogin VALUES ('gmolina', 'Gilberth', 'Molina Castrillo', '12345', 1);
INSERT INTO TLogin VALUES ('cvega', 'Carlos', 'Vega Romero', '12345', 1);
INSERT INTO TLogin VALUES ('cmorales', 'Carlos', 'Morales Núñez', '12345', 1);
COMMIT;

--TRUNCATE TABLE TLogin

--Actualización de Datos

--Actualización de datos para la tabla TDepartamentos
UPDATE TDepartamentos SET Cod_Administrador = 1 WHERE Cod_Departamento = 1;
UPDATE TDepartamentos SET Cod_Administrador = 2 WHERE Cod_Departamento = 2;
UPDATE TDepartamentos SET Cod_Administrador = 3 WHERE Cod_Departamento = 3;
COMMIT;

--Procedimientos almacenados

--TLogin

create or replace PROCEDURE sp_tlogin_buscar_username(
  v_username		  IN tlogin.username%TYPE,
  v_contrasena 	  IN tlogin.contrasena%TYPE,
  v_number_users	OUT tlogin.estado%TYPE
)
AS
BEGIN
  SELECT COUNT(*)
  INTO v_number_users
  FROM tlogin
  WHERE username = v_username
  AND contrasena = v_contrasena
  AND estado     = 1;
  COMMIT;
END;
/

--TVehiculo

CREATE OR REPLACE PROCEDURE sp_tvehiculo_eliminar(
  v_cod_vehiculo      tvehiculo.cod_vehiculo%TYPE
)
AS
BEGIN
  DELETE FROM tvehiculo
  WHERE cod_vehiculo = v_cod_vehiculo;
  COMMIT;
END;
/

--TVehiculo_Nuevo

CREATE OR REPLACE PROCEDURE sp_tvehiculo_nuevo_mostrar(
  c_vehiculos   OUT   SYS_REFCURSOR
)
AS
BEGIN
  OPEN c_vehiculos FOR
    SELECT vn.cod_vehiculo "Cod. Vehículo", v.marca "Marca", v.modelo "Modelo", v.color "Color", v.precio_unitario "Precio Unitario", v.garantia "Garantía", vn.primer_mantenimiento "Primer Mantenimiento", v.especificaciones "Especificaciones"
FROM tvehiculo_nuevo vn, tvehiculo v
WHERE v.cod_vehiculo = vn.cod_vehiculo;
END sp_tvehiculo_nuevo_mostrar;
/

CREATE OR REPLACE PROCEDURE sp_tvehiculo_nuevo_insertar(
  v_marca                 tvehiculo.marca%TYPE,
  v_modelo                tvehiculo.modelo%TYPE,
  v_color                 tvehiculo.color%TYPE,
  v_precio_unitario       tvehiculo.precio_unitario%TYPE,
  v_garantia              tvehiculo.garantia%TYPE,
  v_primer_mantenimiento  tvehiculo_nuevo.primer_mantenimiento%TYPE,
  v_especificaciones      tvehiculo.especificaciones%TYPE
)
AS
  v_cod_vehiculo  tvehiculo.cod_vehiculo%TYPE := SEQ_TVEHICULO.NEXTVAL;
BEGIN
  INSERT INTO tvehiculo(cod_vehiculo, marca, modelo, color, precio_unitario, garantia, especificaciones)
  VALUES ('VE_'||v_cod_vehiculo, v_marca, v_modelo, v_color, v_precio_unitario, v_garantia, v_especificaciones);
  
  INSERT INTO tvehiculo_nuevo(cod_vehiculo, primer_mantenimiento)
  VALUES ('VE_'||v_cod_vehiculo, v_primer_mantenimiento);
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tvehiculo_nuevo_actualizar(
  v_cod_vehiculo            tvehiculo.cod_vehiculo%TYPE,
  v_marca                   tvehiculo.marca%TYPE,
  v_modelo                  tvehiculo.modelo%TYPE,
  v_color                   tvehiculo.color%TYPE,
  v_precio_unitario         tvehiculo.precio_unitario%TYPE,
  v_garantia                tvehiculo.garantia%TYPE,
  v_primer_mantenimiento    tvehiculo_nuevo.primer_mantenimiento%TYPE,
  v_especificaciones        tvehiculo.especificaciones%TYPE
)
AS
BEGIN
  UPDATE tvehiculo
  SET marca = v_marca,
      modelo = v_modelo,
      color = v_color,
      precio_unitario = v_precio_unitario,
      garantia = v_garantia,
      especificaciones = v_especificaciones
  WHERE cod_vehiculo = v_cod_vehiculo;
  
  UPDATE tvehiculo_nuevo
  SET primer_mantenimiento = v_primer_mantenimiento
  WHERE cod_vehiculo = v_cod_vehiculo;
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tvehiculo_nuevo_existente(
  v_marca       IN  tvehiculo.marca%TYPE,
  v_modelo      IN  tvehiculo.modelo%TYPE,
  v_color       IN  tvehiculo.color%TYPE,
  v_encontrado  OUT tvehiculo.precio_unitario%TYPE
)
AS
BEGIN
  SELECT COUNT(*)
  INTO v_encontrado
  FROM tvehiculo_nuevo vn, tvehiculo v
  WHERE v.cod_vehiculo = vn.cod_vehiculo
  AND v.marca = v_marca
  AND v.modelo = v_modelo
  AND v.color = v_color;
END;
/

--TVehiculo_Usado

CREATE OR REPLACE PROCEDURE sp_tvehiculo_usado_mostrar(
  c_vehiculos   OUT   SYS_REFCURSOR
)
AS
BEGIN
  OPEN c_vehiculos FOR
    SELECT vu.cod_vehiculo "Cod. Vehículo", v.marca "Marca", v.modelo "Modelo", v.color "Color", v.precio_unitario "Precio Unitario", v.garantia "Garantía", vu.estado "Estado", vu.kilometraje "Kilometraje", vu.numero_placa "Número de placa", v.especificaciones "Especificaciones"
    FROM tvehiculo_usado vu, tvehiculo v
    WHERE v.cod_vehiculo = vu.cod_vehiculo;
END sp_tvehiculo_usado_mostrar;
/

CREATE OR REPLACE PROCEDURE sp_tvehiculo_usado_insertar(
  v_marca             tvehiculo.marca%TYPE,
  v_modelo            tvehiculo.modelo%TYPE,
  v_color             tvehiculo.color%TYPE,
  v_precio_unitario   tvehiculo.precio_unitario%TYPE,
  v_garantia          tvehiculo.garantia%TYPE,
  v_numero_placa      tvehiculo_usado.numero_placa%TYPE,
  v_kilometaje        tvehiculo_usado.kilometraje%TYPE,
  v_estado            tvehiculo_usado.estado%TYPE,
  v_especificaciones  tvehiculo.especificaciones%TYPE
)
AS
  v_cod_vehiculo  tvehiculo.cod_vehiculo%TYPE := SEQ_TVEHICULO.NEXTVAL;
BEGIN
  INSERT INTO tvehiculo(cod_vehiculo, marca, modelo, color, precio_unitario, garantia, especificaciones)
  VALUES ('VE_'||v_cod_vehiculo, v_marca, v_modelo, v_color, v_precio_unitario, v_garantia, v_especificaciones);
  
  INSERT INTO tvehiculo_usado(cod_vehiculo, numero_placa, kilometraje, estado)
  VALUES ('VE_'||v_cod_vehiculo, v_numero_placa, v_kilometaje, v_estado);
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tvehiculo_usado_actualizar(
  v_cod_vehiculo      tvehiculo.cod_vehiculo%TYPE,
  v_marca             tvehiculo.marca%TYPE,
  v_modelo            tvehiculo.modelo%TYPE,
  v_color             tvehiculo.color%TYPE,
  v_precio_unitario   tvehiculo.precio_unitario%TYPE,
  v_garantia          tvehiculo.garantia%TYPE,
  v_numero_placa      tvehiculo_usado.numero_placa%TYPE,
  v_kilometaje        tvehiculo_usado.kilometraje%TYPE,
  v_estado            tvehiculo_usado.estado%TYPE,
  v_especificaciones  tvehiculo.especificaciones%TYPE
)
AS
BEGIN
  UPDATE tvehiculo
  SET marca = v_marca,
      modelo = v_modelo,
      color = v_color,
      precio_unitario = v_precio_unitario,
      garantia = v_garantia,
      especificaciones = v_especificaciones
  WHERE cod_vehiculo = v_cod_vehiculo;
  
  UPDATE tvehiculo_usado
  SET numero_placa = v_numero_placa,
      kilometraje = v_kilometaje,
      estado = v_estado
  WHERE cod_vehiculo = v_cod_vehiculo;
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tvehiculo_usado_existente(
  v_numero_placa  IN   tvehiculo_usado.numero_placa%TYPE,
  v_encontrado    OUT  tvehiculo_usado.kilometraje%TYPE
)
AS
BEGIN
  SELECT COUNT(*)
  INTO v_encontrado
  FROM tvehiculo_usado
  WHERE numero_placa = v_numero_placa;
END;
/

--TDepartamentos

CREATE OR REPLACE PROCEDURE sp_tdepartamentos_mostrar(
  c_departamentos   OUT   SYS_REFCURSOR
)
AS
BEGIN
  OPEN c_departamentos FOR
    SELECT d.cod_departamento, d.nombre, d.cod_administrador, e.nombre || ' ' || e.apellidos "NOMBRE_EMPLEADO"
    FROM tdepartamentos d
    LEFT OUTER JOIN templeados e
    ON e.cod_empleado = d.cod_administrador
	ORDER BY d.cod_departamento;
END sp_tdepartamentos_mostrar;
/

CREATE OR REPLACE PROCEDURE sp_tdepartamentos_insertar(
  v_nombre              tdepartamentos.nombre%TYPE,
  v_cod_administrador   tdepartamentos.cod_administrador%TYPE
)
AS
BEGIN
  INSERT INTO tdepartamentos(cod_departamento, nombre, cod_administrador)
  VALUES(SEQ_TDEPARTAMENTOS.NEXTVAL,v_nombre,v_cod_administrador);
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tdepartamentos_actualizar(
  v_departamento_id   tdepartamentos.cod_departamento%TYPE,
  v_nombre            tdepartamentos.nombre%TYPE,
  v_administrador_id  tdepartamentos.cod_administrador%TYPE
)
AS
BEGIN
  UPDATE tdepartamentos
  SET nombre = v_nombre,
      cod_administrador = v_administrador_id
  WHERE cod_departamento = v_departamento_id;
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tdepartamentos_eliminar(
  v_departamento_id  tdepartamentos.cod_departamento%TYPE
)
AS
BEGIN
  DELETE FROM tdepartamentos
  WHERE cod_departamento = v_departamento_id;
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tdepartamentos_existente(
  v_nombre      IN    tdepartamentos.nombre%TYPE,
  v_encontrado  OUT   tdepartamentos.cod_departamento%TYPE
)
AS
BEGIN
  SELECT COUNT(*)
  INTO v_encontrado
  FROM tdepartamentos
  WHERE nombre = v_nombre;
END;
/

--TEmpleados

CREATE OR REPLACE PROCEDURE sp_templeados_activos_mostrar(
  c_empleados   OUT   SYS_REFCURSOR
)
AS
BEGIN
  OPEN c_empleados FOR
    SELECT e.cod_empleado, e.cedula, e.nombre, e.apellidos, d.nombre "NOMBRE_DEPARTAMENTO", e.telefono, e.correo, e.salario, e.fecha_contrato, e.fecha_despido, e.estado
    FROM templeados e, tdepartamentos d
    WHERE e.cod_departamento = d.cod_departamento
    AND e.estado = 1
    ORDER BY e.cod_empleado;
END sp_templeados_activos_mostrar;
/

CREATE OR REPLACE PROCEDURE sp_templeados_nactivos_mostrar(
  c_empleados   OUT   SYS_REFCURSOR
)
AS
BEGIN
  OPEN c_empleados FOR
    SELECT e.cod_empleado, e.cedula, e.nombre, e.apellidos, d.nombre "NOMBRE_DEPARTAMENTO", e.telefono, e.correo, e.salario, e.fecha_contrato, e.fecha_despido, e.estado
    FROM templeados e, tdepartamentos d
    WHERE e.cod_departamento = d.cod_departamento
    AND e.estado = 2
    ORDER BY e.cod_empleado;
END sp_templeados_nactivos_mostrar;
/

CREATE OR REPLACE PROCEDURE sp_templeados_no_gerentes(
  c_empleados   OUT   SYS_REFCURSOR
)
AS
BEGIN
  OPEN c_empleados FOR
    SELECT e.cod_empleado, e.nombre ||' '|| e.apellidos "NOMBRE_EMPLEADO"
    FROM templeados e, tdepartamentos d
    WHERE e.cod_departamento = d.cod_departamento
    AND e.estado = 1
    AND e.cod_empleado NOT IN (SELECT cod_administrador FROM tdepartamentos where cod_administrador IS NOT NULL);
END sp_templeados_no_gerentes;
/

CREATE OR REPLACE PROCEDURE sp_templeados_taller(
  c_empleados   OUT   SYS_REFCURSOR
)
AS
BEGIN
  OPEN c_empleados FOR
    SELECT e.cod_empleado, e.nombre ||' '|| e.apellidos "NOMBRE_EMPLEADO"
    FROM templeados e, tdepartamentos d
    WHERE e.cod_departamento = d.cod_departamento
    AND d.nombre = 'Taller'
    ORDER BY e.cod_empleado;
END sp_templeados_taller;
/

CREATE OR REPLACE PROCEDURE sp_templeados_insertar(
  v_cedula            templeados.cedula%TYPE,
  v_nombre            templeados.nombre%TYPE,
  v_apellidos         templeados.apellidos%TYPE,
  v_cod_departamento  templeados.cod_departamento%TYPE,
  v_telefono          templeados.telefono%TYPE,
  v_correo            templeados.correo%TYPE,
  v_salario           templeados.salario%TYPE,
  v_fecha_contrato    templeados.fecha_contrato%TYPE
)
AS
BEGIN
	INSERT INTO templeados(cod_empleado, cedula, nombre, apellidos, cod_departamento, telefono, correo, salario, fecha_contrato, estado)
	VALUES(SEQ_TEMPLEADOS.NEXTVAL, v_cedula, v_nombre, v_apellidos, v_cod_departamento, v_telefono, v_correo, v_salario, v_fecha_contrato, 1);
	COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_templeados_actualizar(
  v_cod_empleado        templeados.cod_empleado%TYPE,
  v_nombre              templeados.nombre%TYPE,
  v_apellidos           templeados.apellidos%TYPE,
  v_cod_departamento    templeados.cod_departamento%TYPE,
  v_telefono            templeados.telefono%TYPE,
  v_salario             templeados.salario%TYPE,
  v_fecha_contrato      templeados.fecha_contrato%TYPE,
  v_fecha_despido       templeados.fecha_despido%TYPE,
  v_estado              templeados.estado%TYPE
)
AS
  v_despido VARCHAR(20) := '';
BEGIN
  SELECT fecha_despido
  INTO v_despido
  FROM templeados
  WHERE cod_empleado = v_cod_empleado;
  IF(v_estado = 1) THEN
    IF(v_despido IS NULL) THEN
      UPDATE templeados
        SET nombre = v_nombre,
            apellidos = v_apellidos,
            cod_departamento = v_cod_departamento,
            telefono = v_telefono,
            salario = v_salario,
            fecha_contrato = v_fecha_contrato,
            estado = v_estado
        WHERE cod_empleado = v_cod_empleado;
    ELSE
      UPDATE templeados
      SET nombre = v_nombre,
          apellidos = v_apellidos,
          cod_departamento = v_cod_departamento,
          telefono = v_telefono,
          salario = v_salario,
          fecha_contrato = v_fecha_contrato,
          fecha_despido = '',
          estado = v_estado
      WHERE cod_empleado = v_cod_empleado;  
    END IF;
  ELSIF(v_estado = 2) THEN
    UPDATE templeados
    SET nombre = v_nombre,
        apellidos = v_apellidos,
        cod_departamento = v_cod_departamento,
        telefono = v_telefono,
        salario = v_salario,
        fecha_despido = v_fecha_despido,
        estado = v_estado
    WHERE cod_empleado = v_cod_empleado;
  END IF;
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_templeados_eliminar(
  v_cod_empleado  templeados.cod_empleado%TYPE
)
AS
BEGIN
  DELETE FROM templeados
  WHERE cod_empleado = v_cod_empleado;
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_templeados_existente(
  v_cedula      IN    templeados.cedula%TYPE,
  v_correo      IN    templeados.correo%TYPE,
  v_encontrado  OUT   templeados.cod_empleado%TYPE
)
AS
BEGIN
  SELECT COUNT(*)
  INTO v_encontrado
  FROM templeados
  WHERE cedula = v_cedula
  OR correo = v_correo;
END;
/

--TCliente

CREATE OR REPLACE PROCEDURE sp_tclientes_mostrar(
  c_clientes   OUT   SYS_REFCURSOR
)
AS
BEGIN
  OPEN c_clientes FOR
    SELECT cod_cliente, cedula, nombre, apellidos, telefono, direccion, ciudad
    FROM tclientes
    ORDER BY cod_cliente;
END sp_tclientes_mostrar;
/

CREATE OR REPLACE PROCEDURE sp_tclientes_insertar(
  v_cedula      tclientes.cedula%TYPE,
  v_nombre      tclientes.nombre%TYPE,
  v_apellidos   tclientes.apellidos%TYPE,
  v_telefono    tclientes.telefono%TYPE,
  v_direccion   tclientes.direccion%TYPE,
  v_ciudad      tclientes.ciudad%TYPE
)
AS
BEGIN
  INSERT INTO tclientes(cod_cliente, cedula, nombre, apellidos, telefono, direccion,ciudad)
  VALUES(SEQ_TCLIENTES.NEXTVAL,v_cedula, v_nombre, v_apellidos, v_telefono, v_direccion,v_ciudad);
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tclientes_actualizar(
  v_cliente_id  tclientes.cod_cliente%TYPE,
  v_nombre      tclientes.nombre%TYPE,
  v_apellidos   tclientes.apellidos%TYPE,
  v_telefono    tclientes.telefono%TYPE,
  v_direccion   tclientes.direccion%TYPE,
  v_ciudad      tclientes.ciudad%TYPE
)
AS
BEGIN
  UPDATE tclientes
  SET nombre = v_nombre,
      apellidos = v_apellidos,
      telefono = v_telefono,
      direccion = v_direccion,
      ciudad = v_ciudad
  WHERE cod_cliente = v_cliente_id;
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tclientes_eliminar(
  v_cliente_id  tclientes.cod_cliente%TYPE
)
AS
BEGIN
  DELETE FROM tclientes
  WHERE cod_cliente = v_cliente_id;
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tclientes_existente(
  v_cedula      IN    tclientes.cedula%TYPE,
  v_encontrado  OUT   DECIMAL
)
AS
BEGIN
  SELECT COUNT(*)
  INTO v_encontrado
  FROM tclientes
  WHERE cedula = v_cedula;
END;
/

--TFactura_Venta

CREATE OR REPLACE PROCEDURE sp_tfactura_venta_actualizar(
  v_factura_venta_id    tfactura_venta.cod_fact_venta%TYPE,
  v_cod_empleado        tfactura_venta.cod_empleado%TYPE,
  v_cod_cliente         tfactura_venta.cod_cliente%TYPE,
  v_fecha_venta         tfactura_venta.fecha_venta%TYPE,
  v_total               tfactura_venta.total%TYPE
)
AS
BEGIN
  UPDATE tfactura_venta
  SET cod_empleado = v_cod_empleado,
      cod_cliente = v_cod_cliente,
      fecha_venta = v_fecha_venta,
      total = v_total
  WHERE cod_fact_venta = v_factura_venta_id;
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tfactura_venta_insertar(
  v_cod_empleado  tfactura_venta.cod_empleado%TYPE,
  v_cod_cliente   tfactura_venta.cod_cliente%TYPE, 
  v_fecha_venta   tfactura_venta.fecha_venta%TYPE, 
  v_total         tfactura_venta.total%TYPE
)
AS
BEGIN
  INSERT INTO tfactura_venta(cod_fact_venta, cod_empleado, cod_cliente, fecha_venta, total)
  VALUES(SEQ_TFACTURA_VENTA.NEXTVAL,v_cod_empleado, v_cod_cliente,v_fecha_venta, v_total);
  COMMIT;
END;
/

--TDetalle_Venta

CREATE OR REPLACE PROCEDURE sp_tdetalle_venta_actualizar(
  v_cod_detalle_venta   tdetalle_venta.cod_detalle_venta%TYPE,
  v_cod_fact_venta      tdetalle_venta.cod_fact_venta%TYPE,
  v_cod_producto        tdetalle_venta.cod_producto%TYPE,
  v_cantidad            tdetalle_venta.cantidad%TYPE,
  v_precio_unitario     tdetalle_venta.precio_unitario%TYPE,
  v_subtotal            tdetalle_venta.subtotal%TYPE,
  v_comentarios         tdetalle_venta.comentarios%TYPE
)
AS
BEGIN
  UPDATE tdetalle_venta
  SET cod_fact_venta = v_cod_fact_venta,
      cod_producto = v_cod_producto,
      cantidad = v_cantidad,
      precio_unitario = v_precio_unitario,
      subtotal = v_subtotal,
      comentarios = v_comentarios
  WHERE cod_detalle_venta = v_cod_detalle_venta;
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tdetalle_venta_insertar(
  v_cod_fact_venta    tdetalle_venta.cod_fact_venta%TYPE,
  v_cod_producto      tdetalle_venta.cod_producto%TYPE,
  v_cantidad          tdetalle_venta.cantidad%TYPE, 
  v_precio_unitario   tdetalle_venta.precio_unitario%TYPE,
  v_subtotal          tdetalle_venta.subtotal%TYPE, 
  v_comentarios       tdetalle_venta.comentarios%TYPE
)
AS
BEGIN
	INSERT INTO tdetalle_venta(cod_detalle_venta, cod_fact_venta, cod_producto, cantidad, precio_unitario, subtotal, comentarios)
	VALUES(SEQ_TDETALLE_VENTA.NEXTVAL,v_cod_fact_venta, v_cod_producto, v_cantidad, v_precio_unitario, v_subtotal, v_comentarios);
	COMMIT;
END;
/

--TProveedores

CREATE OR REPLACE PROCEDURE sp_tproveedores_mostrar(
  c_proveedores   OUT   sys_refcursor
)
AS
BEGIN
  OPEN c_proveedores FOR
    SELECT cod_proveedor, cedula_juridica, nombre, razon_social, descripcion_servicio
    FROM tproveedores;
END sp_tproveedores_mostrar;
/

CREATE OR REPLACE PROCEDURE sp_tproveedores_insertar(
  v_cedula_juridica       tproveedores.cedula_juridica%TYPE,
  v_nombre                tproveedores.nombre%TYPE,
  v_razon_social          tproveedores.razon_social%TYPE,
  v_descripcion_servicio  tproveedores.descripcion_servicio%TYPE
)
AS
BEGIN
  INSERT INTO tproveedores(cod_proveedor, cedula_juridica, nombre, razon_social, descripcion_servicio)
  VALUES(SEQ_TPROVEEDORES.NEXTVAL, v_cedula_juridica, v_nombre, v_razon_social, v_descripcion_servicio);
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tproveedores_actualizar(
  v_cod_proveedor         tproveedores.cod_proveedor%TYPE,
  v_cedula_juridica       tproveedores.cedula_juridica%TYPE,
  v_nombre                tproveedores.nombre%TYPE,
  v_razon_social          tproveedores.razon_social%TYPE,
  v_descripcion_servicio  tproveedores.descripcion_servicio%TYPE
)
AS
BEGIN
  UPDATE tproveedores
  SET cedula_juridica = v_cedula_juridica,
      nombre = v_nombre,
      razon_social = v_razon_social,
      descripcion_servicio = v_descripcion_servicio
  WHERE cod_proveedor = v_cod_proveedor;
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tproveedores_eliminar(
  v_cod_proveedor   tproveedores.cod_proveedor%TYPE
)
AS
BEGIN
  DELETE FROM tproveedores
  WHERE cod_proveedor = v_cod_proveedor;
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tproveedores_existente(
  v_cedula_juridica   IN    tproveedores.cedula_juridica%TYPE,
  v_encontrado        OUT   DECIMAL
)
AS
BEGIN
  SELECT COUNT(*)
  INTO v_encontrado
  FROM tproveedores
  WHERE cedula_juridica = v_cedula_juridica;
END;
/

-- Trepuestos

CREATE OR REPLACE PROCEDURE sp_trepuestos_mostrar(
  c_repuestos OUT sys_refcursor
)
AS
BEGIN
  OPEN c_repuestos FOR
    SELECT cod_repuesto "Cod. Repuesto", tipo "Tipo", precio_unitario "Precio Unitario", descripcion "Descripción"
    FROM trepuestos;
END sp_trepuestos_mostrar;
/

CREATE OR REPLACE PROCEDURE sp_trepuestos_insertar(
  v_descripcion       trepuestos.descripcion%TYPE,
  v_tipo              trepuestos.tipo%TYPE,
  v_precio_unitario   trepuestos.precio_unitario%TYPE
)
AS
BEGIN
  INSERT INTO trepuestos(cod_repuesto, descripcion, tipo, precio_unitario)
  VALUES('RE_'||SEQ_TREPUESTOS.NEXTVAL, v_descripcion, v_tipo, v_precio_unitario);
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_trepuestos_actualizar(
  v_cod_repuesto      trepuestos.cod_repuesto%TYPE,
  v_descripcion       trepuestos.descripcion%TYPE,
  v_tipo              trepuestos.tipo%TYPE,
  v_precio_unitario   trepuestos.precio_unitario%TYPE
)
AS
BEGIN
  UPDATE trepuestos
  SET descripcion = v_descripcion,
      tipo = v_tipo,
      precio_unitario = v_precio_unitario
  WHERE cod_repuesto = v_cod_repuesto;
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_trepuestos_eliminar(
  v_cod_repuesto  trepuestos.cod_repuesto%TYPE
)
AS
BEGIN
  DELETE FROM trepuestos
  WHERE cod_repuesto = v_cod_repuesto;
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_trepuestos_existente(
  v_descripcion     IN  trepuestos.descripcion%TYPE,
  v_tipo            IN  trepuestos.tipo%TYPE,
  v_precio_unitario IN  trepuestos.precio_unitario%TYPE,
  v_encontrado      OUT DECIMAL
)
AS
BEGIN
  SELECT count(*)
  INTO v_encontrado
  FROM trepuestos
  WHERE descripcion = v_descripcion
  AND tipo = v_tipo
  AND precio_unitario = v_precio_unitario;
END;
/

--TServicios

CREATE OR REPLACE PROCEDURE sp_tservicios_mostrar(
  c_servicios OUT sys_refcursor
)
AS
BEGIN
  OPEN c_servicios FOR
    SELECT s.cod_servicio, e.nombre ||' '|| e.apellidos "NOMBRE_EMPLEADO", s.tipo, s.precio, s.descripcion
    FROM tservicios s, templeados e
    WHERE s.cod_empleado = e.cod_empleado;
END sp_tservicios_mostrar;
/

CREATE OR REPLACE PROCEDURE sp_tservicios_insertar(
  v_cod_empleado  tservicios.cod_empleado%TYPE,
  v_tipo          tservicios.tipo%TYPE,
  v_precio        tservicios.precio%TYPE,
  v_descripcion   tservicios.descripcion%TYPE
)
AS
BEGIN
  INSERT
  INTO tservicios(cod_servicio, cod_empleado, tipo, precio, descripcion)
  VALUES('SE_'||SEQ_TSERVICIOS.NEXTVAL, v_cod_empleado, v_tipo, v_precio, v_descripcion);
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tservicios_actualizar(
  v_cod_servicio    tservicios.cod_servicio%TYPE,
  v_cod_empleado    tservicios.cod_empleado%TYPE,
  v_tipo            tservicios.tipo%TYPE,
  v_precio          tservicios.precio%TYPE,
  v_descripcion     tservicios.descripcion%TYPE
)
AS
BEGIN
  UPDATE tservicios
  SET cod_empleado = v_cod_empleado,
      tipo = v_tipo,
      precio = v_precio,
      descripcion = v_descripcion
  WHERE cod_servicio = v_cod_servicio;
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tservicios_eliminar(
  v_cod_servicio  tservicios.cod_servicio%TYPE
)
AS
BEGIN
  DELETE FROM tservicios
  WHERE cod_servicio = v_cod_servicio;
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tservicios_existente(
  v_cod_empleado  IN    tservicios.cod_empleado%TYPE,
  v_tipo          IN    tservicios.tipo%TYPE,
  v_precio        IN    tservicios.precio%TYPE,
  v_encontrado    OUT   DECIMAL
)
AS
BEGIN
  SELECT count(*)
  INTO v_encontrado
  FROM tservicios
  WHERE cod_empleado = v_cod_empleado
  AND tipo = v_tipo
  AND precio = v_precio;
END;
/

--TAdquisiciones

CREATE OR REPLACE PROCEDURE sp_tadquisiciones_mostrar(
  c_adquisiciones out sys_refcursor
)
AS
BEGIN
  OPEN c_adquisiciones FOR
    SELECT cod_fact_compra, cod_vehiculo, cod_repuesto, cantidad_unidades, valor, fecha_compra
    FROM tadquisiciones
    ORDER BY cod_fact_compra;
END sp_tadquisiciones_mostrar;
/

CREATE OR REPLACE PROCEDURE sp_tadquisiciones_insertar(
  v_cod_vehiculo          tadquisiciones.cod_vehiculo%TYPE,
  v_cod_repuesto          tadquisiciones.cod_repuesto%TYPE,
  v_cantidad_unidades     tadquisiciones.cantidad_unidades%TYPE,
  v_fecha_compra          tadquisiciones.fecha_compra%TYPE,
  v_valor                 tadquisiciones.valor%TYPE,
  v_opcion                NUMBER
)
AS
BEGIN
  IF (v_opcion = 1) THEN
    INSERT
    INTO tadquisiciones(cod_fact_compra, cod_vehiculo, cantidad_unidades, fecha_compra, valor)
    VALUES(SEQ_TADQUISICIONES.NEXTVAL, v_cod_vehiculo, v_cantidad_unidades, v_fecha_compra, v_valor);
  ELSE
    INSERT
    INTO tadquisiciones(cod_fact_compra, cod_repuesto, cantidad_unidades, fecha_compra, valor)
    VALUES(SEQ_TADQUISICIONES.NEXTVAL, v_cod_repuesto, v_cantidad_unidades, v_fecha_compra, v_valor);
  END IF;
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tadquisiciones_actualizar(
  v_cod_fact_compra       tadquisiciones.cod_fact_compra%TYPE,
  v_cantidad_unidaddes    tadquisiciones.cantidad_unidades%TYPE,
  v_valor                 tadquisiciones.valor%TYPE
)
AS
BEGIN
  UPDATE tadquisiciones
  SET cantidad_unidades = v_cantidad_unidaddes,
      valor = v_valor
  WHERE cod_fact_compra = v_cod_fact_compra;
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tadquisiciones_eliminar(
  v_cod_fact_compra  tadquisiciones.cod_fact_compra%TYPE
)
AS
BEGIN
  DELETE FROM tadquisiciones
  WHERE cod_fact_compra = v_cod_fact_compra;
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tadquisiciones_existente(
  v_cod_vehiculo  IN    tadquisiciones.cod_vehiculo%TYPE,
  v_cod_repuesto  IN    tadquisiciones.cod_repuesto%TYPE,
  v_fecha_compra  IN    tadquisiciones.fecha_compra%TYPE,
  v_opcion        IN    NUMBER,
  v_encontrado    OUT   DECIMAL
)
AS
BEGIN
  IF (v_opcion = 1) THEN
    SELECT count(*)
    INTO v_encontrado
    FROM tadquisiciones
    WHERE cod_vehiculo = v_cod_vehiculo
    AND fecha_compra = v_fecha_compra;
  ELSE
    SELECT count(*)
    INTO v_encontrado
    FROM tadquisiciones
    WHERE cod_repuesto = v_cod_repuesto
    AND fecha_compra = v_fecha_compra;
  END IF;
END;
/

--TProveedor_TAdquisicion

CREATE OR REPLACE PROCEDURE sp_tpro_tadqui_mostrar(
  c_adquisiciones_proveedores OUT sys_refcursor
)
AS
BEGIN
  OPEN c_adquisiciones_proveedores FOR
    SELECT p.cod_proveedor, p.nombre, a.cod_fact_compra, a.cod_vehiculo, a.cod_repuesto, a.cantidad_unidades, a.valor, a.fecha_compra
    FROM tproveedores p, tproveedor_tadquisicion pa, tadquisiciones a
    WHERE pa.cod_proveedor = p.cod_proveedor
    AND pa.cod_fact_compra = a.cod_fact_compra;
END sp_tpro_tadqui_mostrar;
/

CREATE OR REPLACE PROCEDURE sp_tpro_tadqui_insertar(
  v_cod_proveedor     tproveedor_tadquisicion.cod_proveedor%TYPE,
  v_cod_fact_compra   tproveedor_tadquisicion.cod_fact_compra%TYPE
)
AS
BEGIN
  INSERT
    INTO tproveedor_tadquisicion(cod_proveedor, cod_fact_compra)
    VALUES(v_cod_proveedor, v_cod_fact_compra);
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tpro_tadqui_eliminar(
  v_cod_proveedor     tproveedor_tadquisicion.cod_proveedor%TYPE,
  v_cod_fact_compra   tproveedor_tadquisicion.cod_fact_compra%TYPE
)
AS
BEGIN
  DELETE FROM tproveedor_tadquisicion
  WHERE cod_proveedor = v_cod_proveedor
  AND cod_fact_compra = v_cod_fact_compra;
  COMMIT;
END;
/

CREATE OR REPLACE PROCEDURE sp_tpro_tadqui_existente(
  v_cod_proveedor     IN    tproveedor_tadquisicion.cod_proveedor%TYPE,
  v_cod_fact_compra   IN    tproveedor_tadquisicion.cod_fact_compra%TYPE,
  v_encontrado        OUT   DECIMAL
)
AS
BEGIN
  SELECT count(*)
  INTO v_encontrado
  FROM tproveedor_tadquisicion
  WHERE cod_proveedor = v_cod_proveedor
  AND cod_fact_compra = v_cod_fact_compra;
END;
/
