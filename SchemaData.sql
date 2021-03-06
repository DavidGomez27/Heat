USE [Heat]
GO
/****** Object:  Table [dbo].[Combo]    Script Date: 11/29/2017 2:44:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Combo](
	[CouplesComboID] [int] IDENTITY(1,1) NOT NULL,
	[Combo] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Combo] PRIMARY KEY CLUSTERED 
(
	[CouplesComboID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Couple]    Script Date: 11/29/2017 2:44:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Couple](
	[CouplesID] [int] IDENTITY(1,1) NOT NULL,
	[Partner] [nvarchar](100) NOT NULL,
	[ProID] [int] NOT NULL,
	[HeatListID] [int] NOT NULL,
	[Number] [nvarchar](10) NOT NULL,
	[DanceLevelID] [int] NOT NULL,
	[CouplesComboID] [int] NOT NULL,
	[DanceTypeID] [int] NOT NULL,
 CONSTRAINT [PK_Couple] PRIMARY KEY CLUSTERED 
(
	[CouplesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanceLevel]    Script Date: 11/29/2017 2:44:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanceLevel](
	[DanceLevelID] [int] IDENTITY(1,1) NOT NULL,
	[DanceLevel] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DanceLevel] PRIMARY KEY CLUSTERED 
(
	[DanceLevelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanceType]    Script Date: 11/29/2017 2:44:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanceType](
	[DanceTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Dance] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DanceType] PRIMARY KEY CLUSTERED 
(
	[DanceTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HeatList]    Script Date: 11/29/2017 2:44:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HeatList](
	[HeatListID] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](50) NULL,
	[Time] [datetime] NULL,
	[Name] [nvarchar](100) NULL,
 CONSTRAINT [PK_Heat] PRIMARY KEY CLUSTERED 
(
	[HeatListID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pro]    Script Date: 11/29/2017 2:44:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pro](
	[ProID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Pro] PRIMARY KEY CLUSTERED 
(
	[ProID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Combo] ON 

INSERT [dbo].[Combo] ([CouplesComboID], [Combo]) VALUES (1, N'Pro-Am')
INSERT [dbo].[Combo] ([CouplesComboID], [Combo]) VALUES (2, N'Pro-Pro')
SET IDENTITY_INSERT [dbo].[Combo] OFF
SET IDENTITY_INSERT [dbo].[Couple] ON 

INSERT [dbo].[Couple] ([CouplesID], [Partner], [ProID], [HeatListID], [Number], [DanceLevelID], [CouplesComboID], [DanceTypeID]) VALUES (1, N'Matt Jarvis', 1, 1, N'646', 1, 2, 1)
INSERT [dbo].[Couple] ([CouplesID], [Partner], [ProID], [HeatListID], [Number], [DanceLevelID], [CouplesComboID], [DanceTypeID]) VALUES (2, N'Matt Jarvis', 1, 1, N'646', 1, 2, 2)
INSERT [dbo].[Couple] ([CouplesID], [Partner], [ProID], [HeatListID], [Number], [DanceLevelID], [CouplesComboID], [DanceTypeID]) VALUES (3, N'Coco James', 3, 1, N'11', 3, 1, 2)
INSERT [dbo].[Couple] ([CouplesID], [Partner], [ProID], [HeatListID], [Number], [DanceLevelID], [CouplesComboID], [DanceTypeID]) VALUES (4, N'Daniella Hock', 3, 1, N'12', 2, 1, 6)
INSERT [dbo].[Couple] ([CouplesID], [Partner], [ProID], [HeatListID], [Number], [DanceLevelID], [CouplesComboID], [DanceTypeID]) VALUES (5, N'Judith Hinckleman', 4, 1, N'21', 3, 1, 3)
INSERT [dbo].[Couple] ([CouplesID], [Partner], [ProID], [HeatListID], [Number], [DanceLevelID], [CouplesComboID], [DanceTypeID]) VALUES (6, N'Sophia Maria', 4, 1, N'22', 3, 1, 3)
INSERT [dbo].[Couple] ([CouplesID], [Partner], [ProID], [HeatListID], [Number], [DanceLevelID], [CouplesComboID], [DanceTypeID]) VALUES (7, N'Selena Gomez', 5, 1, N'2121', 2, 2, 1)
INSERT [dbo].[Couple] ([CouplesID], [Partner], [ProID], [HeatListID], [Number], [DanceLevelID], [CouplesComboID], [DanceTypeID]) VALUES (8, N'Shakira', 5, 1, N'800', 3, 2, 6)
INSERT [dbo].[Couple] ([CouplesID], [Partner], [ProID], [HeatListID], [Number], [DanceLevelID], [CouplesComboID], [DanceTypeID]) VALUES (9, N'Asger Barr', 2, 1, N'777', 1, 1, 2)
INSERT [dbo].[Couple] ([CouplesID], [Partner], [ProID], [HeatListID], [Number], [DanceLevelID], [CouplesComboID], [DanceTypeID]) VALUES (10, N'Asger Barr', 2, 1, N'777', 1, 1, 3)
SET IDENTITY_INSERT [dbo].[Couple] OFF
SET IDENTITY_INSERT [dbo].[DanceLevel] ON 

INSERT [dbo].[DanceLevel] ([DanceLevelID], [DanceLevel]) VALUES (1, N'Bronze')
INSERT [dbo].[DanceLevel] ([DanceLevelID], [DanceLevel]) VALUES (2, N'Silver')
INSERT [dbo].[DanceLevel] ([DanceLevelID], [DanceLevel]) VALUES (3, N'Gold')
SET IDENTITY_INSERT [dbo].[DanceLevel] OFF
SET IDENTITY_INSERT [dbo].[DanceType] ON 

INSERT [dbo].[DanceType] ([DanceTypeID], [Dance]) VALUES (1, N'Waltz')
INSERT [dbo].[DanceType] ([DanceTypeID], [Dance]) VALUES (2, N'Foxtrot')
INSERT [dbo].[DanceType] ([DanceTypeID], [Dance]) VALUES (3, N'Tango')
INSERT [dbo].[DanceType] ([DanceTypeID], [Dance]) VALUES (4, N'Quickstep')
INSERT [dbo].[DanceType] ([DanceTypeID], [Dance]) VALUES (5, N'Viennese Waltz')
INSERT [dbo].[DanceType] ([DanceTypeID], [Dance]) VALUES (6, N'Rumba')
INSERT [dbo].[DanceType] ([DanceTypeID], [Dance]) VALUES (7, N'Cha Cha')
INSERT [dbo].[DanceType] ([DanceTypeID], [Dance]) VALUES (8, N'East Coast Swing')
INSERT [dbo].[DanceType] ([DanceTypeID], [Dance]) VALUES (9, N'West Coast Swing')
INSERT [dbo].[DanceType] ([DanceTypeID], [Dance]) VALUES (10, N'Jive')
INSERT [dbo].[DanceType] ([DanceTypeID], [Dance]) VALUES (11, N'Samba')
INSERT [dbo].[DanceType] ([DanceTypeID], [Dance]) VALUES (12, N'Mambo')
INSERT [dbo].[DanceType] ([DanceTypeID], [Dance]) VALUES (13, N'Bolero')
INSERT [dbo].[DanceType] ([DanceTypeID], [Dance]) VALUES (14, N'Paso Doble')
SET IDENTITY_INSERT [dbo].[DanceType] OFF
SET IDENTITY_INSERT [dbo].[HeatList] ON 

INSERT [dbo].[HeatList] ([HeatListID], [Status], [Time], [Name]) VALUES (1, NULL, NULL, N'NOT ASSIGNED')
SET IDENTITY_INSERT [dbo].[HeatList] OFF
SET IDENTITY_INSERT [dbo].[Pro] ON 

INSERT [dbo].[Pro] ([ProID], [Name]) VALUES (1, N'Kaitie Fox')
INSERT [dbo].[Pro] ([ProID], [Name]) VALUES (2, N'Teresa Johnson')
INSERT [dbo].[Pro] ([ProID], [Name]) VALUES (3, N'Dejan Stanarevic')
INSERT [dbo].[Pro] ([ProID], [Name]) VALUES (4, N'Faizon Alexander')
INSERT [dbo].[Pro] ([ProID], [Name]) VALUES (5, N'David Gomez')
SET IDENTITY_INSERT [dbo].[Pro] OFF
ALTER TABLE [dbo].[Couple]  WITH CHECK ADD  CONSTRAINT [FK_Couple_Combo] FOREIGN KEY([CouplesComboID])
REFERENCES [dbo].[Combo] ([CouplesComboID])
GO
ALTER TABLE [dbo].[Couple] CHECK CONSTRAINT [FK_Couple_Combo]
GO
ALTER TABLE [dbo].[Couple]  WITH CHECK ADD  CONSTRAINT [FK_Couple_DanceLevel] FOREIGN KEY([DanceLevelID])
REFERENCES [dbo].[DanceLevel] ([DanceLevelID])
GO
ALTER TABLE [dbo].[Couple] CHECK CONSTRAINT [FK_Couple_DanceLevel]
GO
ALTER TABLE [dbo].[Couple]  WITH CHECK ADD  CONSTRAINT [FK_Couple_DanceType] FOREIGN KEY([DanceTypeID])
REFERENCES [dbo].[DanceType] ([DanceTypeID])
GO
ALTER TABLE [dbo].[Couple] CHECK CONSTRAINT [FK_Couple_DanceType]
GO
ALTER TABLE [dbo].[Couple]  WITH CHECK ADD  CONSTRAINT [FK_Couple_HeatList] FOREIGN KEY([HeatListID])
REFERENCES [dbo].[HeatList] ([HeatListID])
GO
ALTER TABLE [dbo].[Couple] CHECK CONSTRAINT [FK_Couple_HeatList]
GO
ALTER TABLE [dbo].[Couple]  WITH CHECK ADD  CONSTRAINT [FK_Couple_Pro] FOREIGN KEY([ProID])
REFERENCES [dbo].[Pro] ([ProID])
GO
ALTER TABLE [dbo].[Couple] CHECK CONSTRAINT [FK_Couple_Pro]
GO
