USE [master]
GO
/****** Object:  Database [DbTismartLibrary]    Script Date: 20/12/2023 02:09:16 ******/
CREATE DATABASE [DbTismartLibrary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DbTismartLibrary', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DbTismartLibrary.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DbTismartLibrary_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DbTismartLibrary_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DbTismartLibrary] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbTismartLibrary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbTismartLibrary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbTismartLibrary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbTismartLibrary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbTismartLibrary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbTismartLibrary] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbTismartLibrary] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DbTismartLibrary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbTismartLibrary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbTismartLibrary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbTismartLibrary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbTismartLibrary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbTismartLibrary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbTismartLibrary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbTismartLibrary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbTismartLibrary] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DbTismartLibrary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbTismartLibrary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbTismartLibrary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbTismartLibrary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbTismartLibrary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbTismartLibrary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbTismartLibrary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbTismartLibrary] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DbTismartLibrary] SET  MULTI_USER 
GO
ALTER DATABASE [DbTismartLibrary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbTismartLibrary] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbTismartLibrary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbTismartLibrary] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DbTismartLibrary] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DbTismartLibrary] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DbTismartLibrary] SET QUERY_STORE = OFF
GO
USE [DbTismartLibrary]
GO
/****** Object:  Table [dbo].[books]    Script Date: 20/12/2023 02:09:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[books](
	[intIdBook] [int] IDENTITY(1,1) NOT NULL,
	[varTitle] [varchar](250) NULL,
	[varCode] [varchar](100) NOT NULL,
	[bolIsReserved] [bit] NULL,
	[intStatus] [tinyint] NULL,
	[dmeDateTimeCreation] [datetime] NOT NULL,
	[dmeDateTimeUpdate] [datetime] NULL,
	[bolIsActive] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[intIdBook] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reservations]    Script Date: 20/12/2023 02:09:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservations](
	[intIdReservation] [int] IDENTITY(1,1) NOT NULL,
	[intIdUser] [int] NOT NULL,
	[intIdBook] [int] NOT NULL,
	[dmeDateReservation] [datetime] NOT NULL,
	[intStatus] [tinyint] NULL,
	[dmeDateTimeCreation] [datetime] NOT NULL,
	[dmeDateTimeUpdate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[intIdReservation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 20/12/2023 02:09:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[intIdUser] [int] IDENTITY(1,1) NOT NULL,
	[varFirstName] [varchar](100) NULL,
	[varLastName] [varchar](100) NULL,
	[varEmail] [varchar](200) NOT NULL,
	[varPassword] [varchar](15) NOT NULL,
	[intStatus] [tinyint] NULL,
	[dmeDateTimeCreation] [datetime] NOT NULL,
	[dmeDateTimeUpdate] [datetime] NULL,
	[bolIsActive] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[intIdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[books] ON 

INSERT [dbo].[books] ([intIdBook], [varTitle], [varCode], [bolIsReserved], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (1, N'Orgullo y Prejuicio', N'ISBN-0002', 0, NULL, CAST(N'2023-12-12T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[books] ([intIdBook], [varTitle], [varCode], [bolIsReserved], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (2, N'Guerra y Paz', N'ISBN-023002', 0, NULL, CAST(N'2023-12-12T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[books] ([intIdBook], [varTitle], [varCode], [bolIsReserved], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (3, N'El Extranjero', N'ISBN-023002', 0, NULL, CAST(N'2023-12-12T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[books] ([intIdBook], [varTitle], [varCode], [bolIsReserved], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (4, N'Grandes Esperanzas', N'ISBN-0121202', 0, NULL, CAST(N'2023-12-12T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[books] ([intIdBook], [varTitle], [varCode], [bolIsReserved], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (5, N'Don Quijote de la Mancha', N'ISBN-011566202', 0, NULL, CAST(N'2023-12-12T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[books] ([intIdBook], [varTitle], [varCode], [bolIsReserved], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (6, N'1984', N'ISBN-882226202', 0, NULL, CAST(N'2023-12-12T00:00:00.000' AS DateTime), NULL, 1)
SET IDENTITY_INSERT [dbo].[books] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([intIdUser], [varFirstName], [varLastName], [varEmail], [varPassword], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (1, N'Rodrigo', N'Dura Espinoza', N'rdurae@gmail.com', N'reb00ter', NULL, CAST(N'2023-12-12T00:00:00.000' AS DateTime), NULL, 1)
SET IDENTITY_INSERT [dbo].[users] OFF
GO
ALTER TABLE [dbo].[reservations]  WITH CHECK ADD FOREIGN KEY([intIdUser])
REFERENCES [dbo].[users] ([intIdUser])
GO
ALTER TABLE [dbo].[reservations]  WITH CHECK ADD FOREIGN KEY([intIdBook])
REFERENCES [dbo].[books] ([intIdBook])
GO
/****** Object:  StoredProcedure [dbo].[SpBookReservation]    Script Date: 20/12/2023 02:09:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SpBookReservation](@idBook INT, @isReserved BIT, @dateReservation DATETIME)
AS
	UPDATE books SET
			bolIsReserved = @isReserved
		WHERE intIdBook = @idBook

	DELETE FROM reservations WHERE intIdBook = @idBook

	INSERT INTO reservations(intIdUser, intIdBook, dmeDateReservation, dmeDateTimeCreation)
	VALUES (1, @idBook, @dateReservation, GETDATE())		
GO
/****** Object:  StoredProcedure [dbo].[SpBookSelection]    Script Date: 20/12/2023 02:09:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SpBookSelection](@idBook INT)
AS
	SELECT intIdBook, bolIsReserved FROM books
	WHERE intIdBook = @idBook
GO
/****** Object:  StoredProcedure [dbo].[SpBooksReservations]    Script Date: 20/12/2023 02:09:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SpBooksReservations]
AS 
	SELECT books.intIdBook, varCode, varTitle, bolIsReserved, dmeDateReservation
	FROM books
	LEFT JOIN reservations
	ON
	books.intIdBook = reservations.intIdBook;
GO
/****** Object:  StoredProcedure [dbo].[SpUserRetrieval]    Script Date: 20/12/2023 02:09:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SpUserRetrieval](@email VARCHAR(200)) 
AS 
	SELECT intIdUser, varFirstName, varLastName, varEmail, varPassword, bolIsActive
	FROM users
	WHERE varEmail = @email 
GO
USE [master]
GO
ALTER DATABASE [DbTismartLibrary] SET  READ_WRITE 
GO
