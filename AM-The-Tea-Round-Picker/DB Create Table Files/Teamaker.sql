USE [tea-picker-db]
GO

/****** Object:  Table [dbo].[TeaMaker]    Script Date: 17/01/2023 14:37:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TeaMaker](
	[TeaMakerId] [int] IDENTITY(1,1) NOT NULL,
	[PersonId] [int] NOT NULL,
	[PersonName] [nvarchar](50) NOT NULL,
	[TeaMakerCount] [int] NOT NULL,
	[LastTeaMadeTime] [datetime] NOT NULL,
 CONSTRAINT [PK_TeaMaker] PRIMARY KEY CLUSTERED 
(
	[TeaMakerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


