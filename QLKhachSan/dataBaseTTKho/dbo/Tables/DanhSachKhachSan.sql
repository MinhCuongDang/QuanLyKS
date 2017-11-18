CREATE TABLE [dbo].[DanhSachKhachSan] (
    [MaKS]         NCHAR (10)    NOT NULL,
    [TenKS]        NVARCHAR (50) NOT NULL,
    [DC_So]        NVARCHAR (12) NOT NULL,
    [DC_Duong]     NVARCHAR (50) NOT NULL,
    [DC_Phuong]    NVARCHAR (50) NOT NULL,
    [DC_Quan]      NVARCHAR (50) NOT NULL,
    [DC_Tinh]      NVARCHAR (50) NOT NULL,
    [SoPhongTrong] INT           NULL,
    [GhiChu]       TEXT          NULL,
    CONSTRAINT [PK_DanhSachKhachSan] PRIMARY KEY CLUSTERED ([MaKS] ASC)
);

