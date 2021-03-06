USE [master]
GO
/****** Object:  Database [StoreAPI]    Script Date: 30/7/2019 01:42:33 ******/
CREATE DATABASE [StoreAPI]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StoreAPI', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\StoreAPI.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StoreAPI_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\StoreAPI_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StoreAPI].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StoreAPI] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StoreAPI] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StoreAPI] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StoreAPI] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StoreAPI] SET ARITHABORT OFF 
GO
ALTER DATABASE [StoreAPI] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StoreAPI] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StoreAPI] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StoreAPI] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StoreAPI] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StoreAPI] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StoreAPI] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StoreAPI] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StoreAPI] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StoreAPI] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StoreAPI] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StoreAPI] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StoreAPI] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StoreAPI] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StoreAPI] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StoreAPI] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StoreAPI] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StoreAPI] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StoreAPI] SET  MULTI_USER 
GO
ALTER DATABASE [StoreAPI] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StoreAPI] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StoreAPI] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StoreAPI] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StoreAPI] SET DELAYED_DURABILITY = DISABLED 
GO
USE [StoreAPI]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 30/7/2019 01:42:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 30/7/2019 01:42:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 30/7/2019 01:42:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 30/7/2019 01:42:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 30/7/2019 01:42:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 30/7/2019 01:42:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 30/7/2019 01:42:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[LastName] [nvarchar](100) NULL,
	[UserURL] [nvarchar](100) NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 30/7/2019 01:42:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LikeProduct]    Script Date: 30/7/2019 01:42:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LikeProduct](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](450) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](450) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[DeletedBy] [nvarchar](450) NULL,
	[UserId] [nvarchar](450) NULL,
	[ProductId] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_LikeProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LogPriceProduct]    Script Date: 30/7/2019 01:42:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogPriceProduct](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[UpdateDate] [datetime2](7) NOT NULL,
	[OldPrice] [decimal](18, 2) NULL,
	[NewPrice] [decimal](18, 2) NULL,
 CONSTRAINT [PK_LogPriceProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 30/7/2019 01:42:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](450) NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](450) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[DeletedBy] [nvarchar](450) NULL,
	[ProductName] [nvarchar](max) NULL,
	[Quantity] [int] NULL,
	[Price] [decimal](18, 2) NULL,
	[UserId] [nvarchar](450) NULL,
	[UrlImage] [nvarchar](max) NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserPerProduct]    Script Date: 30/7/2019 01:42:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserPerProduct](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[UpdateDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_UserPerProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 30/7/2019 01:42:33 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [RoleNameIndex]    Script Date: 30/7/2019 01:42:33 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 30/7/2019 01:42:33 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 30/7/2019 01:42:33 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 30/7/2019 01:42:33 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [EmailIndex]    Script Date: 30/7/2019 01:42:33 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UserNameIndex]    Script Date: 30/7/2019 01:42:33 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_LikeProduct_CreatedBy]    Script Date: 30/7/2019 01:42:33 ******/
CREATE NONCLUSTERED INDEX [IX_LikeProduct_CreatedBy] ON [dbo].[LikeProduct]
(
	[CreatedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_LikeProduct_DeletedBy]    Script Date: 30/7/2019 01:42:33 ******/
CREATE NONCLUSTERED INDEX [IX_LikeProduct_DeletedBy] ON [dbo].[LikeProduct]
(
	[DeletedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_LikeProduct_ProductId]    Script Date: 30/7/2019 01:42:33 ******/
CREATE NONCLUSTERED INDEX [IX_LikeProduct_ProductId] ON [dbo].[LikeProduct]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_LikeProduct_UpdatedBy]    Script Date: 30/7/2019 01:42:33 ******/
CREATE NONCLUSTERED INDEX [IX_LikeProduct_UpdatedBy] ON [dbo].[LikeProduct]
(
	[UpdatedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_LikeProduct_UserId]    Script Date: 30/7/2019 01:42:33 ******/
CREATE NONCLUSTERED INDEX [IX_LikeProduct_UserId] ON [dbo].[LikeProduct]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_LogPriceProduct_ProductId]    Script Date: 30/7/2019 01:42:33 ******/
CREATE NONCLUSTERED INDEX [IX_LogPriceProduct_ProductId] ON [dbo].[LogPriceProduct]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Product_CreatedBy]    Script Date: 30/7/2019 01:42:33 ******/
CREATE NONCLUSTERED INDEX [IX_Product_CreatedBy] ON [dbo].[Product]
(
	[CreatedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Product_DeletedBy]    Script Date: 30/7/2019 01:42:33 ******/
CREATE NONCLUSTERED INDEX [IX_Product_DeletedBy] ON [dbo].[Product]
(
	[DeletedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Product_UpdatedBy]    Script Date: 30/7/2019 01:42:33 ******/
CREATE NONCLUSTERED INDEX [IX_Product_UpdatedBy] ON [dbo].[Product]
(
	[UpdatedBy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Product_UserId]    Script Date: 30/7/2019 01:42:33 ******/
CREATE NONCLUSTERED INDEX [IX_Product_UserId] ON [dbo].[Product]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserPerProduct_ProductId]    Script Date: 30/7/2019 01:42:33 ******/
CREATE NONCLUSTERED INDEX [IX_UserPerProduct_ProductId] ON [dbo].[UserPerProduct]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_UserPerProduct_UserId]    Script Date: 30/7/2019 01:42:33 ******/
CREATE NONCLUSTERED INDEX [IX_UserPerProduct_UserId] ON [dbo].[UserPerProduct]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[LikeProduct]  WITH CHECK ADD  CONSTRAINT [FK_LikeProduct_AspNetUsers_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[LikeProduct] CHECK CONSTRAINT [FK_LikeProduct_AspNetUsers_CreatedBy]
GO
ALTER TABLE [dbo].[LikeProduct]  WITH CHECK ADD  CONSTRAINT [FK_LikeProduct_AspNetUsers_DeletedBy] FOREIGN KEY([DeletedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[LikeProduct] CHECK CONSTRAINT [FK_LikeProduct_AspNetUsers_DeletedBy]
GO
ALTER TABLE [dbo].[LikeProduct]  WITH CHECK ADD  CONSTRAINT [FK_LikeProduct_AspNetUsers_UpdatedBy] FOREIGN KEY([UpdatedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[LikeProduct] CHECK CONSTRAINT [FK_LikeProduct_AspNetUsers_UpdatedBy]
GO
ALTER TABLE [dbo].[LikeProduct]  WITH CHECK ADD  CONSTRAINT [FK_LikeProduct_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[LikeProduct] CHECK CONSTRAINT [FK_LikeProduct_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[LikeProduct]  WITH CHECK ADD  CONSTRAINT [FK_LikeProduct_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LikeProduct] CHECK CONSTRAINT [FK_LikeProduct_Product_ProductId]
GO
ALTER TABLE [dbo].[LogPriceProduct]  WITH CHECK ADD  CONSTRAINT [FK_LogPriceProduct_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LogPriceProduct] CHECK CONSTRAINT [FK_LogPriceProduct_Product_ProductId]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_AspNetUsers_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_AspNetUsers_CreatedBy]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_AspNetUsers_DeletedBy] FOREIGN KEY([DeletedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_AspNetUsers_DeletedBy]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_AspNetUsers_UpdatedBy] FOREIGN KEY([UpdatedBy])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_AspNetUsers_UpdatedBy]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[UserPerProduct]  WITH CHECK ADD  CONSTRAINT [FK_UserPerProduct_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[UserPerProduct] CHECK CONSTRAINT [FK_UserPerProduct_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[UserPerProduct]  WITH CHECK ADD  CONSTRAINT [FK_UserPerProduct_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserPerProduct] CHECK CONSTRAINT [FK_UserPerProduct_Product_ProductId]
GO
USE [master]
GO
ALTER DATABASE [StoreAPI] SET  READ_WRITE 
GO
