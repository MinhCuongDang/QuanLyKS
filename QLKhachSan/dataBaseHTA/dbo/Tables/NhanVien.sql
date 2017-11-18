CREATE TABLE [dbo].[NhanVien] (
    [MaNV]     NCHAR (8)      NOT NULL,
    [Ho]       NVARCHAR (30)  NULL,
    [Ten]      NVARCHAR (20)  NOT NULL,
    [NgaySinh] DATE           NULL,
    [GioiTinh] NCHAR (4)      NULL,
    [CMND]     NCHAR (12)     NOT NULL,
    [SDT]      NCHAR (11)     NOT NULL,
    [DiaChi]   NVARCHAR (150) NOT NULL,
    [BangCap]  NVARCHAR (20)  NULL,
    [GhiChu]   TEXT           NULL,
    CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED ([MaNV] ASC)
);

