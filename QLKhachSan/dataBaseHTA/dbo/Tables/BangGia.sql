CREATE TABLE [dbo].[BangGia] (
    [STT]       INT           NOT NULL,
    [LoaiPhong] NVARCHAR (10) NOT NULL,
    [LoaiThue]  NVARCHAR (10) NOT NULL,
    [SoGiuong]  INT           NOT NULL,
    [GiaThue]   INT           NOT NULL,
    [GhiChu]    TEXT          NULL,
    CONSTRAINT [PK_BangGia] PRIMARY KEY CLUSTERED ([STT] ASC)
);

