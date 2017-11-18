CREATE TABLE [dbo].[ChiTietDichVu] (
    [MaKS]            NCHAR (10) NOT NULL,
    [ChuSoHuu]        NCHAR (10) NOT NULL,
    [ThoiGianBatDau]  DATE       NOT NULL,
    [ChiPhiHangThang] INT        NULL,
    [GhiChu]          TEXT       NULL,
    CONSTRAINT [PK_ChiTietDichVu] PRIMARY KEY CLUSTERED ([MaKS] ASC, [ChuSoHuu] ASC),
    CONSTRAINT [FK_ChiTietDichVu_DanhSachKhachSan] FOREIGN KEY ([MaKS]) REFERENCES [dbo].[DanhSachKhachSan] ([MaKS]),
    CONSTRAINT [FK_ChiTietDichVu_DSChuSoHuu] FOREIGN KEY ([ChuSoHuu]) REFERENCES [dbo].[DSChuSoHuu] ([MaChuSoHuu])
);

