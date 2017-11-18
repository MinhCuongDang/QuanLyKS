CREATE TABLE [dbo].[CTHoaDon] (
    [MaHD]      NCHAR (8) NOT NULL,
    [MaSP]      NCHAR (5) NOT NULL,
    [SoLuong]   INT       NOT NULL,
    [DonGia]    INT       NOT NULL,
    [ThanhTien] INT       NULL,
    [GhiChu]    TEXT      NULL,
    CONSTRAINT [PK_CTHoaDon] PRIMARY KEY CLUSTERED ([MaHD] ASC, [MaSP] ASC),
    CONSTRAINT [FK_CTHoaDon_SanPham] FOREIGN KEY ([MaSP]) REFERENCES [dbo].[SanPham] ([MaSP])
);

