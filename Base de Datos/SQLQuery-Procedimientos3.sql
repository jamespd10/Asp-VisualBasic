--Procedimiento Total Cliente
create procedure pa_Clientes_Total
@tot int output
As
begin
Select @tot = Count(*) from Clientes 
 end

--Procedimiento Total Concluido
create procedure pa_MConcluido_Total
@tot int output
As
Begin
Select @tot = Count(*) 
from Mantenimiento where status = 'C'
End

--Procedimiento Total Reparacion
create procedure pa_MReparacion_Total
@tot int output
As
Begin
Select @tot = Count(*) 
from Mantenimiento where status = 'R'
End

--Procedimiento Total Pendiente
create procedure pa_MPendiente_Total
@tot int output
As
Begin
Select @tot = Count(*) 
from Mantenimiento where status = 'P'
End

--Procedimiento Total Ingresos
create procedure pa_Alquiler_Total
@tot int output
as
Begin
select @tot = SUM((Datediff(day, a.fecha_entrada, a.fecha_salida) * ap.cost_alquiler))
				  from Alquiler a inner join Apartamento ap
                  on ap.cod_apto = a.cod_apto inner join Propietarios p on p.cod_pro = ap.cod_pro
end

--Procedimiento INSERT Apartamento
create procedure pa_Apartamento_Insertar
@cod_pro int, @nom varchar(50), @rec int, @valor money, @año int, @costo money,
@msj varchar(100) output
As
INSERT INTO Apartamento(cod_pro, nombre, recamaras, valor, año, cost_alquiler) 
VALUES(@cod_pro, @nom, @rec, @valor, @año, @costo)
set @msj = 'La instruccion se ejecuto correctamente'

--Procedimiento INSERT Apartamento
create procedure pa_Mantenimiento_Insertar
@cod_apto int, @fecha date, @costo money, @descripcion varchar(100), @status char(1),
@msj varchar(100) output
As
INSERT INTO Mantenimiento(cod_apto, fecha, costo, descripcion, status) 
VALUES (@cod_apto, @fecha, @costo, @descripcion, @status)
set @msj = 'La instruccion se ejecuto correctamente'

--Procedimiento DELETE Apartamento Nombre
CREATE procedure pa_ApartNom_Eliminar
@nombre varchar(40),
@msj VARCHAR(100) OUTPUT
AS
IF Exists(Select * from Apartamento where nombre = @nombre )
begin
 DELETE FROM Apartamento where nombre =@nombre
 set @msj = 'La instruccion se elimino correctamente'
end
else set @msj = 'La instruccion no se pudo eliminar correctamente'
/**********************************************************************************************************************/
--Procedimiento DELETE Apartamento Codigo
CREATE procedure pa_ApartCod_Eliminar
@cod_apto int,
@msj VARCHAR(100) OUTPUT
AS
IF Exists(Select * from Apartamento where cod_apto = @cod_apto )
begin
 DELETE FROM Apartamento where cod_apto =@cod_apto
 set @msj = 'La instruccion se elimino correctamente'
end
else set @msj = 'La instruccion no se pudo eliminar correctamente'

--Procedimiento DELETE Mantenimiento Codigo
CREATE procedure pa_MantCod_Eliminar
@codigo int,
@msj VARCHAR(100) OUTPUT
AS
IF Exists(Select * from Mantenimiento where codigo = @codigo )
begin
 DELETE FROM Mantenimiento where codigo =@codigo
 set @msj = 'La instruccion se elimino correctamente'
end
else set @msj = 'La instruccion no se pudo eliminar correctamente'

--Procedimiento DELETE Mantenimiento Status
CREATE procedure pa_MantSta_Eliminar
@status char(1),
@msj VARCHAR(100) OUTPUT
AS
IF Exists(Select * from Mantenimiento where status = @status )
begin
 DELETE FROM Mantenimiento where status =@status
 set @msj = 'La instruccion se elimino correctamente'
end
else set @msj = 'La instruccion no se pudo eliminar correctamente'

drop procedure pa_Apartamento_Insertar

--Procedimiento Lista por Codigo Mantenimiento
create procedure pa_Mantenimiento
as
Select codigo from Mantenimiento 

--Procedimiento Lista por Codigo Apartamento
create procedure pa_Apartamento
as
Select cod_apto from Apartamento

--Procedimiento Lista por Nombre Apartamento
create procedure pa_Apartamento_Nom
as
Select nombre from Apartamento

--Procedimiento MODIFICAR Mantenimiento
create procedure pa_Mant_Actual
@codigo int
as
Select cod_apto, fecha, costo, descripcion, status from Mantenimiento where codigo = @codigo

--Procedimiento MODIFICAR Apartamento
create procedure pa_Apart_Actual
@cod_apto int
as
Select cod_pro, nombre, recamaras, valor, año, cost_alquiler from Apartamento where cod_apto = @cod_apto

drop procedure pa_Apart_Modificar
--Procedimiento MODIFICAR Apartamento
create procedure pa_Apart_Modificar
@cod_apto int,
@cod_pro int,
@nombre varchar(40),
@recamaras int,
@valor money,
@año int, 
@cost_alquiler money, 
@msj varchar(100) output
as
IF Exists(Select * from Apartamento where cod_apto = @cod_apto )
begin
	Update Apartamento set cod_pro = @cod_pro, nombre = @nombre, recamaras=@recamaras, valor=@valor, año=@año, cost_alquiler=@cost_alquiler where cod_apto = @cod_apto
	set @msj = 'La instruccion se actualizo correctamente'
end
else set @msj = 'La instruccion no se pudo actualizar correctamente' 

--Procedimiento MODIFICAR Mantenimiento
create procedure pa_Mant_Modificar
@codigo int,
@cod_apto int,
@fecha date,
@costo money,
@descripcion varchar(100), 
@status char(1), 
@msj varchar(100) output
as
IF Exists(Select * from Mantenimiento where codigo = @codigo)
begin
	Update Mantenimiento Set cod_apto= @cod_apto, fecha=@fecha, costo=@costo, descripcion=@descripcion, status=@status where codigo =@codigo
	set @msj = 'La instruccion se actualizo correctamente'
end
else set @msj = 'La instruccion no se pudo actualizar correctamente' 

select * from Mantenimiento