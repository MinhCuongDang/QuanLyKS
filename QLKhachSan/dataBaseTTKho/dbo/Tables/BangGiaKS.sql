CREATE TABLE [dbo].[BangGiaKS] (
    [MaKS]      NCHAR (10)    NOT NULL,
    [STT]       INT           NOT NULL,
    [LoaiPhong] NVARCHAR (10) NOT NULL,
    [LoaiThue]  NVARCHAR (10) NOT NULL,
    [SoGiuong]  INT           NOT NULL,
    [GiaThue]   INT           NOT NULL,
    [GhiChu]    TEXT          NULL,
    CONSTRAINT [PK_BangGiaKS] PRIMARY KEY CLUSTERED ([MaKS] ASC, [STT] ASC),
    CONSTRAINT [FK_BangGiaKS_DanhSachKhachSan] FOREIGN KEY ([MaKS]) REFERENCES [dbo].[DanhSachKhachSan] ([MaKS])
);

