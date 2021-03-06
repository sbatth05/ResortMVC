USE [master]
GO
/****** Object:  Database [ResortEntity]    Script Date: 9/9/2020 7:26:16 AM ******/
CREATE DATABASE [ResortEntity]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ResortEntity_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ResortEntity.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ResortEntity_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ResortEntity.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ResortEntity] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ResortEntity].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ResortEntity] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ResortEntity] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ResortEntity] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ResortEntity] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ResortEntity] SET ARITHABORT OFF 
GO
ALTER DATABASE [ResortEntity] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ResortEntity] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ResortEntity] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ResortEntity] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ResortEntity] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ResortEntity] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ResortEntity] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ResortEntity] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ResortEntity] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ResortEntity] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ResortEntity] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ResortEntity] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ResortEntity] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ResortEntity] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ResortEntity] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ResortEntity] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ResortEntity] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ResortEntity] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ResortEntity] SET  MULTI_USER 
GO
ALTER DATABASE [ResortEntity] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ResortEntity] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ResortEntity] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ResortEntity] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ResortEntity] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ResortEntity] SET QUERY_STORE = OFF
GO
USE [ResortEntity]
GO
/****** Object:  Table [dbo].[AdminLogin]    Script Date: 9/9/2020 7:26:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminLogin](
	[LoginID] [varchar](50) NOT NULL,
	[LoginPassword] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 9/9/2020 7:26:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Message] [varchar](50) NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 9/9/2020 7:26:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[RoomNo] [varchar](50) NULL,
	[Person] [varchar](50) NULL,
	[ChkDate] [varchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 9/9/2020 7:26:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[ChkDate] [varchar](50) NULL,
	[Payment] [varchar](50) NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 9/9/2020 7:26:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Designation] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Salary] [int] NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AdminLogin] ([LoginID], [LoginPassword]) VALUES (N'Admin@admin.com', N'admin')
SET IDENTITY_INSERT [dbo].[Contact] ON 

INSERT [dbo].[Contact] ([id], [Name], [Email], [Contact], [Message]) VALUES (1, N'qwwq', N'qwwq@sas.com', N'12', N'as')
SET IDENTITY_INSERT [dbo].[Contact] OFF
USE [master]
GO
ALTER DATABASE [ResortEntity] SET  READ_WRITE 
GO
