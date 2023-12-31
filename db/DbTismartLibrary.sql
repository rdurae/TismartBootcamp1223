USE [master]
GO
/****** Object:  Database [DbTismartLibrary]    Script Date: 26/12/2023 23:16:19 ******/
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
/****** Object:  Table [dbo].[books]    Script Date: 26/12/2023 23:16:19 ******/
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
/****** Object:  Table [dbo].[reservations]    Script Date: 26/12/2023 23:16:19 ******/
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
	[bolIsActive] [bit] NULL,
	[dmeDateReservationEnd] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[intIdReservation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 26/12/2023 23:16:19 ******/
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
/****** Object:  Table [dbo].[waitreservations]    Script Date: 26/12/2023 23:16:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[waitreservations](
	[intIdWaitReservation] [int] IDENTITY(1,1) NOT NULL,
	[intIdBook] [int] NOT NULL,
	[intIdUser] [int] NOT NULL,
	[varPriority] [char](2) NULL,
	[dmeDateReservation] [datetime] NULL,
	[dmeDateReservationEnd] [datetime] NULL,
	[intStatus] [int] NULL,
	[dmeDateCreate] [datetime] NULL,
	[dmeDateUpdate] [datetime] NULL,
	[bolIsActive] [bit] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[books] ON 

INSERT [dbo].[books] ([intIdBook], [varTitle], [varCode], [bolIsReserved], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (1, N'Orgullo y Prejuicio', N'ISBN-0002', 0, NULL, CAST(N'2023-12-12T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[books] ([intIdBook], [varTitle], [varCode], [bolIsReserved], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (2, N'Guerra y Paz', N'ISBN-023002', 0, NULL, CAST(N'2023-12-12T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[books] ([intIdBook], [varTitle], [varCode], [bolIsReserved], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (3, N'El Extranjero', N'ISBN-023002', 0, NULL, CAST(N'2023-12-12T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[books] ([intIdBook], [varTitle], [varCode], [bolIsReserved], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (4, N'Grandes Esperanzas', N'ISBN-0121202', 0, NULL, CAST(N'2023-12-12T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[books] ([intIdBook], [varTitle], [varCode], [bolIsReserved], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (5, N'Don Quijote de la Mancha', N'ISBN-011566202', 0, NULL, CAST(N'2023-12-12T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[books] ([intIdBook], [varTitle], [varCode], [bolIsReserved], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (6, N'1984', N'ISBN-882226202', 0, NULL, CAST(N'2023-12-12T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[books] ([intIdBook], [varTitle], [varCode], [bolIsReserved], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (9, N'Fight Club', N'ISBN-323422', 0, NULL, CAST(N'2023-12-25T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[books] ([intIdBook], [varTitle], [varCode], [bolIsReserved], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (11, N'Le Dedico mi Silencio', N'ISBN-45688425', 0, NULL, CAST(N'2023-12-25T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[books] ([intIdBook], [varTitle], [varCode], [bolIsReserved], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (12, N'Los Perros Hambrientos', N'ISBN-4345-3245', 0, NULL, CAST(N'2023-12-25T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[books] ([intIdBook], [varTitle], [varCode], [bolIsReserved], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (13, N'La Noche es Mía', N'ISBN-0004-4540', 0, NULL, CAST(N'2023-12-25T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[books] ([intIdBook], [varTitle], [varCode], [bolIsReserved], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (14, N'Dead Space', N'ISBN-456-41441', 0, NULL, CAST(N'2023-12-25T00:00:00.000' AS DateTime), NULL, 1)
SET IDENTITY_INSERT [dbo].[books] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([intIdUser], [varFirstName], [varLastName], [varEmail], [varPassword], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (1, N'Rodrigo', N'Dura Espinoza', N'rdurae@gmail.com', N'reb00ter', NULL, CAST(N'2023-12-12T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[users] ([intIdUser], [varFirstName], [varLastName], [varEmail], [varPassword], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (4, N'Arturo', N'-', N'arturo@gmail.com', N'reb00ter2', NULL, CAST(N'2023-12-12T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[users] ([intIdUser], [varFirstName], [varLastName], [varEmail], [varPassword], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (5, N'Fiorella', N'-', N'fiorella@gmail.com', N'reb00ter3', NULL, CAST(N'2023-12-12T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[users] ([intIdUser], [varFirstName], [varLastName], [varEmail], [varPassword], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (6, N'Juan', N'-', N'juan@gmail.com', N'reb00ter4', NULL, CAST(N'2023-12-12T00:00:00.000' AS DateTime), NULL, 0)
INSERT [dbo].[users] ([intIdUser], [varFirstName], [varLastName], [varEmail], [varPassword], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (8, N'Diego', NULL, N'diego@gmail.com', N'reb00ter5', NULL, CAST(N'2023-12-25T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[users] ([intIdUser], [varFirstName], [varLastName], [varEmail], [varPassword], [intStatus], [dmeDateTimeCreation], [dmeDateTimeUpdate], [bolIsActive]) VALUES (9, N'Alberto', NULL, N'alberto@gmail.com', N'reb00ter6', NULL, CAST(N'2023-12-25T00:00:00.000' AS DateTime), NULL, 1)
SET IDENTITY_INSERT [dbo].[users] OFF
GO
ALTER TABLE [dbo].[reservations]  WITH CHECK ADD FOREIGN KEY([intIdUser])
REFERENCES [dbo].[users] ([intIdUser])
GO
ALTER TABLE [dbo].[reservations]  WITH CHECK ADD FOREIGN KEY([intIdBook])
REFERENCES [dbo].[books] ([intIdBook])
GO
ALTER TABLE [dbo].[waitreservations]  WITH CHECK ADD  CONSTRAINT [FK_waitreservations_books] FOREIGN KEY([intIdBook])
REFERENCES [dbo].[books] ([intIdBook])
GO
ALTER TABLE [dbo].[waitreservations] CHECK CONSTRAINT [FK_waitreservations_books]
GO
ALTER TABLE [dbo].[waitreservations]  WITH CHECK ADD  CONSTRAINT [FK_waitreservations_users] FOREIGN KEY([intIdUser])
REFERENCES [dbo].[users] ([intIdUser])
GO
ALTER TABLE [dbo].[waitreservations] CHECK CONSTRAINT [FK_waitreservations_users]
GO
/****** Object:  StoredProcedure [dbo].[SpBookReservation]    Script Date: 26/12/2023 23:16:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SpBookReservation](@idUser INT, @idBook INT, @isReserved BIT, @dateReservation DATETIME, @dateReservationEnd DATETIME)
AS
	UPDATE books SET
			bolIsReserved = @isReserved
		WHERE intIdBook = @idBook

	INSERT INTO reservations(intIdUser, intIdBook, dmeDateReservation, dmeDateTimeCreation, bolIsActive, dmeDateReservationEnd)
	VALUES (@idUser, @idBook, @dateReservation, GETDATE(), 1, @dateReservationEnd)		
GO
/****** Object:  StoredProcedure [dbo].[SpBookSelection]    Script Date: 26/12/2023 23:16:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SpBookSelection](@idBook INT)
AS
	SELECT intIdBook, bolIsReserved, varTitle, varCode FROM books
	WHERE intIdBook = @idBook AND
		bolIsActive = 1
GO
/****** Object:  StoredProcedure [dbo].[SpBooksReservations]    Script Date: 26/12/2023 23:16:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SpBooksReservations]
AS 
	SELECT b.intIdBook, varCode, varTitle, bolIsReserved, intIdUser, r.dmeDateReservation
FROM books b
LEFT JOIN (
    SELECT intIdBook, MAX(dmeDateReservation) AS max_reservation_date
    FROM reservations
	WHERE bolIsActive = 1
    GROUP BY intIdBook
) latest_reservations ON b.intIdBook = latest_reservations.intIdBook
LEFT JOIN reservations r ON b.intIdBook = r.intIdBook AND r.dmeDateReservation = latest_reservations.max_reservation_date
GO
/****** Object:  StoredProcedure [dbo].[SpCheckUserAwaitingBook]    Script Date: 26/12/2023 23:16:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SpCheckUserAwaitingBook](@userId INT, @bookId INT)
AS
	SELECT COUNT(*) FROM waitreservations WHERE intIdBook = @bookId and intIdUser = @userId
GO
/****** Object:  StoredProcedure [dbo].[SpMoveQueueReservations]    Script Date: 26/12/2023 23:16:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SpMoveQueueReservations]
AS
	DECLARE @RowCount INT;

	-- eliminar logicamente reservas 
	UPDATE reservations SET bolIsActive = 0 WHERE bolIsActive = 1 AND dmeDateReservationEnd < GETDATE()

	--iniciar consultas sobre lista de espera
	SELECT @RowCount = COUNT(*) FROM waitreservations

	IF @RowCount > 0
		-- sí hay lista de espera
		BEGIN
			--insertar todos los que tengan p1 de la lista de espera en tabla reservations
			INSERT INTO reservations(intIdUser, intIdBook, dmeDateReservation, dmeDateTimeCreation, bolIsActive, dmeDateReservationEnd)
			SELECT intIdUser, intIdBook, dmeDateReservation, GETDATE(), 1, dmeDateReservationEnd
			FROM waitreservations
			WHERE varPriority = 'P1' AND
			bolIsActive = 1

			-- eliminar logicamente los que tengan lista de espera con p1 ACTIVOS
			UPDATE waitreservations SET
				bolIsActive = 0
			WHERE varPriority = 'P1' AND
			bolIsActive = 1

			-- eliminar los que tengan p2 logicamente ACTIVOS
			UPDATE waitreservations SET
				bolIsActive = 0
			WHERE varPriority = 'P2' AND
			bolIsActive = 1

			-- insertar nuevos registros que tengan p2 a p1 y activos
			INSERT INTO waitreservations(intIdBook, intIdUser, varPriority, dmeDateReservation, dmeDateReservationEnd, bolIsActive)
			SELECT intIdBook, intIdUser, 'P1', dmeDateReservation, dmeDateReservationEnd, 1
			FROM waitreservations
			WHERE varPriority = 'P2'

			-- eliminar los que tengan p3 logicamente
			UPDATE waitreservations SET
				bolIsActive = 0
			WHERE varPriority = 'P3' AND
			bolIsActive = 1

			-- insertar los que tengan p3 con p2
			INSERT INTO waitreservations(intIdBook, intIdUser, varPriority, dmeDateReservation, dmeDateReservationEnd, bolIsActive)
			SELECT intIdBook, intIdUser, 'P2', dmeDateReservation, dmeDateReservationEnd, 1
			FROM waitreservations
			WHERE varPriority = 'P3' 
		END
	ELSE
		BEGIN
			-- liberar libros
			UPDATE books SET 
				bolIsReserved = 0
			FROM books b 
			INNER JOIN reservations r ON b.intIdBook = r.intIdBook
			WHERE
				r.dmeDateReservationEnd < GETDATE() AND
				bolIsReserved = 1 AND
				b.bolIsActive = 1
		END
GO
/****** Object:  StoredProcedure [dbo].[SpUserRetrieval]    Script Date: 26/12/2023 23:16:20 ******/
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
/****** Object:  StoredProcedure [dbo].[SpValidateUser]    Script Date: 26/12/2023 23:16:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SpValidateUser](@email VARCHAR(200), @password VARCHAR(15)) 
AS
SELECT COUNT(*) 
FROM users
WHERE
	varEmail = @email AND
	varPassword = @password AND 
	bolIsActive = 1;
GO
/****** Object:  StoredProcedure [dbo].[SpWaitingListForBookCounter]    Script Date: 26/12/2023 23:16:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SpWaitingListForBookCounter](@bookId INT)
AS
	SELECT COUNT(*) FROM waitreservations WHERE intIdBook = @bookId AND bolIsActive = 1
GO
/****** Object:  StoredProcedure [dbo].[SpWaitReservationInsert]    Script Date: 26/12/2023 23:16:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SpWaitReservationInsert](@idBook INT, @idUser INT, @priority CHAR(2), @dateReservation DATETIME, @dateReservationEnd DATETIME)
AS
	INSERT INTO waitreservations(intIdBook, intIdUser, varPriority, dmeDateReservation, dmeDateReservationEnd, bolIsActive)
	VALUES(@idBook, @idUser, @priority, @dateReservation, @dateReservationEnd, 1)
GO
USE [master]
GO
ALTER DATABASE [DbTismartLibrary] SET  READ_WRITE 
GO
