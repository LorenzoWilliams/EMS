USE [Ember_medical_service_db]
GO

/****** Object:  Table [dbo].[Attempted_delpayment]    Script Date: 15/12/2019 12:02:18 pm ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Attempted_delpayment](
	[id] [int] IDENTITY(1001,1) NOT NULL,
	[timestmp] [datetime] NOT NULL,
 CONSTRAINT [PK_Attempted_delpayment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Attempted_delpayment] ADD  CONSTRAINT [DF_Attempted_delpayment_timestmp]  DEFAULT (getdate()) FOR [timestmp]
GO


