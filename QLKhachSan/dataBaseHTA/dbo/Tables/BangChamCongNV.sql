CREATE TABLE [dbo].[BangChamCongNV] (
    [MaNV]     NCHAR (8) NOT NULL,
    [NgayCong] DATE      NOT NULL,
    [GioVao]   TIME (7)  NOT NULL,
    [GioRa]    TIME (7)  NULL,
    [GhiChu]   TEXT      NULL,
    CONSTRAINT [PK_BangChamCongNV] PRIMARY KEY CLUSTERED ([MaNV] ASC, [NgayCong] ASC),
    CONSTRAINT [FK_BangChamCongNV_NhanVien] FOREIGN KEY ([MaNV]) REFERENCES [dbo].[NhanVien] ([MaNV])
);

