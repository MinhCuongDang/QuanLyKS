CREATE TABLE [dbo].[DSPhong] (
    [MaP]       NCHAR (4)     NOT NULL,
    [LoaiPhong] NCHAR (10)    NULL,
    [SoGiuong]  INT           NOT NULL,
    [GiaPhong]  INT           NULL,
    [TinhTrang] NVARCHAR (20) NOT NULL,
    [GhiChu]    TEXT          NULL,
    CONSTRAINT [PK_DSPhong] PRIMARY KEY CLUSTERED ([MaP] ASC)
);

