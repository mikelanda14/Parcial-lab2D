USE [master]
GO
/****** Object:  Database [SParcial]    Script Date: 11/24/2020 11:15:00 AM ******/
CREATE DATABASE [SParcial]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SParcial', FILENAME = N'D:\SQL_SERVER\MSSQL15.MSSQLSERVER01\MSSQL\DATA\SParcial.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SParcial_log', FILENAME = N'D:\SQL_SERVER\MSSQL15.MSSQLSERVER01\MSSQL\DATA\SParcial_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SParcial] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SParcial].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SParcial] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SParcial] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SParcial] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SParcial] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SParcial] SET ARITHABORT OFF 
GO
ALTER DATABASE [SParcial] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SParcial] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SParcial] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SParcial] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SParcial] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SParcial] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SParcial] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SParcial] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SParcial] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SParcial] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SParcial] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SParcial] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SParcial] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SParcial] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SParcial] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SParcial] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SParcial] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SParcial] SET RECOVERY FULL 
GO
ALTER DATABASE [SParcial] SET  MULTI_USER 
GO
ALTER DATABASE [SParcial] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SParcial] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SParcial] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SParcial] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SParcial] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SParcial', N'ON'
GO
ALTER DATABASE [SParcial] SET QUERY_STORE = OFF
GO
USE [SParcial]
GO
/****** Object:  Table [dbo].[Pedidos]    Script Date: 11/24/2020 11:15:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidos](
	[IDPedido] [int] IDENTITY(1,1) NOT NULL,
	[Pedido] [nvarchar](max) NOT NULL,
	[ImporteTotal] [float] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 11/24/2020 11:15:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[IDproducto] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Precio] [float] NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [SParcial] SET  READ_WRITE 
GO
