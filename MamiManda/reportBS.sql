--vista para reportes de mayor compra
alter VIEW VIEW_Cliente_Mas_Compro
AS
	
		Select fr.IdFactura,fr.RTNCliente, SUM(Cantidad*Precio) as 'sub',(SUM(Cantidad*Precio)*0.15) as 'isv',fr.Descuento,((SUM(Cantidad*Precio)+(SUM(Cantidad*Precio)*0.15))-(fr.Descuento)) as 'total'
									from DetalleFactura df inner join Factura fr
										 on df.IdFactura = fr.IdFactura
									group by fr.RTNCliente, fr.IdFactura,fr.Descuento							
	



--RptClienteMayor 1
alter  procedure Sp_ClienteMayorCompra
As
	BEGIN
		Set nocount on 
			select c.RTNCliente, c.Nombre+' '+c.Apellido as 'Nombre Completo', SUM(d.Cantidad*d.Precio) as 'sub',SUM(Descuento) as 'Descuento'
			from Cliente c inner join Factura f on c.RTNCliente =  f.RTNCliente
							inner join DetalleFactura d on d.IdFactura = f.IdFactura
			group by c.RTNCliente,(c.Nombre+' '+c.Apellido)
			having SUM(d.Cantidad*d.Precio) = (SELECT MAX(df1.sub)
											   FROM (SELECT c.RTNCliente,SUM(Cantidad * Precio) as 'sub'
													 FROM DetalleFactura df inner join Factura f on df.IdFactura = f.IdFactura
																			inner join Cliente c on f.RTNCliente = c.RTNCliente
													 GROUP BY c.RTNCliente)df1)
	END

select *
FROM DetalleFactura df inner join Factura f on df.IdFactura=f.IdFactura
	inner join Cliente c on f.RTNCliente=c.RTNCliente
	where c.RTNCliente='0601-1997-008418' 

select * from Factura

--RptClienteFactura 2
alter procedure Sp_ClienteFactura
	@rtnCliente nvarchar(16)
As
	BEGIN
		Set nocount on 
		Select f.IdFactura,a.RTNCliente,a.Nombre+' '+a.Apellido as 'Nombre Completo',a.EMail,a.Telefono,a.DiasPlazo,s.Sexo,f.Fecha,
				f.FechaVence,e.EstadoFactura, vc.total
		From CLiente a inner join Factura f 
					   on a.RTNCliente=f.RTNCliente
					   inner join sexo s
					   on a.IdSexo=s.IdSexo
					   inner join EstadoFactura e
					   on f.IdEstadoFactura=e.IdEstadoFactura
					   inner join VIEW_Cliente_Mas_Compro vc
					   on vc.idfactura = f.IdFactura
		where a.RTNCliente=@rtnCliente	  
	END


--RptProductoMV 3
alter  procedure Sp_ProductoMasV
As
	BEGIN
		Set nocount on 
		Select a.IdInventario,a.NombreProducto,SUM(df.Cantidad) as 'Cantidad Vendida'
		From Inventario a inner join DetalleFactura df 
					   on a.IdInventario=df.IdInventario
		group by a.IdInventario,a.NombreProducto
		having SUM(df.Cantidad) =  (SELECT MAX(df.acum)
									FROM (SELECT a.IdInventario, SUM(df.Cantidad) as 'acum'
											FROM DetalleFactura df inner join Inventario a
																	on df.IdInventario=a.IdInventario
											group by a.IdInventario )df)
	END


--RptExistenciaMinima 4
alter procedure Sp_ProductoExistenciaMinima
As
	BEGIN
		Set nocount on 
		Select IdInventario,NombreProducto,Existencia,ExistenciaMinima,ExistenciaMaxima,'Aumentar el Inventario' as 'Factor'
		from Inventario
		where Existencia < existenciaminima
	END


--RptExistenciaMinimaMateria 5
create  procedure Sp_MateriaExistenciaMinima
As
	BEGIN
		Set nocount on 
		Select  IdMateriaPrima,NombreMateriaPrima,Existencia,ExistenciaMinima,'Aumentar La Materia Prima' as 'Factor'
		from MateriaPrima
		where Existencia < existenciaminima
	END


--RptPresentacionProducto 6
alter Procedure Sp_MostrarPresentacionProducto
	@IdPrese varchar(4)
as
	Begin
		IF @IdPrese = ''
			BEGIN	
				Set nocount on
				Select  PP.IdInventario ,I.NombreProducto, TP.TipoPresentacion ,TP.Unidades, PP.PrecioMayorista, PP.PrecioDetalle, PP.PrecioCosto
				From PresentacionProducto PP
				inner join Inventario I on I.IdInventario = PP.IdInventario
				inner join TipoPresentacion TP on TP.IdTipopresentacio = PP.IdTipoPresentacio 
			END
		ELSE 
			BEGIN	
				Set nocount on
				Select  PP.IdInventario ,I.NombreProducto, TP.TipoPresentacion ,TP.Unidades, PP.PrecioMayorista, PP.PrecioDetalle, PP.PrecioCosto
				From PresentacionProducto PP
				inner join Inventario I on I.IdInventario = PP.IdInventario
				inner join TipoPresentacion TP on TP.IdTipopresentacio = PP.IdTipoPresentacio 
				WHERE PP.IdInventario = @IdPrese
			END
			
	END

--RptEmpleados 7
alter Procedure Sp_RptMostrarEmpleados
	@IdEmpleado int
as
	Begin
		IF @IdEmpleado  = 0
			BEGIN	
				Set nocount on
				select Nombre + ' '+ Apellido as 'NombreCompleto', EMail, Telefono, direccion, TE.TipoEmpleado,s.sexo
				From Empleado E	inner join TipoEmpleado TE
						on TE.IdTipoEmpleado = E.IdTipoEmpleado
						inner join sexo s 
						on e.IdSexo=s.IdSexo
			END
		ELSE 
			BEGIN	
				Set nocount on
				select Nombre + ' '+ Apellido as 'NombreCompleto', EMail, Telefono, direccion, TE.TipoEmpleado,s.sexo
				From Empleado E	inner join TipoEmpleado TE
						on TE.IdTipoEmpleado = E.IdTipoEmpleado
						inner join sexo s 
						on e.IdSexo=s.IdSexo
				WHERE E.IdEmpleado = @IdEmpleado
			END
			
	END


--RptProveedor 8
create Procedure Sp_MostrarTodoProveedorR
	@rtnProveedor nvarchar(16)
as
	Begin 
		Set nocount on
			IF @rtnProveedor  = ''
			BEGIN	
				Set nocount on
				select RTNProveedor, Nombre+' '+ Apellido as 'Nombre Completo', Email, Telefono, direccion
				from Proveedor	
			END
		ELSE 
			BEGIN	
				Set nocount on
				select RTNProveedor, Nombre+' '+ Apellido as 'Nombre Completo', Email, Telefono, direccion
				from Proveedor	
				where RTNProveedor=@rtnProveedor
			END
	End




--RptMateriaPrima 9
alter Procedure Sp_RptMostrarMateriaPrima
	@IdMateriaPrima int
as
	Begin
		IF @IdMateriaPrima  = 0
			BEGIN	
				Set nocount on
				select MP.NombreMateriaPrima, P.Nombre + ' ' + P.Apellido as 'Proveedor', MP.ExistenciaMinima, MP.Existencia, UM.Medida, MP.PrecioCostoM,MP.Fecha
				From MateriaPrima MP
				inner join UnidadMedida UM on UM.IdUnidadMedida = MP.IdUnidadMedida
				inner join Proveedor P on P.RTNProveedor = MP.RTNProveedor
			END
		ELSE 
			BEGIN	
				Set nocount on
				select MP.NombreMateriaPrima, P.Nombre + ' ' + P.Apellido as 'Proveedor', MP.ExistenciaMinima, MP.Existencia, UM.Medida, MP.PrecioCostoM,MP.Fecha
				From MateriaPrima MP
				inner join UnidadMedida UM on UM.IdUnidadMedida = MP.IdUnidadMedida
				inner join Proveedor P on P.RTNProveedor = MP.RTNProveedor
				WHERE MP.IdMateriaPrima = @IdMateriaPrima
			END
			
	END


--RptInventario 10
alter Procedure Sp_RptMostrarInventario
	@IdPrese varchar(4)
as
	Begin
		IF @IdPrese = ''
			BEGIN	
				Set nocount on
				Select i.IdInventario,i.NombreProducto,i.Existencia,i.ExistenciaMinima,tp.TipoPresentacion,tp.Unidades
				from Inventario i inner join PresentacionProducto p
						  on i.IdInventario=p.IdInventario
						  inner join TipoPresentacion tp
						  on p.IdTipoPresentacio=tp.IdTipopresentacio
			END
		ELSE 
			BEGIN	
				Set nocount on
				select i.IdInventario,i.NombreProducto,i.Existencia,i.ExistenciaMinima,tp.TipoPresentacion,tp.Unidades
				from Inventario i inner join PresentacionProducto p
						  on i.IdInventario=p.IdInventario
						  inner join TipoPresentacion tp
						  on p.IdTipoPresentacio=tp.IdTipopresentacio
				WHERE i.IdInventario = @IdPrese
			END
			
	END




--RptCliente 11
alter Procedure Sp_RptMostrarClientes
	@rtnCliente nvarchar(16)
as
	Begin 
		Set nocount on
			IF @rtnCliente  = ''
			BEGIN	
				Set nocount on
				select C.RTNCliente, C.Nombre + ' ' + C.Apellido as 'Nombre Completo', C.EMail, C.Telefono, C.Direccion, C.FechaNac, S.sexo, M.Municipio
				from Cliente C
				inner join Municipio M on M.IdMunicipio = C.IdMunicipio
				inner join Sexo S on S.IdSexo = C.IdSexo
			END
		ELSE 
			BEGIN	
				Set nocount on
				select C.RTNCliente, C.Nombre + ' ' + C.Apellido as 'Nombre Completo', C.EMail, C.Telefono, C.Direccion, C.FechaNac, S.sexo, M.Municipio
				from Cliente C
				inner join Municipio M on M.IdMunicipio = C.IdMunicipio
				inner join Sexo S on S.IdSexo = C.IdSexo
				where C.RTNCliente=@rtnCliente
			END
	End



--RptProveedor 12
alter Procedure Sp_MostrarTodoProveedor
as
	Begin 
		Set nocount on
				Set nocount on
				select RTNProveedor, Nombre+' '+ Apellido as 'Nombre Completo', Email, Telefono, direccion
				from Proveedor
	End



create Procedure Sp_MostrarPresentacion
as
	Begin
		Set nocount on
		Select  PP.IdInventario ,I.NombreProducto, TP.TipoPresentacion ,TP.Unidades, PP.PrecioMayorista, PP.PrecioDetalle, PP.PrecioCosto
		From PresentacionProducto PP
		inner join Inventario I on I.IdInventario = PP.IdInventario
		inner join TipoPresentacion TP on TP.IdTipopresentacio = PP.IdTipoPresentacio 
			
	END


Create Procedure Sp_CargarDatosPresentacion
 @IdInventario int
As
	Begin
		Select I.NombreProducto, TP.TipoPresentacion, PP.PrecioMayorista, PP.PrecioDetalle, PP.PrecioCosto, PP.IdInventario, PP.IdTipoPresentacio
		From PresentacionProducto PP
		inner join Inventario I on I.IdInventario = PP.IdInventario
		inner join TipoPresentacion TP on TP.IdTipopresentacio = PP.IdTipoPresentacio 
		Where PP.IdInventario = @IdInventario
	End

--consulta para saver la edad del cliente 
Select RTNCliente, Nombre, Apellido, DATEDIFF(YEAR, FechaNac, GETDATE()) As 'Edad', FechaNac, GETDATE()
From Cliente

--RptEmpleadoFactura 13
alter procedure Sp_EmpleadoFactura
@idempleado int
As
	BEGIN
		select e.IdEmpleado,e.Nombre+' '+e.Apellido as 'Nombre Completo',COUNT(u.IdUsuario) as 'Cantidad de Facturas',e.Telefono,e.direccion,s.sexo
		from Factura f inner join Usuario u
						on f.IdUsuario=u.IdUsuario
						inner join Empleado e
						on u.IdEmpleado=e.IdEmpleado
						inner join sexo s
						on e.IdSexo=s.IdSexo
		where e.IdEmpleado=@idempleado
		group by e.IdEmpleado,e.Nombre,e.Apellido,e.Telefono,e.direccion,s.sexo
	END

--RptEmpleadoFacturaMax 14
alter procedure Sp_EmpleadoFacturaMax
As
	BEGIN
		select e.IdEmpleado,e.Nombre+' '+e.Apellido as 'Nombre Completo',COUNT(u.IdUsuario) as 'Cantidad de Facturas',e.Telefono,e.direccion,s.sexo
		from Factura f inner join Usuario u
						on f.IdUsuario=u.IdUsuario
						inner join Empleado e
						on u.IdEmpleado=e.IdEmpleado
						inner join sexo s
						on e.IdSexo=s.IdSexo
		group by e.IdEmpleado,e.Nombre,e.Apellido,e.Telefono,e.direccion,s.sexo
		having COUNT(u.IdUsuario) =  (SELECT MAX(df.acum)
									FROM (SELECT e.IdEmpleado, COUNT(u.IdUsuario) as 'acum'
											FROM factura f inner join Usuario u
															on f.IdUsuario=u.IdUsuario
															inner join Empleado e
															on u.IdEmpleado=e.IdEmpleado
											group by e.IdEmpleado )df)
	END


--RptVentasAno 15
alter procedure Sp_VentasAno
@ano int
As
	BEGIN
		SELECT Sum(df.Cantidad*df.Precio) AS 'Sub',(Sum(df.Cantidad*df.Precio)*0.15) as 'ISV',sum(f.Descuento) as 'Descuento',((Sum(df.Cantidad*df.Precio)+(Sum(df.Cantidad*df.Precio)*0.15))-(sum(f.Descuento))) as 'Total', YEAR(f.fecha) AS 'Año'
		FROM DetalleFactura df inner join Factura f
							on df.IdFactura=f.idfactura
		where year(f.Fecha)= @ano
		GROUP BY YEAR(f.fecha)
	END

exec Sp_VentasAno 2018

--RptClienteMayorMes 16
alter procedure Sp_ClienteMayorCompraMes
@ano int
As
	BEGIN
		Set nocount on 
			select c.RTNCliente, c.Nombre+' '+c.Apellido as 'Nombre Completo', SUM(d.Cantidad*d.Precio) as 'sub',sum(f.descuento) as 'Descuento',MONTH(f.fecha) as 'Mes'
			from Cliente c inner join Factura f on c.RTNCliente =  f.RTNCliente
							inner join DetalleFactura d on d.IdFactura = f.IdFactura
			where month(f.Fecha)= @ano
			group by c.RTNCliente,(c.Nombre+' '+c.Apellido),MONTH(f.fecha)
			having SUM(d.Cantidad*d.Precio) = (SELECT MAX(df1.sub)
											   FROM (SELECT c.RTNCliente,SUM(Cantidad * Precio) as 'sub'
													 FROM DetalleFactura df inner join Factura f on df.IdFactura = f.IdFactura
																			inner join Cliente c on f.RTNCliente = c.RTNCliente
													 where month(f.Fecha)= @ano
													 GROUP BY c.RTNCliente)df1)
	END


--RptClienteMayorAno 17
alter procedure Sp_ClienteMayorCompraAno
@ano int
As
	BEGIN
		Set nocount on 
			select c.RTNCliente, c.Nombre+' '+c.Apellido as 'Nombre Completo', SUM(d.Cantidad*d.Precio) as 'sub',sum(f.descuento) as 'Descuento',Year(f.fecha) as 'Año'
			from Cliente c inner join Factura f on c.RTNCliente =  f.RTNCliente
							inner join DetalleFactura d on d.IdFactura = f.IdFactura
			where Year(f.Fecha)= @ano
			group by c.RTNCliente,(c.Nombre+' '+c.Apellido),year(f.fecha)
			having SUM(d.Cantidad*d.Precio) = (SELECT MAX(df1.sub)
											   FROM (SELECT c.RTNCliente,SUM(Cantidad * Precio) as 'sub'
													 FROM DetalleFactura df inner join Factura f on df.IdFactura = f.IdFactura
																			inner join Cliente c on f.RTNCliente = c.RTNCliente
													 where Year(f.Fecha)= @ano
													 GROUP BY c.RTNCliente)df1)
	END

--no se esta usando
--RptClienteMayorDia 18
alter procedure Sp_ClienteMayorCompraDia
@dia date
As
	BEGIN
		Set nocount on 
			select c.RTNCliente, c.Nombre+' '+c.Apellido as 'Nombre Completo', SUM(d.Cantidad*d.Precio) as 'sub',f.fecha 
			from Cliente c inner join Factura f on c.RTNCliente =  f.RTNCliente
							inner join DetalleFactura d on d.IdFactura = f.IdFactura
			where f.Fecha= @dia
			group by c.RTNCliente,(c.Nombre+' '+c.Apellido),f.fecha
			having SUM(d.Cantidad*d.Precio) = (SELECT MAX(df1.sub)
											   FROM (SELECT c.RTNCliente,SUM(Cantidad * Precio) as 'sub'
													 FROM DetalleFactura df inner join Factura f on df.IdFactura = f.IdFactura
																			inner join Cliente c on f.RTNCliente = c.RTNCliente
													 where f.Fecha= @dia
													 GROUP BY c.RTNCliente)df1)
	END

--RptVentasMes 19
alter procedure Sp_VentasMes
@ano int
As
	BEGIN
		SELECT Sum(df.Cantidad*df.Precio) AS 'Sub',(Sum(df.Cantidad*df.Precio)*0.15) as 'ISV',sum(f.Descuento) as 'Descuento',((Sum(df.Cantidad*df.Precio)+(Sum(df.Cantidad*df.Precio)*0.15))-(sum(f.Descuento))) as 'Total', Month(f.fecha) AS 'Mes'
		FROM DetalleFactura df inner join Factura f
							on df.IdFactura=f.idfactura
		where Month(f.Fecha)= @ano
		GROUP BY MONTH(f.fecha)
	END
exec Sp_VentasMes 3

--RptVentasDia 20
alter procedure Sp_VentasDia
@ano date
As
	BEGIN
		SELECT Sum(df.Cantidad*df.Precio) AS 'Sub',(Sum(df.Cantidad*df.Precio)*0.15) as 'ISV',sum(f.Descuento) as 'Descuento',((Sum(df.Cantidad*df.Precio)+(Sum(df.Cantidad*df.Precio)*0.15))-(sum(f.Descuento))) as 'Total', f.fecha
		FROM DetalleFactura df inner join Factura f
							on df.IdFactura=f.idfactura
		where f.Fecha= @ano
		GROUP BY f.fecha
	END

