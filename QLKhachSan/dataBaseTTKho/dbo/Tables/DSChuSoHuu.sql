CREATE TABLE [dbo].[DSChuSoHuu] (
    [MaChuSoHuu]      NCHAR (10)    NOT NULL,
    [Ho]              NVARCHAR (30) NOT NULL,
    [Ten]             NVARCHAR (20) NOT NULL,
    [NgaySinh]        DATE          NOT NULL,
    [SoDienThoai]     NCHAR (15)    NOT NULL,
    [CMND]            NCHAR (10)    NOT NULL,
    [DiaChiNha]       NTEXT         NOT NULL,
    [HoKhauThuongTru] NTEXT         NOT NULL,
    [GhiChu]          TEXT          NULL,
    CONSTRAINT [PK_DSChuSoHuu] PRIMARY KEY CLUSTERED ([MaChuSoHuu] ASC)
);

