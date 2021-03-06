USE [master]
GO
/****** Object:  Database [Earth]    Script Date: 10/9/2015 11:29:15 AM ******/
CREATE DATABASE [Earth]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Earth', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Earth.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Earth_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Earth_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Earth] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Earth].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Earth] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Earth] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Earth] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Earth] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Earth] SET ARITHABORT OFF 
GO
ALTER DATABASE [Earth] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Earth] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Earth] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Earth] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Earth] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Earth] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Earth] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Earth] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Earth] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Earth] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Earth] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Earth] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Earth] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Earth] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Earth] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Earth] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Earth] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Earth] SET RECOVERY FULL 
GO
ALTER DATABASE [Earth] SET  MULTI_USER 
GO
ALTER DATABASE [Earth] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Earth] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Earth] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Earth] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Earth] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Earth]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 10/9/2015 11:29:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[AddressId] [int] IDENTITY(1,1) NOT NULL,
	[Address_text] [ntext] NOT NULL,
	[TownId] [int] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continents]    Script Date: 10/9/2015 11:29:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continents](
	[ContinetId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Continents] PRIMARY KEY CLUSTERED 
(
	[ContinetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Countries]    Script Date: 10/9/2015 11:29:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ContinetId] [int] NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[People]    Script Date: 10/9/2015 11:29:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[PersonId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[AddressId] [int] NOT NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Towns]    Script Date: 10/9/2015 11:29:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Towns](
	[TownId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CountryId] [int] NOT NULL,
 CONSTRAINT [PK_Towns] PRIMARY KEY CLUSTERED 
(
	[TownId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Addresses] ON 

INSERT [dbo].[Addresses] ([AddressId], [Address_text], [TownId]) VALUES (2, N'Chuan Jun street', 2)
INSERT [dbo].[Addresses] ([AddressId], [Address_text], [TownId]) VALUES (4, N'Haansun Chu street', 1)
INSERT [dbo].[Addresses] ([AddressId], [Address_text], [TownId]) VALUES (5, N'Malexander Alinov', 3)
SET IDENTITY_INSERT [dbo].[Addresses] OFF
SET IDENTITY_INSERT [dbo].[Continents] ON 

INSERT [dbo].[Continents] ([ContinetId], [Name]) VALUES (1, N'Asia')
INSERT [dbo].[Continents] ([ContinetId], [Name]) VALUES (2, N'Africa')
INSERT [dbo].[Continents] ([ContinetId], [Name]) VALUES (3, N'North America')
INSERT [dbo].[Continents] ([ContinetId], [Name]) VALUES (4, N'South America')
INSERT [dbo].[Continents] ([ContinetId], [Name]) VALUES (5, N'Europe')
INSERT [dbo].[Continents] ([ContinetId], [Name]) VALUES (6, N'Antractica')
INSERT [dbo].[Continents] ([ContinetId], [Name]) VALUES (7, N'Australia')
SET IDENTITY_INSERT [dbo].[Continents] OFF
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([CountryId], [Name], [ContinetId]) VALUES (1, N'China', 1)
INSERT [dbo].[Countries] ([CountryId], [Name], [ContinetId]) VALUES (2, N'Japan', 1)
INSERT [dbo].[Countries] ([CountryId], [Name], [ContinetId]) VALUES (3, N'Botswana', 2)
INSERT [dbo].[Countries] ([CountryId], [Name], [ContinetId]) VALUES (4, N'Bulgaria', 5)
SET IDENTITY_INSERT [dbo].[Countries] OFF
SET IDENTITY_INSERT [dbo].[People] ON 

INSERT [dbo].[People] ([PersonId], [FirstName], [LastName], [AddressId]) VALUES (1, N'San', N'Cho', 2)
INSERT [dbo].[People] ([PersonId], [FirstName], [LastName], [AddressId]) VALUES (2, N'Huri', N'Katogredo', 4)
INSERT [dbo].[People] ([PersonId], [FirstName], [LastName], [AddressId]) VALUES (3, N'John', N'Georgiev', 5)
SET IDENTITY_INSERT [dbo].[People] OFF
SET IDENTITY_INSERT [dbo].[Towns] ON 

INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (1, N'Tokyo', 2)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (2, N'Beijing', 1)
INSERT [dbo].[Towns] ([TownId], [Name], [CountryId]) VALUES (3, N'Sofia', 4)
SET IDENTITY_INSERT [dbo].[Towns] OFF
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_Towns] FOREIGN KEY([TownId])
REFERENCES [dbo].[Towns] ([TownId])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_Towns]
GO
ALTER TABLE [dbo].[Countries]  WITH CHECK ADD  CONSTRAINT [FK_Countries_Continents] FOREIGN KEY([ContinetId])
REFERENCES [dbo].[Continents] ([ContinetId])
GO
ALTER TABLE [dbo].[Countries] CHECK CONSTRAINT [FK_Countries_Continents]
GO
ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [FK_People_Addresses] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Addresses] ([AddressId])
GO
ALTER TABLE [dbo].[People] CHECK CONSTRAINT [FK_People_Addresses]
GO
ALTER TABLE [dbo].[Towns]  WITH CHECK ADD  CONSTRAINT [FK_Towns_Countries] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Countries] ([CountryId])
GO
ALTER TABLE [dbo].[Towns] CHECK CONSTRAINT [FK_Towns_Countries]
GO
USE [master]
GO
ALTER DATABASE [Earth] SET  READ_WRITE 
GO
