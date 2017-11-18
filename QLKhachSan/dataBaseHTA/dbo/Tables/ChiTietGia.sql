CREATE TABLE [dbo].[ChiTietGia] (
    [LoaiPhong]    NVARCHAR (10) NOT NULL,
    [Gia]          INT           NULL,
    [SoPhongTrong] INT           NULL,
    [GhiChu]       TEXT          NULL,
    CONSTRAINT [PK_ChiTietGia] PRIMARY KEY CLUSTERED ([LoaiPhong] ASC)
);

