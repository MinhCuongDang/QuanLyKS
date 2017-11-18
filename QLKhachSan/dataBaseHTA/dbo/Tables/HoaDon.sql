CREATE TABLE [dbo].[HoaDon] (
    [MaHD]      NCHAR (8) NOT NULL,
    [MaKH]      NCHAR (4) NOT NULL,
    [NgayXuat]  DATETIME  NULL,
    [ThanhTien] INT       NULL,
    [MaNV]      NCHAR (8) NULL,
    [GhiChu]    TEXT      NULL,
    CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED ([MaHD] ASC),
    CONSTRAINT [FK_HoaDon_DSKhachHang] FOREIGN KEY ([MaKH]) REFERENCES [dbo].[DSKhachHang] ([MaKH]),
    CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV])
);

