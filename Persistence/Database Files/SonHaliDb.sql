USE [DbAntrenmanTakip2]
GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[YetkiId] [int] NOT NULL,
	[Ad] [nvarchar](max) NOT NULL,
	[Soyad] [nvarchar](max) NOT NULL,
	[KullaniciAdi] [nvarchar](max) NOT NULL,
	[Sifre] [nvarchar](max) NOT NULL,
	[Mail] [nvarchar](max) NULL,
 CONSTRAINT [PK_Kullanicilar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_Antrenorler]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Antrenorler] as SELECT k.Id, k.Ad + ' ' + k.Soyad as AdSoyad , k.YetkiId  FROM kullanicilar k
GO
/****** Object:  Table [dbo].[TopGelisSekilleri]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TopGelisSekilleri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](max) NOT NULL,
	[EAdi] [nvarchar](max) NULL,
 CONSTRAINT [PK_TopGelisSekilleri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VurusBicimleri]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VurusBicimleri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](max) NOT NULL,
	[ResimId] [int] NULL,
	[EAdi] [nvarchar](max) NULL,
 CONSTRAINT [PK_VurusBicimleri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AntrenmanTurleri]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AntrenmanTurleri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TopKonumId] [int] NOT NULL,
	[TopGelisSekliId] [int] NOT NULL,
	[VurusBicimiId] [int] NOT NULL,
 CONSTRAINT [PK_AntrenmanTurleri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_VurusBicimleri]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_VurusBicimleri] as 
                                select tgs.Id,vb.Adi,vb.EAdi from VurusBicimleri vb
                                join AntrenmanTurleri atu on vb.Id = atu.VurusBicimiId
                                join TopGelisSekilleri tgs on atu.TopGelisSekliId = tgs.Id
                                GROUP BY tgs.Id,vb.Adi,vb.EAdi
GO
/****** Object:  Table [dbo].[TopKonumlari]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TopKonumlari](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](max) NOT NULL,
	[EAdi] [nvarchar](max) NULL,
 CONSTRAINT [PK_TopKonumlari] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Antrenmanlar]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Antrenmanlar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SporcuId] [int] NOT NULL,
	[AntrenamTuruId] [int] NULL,
	[AtisSayisi] [int] NOT NULL,
	[BasariliAtis] [int] NOT NULL,
	[Tarih] [datetime2](7) NOT NULL,
	[AntrenmanSayisi] [int] NOT NULL,
	[AntrenmanSuresi] [int] NULL,
	[KAntrenmanTuruId] [int] NULL,
 CONSTRAINT [PK_Antrenmanlar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sporcular]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sporcular](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MevkiId] [int] NOT NULL,
	[Adi] [nvarchar](max) NOT NULL,
	[Soyadi] [nvarchar](max) NOT NULL,
	[Yas] [int] NOT NULL,
	[Kilo] [int] NOT NULL,
	[Boy] [int] NOT NULL,
	[Ulke] [int] NULL,
	[ResimId] [int] NULL,
	[DogumTarihi] [datetime] NULL,
 CONSTRAINT [PK_Sporcular] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_AylikBasariliAtis]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







CREATE VIEW [dbo].[View_AylikBasariliAtis] AS 
SELECT A.AdSoyad, A.AntrenmanTurleri, Yil,A.AntrenamTuruId,A.Id,
    SUM(ISNULL([1] ,0)) OcakBasariliAtisSayisi,
    SUM(ISNULL([2] ,0)) SubatBasariliAtisSayisi,
    SUM(ISNULL([3] ,0)) MartBasariliAtisSayisi,
    SUM(ISNULL([4] ,0)) NisanBasariliAtisSayisi,
    SUM(ISNULL([5] ,0)) MayisBasariliAtisSayisi,
    SUM(ISNULL([6] ,0)) HaziranBasariliAtisSayisi,
    SUM(ISNULL([7] ,0)) TemmuzBasariliAtisSayisi,
    SUM(ISNULL([8] ,0)) AgustosBasariliAtisSayisi,
    SUM(ISNULL([9] ,0)) EylulBasariliAtisSayisi,
    SUM(ISNULL([10],0)) EkimBasariliAtisSayisi,
    SUM(ISNULL([11],0)) KasimBasariliAtisSayisi,
    SUM(ISNULL([12],0)) AralikBasariliAtisSayisi
FROM
(SELECT 
    *
FROM (SELECT
            A.Id as antId ,
            S.Id,
            S.Adi+' '+S.Soyadi AS AdSoyad,
            A.AntrenamTuruId,
            TK.Id AS TopKonumId,
            ATU.Id as AntrenmanId,
            TK.Adi + ' - ' + TGS.Adi + ' - ' + VB.Adi AS AntrenmanTurleri,
            TK.EAdi + ' - ' + TGS.EAdi + ' - ' + VB.EAdi AS EAntrenmanTurleri,
            A.BasariliAtis,
            MONTH(A.Tarih) Ay,
            YEAR(A.Tarih) Yil
            FROM
            Antrenmanlar A
            JOIN Sporcular S ON A.SporcuId = S.Id
            JOIN AntrenmanTurleri ATU ON A.AntrenamTuruId = ATU.Id
            JOIN TopKonumlari TK ON ATU.TopKonumId = TK.Id
            JOIN TopGelisSekilleri TGS ON ATU.TopGelisSekliId = TGS.Id
            JOIN VurusBicimleri VB ON ATU.VurusBicimiId = VB.Id
     ) AS SourceTable 
    PIVOT (
            SUM(BasariliAtis)
            FOR Ay IN ([1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12])
    )AS PivotTable
) AS A GROUP BY A.AdSoyad, A.AntrenmanTurleri, Yil,A.AntrenamTuruId,A.Id

GO
/****** Object:  View [dbo].[View_HaftalikBasariliAtis]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[View_HaftalikBasariliAtis] AS 
SELECT 
    A.AdSoyad,
    A.AntrenmanTurleri,
    A.Id,
    A.AntrenamTuruId,
    MONTH(Tarih) AS Ay,
    YEAR(Tarih) AS Yil,
    SUM(ISNULL([1] ,0)) BirHaftaBasariliAtisSayisi,
    SUM(ISNULL([2] ,0)) IkiHaftaBasariliAtisSayisi,
    SUM(ISNULL([3] ,0)) UcHaftaBasariliAtisSayisi,
    SUM(ISNULL([4] ,0)) DortHaftaBasariliAtisSayisi,
    SUM(ISNULL([5] ,0)) BesHaftaBasariliAtisSayisi
FROM
(
    SELECT 
        *
    FROM 
    (
        SELECT 
            A.Id as antId ,
            S.Id,
            S.Adi+' '+S.Soyadi AS AdSoyad,
            A.AntrenamTuruId,
            TK.Id AS TopKonumId,
            ATU.Id as AntrenmanId,
            TK.Adi + ' - ' + TGS.Adi + ' - ' + VB.Adi AS AntrenmanTurleri,
            TK.EAdi + ' - ' + TGS.EAdi + ' - ' + VB.EAdi AS EAntrenmanTurleri,
            A.BasariliAtis,
            DATEDIFF(WEEK, DATEADD(MONTH, DATEDIFF(MONTH, 0, Tarih), 0), Tarih) +1 Hafta,
            Tarih
        FROM 
            Antrenmanlar A
            JOIN Sporcular S ON A.SporcuId = S.Id
            JOIN AntrenmanTurleri ATU ON A.AntrenamTuruId = ATU.Id
            JOIN TopKonumlari TK ON ATU.TopKonumId = TK.Id
            JOIN TopGelisSekilleri TGS ON ATU.TopGelisSekliId = TGS.Id
            JOIN VurusBicimleri VB ON ATU.VurusBicimiId = VB.Id
            WHERE 
                MONTH(Tarih) BETWEEN 1 AND 12
    ) AS SourceTable 
    PIVOT 
    (
        SUM(BasariliAtis)
        FOR Hafta IN ([1], [2], [3], [4], [5])
    )AS PivotTable
) AS A 
GROUP BY 
    A.AdSoyad,
    A.AntrenmanTurleri,
    A.Id,
    A.AntrenamTuruId,
    MONTH(Tarih),
    YEAR(Tarih)
GO
/****** Object:  View [dbo].[View_Antrenmanlar]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[View_Antrenmanlar] AS
                                SELECT A.Id as antId , A.AntrenamTuruId, S.Id, TK.Id AS TopKonumId, ATU.Id as AntrenmanId,A.AntrenmanSayisi,A.AntrenmanSuresi, 
								TK.Adi + ' - ' + TGS.Adi + ' - ' + VB.Adi AS AntrenmanTurleri,
								TK.EAdi + ' - ' + TGS.EAdi + ' - ' + VB.EAdi AS EAntrenmanTurleri,
								A.AtisSayisi,A.BasariliAtis,A.Tarih FROM Antrenmanlar A
                                JOIN Sporcular S ON A.SporcuId = S.Id
                                JOIN AntrenmanTurleri ATU  ON A.AntrenamTuruId = ATU.Id
                                JOIN TopKonumlari TK ON ATU.TopKonumId = TK.Id
                                JOIN TopGelisSekilleri TGS ON ATU.TopGelisSekliId = TGS.Id
                                JOIN VurusBicimleri VB ON ATU.VurusBicimiId = VB.Id
GO
/****** Object:  View [dbo].[View_AntrenmanlarCMB]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_AntrenmanlarCMB] AS
                                SELECT  ATU.Id as AntrenmanId, 
								TK.Adi + ' - ' + TGS.Adi + ' - ' + VB.Adi AS AntrenmanTurleri, 
								TK.EAdi + ' - ' + TGS.EAdi + ' - ' + VB.EAdi AS EAntrenmanTurleri, 
								A.SporcuId, TK.Id as TopKonumId FROM Antrenmanlar A
                                JOIN Sporcular S ON A.SporcuId = S.Id
                                JOIN AntrenmanTurleri ATU  ON A.AntrenamTuruId = ATU.Id
                                JOIN TopKonumlari TK ON ATU.TopKonumId = TK.Id
                                JOIN TopGelisSekilleri TGS ON ATU.TopGelisSekliId = TGS.Id
                                JOIN VurusBicimleri VB ON ATU.VurusBicimiId = VB.Id
	
								GROUP BY ATU.Id , TK.Adi , TGS.Adi , VB.Adi,TK.EAdi , TGS.EAdi , VB.EAdi, A.SporcuId,TK.Id
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 9.12.2023 07:28:21 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AntrenmanBolge]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AntrenmanBolge](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SporcuId] [int] NULL,
	[AntrenmanTuruId] [int] NOT NULL,
	[Bolge] [int] NOT NULL,
	[BasariliMi] [bit] NOT NULL,
	[AntrenmanId] [int] NULL,
 CONSTRAINT [PK_AntrenmanBolge] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diller]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diller](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Language] [nvarchar](max) NOT NULL,
	[Selected] [bit] NOT NULL,
 CONSTRAINT [PK_Diller] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KaleciAntrenmanTurleri]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KaleciAntrenmanTurleri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TopKonumId] [int] NOT NULL,
	[TopGelisSekliId] [int] NOT NULL,
 CONSTRAINT [PK_KaleciAntrenmanTurleri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KullaniciSporcular]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KullaniciSporcular](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SporcuId] [int] NOT NULL,
	[KullaniciId] [int] NOT NULL,
 CONSTRAINT [PK_KullaniciSporcular] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mevkiler]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mevkiler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](max) NOT NULL,
	[EAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Mevkiler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PortAyari]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PortAyari](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Port] [nvarchar](50) NULL,
 CONSTRAINT [PK_PortAyari_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Resimler]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resimler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Path] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Resimler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ulkeler]    Script Date: 9.12.2023 07:28:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ulkeler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UlkeAdi] [nvarchar](max) NULL,
	[EUlkeAdi] [nvarchar](max) NULL,
 CONSTRAINT [PK_ulkeler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221125053746_init', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221126122924_mig_2', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221126124154_mig_3', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221126135207_mig_4', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221126141247_mig_5', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221201134759_mig_6', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221201145750_mig_7', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221201153906_mig_8', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221201160820_mig_9', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221201162626_mig_10', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221201163238_mig_11', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221201174011_mig_12', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221203172835_mig_13', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221203181044_mig_14', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221203181629_mig_15', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221204073747_mig_16', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221205123838_mig_17', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221206145335_mig_18', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221206164335_mig_20', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221206165145_mig_21', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221207083228_mig_22', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221207093802_mig_23', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221207094439_mig_24', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221207095639_mig_25', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221207102803_mig_26', N'7.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221207114221_mig_27', N'7.0.0')
GO
SET IDENTITY_INSERT [dbo].[AntrenmanBolge] ON 

INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (62, 2, 1, 1, 1, 38)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (63, 2, 1, 1, 1, 38)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (64, 2, 1, 3, 1, 38)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (65, 2, 1, 4, 1, 38)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (66, 2, 1, 3, 1, 38)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (67, 2, 1, 2, 0, 38)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (68, 2, 1, 2, 0, 38)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (69, 2, 1, 5, 0, 38)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (70, 2, 1, 3, 0, 38)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (71, 2, 1, 3, 0, 38)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (72, 2, 1, 2, 1, 39)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (73, 2, 1, 2, 1, 39)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (74, 2, 1, 3, 1, 39)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (75, 2, 1, 3, 1, 39)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (76, 2, 1, 2, 0, 39)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (77, 2, 1, 3, 0, 39)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (78, 2, 1, 3, 0, 39)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (79, 2, 1, 3, 1, 39)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (80, 2, 1, 3, 0, 39)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (81, 2, 1, 2, 1, 39)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (82, 2, 1, 2, 0, 40)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (83, 2, 1, 3, 0, 40)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (84, 2, 1, 3, 0, 40)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (85, 2, 1, 3, 0, 40)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (86, 2, 1, 4, 0, 40)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (87, 2, 1, 3, 1, 40)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (88, 2, 1, 2, 1, 40)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (89, 2, 1, 4, 1, 40)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (90, 2, 1, 3, 1, 40)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (91, 2, 1, 3, 1, 40)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (92, 2, 1, 2, 0, 41)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (93, 2, 1, 3, 0, 41)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (94, 2, 1, 3, 1, 41)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (95, 2, 1, 3, 0, 41)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (96, 2, 1, 4, 0, 41)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (97, 2, 1, 3, 0, 41)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (98, 2, 1, 2, 0, 41)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (99, 2, 1, 4, 0, 41)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (100, 2, 1, 3, 1, 41)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (101, 2, 1, 3, 1, 41)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (102, 2, 2, 2, 0, 42)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (103, 2, 2, 3, 0, 42)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (104, 2, 2, 3, 1, 42)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (105, 2, 2, 3, 0, 42)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (106, 2, 2, 4, 0, 42)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (107, 2, 2, 3, 0, 42)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (108, 2, 2, 2, 0, 42)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (109, 2, 2, 4, 0, 42)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (110, 2, 2, 3, 1, 42)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (111, 2, 2, 3, 1, 42)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (112, 2, 2, 2, 0, 43)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (113, 2, 2, 3, 0, 43)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (114, 2, 2, 3, 1, 43)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (115, 2, 2, 3, 0, 43)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (116, 2, 2, 4, 0, 43)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (117, 2, 2, 3, 0, 43)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (118, 2, 2, 2, 0, 43)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (119, 2, 2, 4, 0, 43)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (120, 2, 2, 3, 1, 43)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (121, 2, 2, 3, 1, 43)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (122, 2, 2, 2, 1, 44)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (123, 2, 2, 3, 1, 44)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (124, 2, 2, 3, 1, 44)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (125, 2, 2, 3, 1, 44)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (126, 2, 2, 4, 1, 44)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (127, 2, 2, 3, 1, 44)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (128, 2, 2, 2, 0, 44)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (129, 2, 2, 4, 0, 44)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (130, 2, 2, 3, 1, 44)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (131, 2, 2, 3, 1, 44)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (132, 21, 13, 2, 1, 45)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (133, 21, 13, 3, 1, 45)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (134, 21, 13, 3, 1, 45)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (135, 21, 13, 3, 1, 45)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (136, 21, 13, 4, 1, 45)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (137, 21, 13, 3, 1, 45)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (138, 21, 13, 2, 0, 45)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (139, 21, 13, 4, 0, 45)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (140, 21, 13, 3, 1, 45)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (141, 21, 13, 3, 1, 45)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (142, 21, 13, 2, 1, 46)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (143, 21, 13, 3, 1, 46)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (144, 21, 13, 3, 1, 46)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (145, 21, 13, 3, 0, 46)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (146, 21, 13, 4, 0, 46)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (147, 21, 13, 3, 0, 46)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (148, 21, 13, 2, 0, 46)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (149, 21, 13, 4, 0, 46)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (150, 21, 13, 3, 1, 46)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (151, 21, 13, 3, 1, 46)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (152, 21, 13, 2, 1, 47)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (153, 21, 13, 3, 1, 47)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (154, 21, 13, 3, 1, 47)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (155, 21, 13, 3, 0, 47)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (156, 21, 13, 4, 0, 47)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (157, 21, 13, 3, 0, 47)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (158, 21, 13, 2, 0, 47)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (159, 21, 13, 4, 0, 47)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (160, 21, 13, 3, 1, 47)
GO
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (161, 21, 13, 3, 1, 47)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (162, 21, 13, 2, 1, 48)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (163, 21, 13, 3, 1, 48)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (164, 21, 13, 3, 1, 48)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (165, 21, 13, 3, 0, 48)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (166, 21, 13, 4, 0, 48)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (167, 21, 13, 3, 0, 48)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (168, 21, 13, 2, 0, 48)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (169, 21, 13, 4, 0, 48)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (170, 21, 13, 3, 1, 48)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (171, 21, 13, 3, 1, 48)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (172, 21, 13, 2, 1, 49)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (173, 21, 13, 3, 1, 49)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (174, 21, 13, 3, 1, 49)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (175, 21, 13, 3, 1, 49)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (176, 21, 13, 4, 1, 49)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (177, 21, 13, 3, 1, 49)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (178, 21, 13, 2, 1, 49)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (179, 21, 13, 4, 1, 49)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (180, 21, 13, 3, 1, 49)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (181, 21, 13, 3, 1, 49)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (182, 21, 14, 2, 1, 50)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (183, 21, 14, 3, 1, 50)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (184, 21, 14, 3, 1, 50)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (185, 21, 14, 3, 1, 50)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (186, 21, 14, 4, 1, 50)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (187, 21, 14, 3, 1, 50)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (188, 21, 14, 2, 1, 50)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (189, 21, 14, 4, 1, 50)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (190, 21, 14, 3, 1, 50)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (191, 21, 14, 3, 1, 50)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (192, 21, 14, 2, 1, 51)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (193, 21, 14, 3, 1, 51)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (194, 21, 14, 3, 1, 51)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (195, 21, 14, 3, 1, 51)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (196, 21, 14, 4, 1, 51)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (197, 21, 14, 3, 1, 51)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (198, 21, 14, 2, 0, 51)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (199, 21, 14, 4, 0, 51)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (200, 21, 14, 3, 1, 51)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (201, 21, 14, 3, 1, 51)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (202, 21, 14, 2, 1, 52)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (203, 21, 14, 3, 1, 52)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (204, 21, 14, 3, 1, 52)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (205, 21, 14, 3, 1, 52)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (206, 21, 14, 4, 0, 52)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (207, 21, 14, 3, 0, 52)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (208, 21, 14, 2, 0, 52)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (209, 21, 14, 4, 0, 52)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (210, 21, 14, 3, 1, 52)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (211, 21, 14, 3, 1, 52)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (212, 21, 14, 2, 1, 53)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (213, 21, 14, 3, 1, 53)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (214, 21, 14, 3, 1, 53)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (215, 21, 14, 3, 1, 53)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (216, 21, 14, 4, 0, 53)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (217, 21, 14, 3, 0, 53)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (218, 21, 14, 2, 0, 53)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (219, 21, 14, 4, 0, 53)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (220, 21, 14, 3, 1, 53)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (221, 21, 14, 3, 1, 53)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (222, 21, 14, 2, 1, 54)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (223, 21, 14, 3, 1, 54)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (224, 21, 14, 3, 1, 54)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (225, 21, 14, 3, 1, 54)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (226, 21, 14, 4, 0, 54)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (227, 21, 14, 3, 0, 54)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (228, 21, 14, 2, 0, 54)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (229, 21, 14, 4, 0, 54)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (230, 21, 14, 3, 1, 54)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (231, 21, 14, 3, 1, 54)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (232, 22, 19, 2, 1, 55)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (233, 22, 19, 3, 1, 55)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (234, 22, 19, 3, 1, 55)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (235, 22, 19, 3, 1, 55)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (236, 22, 19, 4, 0, 55)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (237, 22, 19, 3, 0, 55)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (238, 22, 19, 2, 0, 55)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (239, 22, 19, 4, 0, 55)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (240, 22, 19, 3, 1, 55)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (241, 22, 19, 3, 1, 55)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (242, 22, 19, 2, 1, 56)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (243, 22, 19, 3, 1, 56)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (244, 22, 19, 3, 1, 56)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (245, 22, 19, 3, 1, 56)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (246, 22, 19, 4, 0, 56)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (247, 22, 19, 3, 0, 56)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (248, 22, 19, 2, 0, 56)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (249, 22, 19, 4, 0, 56)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (250, 22, 19, 3, 1, 56)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (251, 22, 19, 3, 1, 56)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (252, 22, 19, 2, 1, 57)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (253, 22, 19, 3, 1, 57)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (254, 22, 19, 3, 1, 57)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (255, 22, 19, 3, 1, 57)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (256, 22, 19, 4, 0, 57)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (257, 22, 19, 3, 0, 57)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (258, 22, 19, 2, 0, 57)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (259, 22, 19, 4, 0, 57)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (260, 22, 19, 3, 1, 57)
GO
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (261, 22, 19, 3, 1, 57)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (262, 22, 19, 2, 1, 58)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (263, 22, 19, 3, 1, 58)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (264, 22, 19, 3, 1, 58)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (265, 22, 19, 3, 1, 58)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (266, 22, 19, 4, 0, 58)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (267, 22, 19, 3, 0, 58)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (268, 22, 19, 2, 0, 58)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (269, 22, 19, 4, 0, 58)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (270, 22, 19, 3, 1, 58)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (271, 22, 19, 3, 1, 58)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (272, 22, 19, 2, 1, 59)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (273, 22, 19, 3, 1, 59)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (274, 22, 19, 3, 1, 59)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (275, 22, 19, 3, 1, 59)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (276, 22, 19, 4, 0, 59)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (277, 22, 19, 3, 1, 59)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (278, 22, 19, 2, 1, 59)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (279, 22, 19, 4, 1, 59)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (280, 22, 19, 3, 1, 59)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (281, 22, 19, 3, 1, 59)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (282, 22, 20, 2, 1, 60)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (283, 22, 20, 3, 1, 60)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (284, 22, 20, 3, 1, 60)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (285, 22, 20, 3, 1, 60)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (286, 22, 20, 4, 0, 60)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (287, 22, 20, 3, 1, 60)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (288, 22, 20, 2, 1, 60)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (289, 22, 20, 4, 1, 60)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (290, 22, 20, 3, 1, 60)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (291, 22, 20, 3, 1, 60)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (292, 22, 20, 2, 1, 61)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (293, 22, 20, 3, 1, 61)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (294, 22, 20, 3, 1, 61)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (295, 22, 20, 3, 1, 61)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (296, 22, 20, 4, 0, 61)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (297, 22, 20, 3, 1, 61)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (298, 22, 20, 2, 1, 61)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (299, 22, 20, 4, 1, 61)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (300, 22, 20, 3, 1, 61)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (301, 22, 20, 3, 1, 61)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (302, 22, 20, 2, 1, 62)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (303, 22, 20, 3, 1, 62)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (304, 22, 20, 3, 1, 62)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (305, 22, 20, 3, 1, 62)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (306, 22, 20, 4, 0, 62)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (307, 22, 20, 3, 1, 62)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (308, 22, 20, 2, 1, 62)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (309, 22, 20, 4, 1, 62)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (310, 22, 20, 3, 1, 62)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (311, 22, 20, 3, 1, 62)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (312, 22, 20, 2, 1, 63)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (313, 22, 20, 3, 1, 63)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (314, 22, 20, 3, 1, 63)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (315, 22, 20, 3, 1, 63)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (316, 22, 20, 4, 0, 63)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (317, 22, 20, 3, 1, 63)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (318, 22, 20, 2, 1, 63)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (319, 22, 20, 4, 1, 63)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (320, 22, 20, 3, 1, 63)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (321, 22, 20, 3, 1, 63)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (322, 22, 20, 2, 1, 64)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (323, 22, 20, 3, 0, 64)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (324, 22, 20, 3, 0, 64)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (325, 22, 20, 3, 0, 64)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (326, 22, 20, 4, 0, 64)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (327, 22, 20, 3, 1, 64)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (328, 22, 20, 2, 1, 64)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (329, 22, 20, 4, 1, 64)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (330, 22, 20, 3, 1, 64)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (331, 22, 20, 3, 1, 64)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (332, 22, 20, 2, 1, 65)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (333, 22, 20, 3, 0, 65)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (334, 22, 20, 3, 0, 65)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (335, 22, 20, 3, 0, 65)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (336, 22, 20, 4, 0, 65)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (337, 22, 20, 3, 1, 65)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (338, 22, 20, 2, 1, 65)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (339, 22, 20, 4, 1, 65)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (340, 22, 20, 3, 1, 65)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (341, 22, 20, 3, 1, 65)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (342, 22, 20, 2, 1, 66)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (343, 22, 20, 3, 0, 66)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (344, 22, 20, 3, 0, 66)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (345, 22, 20, 3, 0, 66)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (346, 22, 20, 4, 0, 66)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (347, 22, 20, 3, 1, 66)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (348, 22, 20, 2, 1, 66)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (349, 22, 20, 4, 1, 66)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (350, 22, 20, 3, 1, 66)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (351, 22, 20, 3, 1, 66)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (352, 25, 37, 2, 1, 67)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (353, 25, 37, 3, 0, 67)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (354, 25, 37, 3, 0, 67)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (355, 25, 37, 3, 0, 67)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (356, 25, 37, 4, 0, 67)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (357, 25, 37, 3, 1, 67)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (358, 25, 37, 2, 1, 67)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (359, 25, 37, 4, 1, 67)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (360, 25, 37, 3, 1, 67)
GO
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (361, 25, 37, 3, 1, 67)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (362, 25, 37, 2, 1, 68)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (363, 25, 37, 3, 0, 68)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (364, 25, 37, 3, 0, 68)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (365, 25, 37, 3, 0, 68)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (366, 25, 37, 4, 0, 68)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (367, 25, 37, 3, 1, 68)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (368, 25, 37, 2, 1, 68)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (369, 25, 37, 4, 1, 68)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (370, 25, 37, 3, 1, 68)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (371, 25, 37, 3, 1, 68)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (372, 25, 37, 2, 1, 69)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (373, 25, 37, 3, 0, 69)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (374, 25, 37, 3, 0, 69)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (375, 25, 37, 3, 0, 69)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (376, 25, 37, 4, 0, 69)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (377, 25, 37, 3, 1, 69)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (378, 25, 37, 2, 1, 69)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (379, 25, 37, 4, 1, 69)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (380, 25, 37, 3, 1, 69)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (381, 25, 37, 3, 1, 69)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (382, 25, 37, 2, 1, 70)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (383, 25, 37, 3, 0, 70)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (384, 25, 37, 3, 0, 70)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (385, 25, 37, 3, 0, 70)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (386, 25, 37, 4, 0, 70)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (387, 25, 37, 3, 1, 70)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (388, 25, 37, 2, 1, 70)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (389, 25, 37, 4, 1, 70)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (390, 25, 37, 3, 1, 70)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (391, 25, 37, 3, 1, 70)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (392, 25, 37, 2, 1, 71)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (393, 25, 37, 3, 0, 71)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (394, 25, 37, 3, 0, 71)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (395, 25, 37, 3, 0, 71)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (396, 25, 37, 4, 0, 71)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (397, 25, 37, 3, 1, 71)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (398, 25, 37, 2, 0, 71)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (399, 25, 37, 4, 0, 71)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (400, 25, 37, 3, 1, 71)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (401, 25, 37, 3, 1, 71)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (402, 25, 37, 2, 1, 72)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (403, 25, 37, 3, 0, 72)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (404, 25, 37, 3, 0, 72)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (405, 25, 37, 3, 0, 72)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (406, 25, 37, 4, 0, 72)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (407, 25, 37, 3, 1, 72)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (408, 25, 37, 2, 0, 72)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (409, 25, 37, 4, 0, 72)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (410, 25, 37, 3, 1, 72)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (411, 25, 37, 3, 1, 72)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (412, 25, 37, 2, 1, 73)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (413, 25, 37, 3, 0, 73)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (414, 25, 37, 3, 0, 73)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (415, 25, 37, 3, 0, 73)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (416, 25, 37, 4, 0, 73)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (417, 25, 37, 3, 1, 73)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (418, 25, 37, 2, 0, 73)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (419, 25, 37, 4, 0, 73)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (420, 25, 37, 3, 1, 73)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (421, 25, 37, 3, 1, 73)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (422, 25, 37, 2, 1, 74)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (423, 25, 37, 3, 0, 74)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (424, 25, 37, 3, 0, 74)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (425, 25, 37, 3, 0, 74)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (426, 25, 37, 4, 0, 74)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (427, 25, 37, 3, 1, 74)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (428, 25, 37, 2, 0, 74)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (429, 25, 37, 4, 0, 74)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (430, 25, 37, 3, 1, 74)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (431, 25, 37, 3, 1, 74)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (432, 25, 37, 2, 1, 75)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (433, 25, 37, 3, 0, 75)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (434, 25, 37, 3, 0, 75)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (435, 25, 37, 3, 0, 75)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (436, 25, 37, 4, 0, 75)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (437, 25, 37, 3, 1, 75)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (438, 25, 37, 2, 0, 75)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (439, 25, 37, 4, 0, 75)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (440, 25, 37, 3, 1, 75)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (441, 25, 37, 3, 1, 75)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (442, 25, 21, 2, 1, 76)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (443, 25, 21, 3, 0, 76)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (444, 25, 21, 3, 0, 76)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (445, 25, 21, 3, 0, 76)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (446, 25, 21, 4, 0, 76)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (447, 25, 21, 3, 1, 76)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (448, 25, 21, 2, 0, 76)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (449, 25, 21, 4, 0, 76)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (450, 25, 21, 3, 1, 76)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (451, 25, 21, 3, 1, 76)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (452, 25, 21, 2, 1, 77)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (453, 25, 21, 3, 1, 77)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (454, 25, 21, 3, 1, 77)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (455, 25, 21, 3, 1, 77)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (456, 25, 21, 4, 1, 77)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (457, 25, 21, 3, 1, 77)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (458, 25, 21, 2, 0, 77)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (459, 25, 21, 4, 0, 77)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (460, 25, 21, 3, 1, 77)
GO
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (461, 25, 21, 3, 1, 77)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (462, 25, 21, 2, 1, 78)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (463, 25, 21, 3, 1, 78)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (464, 25, 21, 3, 1, 78)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (465, 25, 21, 3, 1, 78)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (466, 25, 21, 4, 1, 78)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (467, 25, 21, 3, 1, 78)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (468, 25, 21, 2, 0, 78)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (469, 25, 21, 4, 0, 78)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (470, 25, 21, 3, 1, 78)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (471, 25, 21, 3, 1, 78)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (472, 25, 21, 2, 1, 79)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (473, 25, 21, 3, 1, 79)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (474, 25, 21, 3, 1, 79)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (475, 25, 21, 3, 1, 79)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (476, 25, 21, 4, 1, 79)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (477, 25, 21, 3, 1, 79)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (478, 25, 21, 2, 0, 79)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (479, 25, 21, 4, 0, 79)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (480, 25, 21, 3, 1, 79)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (481, 25, 21, 3, 1, 79)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (482, 25, 21, 2, 1, 80)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (483, 25, 21, 3, 1, 80)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (484, 25, 21, 3, 1, 80)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (485, 25, 21, 3, 1, 80)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (486, 25, 21, 4, 1, 80)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (487, 25, 21, 3, 1, 80)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (488, 25, 21, 2, 0, 80)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (489, 25, 21, 4, 0, 80)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (490, 25, 21, 3, 1, 80)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (491, 25, 21, 3, 1, 80)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (492, 25, 21, 2, 1, 81)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (493, 25, 21, 3, 1, 81)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (494, 25, 21, 3, 1, 81)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (495, 25, 21, 3, 1, 81)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (496, 25, 21, 4, 1, 81)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (497, 25, 21, 3, 1, 81)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (498, 25, 21, 2, 0, 81)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (499, 25, 21, 4, 0, 81)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (500, 25, 21, 3, 1, 81)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (501, 25, 21, 3, 1, 81)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (502, 25, 21, 2, 1, 82)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (503, 25, 21, 3, 1, 82)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (504, 25, 21, 3, 1, 82)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (505, 25, 21, 3, 1, 82)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (506, 25, 21, 4, 1, 82)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (507, 25, 21, 3, 1, 82)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (508, 25, 21, 2, 0, 82)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (509, 25, 21, 4, 0, 82)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (510, 25, 21, 3, 1, 82)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (511, 25, 21, 3, 1, 82)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (512, 25, 21, 2, 1, 83)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (513, 25, 21, 3, 1, 83)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (514, 25, 21, 3, 1, 83)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (515, 25, 21, 3, 1, 83)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (516, 25, 21, 4, 1, 83)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (517, 25, 21, 3, 1, 83)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (518, 25, 21, 2, 0, 83)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (519, 25, 21, 4, 0, 83)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (520, 25, 21, 3, 1, 83)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (521, 25, 21, 3, 1, 83)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (522, 24, 29, 2, 1, 84)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (523, 24, 29, 3, 1, 84)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (524, 24, 29, 3, 1, 84)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (525, 24, 29, 3, 1, 84)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (526, 24, 29, 4, 1, 84)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (527, 24, 29, 3, 1, 84)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (528, 24, 29, 2, 0, 84)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (529, 24, 29, 4, 0, 84)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (530, 24, 29, 3, 1, 84)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (531, 24, 29, 3, 1, 84)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (532, 24, 29, 2, 1, 85)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (533, 24, 29, 3, 1, 85)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (534, 24, 29, 3, 1, 85)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (535, 24, 29, 3, 1, 85)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (536, 24, 29, 4, 1, 85)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (537, 24, 29, 3, 1, 85)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (538, 24, 29, 2, 0, 85)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (539, 24, 29, 4, 0, 85)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (540, 24, 29, 3, 1, 85)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (541, 24, 29, 3, 1, 85)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (542, 24, 29, 2, 1, 86)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (543, 24, 29, 3, 1, 86)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (544, 24, 29, 3, 1, 86)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (545, 24, 29, 3, 1, 86)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (546, 24, 29, 4, 1, 86)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (547, 24, 29, 3, 1, 86)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (548, 24, 29, 2, 0, 86)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (549, 24, 29, 4, 0, 86)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (550, 24, 29, 3, 1, 86)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (551, 24, 29, 3, 1, 86)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (552, 24, 29, 2, 1, 87)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (553, 24, 29, 3, 1, 87)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (554, 24, 29, 3, 1, 87)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (555, 24, 29, 3, 1, 87)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (556, 24, 29, 4, 1, 87)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (557, 24, 29, 3, 1, 87)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (558, 24, 29, 2, 0, 87)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (559, 24, 29, 4, 0, 87)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (560, 24, 29, 3, 1, 87)
GO
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (561, 24, 29, 3, 1, 87)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (562, 24, 29, 2, 1, 88)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (563, 24, 29, 3, 1, 88)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (564, 24, 29, 3, 0, 88)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (565, 24, 29, 3, 0, 88)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (566, 24, 29, 4, 1, 88)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (567, 24, 29, 3, 1, 88)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (568, 24, 29, 2, 0, 88)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (569, 24, 29, 4, 0, 88)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (570, 24, 29, 3, 0, 88)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (571, 24, 29, 3, 0, 88)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (572, 24, 29, 2, 1, 89)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (573, 24, 29, 3, 1, 89)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (574, 24, 29, 3, 1, 89)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (575, 24, 29, 3, 1, 89)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (576, 24, 29, 4, 1, 89)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (577, 24, 29, 3, 1, 89)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (578, 24, 29, 2, 0, 89)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (579, 24, 29, 4, 0, 89)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (580, 24, 29, 3, 0, 89)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (581, 24, 29, 3, 0, 89)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (582, 24, 29, 2, 1, 90)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (583, 24, 29, 3, 1, 90)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (584, 24, 29, 3, 1, 90)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (585, 24, 29, 3, 1, 90)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (586, 24, 29, 4, 1, 90)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (587, 24, 29, 3, 1, 90)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (588, 24, 29, 2, 0, 90)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (589, 24, 29, 4, 0, 90)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (590, 24, 29, 3, 0, 90)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (591, 24, 29, 3, 0, 90)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (592, 24, 29, 2, 1, 91)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (593, 24, 29, 3, 1, 91)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (594, 24, 29, 3, 1, 91)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (595, 24, 29, 3, 1, 91)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (596, 24, 29, 4, 1, 91)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (597, 24, 29, 3, 1, 91)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (598, 24, 29, 2, 0, 91)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (599, 24, 29, 4, 0, 91)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (600, 24, 29, 3, 0, 91)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (601, 24, 29, 3, 0, 91)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (602, 24, 28, 2, 1, 92)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (603, 24, 28, 3, 1, 92)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (604, 24, 28, 3, 1, 92)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (605, 24, 28, 3, 1, 92)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (606, 24, 28, 4, 1, 92)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (607, 24, 28, 3, 1, 92)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (608, 24, 28, 2, 0, 92)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (609, 24, 28, 4, 0, 92)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (610, 24, 28, 3, 0, 92)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (611, 24, 28, 3, 0, 92)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (612, 24, 28, 2, 1, 93)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (613, 24, 28, 3, 1, 93)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (614, 24, 28, 3, 1, 93)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (615, 24, 28, 3, 1, 93)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (616, 24, 28, 4, 1, 93)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (617, 24, 28, 3, 1, 93)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (618, 24, 28, 2, 0, 93)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (619, 24, 28, 4, 0, 93)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (620, 24, 28, 3, 0, 93)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (621, 24, 28, 3, 0, 93)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (622, 24, 28, 2, 1, 94)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (623, 24, 28, 3, 1, 94)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (624, 24, 28, 3, 1, 94)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (625, 24, 28, 3, 1, 94)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (626, 24, 28, 4, 1, 94)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (627, 24, 28, 3, 1, 94)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (628, 24, 28, 2, 0, 94)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (629, 24, 28, 4, 0, 94)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (630, 24, 28, 3, 0, 94)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (631, 24, 28, 3, 0, 94)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (632, 24, 28, 2, 1, 95)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (633, 24, 28, 3, 1, 95)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (634, 24, 28, 3, 1, 95)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (635, 24, 28, 3, 1, 95)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (636, 24, 28, 4, 1, 95)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (637, 24, 28, 3, 1, 95)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (638, 24, 28, 2, 0, 95)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (639, 24, 28, 4, 0, 95)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (640, 24, 28, 3, 0, 95)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (641, 24, 28, 3, 0, 95)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (642, 24, 28, 2, 1, 96)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (643, 24, 28, 3, 1, 96)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (644, 24, 28, 3, 1, 96)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (645, 24, 28, 3, 1, 96)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (646, 24, 28, 4, 1, 96)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (647, 24, 28, 3, 1, 96)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (648, 24, 28, 2, 0, 96)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (649, 24, 28, 4, 0, 96)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (650, 24, 28, 3, 0, 96)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (651, 24, 28, 3, 0, 96)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (652, 24, 28, 2, 1, 97)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (653, 24, 28, 3, 1, 97)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (654, 24, 28, 3, 1, 97)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (655, 24, 28, 3, 1, 97)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (656, 24, 28, 4, 1, 97)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (657, 24, 28, 3, 1, 97)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (658, 24, 28, 2, 0, 97)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (659, 24, 28, 4, 0, 97)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (660, 24, 28, 3, 0, 97)
GO
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (661, 24, 28, 3, 0, 97)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (662, 24, 28, 2, 1, 98)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (663, 24, 28, 3, 1, 98)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (664, 24, 28, 3, 1, 98)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (665, 24, 28, 3, 1, 98)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (666, 24, 28, 4, 1, 98)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (667, 24, 28, 3, 1, 98)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (668, 24, 28, 2, 0, 98)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (669, 24, 28, 4, 0, 98)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (670, 24, 28, 3, 0, 98)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (671, 24, 28, 3, 0, 98)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (672, 24, 28, 2, 1, 99)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (673, 24, 28, 3, 1, 99)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (674, 24, 28, 3, 1, 99)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (675, 24, 28, 3, 1, 99)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (676, 24, 28, 4, 1, 99)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (677, 24, 28, 3, 1, 99)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (678, 24, 28, 2, 0, 99)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (679, 24, 28, 4, 0, 99)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (680, 24, 28, 3, 0, 99)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (681, 24, 28, 3, 0, 99)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (682, 24, 28, 2, 1, 100)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (683, 24, 28, 3, 1, 100)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (684, 24, 28, 3, 1, 100)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (685, 24, 28, 3, 1, 100)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (686, 24, 28, 4, 1, 100)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (687, 24, 28, 3, 1, 100)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (688, 24, 28, 2, 0, 100)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (689, 24, 28, 4, 0, 100)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (690, 24, 28, 3, 0, 100)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (691, 24, 28, 3, 0, 100)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (692, 2, 1, 2, 0, 101)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (693, 2, 1, 3, 1, 101)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (694, 2, 1, 2, 0, 101)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (695, 2, 1, 5, 1, 101)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (696, 2, 1, 3, 0, 101)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (697, 2, 1, 4, 0, 101)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (698, 2, 1, 1, 0, 101)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (699, 2, 1, 3, 1, 101)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (700, 2, 1, 3, 1, 101)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (701, 2, 1, 3, 1, 101)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (702, 2, 1, 2, 0, 102)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (703, 2, 1, 3, 1, 102)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (704, 2, 1, 2, 0, 102)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (705, 2, 1, 5, 1, 102)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (706, 2, 1, 3, 0, 102)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (707, 2, 1, 4, 0, 102)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (708, 2, 1, 1, 0, 102)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (709, 2, 1, 3, 1, 102)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (710, 2, 1, 3, 1, 102)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (711, 2, 1, 3, 1, 102)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (712, 2, 1, 2, 0, 103)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (713, 2, 1, 3, 1, 103)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (714, 2, 1, 2, 0, 103)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (715, 2, 1, 5, 1, 103)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (716, 2, 1, 3, 0, 103)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (717, 2, 1, 4, 0, 103)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (718, 2, 1, 1, 0, 103)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (719, 2, 1, 3, 1, 103)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (720, 2, 1, 3, 1, 103)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (721, 2, 1, 3, 1, 103)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (722, 2, 1, 2, 0, 104)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (723, 2, 1, 3, 1, 104)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (724, 2, 1, 2, 0, 104)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (725, 2, 1, 5, 1, 104)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (726, 2, 1, 3, 0, 104)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (727, 2, 1, 4, 0, 104)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (728, 2, 1, 1, 0, 104)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (729, 2, 1, 3, 1, 104)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (730, 2, 1, 3, 1, 104)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (731, 2, 1, 3, 1, 104)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (732, 2, 1, 2, 0, 105)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (733, 2, 1, 3, 1, 105)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (734, 2, 1, 2, 0, 105)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (735, 2, 1, 5, 1, 105)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (736, 2, 1, 3, 0, 105)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (737, 2, 1, 4, 0, 105)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (738, 2, 1, 1, 0, 105)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (739, 2, 1, 3, 1, 105)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (740, 2, 1, 3, 1, 105)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (741, 2, 1, 3, 1, 105)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (742, 2, 1, 2, 0, 106)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (743, 2, 1, 3, 1, 106)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (744, 2, 1, 2, 0, 106)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (745, 2, 1, 5, 1, 106)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (746, 2, 1, 3, 0, 106)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (747, 2, 1, 4, 0, 106)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (748, 2, 1, 1, 0, 106)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (749, 2, 1, 3, 1, 106)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (750, 2, 1, 3, 1, 106)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (751, 2, 1, 3, 1, 106)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (752, 2, 1, 2, 0, 107)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (753, 2, 1, 3, 1, 107)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (754, 2, 1, 2, 0, 107)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (755, 2, 1, 5, 1, 107)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (756, 2, 1, 3, 0, 107)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (757, 2, 1, 4, 0, 107)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (758, 2, 1, 1, 0, 107)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (759, 2, 1, 3, 1, 107)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (760, 2, 1, 3, 1, 107)
GO
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (761, 2, 1, 3, 1, 107)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (762, 2, 1, 2, 0, 108)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (763, 2, 1, 3, 1, 108)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (764, 2, 1, 2, 0, 108)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (765, 2, 1, 5, 1, 108)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (766, 2, 1, 3, 0, 108)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (767, 2, 1, 4, 0, 108)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (768, 2, 1, 1, 0, 108)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (769, 2, 1, 3, 1, 108)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (770, 2, 1, 3, 1, 108)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (771, 2, 1, 3, 1, 108)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (772, 2, 1, 2, 0, 109)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (773, 2, 1, 3, 1, 109)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (774, 2, 1, 2, 0, 109)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (775, 2, 1, 5, 1, 109)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (776, 2, 1, 3, 0, 109)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (777, 2, 1, 4, 0, 109)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (778, 2, 1, 1, 0, 109)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (779, 2, 1, 3, 1, 109)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (780, 2, 1, 3, 1, 109)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (781, 2, 1, 3, 1, 109)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (782, 2, 1, 2, 0, 110)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (783, 2, 1, 3, 1, 110)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (784, 2, 1, 2, 0, 110)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (785, 2, 1, 5, 1, 110)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (786, 2, 1, 3, 0, 110)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (787, 2, 1, 4, 0, 110)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (788, 2, 1, 1, 0, 110)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (789, 2, 1, 3, 1, 110)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (790, 2, 1, 3, 1, 110)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (791, 2, 1, 3, 1, 110)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (792, 2, 1, 2, 0, 111)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (793, 2, 1, 3, 1, 111)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (794, 2, 1, 2, 0, 111)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (795, 2, 1, 5, 1, 111)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (796, 2, 1, 3, 0, 111)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (797, 2, 1, 4, 0, 111)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (798, 2, 1, 1, 0, 111)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (799, 2, 1, 3, 1, 111)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (800, 2, 1, 3, 1, 111)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (801, 2, 1, 3, 1, 111)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (802, 2, 1, 2, 0, 112)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (803, 2, 1, 3, 1, 112)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (804, 2, 1, 2, 0, 112)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (805, 2, 1, 5, 1, 112)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (806, 2, 1, 3, 0, 112)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (807, 2, 1, 4, 0, 112)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (808, 2, 1, 1, 0, 112)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (809, 2, 1, 3, 1, 112)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (810, 2, 1, 3, 1, 112)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (811, 2, 1, 3, 1, 112)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (812, 2, 1, 2, 0, 113)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (813, 2, 1, 3, 1, 113)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (814, 2, 1, 2, 0, 113)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (815, 2, 1, 5, 1, 113)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (816, 2, 1, 3, 0, 113)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (817, 2, 1, 4, 0, 113)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (818, 2, 1, 1, 0, 113)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (819, 2, 1, 3, 1, 113)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (820, 2, 1, 3, 1, 113)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (821, 2, 1, 3, 1, 113)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (822, 2, 1, 2, 0, 114)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (823, 2, 1, 3, 1, 114)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (824, 2, 1, 2, 0, 114)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (825, 2, 1, 5, 1, 114)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (826, 2, 1, 3, 0, 114)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (827, 2, 1, 4, 0, 114)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (828, 2, 1, 1, 0, 114)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (829, 2, 1, 3, 1, 114)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (830, 2, 1, 3, 1, 114)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (831, 2, 1, 3, 1, 114)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (832, 2, 1, 2, 0, 115)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (833, 2, 1, 3, 1, 115)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (834, 2, 1, 2, 0, 115)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (835, 2, 1, 5, 1, 115)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (836, 2, 1, 3, 0, 115)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (837, 2, 1, 4, 0, 115)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (838, 2, 1, 1, 0, 115)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (839, 2, 1, 3, 1, 115)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (840, 2, 1, 3, 1, 115)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (841, 2, 1, 3, 1, 115)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (842, 2, 1, 2, 0, 116)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (843, 2, 1, 3, 1, 116)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (844, 2, 1, 2, 0, 116)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (845, 2, 1, 5, 1, 116)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (846, 2, 1, 3, 0, 116)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (847, 2, 1, 4, 0, 116)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (848, 2, 1, 1, 0, 116)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (849, 2, 1, 3, 1, 116)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (850, 2, 1, 3, 1, 116)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (851, 2, 1, 3, 1, 116)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (852, 2, 1, 2, 0, 117)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (853, 2, 1, 3, 1, 117)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (854, 2, 1, 2, 0, 117)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (855, 2, 1, 5, 1, 117)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (856, 2, 1, 3, 0, 117)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (857, 2, 1, 4, 0, 117)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (858, 2, 1, 1, 0, 117)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (859, 2, 1, 3, 1, 117)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (860, 2, 1, 3, 1, 117)
GO
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (861, 2, 1, 3, 1, 117)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (862, 2, 1, 2, 0, 118)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (863, 2, 1, 3, 1, 118)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (864, 2, 1, 2, 0, 118)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (865, 2, 1, 5, 1, 118)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (866, 2, 1, 3, 0, 118)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (867, 2, 1, 4, 0, 118)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (868, 2, 1, 1, 0, 118)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (869, 2, 1, 3, 1, 118)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (870, 2, 1, 3, 1, 118)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (871, 2, 1, 3, 1, 118)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (872, 2, 1, 2, 0, 119)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (873, 2, 1, 3, 1, 119)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (874, 2, 1, 2, 0, 119)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (875, 2, 1, 5, 1, 119)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (876, 2, 1, 3, 0, 119)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (877, 2, 1, 4, 0, 119)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (878, 2, 1, 1, 0, 119)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (879, 2, 1, 3, 1, 119)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (880, 2, 1, 3, 1, 119)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (881, 2, 1, 3, 1, 119)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (882, 2, 1, 2, 0, 120)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (883, 2, 1, 3, 1, 120)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (884, 2, 1, 2, 0, 120)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (885, 2, 1, 5, 1, 120)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (886, 2, 1, 3, 0, 120)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (887, 2, 1, 4, 0, 120)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (888, 2, 1, 1, 0, 120)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (889, 2, 1, 3, 1, 120)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (890, 2, 1, 3, 1, 120)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (891, 2, 1, 3, 1, 120)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (892, 2, 1, 2, 0, 121)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (893, 2, 1, 3, 1, 121)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (894, 2, 1, 2, 0, 121)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (895, 2, 1, 5, 1, 121)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (896, 2, 1, 3, 0, 121)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (897, 2, 1, 4, 0, 121)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (898, 2, 1, 1, 0, 121)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (899, 2, 1, 3, 1, 121)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (900, 2, 1, 3, 1, 121)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (901, 2, 1, 3, 1, 121)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (902, 2, 1, 2, 0, 122)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (903, 2, 1, 3, 1, 122)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (904, 2, 1, 2, 0, 122)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (905, 2, 1, 5, 1, 122)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (906, 2, 1, 3, 0, 122)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (907, 2, 1, 4, 0, 122)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (908, 2, 1, 1, 0, 122)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (909, 2, 1, 3, 1, 122)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (910, 2, 1, 3, 1, 122)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (911, 2, 1, 3, 1, 122)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (912, 2, 1, 2, 0, 123)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (913, 2, 1, 3, 1, 123)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (914, 2, 1, 2, 0, 123)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (915, 2, 1, 5, 1, 123)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (916, 2, 1, 3, 0, 123)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (917, 2, 1, 4, 0, 123)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (918, 2, 1, 1, 0, 123)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (919, 2, 1, 3, 1, 123)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (920, 2, 1, 3, 1, 123)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (921, 2, 1, 3, 1, 123)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (922, 2, 1, 2, 0, 124)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (923, 2, 1, 3, 1, 124)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (924, 2, 1, 2, 0, 124)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (925, 2, 1, 5, 1, 124)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (926, 2, 1, 3, 0, 124)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (927, 2, 1, 4, 0, 124)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (928, 2, 1, 1, 0, 124)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (929, 2, 1, 3, 1, 124)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (930, 2, 1, 3, 1, 124)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (931, 2, 1, 3, 1, 124)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (932, 2, 1, 2, 0, 125)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (933, 2, 1, 3, 1, 125)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (934, 2, 1, 2, 0, 125)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (935, 2, 1, 5, 1, 125)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (936, 2, 1, 3, 0, 125)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (937, 2, 1, 4, 0, 125)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (938, 2, 1, 1, 0, 125)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (939, 2, 1, 3, 1, 125)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (940, 2, 1, 3, 1, 125)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (941, 2, 1, 3, 1, 125)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (942, 2, 1, 2, 0, 126)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (943, 2, 1, 3, 1, 126)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (944, 2, 1, 2, 0, 126)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (945, 2, 1, 5, 1, 126)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (946, 2, 1, 3, 0, 126)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (947, 2, 1, 4, 0, 126)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (948, 2, 1, 1, 0, 126)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (949, 2, 1, 3, 1, 126)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (950, 2, 1, 3, 1, 126)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (951, 2, 1, 3, 1, 126)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (952, 2, 1, 2, 0, 127)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (953, 2, 1, 3, 1, 127)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (954, 2, 1, 2, 0, 127)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (955, 2, 1, 5, 1, 127)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (956, 2, 1, 3, 0, 127)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (957, 2, 1, 4, 0, 127)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (958, 2, 1, 1, 0, 127)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (959, 2, 1, 3, 1, 127)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (960, 2, 1, 3, 1, 127)
GO
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (961, 2, 1, 3, 1, 127)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (962, 2, 1, 2, 0, 128)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (963, 2, 1, 3, 1, 128)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (964, 2, 1, 2, 0, 128)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (965, 2, 1, 5, 1, 128)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (966, 2, 1, 3, 0, 128)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (967, 2, 1, 4, 0, 128)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (968, 2, 1, 1, 0, 128)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (969, 2, 1, 3, 1, 128)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (970, 2, 1, 3, 1, 128)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (971, 2, 1, 3, 1, 128)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (972, 2, 1, 2, 0, 129)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (973, 2, 1, 3, 1, 129)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (974, 2, 1, 2, 0, 129)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (975, 2, 1, 5, 1, 129)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (976, 2, 1, 3, 0, 129)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (977, 2, 1, 4, 0, 129)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (978, 2, 1, 1, 0, 129)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (979, 2, 1, 3, 1, 129)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (980, 2, 1, 3, 1, 129)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (981, 2, 1, 3, 1, 129)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (982, 2, 1, 2, 0, 130)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (983, 2, 1, 3, 1, 130)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (984, 2, 1, 2, 0, 130)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (985, 2, 1, 5, 1, 130)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (986, 2, 1, 3, 0, 130)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (987, 2, 1, 4, 0, 130)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (988, 2, 1, 1, 0, 130)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (989, 2, 1, 3, 1, 130)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (990, 2, 1, 3, 1, 130)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (991, 2, 1, 3, 1, 130)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (992, 2, 1, 2, 0, 131)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (993, 2, 1, 3, 1, 131)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (994, 2, 1, 2, 0, 131)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (995, 2, 1, 5, 1, 131)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (996, 2, 1, 3, 0, 131)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (997, 2, 1, 4, 0, 131)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (998, 2, 1, 1, 0, 131)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (999, 2, 1, 3, 1, 131)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1000, 2, 1, 3, 1, 131)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1001, 2, 1, 3, 1, 131)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1002, 2, 1, 2, 0, 132)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1003, 2, 1, 3, 1, 132)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1004, 2, 1, 2, 0, 132)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1005, 2, 1, 5, 1, 132)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1006, 2, 1, 3, 0, 132)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1007, 2, 1, 4, 0, 132)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1008, 2, 1, 1, 0, 132)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1009, 2, 1, 3, 1, 132)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1010, 2, 1, 3, 1, 132)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1011, 2, 1, 3, 1, 132)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1012, 2, 1, 2, 0, 133)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1013, 2, 1, 3, 1, 133)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1014, 2, 1, 2, 0, 133)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1015, 2, 1, 5, 1, 133)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1016, 2, 1, 3, 0, 133)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1017, 2, 1, 4, 0, 133)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1018, 2, 1, 1, 0, 133)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1019, 2, 1, 3, 1, 133)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1020, 2, 1, 3, 1, 133)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1021, 2, 1, 3, 1, 133)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1022, 2, 1, 2, 0, 134)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1023, 2, 1, 3, 1, 134)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1024, 2, 1, 2, 0, 134)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1025, 2, 1, 5, 1, 134)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1026, 2, 1, 3, 0, 134)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1027, 2, 1, 4, 0, 134)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1028, 2, 1, 1, 0, 134)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1029, 2, 1, 3, 1, 134)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1030, 2, 1, 3, 1, 134)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1031, 2, 1, 3, 1, 134)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1032, 2, 1, 2, 0, 135)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1033, 2, 1, 3, 1, 135)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1034, 2, 1, 2, 0, 135)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1035, 2, 1, 5, 1, 135)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1036, 2, 1, 3, 0, 135)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1037, 2, 1, 4, 0, 135)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1038, 2, 1, 1, 0, 135)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1039, 2, 1, 3, 1, 135)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1040, 2, 1, 3, 1, 135)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1041, 2, 1, 3, 1, 135)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1042, 2, 1, 2, 0, 136)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1043, 2, 1, 3, 1, 136)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1044, 2, 1, 2, 0, 136)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1045, 2, 1, 5, 1, 136)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1046, 2, 1, 3, 0, 136)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1047, 2, 1, 4, 0, 136)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1048, 2, 1, 1, 0, 136)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1049, 2, 1, 3, 1, 136)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1050, 2, 1, 3, 1, 136)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1051, 2, 1, 3, 1, 136)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1052, 2, 1, 2, 0, 137)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1053, 2, 1, 3, 1, 137)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1054, 2, 1, 2, 0, 137)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1055, 2, 1, 5, 1, 137)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1056, 2, 1, 3, 0, 137)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1057, 2, 1, 4, 0, 137)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1058, 2, 1, 1, 0, 137)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1059, 2, 1, 3, 1, 137)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1060, 2, 1, 3, 1, 137)
GO
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1061, 2, 1, 3, 1, 137)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1062, 2, 1, 2, 0, 138)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1063, 2, 1, 3, 1, 138)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1064, 2, 1, 2, 0, 138)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1065, 2, 1, 5, 1, 138)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1066, 2, 1, 3, 0, 138)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1067, 2, 1, 4, 0, 138)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1068, 2, 1, 1, 0, 138)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1069, 2, 1, 3, 1, 138)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1070, 2, 1, 3, 1, 138)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1071, 2, 1, 3, 1, 138)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1072, 2, 1, 2, 0, 139)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1073, 2, 1, 3, 1, 139)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1074, 2, 1, 2, 0, 139)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1075, 2, 1, 5, 1, 139)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1076, 2, 1, 3, 0, 139)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1077, 2, 1, 4, 0, 139)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1078, 2, 1, 1, 0, 139)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1079, 2, 1, 3, 1, 139)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1080, 2, 1, 3, 1, 139)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1081, 2, 1, 3, 1, 139)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1082, 2, 1, 2, 0, 140)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1083, 2, 1, 3, 1, 140)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1084, 2, 1, 2, 0, 140)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1085, 2, 1, 5, 1, 140)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1086, 2, 1, 3, 0, 140)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1087, 2, 1, 4, 0, 140)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1088, 2, 1, 1, 0, 140)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1089, 2, 1, 3, 1, 140)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1090, 2, 1, 3, 1, 140)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1091, 2, 1, 3, 1, 140)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1092, 2, 1, 2, 0, 141)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1093, 2, 1, 3, 1, 141)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1094, 2, 1, 2, 0, 141)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1095, 2, 1, 5, 1, 141)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1096, 2, 1, 3, 0, 141)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1097, 2, 1, 4, 0, 141)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1098, 2, 1, 1, 0, 141)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1099, 2, 1, 3, 1, 141)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1100, 2, 1, 3, 1, 141)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1101, 2, 1, 3, 1, 141)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1102, 2, 1, 2, 0, 142)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1103, 2, 1, 3, 1, 142)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1104, 2, 1, 2, 0, 142)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1105, 2, 1, 5, 1, 142)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1106, 2, 1, 3, 0, 142)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1107, 2, 1, 4, 0, 142)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1108, 2, 1, 1, 0, 142)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1109, 2, 1, 3, 1, 142)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1110, 2, 1, 3, 1, 142)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1111, 2, 1, 3, 1, 142)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1112, 2, 1, 2, 0, 143)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1113, 2, 1, 3, 1, 143)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1114, 2, 1, 2, 0, 143)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1115, 2, 1, 5, 1, 143)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1116, 2, 1, 3, 0, 143)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1117, 2, 1, 4, 0, 143)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1118, 2, 1, 1, 0, 143)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1119, 2, 1, 3, 1, 143)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1120, 2, 1, 3, 1, 143)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1121, 2, 1, 3, 1, 143)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1122, 2, 1, 2, 0, 144)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1123, 2, 1, 3, 1, 144)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1124, 2, 1, 2, 0, 144)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1125, 2, 1, 5, 1, 144)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1126, 2, 1, 3, 0, 144)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1127, 2, 1, 4, 0, 144)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1128, 2, 1, 1, 0, 144)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1129, 2, 1, 3, 1, 144)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1130, 2, 1, 3, 1, 144)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1131, 2, 1, 3, 1, 144)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1132, 2, 1, 2, 0, 145)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1133, 2, 1, 3, 1, 145)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1134, 2, 1, 2, 0, 145)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1135, 2, 1, 5, 1, 145)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1136, 2, 1, 3, 0, 145)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1137, 2, 1, 4, 0, 145)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1138, 2, 1, 1, 0, 145)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1139, 2, 1, 3, 1, 145)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1140, 2, 1, 3, 1, 145)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1141, 2, 1, 3, 1, 145)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1142, 2, 1, 2, 0, 146)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1143, 2, 1, 3, 1, 146)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1144, 2, 1, 2, 0, 146)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1145, 2, 1, 5, 1, 146)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1146, 2, 1, 3, 0, 146)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1147, 2, 1, 4, 0, 146)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1148, 2, 1, 1, 0, 146)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1149, 2, 1, 3, 1, 146)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1150, 2, 1, 3, 1, 146)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1151, 2, 1, 3, 1, 146)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1152, 2, 1, 2, 0, 147)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1153, 2, 1, 3, 1, 147)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1154, 2, 1, 2, 0, 147)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1155, 2, 1, 5, 1, 147)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1156, 2, 1, 3, 0, 147)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1157, 2, 1, 4, 0, 147)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1158, 2, 1, 1, 0, 147)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1159, 2, 1, 3, 1, 147)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1160, 2, 1, 3, 1, 147)
GO
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1161, 2, 1, 3, 1, 147)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1162, 2, 1, 2, 0, 148)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1163, 2, 1, 3, 1, 148)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1164, 2, 1, 2, 0, 148)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1165, 2, 1, 5, 1, 148)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1166, 2, 1, 3, 0, 148)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1167, 2, 1, 4, 0, 148)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1168, 2, 1, 1, 0, 148)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1169, 2, 1, 3, 1, 148)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1170, 2, 1, 3, 1, 148)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1171, 2, 1, 3, 1, 148)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1172, 2, 1, 2, 0, 149)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1173, 2, 1, 3, 1, 149)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1174, 2, 1, 2, 0, 149)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1175, 2, 1, 5, 1, 149)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1176, 2, 1, 3, 0, 149)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1177, 2, 1, 4, 0, 149)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1178, 2, 1, 1, 0, 149)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1179, 2, 1, 3, 1, 149)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1180, 2, 1, 3, 1, 149)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1181, 2, 1, 3, 1, 149)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1182, 2, 1, 2, 0, 150)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1183, 2, 1, 3, 1, 150)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1184, 2, 1, 2, 0, 150)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1185, 2, 1, 5, 1, 150)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1186, 2, 1, 3, 0, 150)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1187, 2, 1, 4, 0, 150)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1188, 2, 1, 1, 0, 150)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1189, 2, 1, 3, 1, 150)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1190, 2, 1, 3, 1, 150)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1191, 2, 1, 3, 1, 150)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1192, 2, 1, 2, 0, 151)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1193, 2, 1, 3, 1, 151)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1194, 2, 1, 2, 0, 151)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1195, 2, 1, 5, 1, 151)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1196, 2, 1, 3, 0, 151)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1197, 2, 1, 4, 0, 151)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1198, 2, 1, 1, 0, 151)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1199, 2, 1, 3, 1, 151)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1200, 2, 1, 3, 1, 151)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1201, 2, 1, 3, 1, 151)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1202, 2, 1, 2, 0, 152)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1203, 2, 1, 3, 1, 152)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1204, 2, 1, 2, 0, 152)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1205, 2, 1, 5, 1, 152)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1206, 2, 1, 3, 0, 152)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1207, 2, 1, 4, 0, 152)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1208, 2, 1, 1, 0, 152)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1209, 2, 1, 3, 1, 152)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1210, 2, 1, 3, 1, 152)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1211, 2, 1, 3, 1, 152)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1212, 2, 1, 2, 0, 153)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1213, 2, 1, 3, 1, 153)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1214, 2, 1, 2, 0, 153)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1215, 2, 1, 5, 1, 153)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1216, 2, 1, 3, 0, 153)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1217, 2, 1, 4, 0, 153)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1218, 2, 1, 1, 0, 153)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1219, 2, 1, 3, 1, 153)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1220, 2, 1, 3, 1, 153)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1221, 2, 1, 3, 1, 153)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1222, 2, 1, 2, 0, 154)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1223, 2, 1, 3, 1, 154)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1224, 2, 1, 2, 0, 154)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1225, 2, 1, 5, 1, 154)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1226, 2, 1, 3, 0, 154)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1227, 2, 1, 4, 0, 154)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1228, 2, 1, 1, 0, 154)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1229, 2, 1, 3, 1, 154)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1230, 2, 1, 3, 1, 154)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1231, 2, 1, 3, 1, 154)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1232, 2, 1, 2, 0, 155)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1233, 2, 1, 3, 1, 155)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1234, 2, 1, 2, 0, 155)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1235, 2, 1, 5, 1, 155)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1236, 2, 1, 3, 0, 155)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1237, 2, 1, 4, 0, 155)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1238, 2, 1, 1, 0, 155)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1239, 2, 1, 3, 1, 155)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1240, 2, 1, 3, 1, 155)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1241, 2, 1, 3, 1, 155)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1242, 2, 1, 2, 0, 156)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1243, 2, 1, 3, 1, 156)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1244, 2, 1, 2, 0, 156)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1245, 2, 1, 5, 1, 156)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1246, 2, 1, 3, 0, 156)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1247, 2, 1, 4, 0, 156)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1248, 2, 1, 1, 0, 156)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1249, 2, 1, 3, 1, 156)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1250, 2, 1, 3, 1, 156)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1251, 2, 1, 3, 1, 156)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1252, 2, 1, 2, 0, 157)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1253, 2, 1, 3, 1, 157)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1254, 2, 1, 2, 0, 157)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1255, 2, 1, 5, 1, 157)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1256, 2, 1, 3, 0, 157)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1257, 2, 1, 4, 0, 157)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1258, 2, 1, 1, 0, 157)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1259, 2, 1, 3, 1, 157)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1260, 2, 1, 3, 1, 157)
GO
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1261, 2, 1, 3, 1, 157)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1262, 2, 1, 2, 0, 158)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1263, 2, 1, 3, 1, 158)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1264, 2, 1, 2, 0, 158)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1265, 2, 1, 5, 1, 158)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1266, 2, 1, 3, 0, 158)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1267, 2, 1, 4, 0, 158)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1268, 2, 1, 1, 0, 158)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1269, 2, 1, 3, 1, 158)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1270, 2, 1, 3, 1, 158)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1271, 2, 1, 3, 1, 158)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1272, 2, 1, 4, 1, 159)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1273, 2, 1, 2, 1, 159)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1274, 2, 1, 4, 1, 159)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1275, 2, 1, 3, 1, 159)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1276, 2, 1, 2, 1, 159)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1277, 2, 1, 4, 0, 159)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1278, 2, 1, 3, 0, 159)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1279, 2, 1, 4, 0, 159)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1280, 2, 1, 3, 0, 159)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1281, 2, 1, 4, 0, 159)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1282, 2, 1, 4, 1, 160)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1283, 2, 1, 2, 1, 160)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1284, 2, 1, 4, 1, 160)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1285, 2, 1, 3, 1, 160)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1286, 2, 1, 2, 1, 160)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1287, 2, 1, 4, 0, 160)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1288, 2, 1, 3, 0, 160)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1289, 2, 1, 4, 0, 160)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1290, 2, 1, 3, 0, 160)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1291, 2, 1, 4, 0, 160)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1292, 2, 1, 4, 1, 161)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1293, 2, 1, 2, 1, 161)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1294, 2, 1, 4, 1, 161)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1295, 2, 1, 3, 1, 161)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1296, 2, 1, 2, 1, 161)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1297, 2, 1, 4, 0, 161)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1298, 2, 1, 3, 0, 161)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1299, 2, 1, 4, 0, 161)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1300, 2, 1, 3, 0, 161)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1301, 2, 1, 4, 0, 161)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1302, 2, 1, 4, 1, 162)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1303, 2, 1, 2, 1, 162)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1304, 2, 1, 4, 1, 162)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1305, 2, 1, 3, 1, 162)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1306, 2, 1, 2, 1, 162)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1307, 2, 1, 4, 0, 162)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1308, 2, 1, 3, 0, 162)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1309, 2, 1, 4, 0, 162)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1310, 2, 1, 3, 0, 162)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1311, 2, 1, 4, 0, 162)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1312, 2, 1, 4, 0, 163)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1313, 2, 1, 3, 0, 163)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1314, 2, 1, 4, 1, 163)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1315, 2, 1, 3, 0, 163)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1316, 2, 1, 4, 1, 163)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1317, 2, 1, 6, 1, 163)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1318, 2, 1, 5, 0, 163)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1319, 2, 1, 2, 1, 163)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1320, 2, 1, 3, 0, 163)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1321, 2, 1, 3, 0, 163)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1322, 2, 3, 4, 0, 164)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1323, 2, 3, 3, 0, 164)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1324, 2, 3, 4, 1, 164)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1325, 2, 3, 3, 0, 164)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1326, 2, 3, 4, 1, 164)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1327, 2, 3, 6, 1, 164)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1328, 2, 3, 5, 0, 164)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1329, 2, 3, 2, 1, 164)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1330, 2, 3, 3, 0, 164)
INSERT [dbo].[AntrenmanBolge] ([Id], [SporcuId], [AntrenmanTuruId], [Bolge], [BasariliMi], [AntrenmanId]) VALUES (1331, 2, 3, 3, 0, 164)
SET IDENTITY_INSERT [dbo].[AntrenmanBolge] OFF
GO
SET IDENTITY_INSERT [dbo].[Antrenmanlar] ON 

INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (38, 2, 1, 10, 5, CAST(N'2023-11-22T22:45:31.0006695' AS DateTime2), 1, 500, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (39, 2, 1, 10, 6, CAST(N'2023-12-02T21:30:01.5378473' AS DateTime2), 2, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (40, 2, 1, 10, 5, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 3, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (41, 2, 1, 10, 3, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 4, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (42, 2, 2, 10, 3, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 1, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (43, 2, 2, 10, 3, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 2, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (44, 2, 2, 10, 8, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 3, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (45, 21, 13, 10, 8, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 1, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (46, 21, 13, 10, 5, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 2, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (47, 21, 13, 10, 5, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 3, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (48, 21, 13, 10, 5, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 4, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (49, 21, 13, 10, 10, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 5, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (50, 21, 14, 10, 10, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 1, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (51, 21, 14, 10, 8, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 2, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (52, 21, 14, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 3, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (53, 21, 14, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 4, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (54, 21, 14, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 5, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (55, 22, 19, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 1, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (56, 22, 19, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 2, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (57, 22, 19, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 3, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (58, 22, 19, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 4, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (59, 22, 19, 10, 9, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 5, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (60, 22, 20, 10, 9, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 1, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (61, 22, 20, 10, 9, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 2, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (62, 22, 20, 10, 9, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 3, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (63, 22, 20, 10, 9, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 4, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (64, 22, 20, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 5, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (65, 22, 20, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 6, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (66, 22, 20, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 7, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (67, 25, 37, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 1, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (68, 25, 37, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 2, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (69, 25, 37, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 3, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (70, 25, 37, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 4, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (71, 25, 37, 10, 4, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 5, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (72, 25, 37, 10, 4, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 6, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (73, 25, 37, 10, 4, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 7, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (74, 25, 37, 10, 4, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 8, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (75, 25, 37, 10, 4, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 9, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (76, 25, 21, 10, 4, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 1, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (77, 25, 21, 10, 8, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 2, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (78, 25, 21, 10, 8, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 3, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (79, 25, 21, 10, 8, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 4, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (80, 25, 21, 10, 8, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 5, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (81, 25, 21, 10, 8, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 6, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (82, 25, 21, 10, 8, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 7, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (83, 25, 21, 10, 8, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 8, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (84, 24, 29, 10, 8, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 1, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (85, 24, 29, 10, 8, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 2, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (86, 24, 29, 10, 8, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 3, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (87, 24, 29, 10, 8, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 4, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (88, 24, 29, 10, 4, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 5, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (89, 24, 29, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 6, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (90, 24, 29, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 7, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (91, 24, 29, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 8, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (92, 24, 28, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 1, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (93, 24, 28, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 2, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (94, 24, 28, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 3, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (95, 24, 28, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 4, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (96, 24, 28, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 5, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (97, 24, 28, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 6, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (98, 24, 28, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 7, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (99, 24, 28, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 8, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (100, 24, 28, 10, 6, CAST(N'2023-12-03T14:45:58.0610796' AS DateTime2), 9, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (101, 2, 1, 10, 5, CAST(N'2023-01-12T15:05:50.0000000' AS DateTime2), 5, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (102, 2, 1, 10, 5, CAST(N'2023-01-12T15:05:50.0000000' AS DateTime2), 6, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (103, 2, 1, 10, 5, CAST(N'2023-01-12T15:05:50.0000000' AS DateTime2), 7, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (104, 2, 1, 10, 5, CAST(N'2023-01-12T15:05:50.0000000' AS DateTime2), 8, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (105, 2, 1, 10, 5, CAST(N'2023-02-09T15:05:50.0000000' AS DateTime2), 9, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (106, 2, 1, 10, 5, CAST(N'2023-02-09T15:05:50.0000000' AS DateTime2), 10, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (107, 2, 1, 10, 5, CAST(N'2023-02-09T15:05:50.0000000' AS DateTime2), 11, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (108, 2, 1, 10, 5, CAST(N'2023-02-09T15:05:50.0000000' AS DateTime2), 12, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (109, 2, 1, 10, 5, CAST(N'2023-02-09T15:05:50.0000000' AS DateTime2), 13, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (110, 2, 1, 10, 5, CAST(N'2023-02-09T15:05:50.0000000' AS DateTime2), 14, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (111, 2, 1, 10, 5, CAST(N'2023-02-09T15:05:50.0000000' AS DateTime2), 15, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (112, 2, 1, 10, 5, CAST(N'2023-02-09T15:05:50.0000000' AS DateTime2), 16, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (113, 2, 1, 10, 5, CAST(N'2023-03-16T15:05:50.0000000' AS DateTime2), 17, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (114, 2, 1, 10, 5, CAST(N'2023-03-16T15:05:50.0000000' AS DateTime2), 18, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (115, 2, 1, 10, 5, CAST(N'2023-03-16T15:05:50.0000000' AS DateTime2), 19, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (116, 2, 1, 10, 5, CAST(N'2023-03-16T15:05:50.0000000' AS DateTime2), 20, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (117, 2, 1, 10, 5, CAST(N'2023-04-28T15:05:50.0000000' AS DateTime2), 21, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (118, 2, 1, 10, 5, CAST(N'2023-04-28T15:05:50.0000000' AS DateTime2), 22, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (119, 2, 1, 10, 5, CAST(N'2023-04-28T15:05:50.0000000' AS DateTime2), 23, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (120, 2, 1, 10, 5, CAST(N'2023-04-28T15:05:50.0000000' AS DateTime2), 24, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (121, 2, 1, 10, 5, CAST(N'2023-04-28T15:05:50.0000000' AS DateTime2), 25, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (122, 2, 1, 10, 5, CAST(N'2023-05-10T15:05:50.0000000' AS DateTime2), 26, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (123, 2, 1, 10, 5, CAST(N'2023-05-10T15:05:50.0000000' AS DateTime2), 27, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (124, 2, 1, 10, 5, CAST(N'2023-05-10T15:05:50.0000000' AS DateTime2), 28, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (125, 2, 1, 10, 5, CAST(N'2023-05-10T15:05:50.0000000' AS DateTime2), 29, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (126, 2, 1, 10, 5, CAST(N'2023-05-10T15:05:50.0000000' AS DateTime2), 30, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (127, 2, 1, 10, 5, CAST(N'2023-06-15T15:05:50.0000000' AS DateTime2), 31, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (128, 2, 1, 10, 5, CAST(N'2023-06-15T15:05:50.0000000' AS DateTime2), 32, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (129, 2, 1, 10, 5, CAST(N'2023-06-15T15:05:50.0000000' AS DateTime2), 33, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (130, 2, 1, 10, 5, CAST(N'2023-06-15T15:05:50.0000000' AS DateTime2), 34, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (131, 2, 1, 10, 5, CAST(N'2023-07-12T15:05:50.0000000' AS DateTime2), 35, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (132, 2, 1, 10, 5, CAST(N'2023-07-12T15:05:50.0000000' AS DateTime2), 36, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (133, 2, 1, 10, 5, CAST(N'2023-07-12T15:05:50.0000000' AS DateTime2), 37, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (134, 2, 1, 10, 5, CAST(N'2023-07-12T15:05:50.0000000' AS DateTime2), 38, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (135, 2, 1, 10, 5, CAST(N'2023-07-12T15:05:50.0000000' AS DateTime2), 39, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (136, 2, 1, 10, 5, CAST(N'2023-07-12T15:05:50.0000000' AS DateTime2), 40, 180, NULL)
GO
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (137, 2, 1, 10, 5, CAST(N'2023-08-23T15:05:50.0000000' AS DateTime2), 41, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (138, 2, 1, 10, 5, CAST(N'2023-08-23T15:05:50.0000000' AS DateTime2), 42, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (139, 2, 1, 10, 5, CAST(N'2023-08-23T15:05:50.0000000' AS DateTime2), 43, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (140, 2, 1, 10, 5, CAST(N'2023-08-23T15:05:50.0000000' AS DateTime2), 44, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (141, 2, 1, 10, 5, CAST(N'2023-08-23T15:05:50.0000000' AS DateTime2), 45, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (142, 2, 1, 10, 5, CAST(N'2023-08-23T15:05:50.0000000' AS DateTime2), 46, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (143, 2, 1, 10, 5, CAST(N'2023-09-15T15:05:50.0000000' AS DateTime2), 47, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (144, 2, 1, 10, 5, CAST(N'2023-09-15T15:05:50.0000000' AS DateTime2), 48, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (145, 2, 1, 10, 5, CAST(N'2023-09-15T15:05:50.0000000' AS DateTime2), 49, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (146, 2, 1, 10, 5, CAST(N'2023-09-15T15:05:50.0000000' AS DateTime2), 50, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (147, 2, 1, 10, 5, CAST(N'2023-09-15T15:05:50.0000000' AS DateTime2), 51, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (148, 2, 1, 10, 5, CAST(N'2023-10-19T15:05:50.0000000' AS DateTime2), 52, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (149, 2, 1, 10, 5, CAST(N'2023-10-19T15:05:50.0000000' AS DateTime2), 53, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (150, 2, 1, 10, 5, CAST(N'2023-10-19T15:05:50.0000000' AS DateTime2), 54, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (151, 2, 1, 10, 5, CAST(N'2023-10-19T15:05:50.0000000' AS DateTime2), 55, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (152, 2, 1, 10, 5, CAST(N'2023-10-19T15:05:50.0000000' AS DateTime2), 56, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (153, 2, 1, 10, 5, CAST(N'2023-11-22T15:05:50.0000000' AS DateTime2), 57, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (154, 2, 1, 10, 5, CAST(N'2023-11-22T15:05:50.0000000' AS DateTime2), 58, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (155, 2, 1, 10, 5, CAST(N'2023-11-22T15:05:50.0000000' AS DateTime2), 59, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (156, 2, 1, 10, 5, CAST(N'2023-11-22T15:05:50.0000000' AS DateTime2), 60, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (157, 2, 1, 10, 5, CAST(N'2023-11-22T15:05:50.0000000' AS DateTime2), 61, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (158, 2, 1, 10, 5, CAST(N'2023-11-22T15:05:50.0000000' AS DateTime2), 62, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (159, 2, 1, 10, 5, CAST(N'2023-11-03T22:52:27.0000000' AS DateTime2), 63, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (160, 2, 1, 10, 5, CAST(N'2023-11-10T22:52:27.0000000' AS DateTime2), 64, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (161, 2, 1, 10, 5, CAST(N'2023-11-16T22:52:27.0000000' AS DateTime2), 65, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (162, 2, 1, 10, 5, CAST(N'2023-11-30T22:52:27.0000000' AS DateTime2), 66, 180, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (163, 2, 1, 10, 4, CAST(N'2022-12-09T00:05:49.0000000' AS DateTime2), 67, 299, NULL)
INSERT [dbo].[Antrenmanlar] ([Id], [SporcuId], [AntrenamTuruId], [AtisSayisi], [BasariliAtis], [Tarih], [AntrenmanSayisi], [AntrenmanSuresi], [KAntrenmanTuruId]) VALUES (164, 2, 3, 10, 4, CAST(N'2022-12-09T00:05:49.0000000' AS DateTime2), 1, 299, NULL)
SET IDENTITY_INSERT [dbo].[Antrenmanlar] OFF
GO
SET IDENTITY_INSERT [dbo].[AntrenmanTurleri] ON 

INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (1, 1, 1, 1)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (2, 1, 1, 2)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (3, 1, 2, 3)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (4, 1, 2, 4)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (5, 1, 2, 5)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (6, 1, 2, 6)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (7, 1, 3, 3)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (8, 1, 3, 4)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (9, 1, 3, 5)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (10, 1, 3, 6)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (11, 2, 1, 1)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (12, 2, 1, 2)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (13, 2, 2, 3)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (14, 2, 2, 4)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (15, 2, 2, 5)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (16, 2, 2, 6)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (17, 2, 3, 3)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (18, 2, 3, 4)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (19, 2, 3, 5)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (20, 2, 3, 6)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (21, 3, 1, 1)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (23, 3, 2, 3)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (24, 3, 2, 4)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (25, 3, 2, 5)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (26, 3, 2, 6)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (27, 3, 3, 3)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (28, 3, 3, 4)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (29, 3, 3, 5)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (30, 3, 3, 6)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (37, 3, 1, 2)
INSERT [dbo].[AntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId], [VurusBicimiId]) VALUES (39, 1, 1, 14)
SET IDENTITY_INSERT [dbo].[AntrenmanTurleri] OFF
GO
SET IDENTITY_INSERT [dbo].[Diller] ON 

INSERT [dbo].[Diller] ([Id], [Language], [Selected]) VALUES (1, N'Turkish', 0)
INSERT [dbo].[Diller] ([Id], [Language], [Selected]) VALUES (3, N'English', 1)
SET IDENTITY_INSERT [dbo].[Diller] OFF
GO
SET IDENTITY_INSERT [dbo].[KaleciAntrenmanTurleri] ON 

INSERT [dbo].[KaleciAntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId]) VALUES (1, 1, 1)
INSERT [dbo].[KaleciAntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId]) VALUES (2, 1, 2)
INSERT [dbo].[KaleciAntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId]) VALUES (3, 1, 3)
INSERT [dbo].[KaleciAntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId]) VALUES (4, 2, 1)
INSERT [dbo].[KaleciAntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId]) VALUES (5, 2, 2)
INSERT [dbo].[KaleciAntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId]) VALUES (6, 2, 3)
INSERT [dbo].[KaleciAntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId]) VALUES (7, 3, 1)
INSERT [dbo].[KaleciAntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId]) VALUES (8, 3, 2)
INSERT [dbo].[KaleciAntrenmanTurleri] ([Id], [TopKonumId], [TopGelisSekliId]) VALUES (9, 3, 3)
SET IDENTITY_INSERT [dbo].[KaleciAntrenmanTurleri] OFF
GO
SET IDENTITY_INSERT [dbo].[Kullanicilar] ON 

INSERT [dbo].[Kullanicilar] ([Id], [YetkiId], [Ad], [Soyad], [KullaniciAdi], [Sifre], [Mail]) VALUES (10, 0, N'cemile', N'arslan', N'cemile', N'1923', N'cemile@ktun.edu.tr')
INSERT [dbo].[Kullanicilar] ([Id], [YetkiId], [Ad], [Soyad], [KullaniciAdi], [Sifre], [Mail]) VALUES (11, 1, N'Mustafa ', N'Tari', N'tari', N'1234', N'tari@ktun.edu.tr')
INSERT [dbo].[Kullanicilar] ([Id], [YetkiId], [Ad], [Soyad], [KullaniciAdi], [Sifre], [Mail]) VALUES (12, 1, N'Mehmet', N'Balci', N'balci', N'net1', N'balci@ktun.edu.tr')
SET IDENTITY_INSERT [dbo].[Kullanicilar] OFF
GO
SET IDENTITY_INSERT [dbo].[KullaniciSporcular] ON 

INSERT [dbo].[KullaniciSporcular] ([Id], [SporcuId], [KullaniciId]) VALUES (32, 2, 11)
INSERT [dbo].[KullaniciSporcular] ([Id], [SporcuId], [KullaniciId]) VALUES (33, 24, 11)
INSERT [dbo].[KullaniciSporcular] ([Id], [SporcuId], [KullaniciId]) VALUES (34, 22, 12)
INSERT [dbo].[KullaniciSporcular] ([Id], [SporcuId], [KullaniciId]) VALUES (35, 21, 11)
INSERT [dbo].[KullaniciSporcular] ([Id], [SporcuId], [KullaniciId]) VALUES (36, 25, 11)
SET IDENTITY_INSERT [dbo].[KullaniciSporcular] OFF
GO
SET IDENTITY_INSERT [dbo].[Mevkiler] ON 

INSERT [dbo].[Mevkiler] ([Id], [Adi], [EAdi]) VALUES (1, N'Defans', N'Defense')
INSERT [dbo].[Mevkiler] ([Id], [Adi], [EAdi]) VALUES (2, N'Kaleci', N'GoalKeeper')
INSERT [dbo].[Mevkiler] ([Id], [Adi], [EAdi]) VALUES (3, N'Forvet', N'Forward')
INSERT [dbo].[Mevkiler] ([Id], [Adi], [EAdi]) VALUES (4, N'Orta Saha', N'Midfielder')
SET IDENTITY_INSERT [dbo].[Mevkiler] OFF
GO
SET IDENTITY_INSERT [dbo].[PortAyari] ON 

INSERT [dbo].[PortAyari] ([Id], [Port]) VALUES (1, N'6555')
SET IDENTITY_INSERT [dbo].[PortAyari] OFF
GO
SET IDENTITY_INSERT [dbo].[Resimler] ON 

INSERT [dbo].[Resimler] ([Id], [Path]) VALUES (1, N'durdurVur64px.png')
INSERT [dbo].[Resimler] ([Id], [Path]) VALUES (2, N'gelisine2_64px.png')
INSERT [dbo].[Resimler] ([Id], [Path]) VALUES (3, N'gogusStop64px.png')
INSERT [dbo].[Resimler] ([Id], [Path]) VALUES (4, N'ayakStop64px.png')
INSERT [dbo].[Resimler] ([Id], [Path]) VALUES (5, N'vole64px.png')
INSERT [dbo].[Resimler] ([Id], [Path]) VALUES (6, N'kafa2_64px.png')
INSERT [dbo].[Resimler] ([Id], [Path]) VALUES (11, N'8812101_messenger_logo_brand_free_icon.png')
INSERT [dbo].[Resimler] ([Id], [Path]) VALUES (12, N'me.jpg')
INSERT [dbo].[Resimler] ([Id], [Path]) VALUES (13, N'me.jpg')
INSERT [dbo].[Resimler] ([Id], [Path]) VALUES (14, N'profil256px.png')
INSERT [dbo].[Resimler] ([Id], [Path]) VALUES (15, N'defaultBall.png')
SET IDENTITY_INSERT [dbo].[Resimler] OFF
GO
SET IDENTITY_INSERT [dbo].[Sporcular] ON 

INSERT [dbo].[Sporcular] ([Id], [MevkiId], [Adi], [Soyadi], [Yas], [Kilo], [Boy], [Ulke], [ResimId], [DogumTarihi]) VALUES (2, 3, N'Zeynel', N'Toplar', 22, 70, 178, 223, 13, CAST(N'2000-12-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Sporcular] ([Id], [MevkiId], [Adi], [Soyadi], [Yas], [Kilo], [Boy], [Ulke], [ResimId], [DogumTarihi]) VALUES (21, 4, N'Mevlüt', N'Arıkan', 23, 78, 178, 223, 14, CAST(N'2000-02-14T00:00:00.000' AS DateTime))
INSERT [dbo].[Sporcular] ([Id], [MevkiId], [Adi], [Soyadi], [Yas], [Kilo], [Boy], [Ulke], [ResimId], [DogumTarihi]) VALUES (22, 2, N'şirin', N'sarcan', 21, 56, 175, 223, 14, CAST(N'2002-04-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Sporcular] ([Id], [MevkiId], [Adi], [Soyadi], [Yas], [Kilo], [Boy], [Ulke], [ResimId], [DogumTarihi]) VALUES (24, 1, N'Emre', N'Yetişir', 23, 75, 178, 223, 14, CAST(N'2000-06-01T09:40:54.000' AS DateTime))
INSERT [dbo].[Sporcular] ([Id], [MevkiId], [Adi], [Soyadi], [Yas], [Kilo], [Boy], [Ulke], [ResimId], [DogumTarihi]) VALUES (25, 4, N'Mehmet', N'Kartal', 31, 94, 178, 223, 14, CAST(N'1992-06-10T21:11:20.000' AS DateTime))
INSERT [dbo].[Sporcular] ([Id], [MevkiId], [Adi], [Soyadi], [Yas], [Kilo], [Boy], [Ulke], [ResimId], [DogumTarihi]) VALUES (26, 2, N'Mehmet Ali', N'Asil', 22, 75, 183, 10, 14, CAST(N'2001-01-01T20:51:08.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Sporcular] OFF
GO
SET IDENTITY_INSERT [dbo].[TopGelisSekilleri] ON 

INSERT [dbo].[TopGelisSekilleri] ([Id], [Adi], [EAdi]) VALUES (1, N'Yerden', N'From the ground')
INSERT [dbo].[TopGelisSekilleri] ([Id], [Adi], [EAdi]) VALUES (2, N'Havadan', N'From the air')
INSERT [dbo].[TopGelisSekilleri] ([Id], [Adi], [EAdi]) VALUES (3, N'Falsolu', N'Curveball')
SET IDENTITY_INSERT [dbo].[TopGelisSekilleri] OFF
GO
SET IDENTITY_INSERT [dbo].[TopKonumlari] ON 

INSERT [dbo].[TopKonumlari] ([Id], [Adi], [EAdi]) VALUES (1, N'Karşıdan', N'Across')
INSERT [dbo].[TopKonumlari] ([Id], [Adi], [EAdi]) VALUES (2, N'Sağ', N'Right')
INSERT [dbo].[TopKonumlari] ([Id], [Adi], [EAdi]) VALUES (3, N'Sol', N'Left')
SET IDENTITY_INSERT [dbo].[TopKonumlari] OFF
GO
SET IDENTITY_INSERT [dbo].[ulkeler] ON 

INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (1, N'Afganistan', N'Afghanistan')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (2, N'Arnavutluk', N'Albania')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (3, N'Cezayir', N'Algeria')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (4, N'Amerikan Samoasi', N'American Samoa')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (5, N'Andorra', N'Andorra')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (6, N'Angola', N'Angola')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (7, N'Anguilla', N'Anguilla')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (8, N'Antarktika', N'Antarctica')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (9, N'Antigua ve Barbuda', N'Antigua And Barbuda')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (10, N'Arjantin', N'Argentina')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (11, N'Ermenistan', N'Armenia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (12, N'Aruba', N'Aruba')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (13, N'Avustralya', N'Australia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (14, N'Avusturya', N'Austria')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (15, N'Azerbaycan', N'Azerbaijan')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (16, N'Bahamalar', N'Bahamas The')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (17, N'Bahreyn', N'Bahrain')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (18, N'Banglades', N'Bangladesh')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (19, N'Barbados', N'Barbados')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (20, N'Beyaz Rusya', N'Belarus')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (21, N'Belçika', N'Belgium')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (22, N'Belize', N'Belize')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (23, N'Benin', N'Benin')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (24, N'Bermuda', N'Bermuda')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (25, N'Butan', N'Bhutan')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (26, N'Bolivya', N'Bolivia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (27, N'Bosna-Hersek', N'Bosnia and Herzegovina')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (28, N'Botsvana', N'Botswana')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (29, N'Bouvet Adasi', N'Bouvet Island')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (30, N'Brezilya', N'Brazil')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (31, N'Britanya Hint Okyanusu Topraklari', N'British Indian Ocean Territory')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (32, N'Brunei', N'Brunei')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (33, N'Bulgaristan', N'Bulgaria')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (34, N'Burkina Faso', N'Burkina Faso')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (35, N'Burundi', N'Burundi')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (36, N'Kamboçya', N'Cambodia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (37, N'Kamerun', N'Cameroon')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (38, N'Kanada', N'Canada')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (39, N'Yesil Burun Adalari', N'Cape Verde')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (40, N'Cayman Adalari', N'Cayman Islands')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (41, N'Orta Afrika Cumhuriyeti', N'Central African Republic')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (42, N'Çad', N'Chad')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (43, N'Sili', N'Chile')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (44, N'Çin', N'China')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (45, N'Christmas Adasi', N'Christmas Island')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (46, N'Cocos Adalari', N'Cocos (Keeling) Islands')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (47, N'Kolombiya', N'Colombia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (48, N'Komorlar', N'Comoros')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (49, N'Kongo Cumhuriyeti', N'Republic Of The Congo')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (50, N'Kongo Demokratik Cumhuriyeti', N'Democratic Republic Of The Congo')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (51, N'Cook Adalari', N'Cook Islands')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (52, N'Kosta Rika', N'Costa Rica')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (53, N'Fildisi Sahili', N'Cote Ivoire (Ivory Coast)')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (54, N'Hirvatistan', N'Croatia (Hrvatska)')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (55, N'Küba', N'Cuba')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (56, N'Kibris', N'Cyprus')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (57, N'Çek Cumhuriyeti', N'Czech Republic')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (58, N'Danimarka', N'Denmark')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (59, N'Cibuti', N'Djibouti')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (60, N'Dominika', N'Dominica')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (61, N'Dominik Cumhuriyeti', N'Dominican Republic')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (62, N'Dogu Timor', N'East Timor')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (63, N'Ekvador', N'Ecuador')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (64, N'Misir', N'Egypt')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (65, N'El Salvador', N'El Salvador')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (66, N'Ekvator Ginesi', N'Equatorial Guinea')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (67, N'Eritre', N'Eritrea')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (68, N'Estonya', N'Estonia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (69, N'Etiyopya', N'Ethiopia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (70, N'Avustralya Dis Topraklari', N'External Territories of Australia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (71, N'Falkland Adalari', N'Falkland Islands')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (72, N'Faroe Adalari', N'Faroe Islands')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (73, N'Fiji', N'Fiji Islands')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (74, N'Finlandiya', N'Finland')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (75, N'Fransa', N'France')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (76, N'Fransiz Guyanasi', N'French Guiana')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (77, N'Fransiz Polinezyasi', N'French Polynesia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (78, N'Fransiz Güney Topraklari', N'French Southern Territories')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (79, N'Gabon', N'Gabon')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (80, N'Gambia', N'Gambia The')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (81, N'Gürcistan', N'Georgia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (82, N'Almanya', N'Germany')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (83, N'Gana', N'Ghana')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (84, N'Cebelitarik', N'Gibraltar')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (85, N'Yunanistan', N'Greece')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (86, N'Grönland', N'Greenland')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (87, N'Grenada', N'Grenada')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (88, N'Guadeloupe', N'Guadeloupe')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (89, N'Guam', N'Guam')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (90, N'Guatemala', N'Guatemala')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (91, N'Guernsey ve Alderney', N'Guernsey and Alderney')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (92, N'Gine', N'Guinea')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (93, N'Gine-Bissau', N'Guinea-Bissau')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (94, N'Guyana', N'Guyana')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (95, N'Haiti', N'Haiti')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (96, N'Heard Adasi ve McDonald Adalari', N'Heard and McDonald Islands')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (97, N'Honduras', N'Honduras')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (98, N'Hong Kong SAR', N'Hong Kong S.A.R.')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (99, N'Macaristan', N'Hungary')
GO
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (100, N'Izlanda', N'Iceland')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (101, N'Hindistan', N'India')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (102, N'Endonezya', N'Indonesia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (103, N'Iran', N'Iran')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (104, N'Irak', N'Iraq')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (105, N'Irlanda', N'Ireland')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (106, N'Israil', N'Israel')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (107, N'Italya', N'Italy')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (108, N'Jamaika', N'Jamaica')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (109, N'Japonya', N'Japan')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (110, N'Jersey', N'Jersey')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (111, N'Ürdün', N'Jordan')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (112, N'Kazakistan', N'Kazakhstan')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (113, N'Kenya', N'Kenya')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (114, N'Kiribati', N'Kiribati')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (115, N'Kuzey Kore', N'Korea North')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (116, N'Güney Kore', N'Korea South')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (117, N'Kuveyt', N'Kuwait')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (118, N'Kirgizistan', N'Kyrgyzstan')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (119, N'Laos', N'Laos')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (120, N'Letonya', N'Latvia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (121, N'Lübnan', N'Lebanon')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (122, N'Lesotho', N'Lesotho')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (123, N'Liberya', N'Liberia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (124, N'Libya', N'Libya')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (125, N'Liechtenstein', N'Liechtenstein')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (126, N'Litvanya', N'Lithuania')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (127, N'Lüksemburg', N'Luxembourg')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (128, N'Macao SAR', N'Macau S.A.R.')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (129, N'Makedonya', N'Macedonia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (130, N'Madagaskar', N'Madagascar')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (131, N'Malavi', N'Malawi')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (132, N'Malezya', N'Malaysia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (133, N'Maldivler', N'Maldives')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (134, N'Mali', N'Mali')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (135, N'Malta', N'Malta')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (136, N'Man Adasi', N'Man (Isle of)')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (137, N'Marshall Adalari', N'Marshall Islands')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (138, N'Martinik', N'Martinique')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (139, N'Moritanya', N'Mauritania')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (140, N'Mauritius', N'Mauritius')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (141, N'Mayotte', N'Mayotte')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (142, N'Meksika', N'Mexico')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (143, N'Mikronezya', N'Micronesia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (144, N'Moldova', N'Moldova')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (145, N'Monako', N'Monaco')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (146, N'Mogolistan', N'Mongolia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (147, N'Montserrat', N'Montserrat')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (148, N'Fas', N'Morocco')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (149, N'Mozambik', N'Mozambique')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (150, N'Myanmar', N'Myanmar')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (151, N'Namibya', N'Namibia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (152, N'Nauru', N'Nauru')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (153, N'Nepal', N'Nepal')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (154, N'Hollanda Antilleri', N'Netherlands Antilles')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (155, N'Hollanda', N'Netherlands The')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (156, N'Yeni Kaledonya', N'New Caledonia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (157, N'Yeni Zelanda', N'New Zealand')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (158, N'Nikaragua', N'Nicaragua')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (159, N'Nijer', N'Niger')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (160, N'Nijerya', N'Nigeria')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (161, N'Niue', N'Niue')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (162, N'Norfolk Adasi', N'Norfolk Island')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (163, N'Kuzey Mariana Adalari', N'Northern Mariana Islands')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (164, N'Norveç', N'Norway')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (165, N'Umman', N'Oman')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (166, N'Pakistan', N'Pakistan')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (167, N'Palau', N'Palau')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (168, N'Filistin Topraklari', N'Palestinian Territory Occupied')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (169, N'Panama', N'Panama')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (170, N'Papua Yeni Gine', N'Papua new Guinea')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (171, N'Paraguay', N'Paraguay')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (172, N'Peru', N'Peru')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (173, N'Filipinler', N'Philippines')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (174, N'Pitcairn Adasi', N'Pitcairn Island')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (175, N'Polonya', N'Poland')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (176, N'Portekiz', N'Portugal')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (177, N'Porto Riko', N'Puerto Rico')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (178, N'Katar', N'Qatar')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (179, N'Reunion', N'Reunion')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (180, N'Romanya', N'Romania')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (181, N'Rusya', N'Russia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (182, N'Ruanda', N'Rwanda')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (183, N'Saint Helena', N'Saint Helena')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (184, N'Saint Kitts ve Nevis', N'Saint Kitts And Nevis')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (185, N'Saint Lucia', N'Saint Lucia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (186, N'Saint Pierre ve Miquelon', N'Saint Pierre and Miquelon')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (187, N'Saint Vincent ve Grenadinler', N'Saint Vincent And The Grenadines')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (188, N'Samoa', N'Samoa')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (189, N'San Marino', N'San Marino')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (190, N'Sao Tome ve Principe', N'Sao Tome and Principe')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (191, N'Suudi Arabistan', N'Saudi Arabia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (192, N'Senegal', N'Senegal')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (193, N'Sirbistan', N'Serbia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (194, N'Seyseller', N'Seychelles')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (195, N'Sierra Leone', N'Sierra Leone')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (196, N'Singapur', N'Singapore')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (197, N'Slovakya', N'Slovakia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (198, N'Slovenya', N'Slovenia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (199, N'Birlesik Krallik Küçük Adalar', N'Smaller Territories of the UK')
GO
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (200, N'Solomon Adalari', N'Solomon Islands')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (201, N'Somali', N'Somalia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (202, N'Güney Afrika', N'South Africa')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (203, N'Gürcistan', N'South Georgia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (204, N'Güney Sudan', N'South Sudan')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (205, N'Ispanya', N'Spain')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (206, N'Sri Lanka', N'Sri Lanka')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (207, N'Sudan', N'Sudan')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (208, N'Surinam', N'Suriname')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (209, N'Svalbard ve Jan Mayen Adalari', N'Svalbard And Jan Mayen Islands')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (210, N'Svaziland', N'Swaziland')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (211, N'Isveç', N'Sweden')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (212, N'Isviçre', N'Switzerland')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (213, N'Suriye', N'Syria')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (214, N'Tayvan', N'Taiwan')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (215, N'Tacikistan', N'Tajikistan')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (216, N'Tanzanya', N'Tanzania')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (217, N'Tayland', N'Thailand')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (218, N'Togo', N'Togo')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (219, N'Tokelau', N'Tokelau')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (220, N'Tonga', N'Tonga')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (221, N'Trinidad ve Tobago', N'Trinidad And Tobago')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (222, N'Tunus', N'Tunisia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (223, N'Türkiye', N'Turkey')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (224, N'Türkmenistan', N'Turkmenistan')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (225, N'Turks ve Caicos Adalari', N'Turks And Caicos Islands')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (226, N'Tuvalu', N'Tuvalu')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (227, N'Uganda', N'Uganda')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (228, N'Ukrayna', N'Ukraine')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (229, N'Birlesik Arap Emirlikleri', N'United Arab Emirates')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (230, N'Birlesik Krallik', N'United Kingdom')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (231, N'Amerika Birlesik Devletleri', N'United States')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (232, N'Amerika Birlesik Devletleri Küçük Dis Adalari', N'United States Minor Outlying Islands')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (233, N'Uruguay', N'Uruguay')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (234, N'Özbekistan', N'Uzbekistan')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (235, N'Vanuatu', N'Vanuatu')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (236, N'Vatikan', N'Vatican City State (Holy See)')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (237, N'Venezuela', N'Venezuela')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (238, N'Vietnam', N'Vietnam')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (239, N'Virgin Adalari (Britanya)', N'Virgin Islands (British)')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (240, N'Virgin Adalari (ABD)', N'Virgin Islands (US)')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (241, N'Wallis ve Futuna Adalari', N'Wallis And Futuna Islands')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (242, N'Bati Sahara', N'Western Sahara')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (243, N'Yemen', N'Yemen')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (244, N'Yugoslavya', N'Yugoslavia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (245, N'Zambiya', N'Zambia')
INSERT [dbo].[ulkeler] ([Id], [UlkeAdi], [EUlkeAdi]) VALUES (246, N'Zimbabve', N'Zimbabwe')
SET IDENTITY_INSERT [dbo].[ulkeler] OFF
GO
SET IDENTITY_INSERT [dbo].[VurusBicimleri] ON 

INSERT [dbo].[VurusBicimleri] ([Id], [Adi], [ResimId], [EAdi]) VALUES (1, N'Durdur Vur', 1, N'Stop and shot')
INSERT [dbo].[VurusBicimleri] ([Id], [Adi], [ResimId], [EAdi]) VALUES (2, N'Gelişine Vur', 2, N'Shot the incoming')
INSERT [dbo].[VurusBicimleri] ([Id], [Adi], [ResimId], [EAdi]) VALUES (3, N'Göğüs Stop', 3, N'
Chest Stop')
INSERT [dbo].[VurusBicimleri] ([Id], [Adi], [ResimId], [EAdi]) VALUES (4, N'Ayak Stop', 4, N'Foot Stop')
INSERT [dbo].[VurusBicimleri] ([Id], [Adi], [ResimId], [EAdi]) VALUES (5, N'Vole', 5, N'Volley')
INSERT [dbo].[VurusBicimleri] ([Id], [Adi], [ResimId], [EAdi]) VALUES (6, N'Kafa', 6, N'Head')
INSERT [dbo].[VurusBicimleri] ([Id], [Adi], [ResimId], [EAdi]) VALUES (14, N'Deneme', 4, N'attempt')
SET IDENTITY_INSERT [dbo].[VurusBicimleri] OFF
GO
ALTER TABLE [dbo].[Antrenmanlar] ADD  CONSTRAINT [DF__Antrenman__Antre__6FE99F9F]  DEFAULT ((0)) FOR [AntrenmanSayisi]
GO
ALTER TABLE [dbo].[VurusBicimleri] ADD  DEFAULT ((0)) FOR [ResimId]
GO
ALTER TABLE [dbo].[Antrenmanlar]  WITH CHECK ADD  CONSTRAINT [FK_Antrenmanlar_AntrenmanTurleri_AntrenamTuruId] FOREIGN KEY([AntrenamTuruId])
REFERENCES [dbo].[AntrenmanTurleri] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Antrenmanlar] CHECK CONSTRAINT [FK_Antrenmanlar_AntrenmanTurleri_AntrenamTuruId]
GO
ALTER TABLE [dbo].[Antrenmanlar]  WITH CHECK ADD  CONSTRAINT [FK_Antrenmanlar_KaleciAntrenmanTurleri_KAntrenmanTuruId] FOREIGN KEY([KAntrenmanTuruId])
REFERENCES [dbo].[KaleciAntrenmanTurleri] ([Id])
GO
ALTER TABLE [dbo].[Antrenmanlar] CHECK CONSTRAINT [FK_Antrenmanlar_KaleciAntrenmanTurleri_KAntrenmanTuruId]
GO
ALTER TABLE [dbo].[Antrenmanlar]  WITH CHECK ADD  CONSTRAINT [FK_Antrenmanlar_Sporcular_SporcuId] FOREIGN KEY([SporcuId])
REFERENCES [dbo].[Sporcular] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Antrenmanlar] CHECK CONSTRAINT [FK_Antrenmanlar_Sporcular_SporcuId]
GO
ALTER TABLE [dbo].[AntrenmanTurleri]  WITH CHECK ADD  CONSTRAINT [FK_AntrenmanTurleri_TopGelisSekilleri_TopGelisSekliId] FOREIGN KEY([TopGelisSekliId])
REFERENCES [dbo].[TopGelisSekilleri] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AntrenmanTurleri] CHECK CONSTRAINT [FK_AntrenmanTurleri_TopGelisSekilleri_TopGelisSekliId]
GO
ALTER TABLE [dbo].[AntrenmanTurleri]  WITH CHECK ADD  CONSTRAINT [FK_AntrenmanTurleri_TopKonumlari_TopKonumId] FOREIGN KEY([TopKonumId])
REFERENCES [dbo].[TopKonumlari] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AntrenmanTurleri] CHECK CONSTRAINT [FK_AntrenmanTurleri_TopKonumlari_TopKonumId]
GO
ALTER TABLE [dbo].[AntrenmanTurleri]  WITH CHECK ADD  CONSTRAINT [FK_AntrenmanTurleri_VurusBicimleri_VurusBicimiId] FOREIGN KEY([VurusBicimiId])
REFERENCES [dbo].[VurusBicimleri] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AntrenmanTurleri] CHECK CONSTRAINT [FK_AntrenmanTurleri_VurusBicimleri_VurusBicimiId]
GO
ALTER TABLE [dbo].[KaleciAntrenmanTurleri]  WITH CHECK ADD  CONSTRAINT [FK_KaleciAntrenmanTurleri_TopGelisSekilleri_TopGelisSekliId] FOREIGN KEY([TopGelisSekliId])
REFERENCES [dbo].[TopGelisSekilleri] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KaleciAntrenmanTurleri] CHECK CONSTRAINT [FK_KaleciAntrenmanTurleri_TopGelisSekilleri_TopGelisSekliId]
GO
ALTER TABLE [dbo].[KaleciAntrenmanTurleri]  WITH CHECK ADD  CONSTRAINT [FK_KaleciAntrenmanTurleri_TopKonumlari_TopKonumId] FOREIGN KEY([TopKonumId])
REFERENCES [dbo].[TopKonumlari] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KaleciAntrenmanTurleri] CHECK CONSTRAINT [FK_KaleciAntrenmanTurleri_TopKonumlari_TopKonumId]
GO
ALTER TABLE [dbo].[KullaniciSporcular]  WITH CHECK ADD  CONSTRAINT [FK_KullaniciSporcular_Kullanicilar_KullaniciId] FOREIGN KEY([KullaniciId])
REFERENCES [dbo].[Kullanicilar] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KullaniciSporcular] CHECK CONSTRAINT [FK_KullaniciSporcular_Kullanicilar_KullaniciId]
GO
ALTER TABLE [dbo].[KullaniciSporcular]  WITH CHECK ADD  CONSTRAINT [FK_KullaniciSporcular_Sporcular_SporcuId] FOREIGN KEY([SporcuId])
REFERENCES [dbo].[Sporcular] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KullaniciSporcular] CHECK CONSTRAINT [FK_KullaniciSporcular_Sporcular_SporcuId]
GO
ALTER TABLE [dbo].[Sporcular]  WITH CHECK ADD  CONSTRAINT [FK_Sporcular_Mevkiler_MevkiId] FOREIGN KEY([MevkiId])
REFERENCES [dbo].[Mevkiler] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sporcular] CHECK CONSTRAINT [FK_Sporcular_Mevkiler_MevkiId]
GO
ALTER TABLE [dbo].[Sporcular]  WITH CHECK ADD  CONSTRAINT [FK_Sporcular_Resimler] FOREIGN KEY([ResimId])
REFERENCES [dbo].[Resimler] ([Id])
GO
ALTER TABLE [dbo].[Sporcular] CHECK CONSTRAINT [FK_Sporcular_Resimler]
GO
ALTER TABLE [dbo].[Sporcular]  WITH CHECK ADD  CONSTRAINT [FK_Sporcular_ulkeler] FOREIGN KEY([Ulke])
REFERENCES [dbo].[ulkeler] ([Id])
GO
ALTER TABLE [dbo].[Sporcular] CHECK CONSTRAINT [FK_Sporcular_ulkeler]
GO
ALTER TABLE [dbo].[VurusBicimleri]  WITH CHECK ADD  CONSTRAINT [FK_VurusBicimleri_Resimler_ResimId] FOREIGN KEY([ResimId])
REFERENCES [dbo].[Resimler] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VurusBicimleri] CHECK CONSTRAINT [FK_VurusBicimleri_Resimler_ResimId]
GO
