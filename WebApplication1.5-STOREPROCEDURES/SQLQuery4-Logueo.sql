USE [CursoGyLStoreProcedure]
GO
/****** Object:  StoredProcedure [dbo].[Logueo]    Script Date: 23/3/2020 17:08:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Logueo] @usuarioProcedure nvarchar(10) AS --Create en lugar de procedure para primero crearlo
select * from Usuarios
	where @usuarioProcedure = UsuarioDB;