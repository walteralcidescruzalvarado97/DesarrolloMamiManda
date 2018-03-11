CREATE  procedure Sp_ClienteMayorCompra
As
	BEGIN
		Set nocount on 
		Select df.RTNCliente,df.sub as 'ValorM'
		From CLiente a inner join(Select fr.RTNCliente, SUM(Cantidad*Precio) as 'sub'
									from DetalleFactura df inner join Factura fr
										 on df.IdFactura = fr.IdFactura
									group by fr.RTNCliente)df
									on a.RTNCliente=df.RTNCliente
									where df.sub =  (SELECT MAX(df1.sub)
													   FROM (SELECT c.RTNCliente,SUM(Cantidad * Precio) as 'sub'
															 FROM DetalleFactura df inner join Factura f on df.IdFactura = f.IdFactura
																					inner join Cliente c on f.RTNCliente = c.RTNCliente
															 GROUP BY c.RTNCliente)df1)
									GROUP BY df.RTNCliente, df.sub


alter VIEW VIEW_Cliente_Mas_Compro
AS
	
		Select fr.IdFactura,fr.RTNCliente, SUM(Cantidad*Precio) as 'sub',(SUM(Cantidad*Precio)*0.15) as 'isv',(SUM(Cantidad*Precio)+(SUM(Cantidad*Precio)*0.15)) as 'total'
									from DetalleFactura df inner join Factura fr
										 on df.IdFactura = fr.IdFactura
									group by fr.RTNCliente, fr.IdFactura							
	



--RptClienteMayor
CREATE  procedure Sp_ClienteMayorCompra
As
	BEGIN
		Set nocount on 
			select c.RTNCliente, c.Nombre+' '+c.Apellido as 'Nombre Completo', SUM(d.Cantidad*d.Precio) as 'sub'
			from Cliente c inner join Factura f on c.RTNCliente =  f.RTNCliente
							inner join DetalleFactura d on d.IdFactura = f.IdFactura
			group by c.RTNCliente,(c.Nombre+' '+c.Apellido)
			having SUM(d.Cantidad*d.Precio) = (SELECT MAX(df1.sub)
											   FROM (SELECT c.RTNCliente,SUM(Cantidad * Precio) as 'sub'
													 FROM DetalleFactura df inner join Factura f on df.IdFactura = f.IdFactura
																			inner join Cliente c on f.RTNCliente = c.RTNCliente
													 GROUP BY c.RTNCliente)df1)
	END




--RptClienteFactura
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


CREATE  procedure Sp_ProductoMasV
As
	BEGIN
		Set nocount on 
		Select a.IdInventario,a.NombreProducto,SUM(df.Cantidad) as 'Cantidad Vendida'
		From Inventario a inner join DetalleFactura df 
					   on a.IdInventario=df.IdInventario
		group by a.IdInventario,a.NombreProducto
	END




--RptExistenciaM
create  procedure Sp_ProductoExistenciaMinima
As
	BEGIN
		Set nocount on 
		Select IdInventario,NombreProducto,Existencia,ExistenciaMinima,ExistenciaMaxima,'aumentar el inventario' as 'Factor'
		from Inventario
		where Existencia < existenciaminima
	END


--RptPresentacionProducto
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

--RptEmpleados
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


--RptProveedor
alter Procedure Sp_MostrarTodoProveedor
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




--rptmateriaprima
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


--rptinventario
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




--RptCliente
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

