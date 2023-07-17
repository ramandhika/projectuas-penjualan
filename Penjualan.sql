/*
 Navicat Premium Data Transfer

 Source Server         : Localhost - SQL Server
 Source Server Type    : SQL Server
 Source Server Version : 11002100 (11.00.2100)
 Source Host           : WIN-JA4ORIHIEQL:1433
 Source Catalog        : penjualan
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 11002100 (11.00.2100)
 File Encoding         : 65001

 Date: 17/07/2023 16:52:57
*/


-- ----------------------------
-- Table structure for Pegawai
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Pegawai]') AND type IN ('U'))
	DROP TABLE [dbo].[Pegawai]
GO

CREATE TABLE [dbo].[Pegawai] (
  [Kode] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Nama] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Username] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Password] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Pegawai] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Pegawai
-- ----------------------------
INSERT INTO [dbo].[Pegawai] ([Kode], [Nama], [Username], [Password]) VALUES (N'PGW001', N'Andi Susanto', N'admin', N'admin')
GO

INSERT INTO [dbo].[Pegawai] ([Kode], [Nama], [Username], [Password]) VALUES (N'PGW002', N'Budi Prasetyo', N'budi456', N'password456')
GO

INSERT INTO [dbo].[Pegawai] ([Kode], [Nama], [Username], [Password]) VALUES (N'PGW003', N'Citra Dewi', N'citra789', N'password789')
GO


-- ----------------------------
-- Table structure for Produk
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Produk]') AND type IN ('U'))
	DROP TABLE [dbo].[Produk]
GO

CREATE TABLE [dbo].[Produk] (
  [Kode] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [NamaProduk] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Harga] int  NULL,
  [Diskon] int  NULL,
  [Stok] int  NULL
)
GO

ALTER TABLE [dbo].[Produk] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Produk
-- ----------------------------
INSERT INTO [dbo].[Produk] ([Kode], [NamaProduk], [Harga], [Diskon], [Stok]) VALUES (N'P001', N'Baju', N'50000', N'10', N'50')
GO

INSERT INTO [dbo].[Produk] ([Kode], [NamaProduk], [Harga], [Diskon], [Stok]) VALUES (N'P002', N'Sendal', N'25000', N'5', N'29')
GO

INSERT INTO [dbo].[Produk] ([Kode], [NamaProduk], [Harga], [Diskon], [Stok]) VALUES (N'P003', N'Celana', N'80000', N'15', N'19')
GO

INSERT INTO [dbo].[Produk] ([Kode], [NamaProduk], [Harga], [Diskon], [Stok]) VALUES (N'P004', N'Kemeja', N'120000', N'20', N'15')
GO

INSERT INTO [dbo].[Produk] ([Kode], [NamaProduk], [Harga], [Diskon], [Stok]) VALUES (N'P005', N'Sepatu', N'300000', N'10', N'9')
GO

INSERT INTO [dbo].[Produk] ([Kode], [NamaProduk], [Harga], [Diskon], [Stok]) VALUES (N'P006', N'Topi', N'50000', N'5', N'10')
GO

INSERT INTO [dbo].[Produk] ([Kode], [NamaProduk], [Harga], [Diskon], [Stok]) VALUES (N'P007', N'Jaket', N'150000', N'15', N'15')
GO

INSERT INTO [dbo].[Produk] ([Kode], [NamaProduk], [Harga], [Diskon], [Stok]) VALUES (N'P008', N'Kaos', N'75000', N'5', N'25')
GO

INSERT INTO [dbo].[Produk] ([Kode], [NamaProduk], [Harga], [Diskon], [Stok]) VALUES (N'P009', N'Tas', N'200000', N'10', N'15')
GO

INSERT INTO [dbo].[Produk] ([Kode], [NamaProduk], [Harga], [Diskon], [Stok]) VALUES (N'P010', N'Topeng', N'30000', N'0', N'10')
GO


-- ----------------------------
-- Table structure for Transaksi
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Transaksi]') AND type IN ('U'))
	DROP TABLE [dbo].[Transaksi]
GO

CREATE TABLE [dbo].[Transaksi] (
  [Kode] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [NamaPembeli] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Tanggal] date  NULL,
  [TotalHarga] int  NULL,
  [ProdukKode] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [PegawaiKode] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Transaksi] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Transaksi
-- ----------------------------
INSERT INTO [dbo].[Transaksi] ([Kode], [NamaPembeli], [Tanggal], [TotalHarga], [ProdukKode], [PegawaiKode]) VALUES (N'T001', N'Rina Sari', N'2023-07-01', N'90000', N'P001', N'PGW001')
GO

INSERT INTO [dbo].[Transaksi] ([Kode], [NamaPembeli], [Tanggal], [TotalHarga], [ProdukKode], [PegawaiKode]) VALUES (N'T002', N'Dewi Permata', N'2023-07-02', N'60000', N'P002', N'PGW002')
GO

INSERT INTO [dbo].[Transaksi] ([Kode], [NamaPembeli], [Tanggal], [TotalHarga], [ProdukKode], [PegawaiKode]) VALUES (N'T003', N'Ahmad Pratama', N'2023-07-03', N'120000', N'P003', N'PGW001')
GO

INSERT INTO [dbo].[Transaksi] ([Kode], [NamaPembeli], [Tanggal], [TotalHarga], [ProdukKode], [PegawaiKode]) VALUES (N'T004', N'Siti Rahayu', N'2023-07-04', N'90000', N'P004', N'PGW003')
GO

INSERT INTO [dbo].[Transaksi] ([Kode], [NamaPembeli], [Tanggal], [TotalHarga], [ProdukKode], [PegawaiKode]) VALUES (N'T005', N'Eko Pranoto', N'2023-07-05', N'250000', N'P005', N'PGW002')
GO

INSERT INTO [dbo].[Transaksi] ([Kode], [NamaPembeli], [Tanggal], [TotalHarga], [ProdukKode], [PegawaiKode]) VALUES (N'T006', N'Budi Setyawan', N'2023-07-17', N'27000', N'P010', N'PGW003')
GO

INSERT INTO [dbo].[Transaksi] ([Kode], [NamaPembeli], [Tanggal], [TotalHarga], [ProdukKode], [PegawaiKode]) VALUES (N'T006', N'Budi Setyawan', N'2023-07-17', N'27000', N'P010', N'PGW003')
GO


-- ----------------------------
-- Primary Key structure for table Pegawai
-- ----------------------------
ALTER TABLE [dbo].[Pegawai] ADD CONSTRAINT [PK__Pegawai__706C7EE93F406D59] PRIMARY KEY CLUSTERED ([Kode])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Produk
-- ----------------------------
ALTER TABLE [dbo].[Produk] ADD CONSTRAINT [PK__Produk__706C7EE935361EEC] PRIMARY KEY CLUSTERED ([Kode])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table Transaksi
-- ----------------------------
ALTER TABLE [dbo].[Transaksi] ADD CONSTRAINT [FK__Transaksi__Produ__4CA06362] FOREIGN KEY ([ProdukKode]) REFERENCES [dbo].[Produk] ([Kode]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Transaksi] ADD CONSTRAINT [FK__Transaksi__Pegaw__4D94879B] FOREIGN KEY ([PegawaiKode]) REFERENCES [dbo].[Pegawai] ([Kode]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

