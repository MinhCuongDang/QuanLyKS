CREATE TABLE [dbo].[SanPham] (
    [MaSP]     NCHAR (5)     NOT NULL,
    [TenSP]    NVARCHAR (30) NULL,
    [SLTonKho] INT           NOT NULL,
    [Gia]      INT           NOT NULL,
    [GhiChu]   TEXT          NULL,
    CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED ([MaSP] ASC)
);

