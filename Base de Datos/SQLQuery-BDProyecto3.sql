Create database ResortBuenaVista

Create table Clientes (
cod_cli int identity
	constraint Clientes_cod_cli_pk primary key,
nombre varchar(40), 
direccion varchar(40), 
telefono varchar(9),
email varchar(40)
) 

Create table Propietarios ( 
cod_pro int identity
	constraint Propietarios_cod_pro_pk primary key,
nombre varchar(40),
direccion varchar(40), 
telefono varchar(40), 
email varchar(40)
)

Create table Apartamento (
cod_apto int identity (100, 1)
	constraint Apartamento_cod_apto_pk primary key,
cod_pro int
|	constraint Apartamento_cod_pro_fk foreign key(cod_pro)
	references Propietarios(cod_pro)
	ON DELETE SET NULL,
nombre varchar(40), 
recamaras int, 
valor money, 
año int, 
cost_aquiler money
)

Create table Alquiler ( 
cod int identity
	constraint Alquiler_cod_pk primary key, 
cod_apto int,
	constraint Alquiler_cod_apto_fk foreign key(cod_apto)
	references Apartamento(cod_apto)
	ON DELETE SET NULL,
cod_cli int,
	constraint Alquiler_cod_cli_fk foreign key (cod_cli)
	references Clientes (cod_cli)
	ON DELETE CASCADE,
fecha_entrada date, 
fecha_salida date
)

Create table Mantenimiento (
codigo int identity
	constraint Mantenimiento_codigo_pk primary key, 
cod_apto int,
	constraint Mantenimiento_cod_apto_fk foreign key (cod_apto)
	references Apartamento(cod_apto),
	ON DELETE CASCADE,
fecha date, 
costo money, 
descripcion varchar(100), 
status char(1) --(P: pendiente; R:repación; C: concluida)
)
 
Create table Equipos (
cod_equipo int identity (10,10)
	constraint Equipos_cod_equipo_pk primary key, 
descripcion varchar(100), 
tipo varchar(10) --(fijo, instalable)
)

Create table Apto_Equipo(
cod_equipo int 
	constraint AptoEquipo_cod_equipo_fk foreign key (cod_equipo)
	references Equipos(cod_equipo),
cod_apto int
	constraint AptoEquipo_cod_apto_fk foreign key(cod_apto)
	references Apartamento(cod_apto)
	ON DELETE CASCADE,
constraint AptoEquipo_pk primary key(cod_equipo, cod_apto)
)



