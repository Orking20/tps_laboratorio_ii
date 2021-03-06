USE [master]
GO
/****** Object:  Database [TP4_Luchetti_Capalbo_Mateo]    Script Date: 21/11/2021 14:35:05 ******/
CREATE DATABASE [TP4_Luchetti_Capalbo_Mateo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TP3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TP3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TP3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TP3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP4_Luchetti_Capalbo_Mateo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET RECOVERY FULL 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET  MULTI_USER 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TP4_Luchetti_Capalbo_Mateo', N'ON'
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET QUERY_STORE = OFF
GO
USE [TP4_Luchetti_Capalbo_Mateo]
GO
/****** Object:  Table [dbo].[Ejercitos]    Script Date: 21/11/2021 14:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ejercitos](
	[ID] [int] NOT NULL,
	[NOMBRE] [nvarchar](150) NOT NULL,
	[NACION] [nvarchar](100) NOT NULL,
	[TIPO] [nvarchar](150) NOT NULL,
	[AUTONOMIA] [nvarchar](100) NOT NULL,
	[CANTIDAD] [int] NOT NULL,
 CONSTRAINT [PK_Ejercitos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (1, N'Ejercito regular', N'Dormenia', N'Infanteria_ligera', N'Alta', 40000)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (2, N'Legion del sur', N'Dormenia', N'Infanteria_media_de_asalto', N'Casi_completa', 10000)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (3, N'Guardia real', N'Dormenia', N'Infanteria_pesada', N'Baja', 800)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (4, N'Hermanos iluminados', N'Dormenia', N'Infanteria_media_de_asalto', N'Completa', 1000)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (5, N'Cabellería ligera regular', N'Dormenia', N'Caballeria_ligera', N'Baja', 1000)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (6, N'Cabellería pesada regular', N'Dormenia', N'Caballeria_pesada_de_asalto', N'Baja', 1500)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (7, N'Primera cohorte', N'Eride', N'Infanteria_pesada', N'Completa', 950)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (8, N'Segunda cohorte', N'Eride', N'Infanteria_ligera', N'Completa', 900)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (9, N'Tercera cohorte', N'Eride', N'Infanteria_ligera', N'Completa', 1100)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (10, N'Cuarta cohorte', N'Eride', N'Infanteria_pesada', N'Completa', 4500)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (11, N'Quinta cohorte', N'Eride', N'Infanteria_ligera', N'Completa', 900)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (12, N'Sexta cohorte', N'Eride', N'Infanteria_pesada', N'Completa', 950)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (13, N'Septima cohorte', N'Eride', N'Infanteria_ligera', N'Completa', 1000)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (14, N'Octava cohorte', N'Eride', N'Infanteria_de_soporte', N'Completa', 850)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (15, N'Novena cohorte', N'Eride', N'Infanteria_ligera', N'Completa', 900)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (16, N'Carsij', N'Harrassia', N'Caballeria_media', N'Baja', 3000)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (17, N'Caballería sariana', N'Harrassia', N'Caballeria_ligera', N'Alta', 2000)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (18, N'Defensores de puesto avanzado', N'Harrassia', N'Infanteria_ligera', N'Alta', 2300)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (19, N'Zobagar adia', N'Tirtie', N'Infanteria_ligera', N'Completa', 800)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (20, N'Zobagar zitakoda', N'Tirtie', N'Mulenevor', N'Completa', 80)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (21, N'Zobagar Urke', N'Tirtie', N'Infanteria_ligera', N'Completa', 600)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (22, N'Exaltados de Armurésevor', N'Tirtie', N'Infanteria_ligera', N'Alta', 400)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (23, N'Guerreros del clan del oso', N'Gunear', N'Infanteria_media', N'Aceptable', 1240)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (24, N'Milicia del clan de la orca', N'Gunear', N'Infanteria_media', N'Baja', 4000)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (25, N'Caballería del clan del carnero', N'Gunear', N'Caballeria_media', N'Casi_completa', 500)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (26, N'Exploradores del clan del águila', N'Gunear', N'Arqueria_ligera', N'Completa', 1000)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (27, N'Leva del clan del lobo', N'Gunear', N'Infanteria_media', N'Moderada', 9840)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (28, N'Guardia del heredero', N'Najshet', N'Infanteria_media', N'Poca', 1350)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (29, N'Furias', N'Najshet', N'Infanteria_ligera', N'Desconocida', 5430)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (30, N'Tahlaned de la serpiente', N'Tribus', N'Infanteria_ligera', N'Completa', 800)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (31, N'Tahlaned del antílope', N'Tribus', N'Caballeria_ligera', N'Completa', 700)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (32, N'Tahlaned de la iguana', N'Tribus', N'Infanteria_ligera', N'Completa', 500)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (33, N'Tahlaned de la araña', N'Tribus', N'Infanteria_ligera', N'Completa', 600)
INSERT [dbo].[Ejercitos] ([ID], [NOMBRE], [NACION], [TIPO], [AUTONOMIA], [CANTIDAD]) VALUES (34, N'Tahlaned del escorpión', N'Tribus', N'Infanteria_media', N'Casi_completa', 400)
GO
USE [master]
GO
ALTER DATABASE [TP4_Luchetti_Capalbo_Mateo] SET  READ_WRITE 
GO
