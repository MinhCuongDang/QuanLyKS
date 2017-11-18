CREATE TABLE [dbo].[DSKhachHang] (
    [MaKH]     NCHAR (4)      NOT NULL,
    [Ho]       NVARCHAR (30)  NOT NULL,
    [Ten]      NVARCHAR (20)  NOT NULL,
    [NgaySinh] DATE           NULL,
    [CMND]     NCHAR (12)     NOT NULL,
    [DiaChi]   NVARCHAR (150) NOT NULL,
    [SDT]      NCHAR (15)     NOT NULL,
    [Fax]      NCHAR (15)     NULL,
    [GhiChu]   TEXT           NULL,
    CONSTRAINT [PK_DSKhachHang] PRIMARY KEY CLUSTERED ([MaKH] ASC)
);

