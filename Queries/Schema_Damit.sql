USE [Damit]
GO
/****** Object:  UserDefinedFunction [dbo].[udf_DataObjects_GetTableDef]    Script Date: 10/18/2013 20:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_DataObjects_GetTableDef]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'Create Function [dbo].[udf_DataObjects_GetTableDef]
(@TableName VarChar(Max))	
Returns Table
As
Return
	(
	Select
		sCol.Column_id
		, sCol.Name As [ColumnName]
		, sTyp.Name As [DataType]
		, sCol.max_length As [Length]
		, sCol.Precision
		, sCol.Scale
		, sCol.Is_Identity As [IsIdentity]
		, Cast
		(
			(
			Case Count(IsCcu.Column_Name)
				When 0 Then 0
				Else 1
			End
			) 
		As Bit) As IsPk
	From 
		Sys.Columns As sCol
		Left Join Sys.Types As sTyp
			On sCol.system_type_id = sTyp.system_type_id
			And [sCol].User_Type_ID = [sTyp].User_Type_ID
		Inner Join Sys.Tables As sTab
			On sCol.Object_ID = sTab.Object_ID
		Inner Join Sys.Schemas As sSch
			On sSch.Schema_ID = sTab.Schema_ID
		Left Join Sys.Key_Constraints As Skc
			On sTab.Object_Id = Skc.Parent_Object_Id
			And Skc.Type = ''PK''
		Left Join INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE As IsCcu
			On Skc.Name = IsCcu.Constraint_Name
			And sTab.Name = IsCcu.Table_Name
			And sCol.Name = IsCcu.Column_Name
	Where
		sSch.Name + ''.'' + sTab.Name = @TableName
		And sCol.Is_Computed = 0
	Group By
		sCol.Name
		, sTyp.Name
		, sCol.max_length
		, sCol.Precision
		, sCol.Scale
		, sCol.Is_Identity
		, sCol.Column_id
	)


' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[udf_DataObjects_ConvertDate]    Script Date: 10/18/2013 20:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_DataObjects_ConvertDate]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'Create Function [dbo].[udf_DataObjects_ConvertDate]
(
@DateInput DateTime	
	
)
Returns DateTime
As
Begin
	Declare @DateOutput DateTime
	
	Set @DateOutput = (Convert(DateTime,(Cast(DatePart(yyyy,@DateInput) as VarChar)
			+ ''-'' + 
			Cast(DatePart(mm,@DateInput) as VarChar)
			+ ''-'' + 
			Cast(DatePart(dd,@DateInput) as VarChar)),102))
	Return @DateOutput
End
' 
END
GO
/****** Object:  Table [dbo].[System_SelectionDefinition_TableKey]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[System_SelectionDefinition_TableKey]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[System_SelectionDefinition_TableKey](
	[System_SelectionDefinition_TableKeyID] [bigint] NOT NULL,
	[System_SelectionDefinitionID] [bigint] NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_System_SelectionDefinition_TableKey] PRIMARY KEY CLUSTERED 
(
	[System_SelectionDefinition_TableKeyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[System_SelectionDefinition]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[System_SelectionDefinition]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[System_SelectionDefinition](
	[System_SelectionDefinitionID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](1000) NULL,
	[TableName] [varchar](1000) NULL,
	[TableKey] [varchar](50) NULL,
	[Desc] [varchar](1000) NULL,
	[Condition] [varchar](8000) NULL,
	[Sort] [varchar](8000) NULL,
	[Window_Width] [int] NULL,
	[Window_Height] [int] NULL,
	[IsMultipleSelect] [bit] NULL,
	[System_BindDefinitionID] [bigint] NULL,
 CONSTRAINT [PK_System_SelectionDefinition] PRIMARY KEY CLUSTERED 
(
	[System_SelectionDefinitionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[System_Modules_Images]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[System_Modules_Images]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[System_Modules_Images](
	[System_Modules_ImagesID] [bigint] NOT NULL,
	[IconIndex] [bigint] NULL,
	[ImagePath] [varchar](1000) NULL,
	[SelectedImagePath] [varchar](1000) NULL,
 CONSTRAINT [PK_System_Modules_Images] PRIMARY KEY CLUSTERED 
(
	[System_Modules_ImagesID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[System_Modules_AccessLib]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[System_Modules_AccessLib]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[System_Modules_AccessLib](
	[System_Modules_AccessLibID] [bigint] NOT NULL,
	[Desc] [varchar](50) NULL,
 CONSTRAINT [PK_System_Modules_AccessLib] PRIMARY KEY CLUSTERED 
(
	[System_Modules_AccessLibID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[System_Modules_Access]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[System_Modules_Access]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[System_Modules_Access](
	[System_Modules_AccessID] [bigint] NOT NULL,
	[System_ModulesID] [bigint] NULL,
	[System_Modules_AccessLibID] [bigint] NULL,
 CONSTRAINT [PK_System_Modules_Access] PRIMARY KEY CLUSTERED 
(
	[System_Modules_AccessID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[System_Modules]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[System_Modules]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[System_Modules](
	[System_ModulesID] [bigint] NOT NULL,
	[Name] [varchar](1000) NULL,
	[Code] [varchar](1000) NULL,
	[IsHO] [bit] NULL,
	[IsBranch] [bit] NULL,
	[IsWarehouse] [bit] NULL,
	[IsHidden] [bit] NULL,
	[PageUrl_List] [varchar](1000) NULL,
	[PageUrl_Details] [varchar](1000) NULL,
	[FormName] [varchar](1000) NULL,
	[FormList] [varchar](1000) NULL,
	[FormDetail] [varchar](1000) NULL,
	[Arguments] [varchar](1000) NULL,
	[Parent_System_ModulesID] [bigint] NULL,
	[IconIndex] [int] NULL,
	[OrderIndex] [int] NULL,
 CONSTRAINT [PK_System_Modules_1] PRIMARY KEY CLUSTERED 
(
	[System_ModulesID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[System_LookupPartyType]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[System_LookupPartyType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[System_LookupPartyType](
	[System_LookupPartyTypeID] [bigint] NOT NULL,
	[Name] [varchar](50) NULL,
	[TableName] [varchar](100) NULL,
	[FieldName] [varchar](100) NULL,
 CONSTRAINT [PK_System_LookupPartyType] PRIMARY KEY CLUSTERED 
(
	[System_LookupPartyTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[System_Lookup_Details]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[System_Lookup_Details]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[System_Lookup_Details](
	[System_Lookup_DetailsID] [bigint] NOT NULL,
	[System_LookupID] [bigint] NOT NULL,
	[Name] [varchar](50) NULL,
	[Desc] [varchar](50) NULL,
	[Value] [varchar](50) NULL,
	[OrderIndex] [int] NULL,
 CONSTRAINT [PK_System_Lookup_Details] PRIMARY KEY CLUSTERED 
(
	[System_Lookup_DetailsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[System_Lookup]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[System_Lookup]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[System_Lookup](
	[System_LookupID] [bigint] NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_System_Lookup] PRIMARY KEY CLUSTERED 
(
	[System_LookupID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[System_DocumentSeries]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[System_DocumentSeries]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[System_DocumentSeries](
	[System_DocumentSeriesID] [bigint] NOT NULL,
	[ModuleName] [varchar](1000) NULL,
	[TableName] [varchar](1000) NULL,
	[FieldName] [varchar](1000) NULL,
	[Desc] [varchar](1000) NULL,
	[Prefix] [varchar](50) NULL,
	[Digits] [int] NULL,
 CONSTRAINT [PK_System_SeriesParameters] PRIMARY KEY CLUSTERED 
(
	[System_DocumentSeriesID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[System_BindDefinition_Field]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[System_BindDefinition_Field]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[System_BindDefinition_Field](
	[System_BindDefinition_FieldID] [bigint] NOT NULL,
	[System_BindDefinitionID] [bigint] NULL,
	[Name] [varchar](1000) NULL,
	[Desc] [varchar](1000) NULL,
	[System_LookupID_FieldType] [int] NULL,
	[IsReadOnly] [bit] NULL,
	[Width] [int] NULL,
	[NumberFormat] [varchar](50) NULL,
	[System_LookupID_HorizontalAlign] [bigint] NULL,
	[ClientSideBeginEdit] [varchar](1000) NULL,
	[ClientSideEndEdit] [varchar](1000) NULL,
	[CommandName] [varchar](1000) NULL,
	[System_LookupID_ButtonType] [int] NULL,
	[FieldText] [varchar](50) NULL,
	[OrderIndex] [int] NULL,
	[IsHidden] [bit] NULL,
	[IsFilter] [bit] NULL,
 CONSTRAINT [PK_BindDefinition_Field] PRIMARY KEY CLUSTERED 
(
	[System_BindDefinition_FieldID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[System_BindDefinition]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[System_BindDefinition]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[System_BindDefinition](
	[System_BindDefinitionID] [bigint] NOT NULL,
	[Name] [varchar](1000) NULL,
 CONSTRAINT [PK_BindDefinition] PRIMARY KEY CLUSTERED 
(
	[System_BindDefinitionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RowProperty]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RowProperty]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[RowProperty](
	[RowPropertyID] [bigint] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](100) NULL,
	[Name] [varchar](1000) NULL,
	[IsActive] [bigint] NULL,
	[Remarks] [varchar](1000) NULL,
	[DateCreated] [datetime] NULL,
	[DateUpdated] [datetime] NULL,
 CONSTRAINT [PK_RowProperty] PRIMARY KEY CLUSTERED 
(
	[RowPropertyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pinalaba_Damit]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pinalaba_Damit]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Pinalaba_Damit](
	[Pinalaba_DamitID] [bigint] IDENTITY(1,1) NOT NULL,
	[PinalabaID] [bigint] NULL,
	[DamitID] [bigint] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Pinalaba_Damit] PRIMARY KEY CLUSTERED 
(
	[Pinalaba_DamitID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Pinalaba]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pinalaba]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Pinalaba](
	[PinalabaID] [bigint] IDENTITY(1,1) NOT NULL,
	[RowPropertyID] [bigint] NULL,
	[MayariID] [bigint] NULL,
	[DatePinalaba] [datetime] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Pinalaba] PRIMARY KEY CLUSTERED 
(
	[PinalabaID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Mayari]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Mayari]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Mayari](
	[MayariID] [bigint] IDENTITY(1,1) NOT NULL,
	[RowPropertyID] [bigint] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Mayari] PRIMARY KEY CLUSTERED 
(
	[MayariID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Lookup_Details]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Lookup_Details]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Lookup_Details](
	[Lookup_DetailsID] [bigint] IDENTITY(1,1) NOT NULL,
	[LookupID] [bigint] NULL,
	[Desc] [varchar](50) NULL,
	[IsActive] [bit] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Lookup_Items] PRIMARY KEY CLUSTERED 
(
	[Lookup_DetailsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lookup]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Lookup]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Lookup](
	[LookupID] [bigint] NOT NULL,
	[Name] [varchar](50) NULL,
	[Desc] [varchar](1000) NULL,
	[Lookup_DetailsID_Default] [bigint] NULL,
	[IsLookup_Details] [bit] NULL,
	[Lookup_Details_Other_TableName] [varchar](1000) NULL,
	[Lookup_Details_Other_DescField] [varchar](1000) NULL,
	[Lookup_Details_Other_Condition] [varchar](1000) NULL,
	[Lookup_Details_Other_Url] [varchar](1000) NULL,
	[IsHidden] [bit] NULL,
 CONSTRAINT [PK_Lookup] PRIMARY KEY CLUSTERED 
(
	[LookupID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DataObjects_Series]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DataObjects_Series]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DataObjects_Series](
	[TableName] [varchar](1000) NULL,
	[LastID] [bigint] NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DataObjects_Parameters]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DataObjects_Parameters]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DataObjects_Parameters](
	[ParameterName] [varchar](50) NULL,
	[ParameterValue] [varchar](8000) NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Damit]    Script Date: 10/18/2013 20:17:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Damit]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Damit](
	[DamitID] [bigint] IDENTITY(1,1) NOT NULL,
	[RowPropertyID] [bigint] NULL,
	[MayariID] [bigint] NULL,
	[LookupID_Category] [bigint] NULL,
	[LookupID_Brand] [bigint] NULL,
	[LookupID_Color] [bigint] NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Damit] PRIMARY KEY CLUSTERED 
(
	[DamitID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  UserDefinedFunction [dbo].[udf_TextFiller]    Script Date: 10/18/2013 20:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_TextFiller]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
--	Author:		
--		Kolin Locke
--	Create date: 	
--		2010.02.25.0051
--	Description:	
--		[???]
-- =============================================
CREATE FUNCTION [dbo].[udf_TextFiller]
(
@TextInput As VarChar(8000),
@Filler As VarChar(1),
@TextLength Int
)
RETURNS VarChar(8000)
AS
BEGIN
	Declare @ReturnValue VarChar(8000)
	Set @ReturnValue = Right(Replicate(@Filler,@TextLength) + Ltrim(Left(IsNull(@TextInput,''''),@TextLength)),@TextLength) 
	Return @ReturnValue
	
END
' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[udf_DataObjects_TextFiller]    Script Date: 10/18/2013 20:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_DataObjects_TextFiller]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'Create Function [dbo].[udf_DataObjects_TextFiller]
(
@TextInput As VarChar(8000),
@Filler As VarChar(1),
@TextLength Int
)
Returns VarChar(8000)
As
Begin
	Declare @ReturnValue VarChar(8000)
	Set @ReturnValue = Right(Replicate(@Filler,@TextLength) + Ltrim(Left(IsNull(@TextInput,''''),@TextLength)),@TextLength) 
	Return @ReturnValue	
End
' 
END
GO
/****** Object:  View [dbo].[uvw_Lookup_Details]    Script Date: 10/18/2013 20:17:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[uvw_Lookup_Details]'))
EXEC dbo.sp_executesql @statement = N'CREATE View [dbo].[uvw_Lookup_Details]
As
	Select 
		[Tbd].*
		, [Tb].[Name] As [Lookup_Name]
	From 
		Lookup_Details As [Tbd]
		Left Join Lookup As [Tb]
			On [Tb].LookupID = [Tbd].LookupID

'
GO
/****** Object:  StoredProcedure [dbo].[usp_System_Modules_Load]    Script Date: 10/18/2013 20:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_System_Modules_Load]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[usp_System_Modules_Load]
@UserID As BigInt
As
Begin
	Select Distinct
		[Sm].*
		, [Psm].OrderIndex As [Psm_OrderIndex]
		, [Sm].OrderIndex As [Sm_OrderIndex]
	From 
		System_Modules As [Sm]
		Inner Join uvw_Rights_Details As [Rd]
			On [Rd].System_ModulesID = [Sm].System_ModulesID
			And [Rd].System_Modules_Access_Desc = ''Access''
			And [Rd].IsAllowed = 1
			And IsNull([Sm].IsHidden,0) = 0
		Inner Join uvw_User_Rights As [Ur]
			On [Ur].RightsID = [Rd].RightsID
			And [Ur].IsActive = 1
			And [Ur].UserID = @UserID
		Left Join System_Modules As [Psm]
			On [Psm].System_ModulesID = [Sm].Parent_System_ModulesID
	Order By
		[Psm].OrderIndex
		, [Sm].OrderIndex
End
' 
END
GO
/****** Object:  StoredProcedure [dbo].[usp_DataObjects_Parameter_Set]    Script Date: 10/18/2013 20:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_DataObjects_Parameter_Set]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create Procedure [dbo].[usp_DataObjects_Parameter_Set]
@ParameterName VarChar(Max)
, @ParameterValue VarChar(Max)
As
Begin
	Declare @Ct As Int	
	Select @Ct = Count(1)
	From DataObjects_Parameters
	Where ParameterName = @ParameterName
	
	If @Ct = 0
	Begin
		Insert Into DataObjects_Parameters 
			(ParameterName, ParameterValue) 
		Values 
			(@ParameterName, @ParameterValue)
	End
	Else
	Begin
		Update DataObjects_Parameters 
		Set ParameterValue = @ParameterValue 
		Where ParameterName = @ParameterName
	End
End

' 
END
GO
/****** Object:  StoredProcedure [dbo].[usp_DataObjects_Parameter_Require]    Script Date: 10/18/2013 20:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_DataObjects_Parameter_Require]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create Procedure [dbo].[usp_DataObjects_Parameter_Require]
@ParameterName VarChar(Max)
, @ParameterValue VarChar(Max)
As
Begin
	Declare @Ct As Int	
	Select @Ct = Count(1)
	From DataObjects_Parameters
	Where ParameterName = @ParameterName
	
	If @Ct = 0
	Begin
		Insert Into DataObjects_Parameters 
			(ParameterName, ParameterValue) 
		Values 
			(@ParameterName, @ParameterValue)
	End
End

' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[udf_DataObjects_Parameter_Get]    Script Date: 10/18/2013 20:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_DataObjects_Parameter_Get]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'Create Function [dbo].[udf_DataObjects_Parameter_Get]
(@ParameterName VarChar(Max))
Returns VarChar(Max)
As
Begin
	Declare @ParameterValue As VarChar(Max)		
	Set @ParameterValue = ''''
	
	Declare @Ct As Int	
	Select @Ct = Count(1)
	From DataObjects_Parameters
	Where ParameterName = @ParameterName
	
	If @Ct = 0
	Begin
		Return ''''
	End
	Else
	Begin
		Select @ParameterValue = ParameterValue
		From DataObjects_Parameters
		Where ParameterName = @ParameterName
	End
	
	Return @ParameterValue
End

' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[udf_System_BindDefinition]    Script Date: 10/18/2013 20:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_System_BindDefinition]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE Function [dbo].[udf_System_BindDefinition]
(
	@Name VarChar(Max)
)	
Returns Table
As
Return
	(
	Select 
		[Tbd].*
	From 
		System_BindDefinition_Field As [Tbd]
		Inner Join System_BindDefinition As [Tb]
			On [Tb].System_BindDefinitionID = [Tbd].System_BindDefinitionID
	Where
		[Tb].Name = @Name
	)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[usp_DataObjects_GetTableDef]    Script Date: 10/18/2013 20:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_DataObjects_GetTableDef]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[usp_DataObjects_GetTableDef]
@TableName VarChar(Max)
, @SchemaName VarChar(Max) = ''''
As
Set NOCOUNT On
Begin
	
	If IsNull(@SchemaName, '''') = ''''
	Begin
		Set @SchemaName = ''dbo''
	End
	
	Select *
	From [udf_DataObjects_GetTableDef](@SchemaName + ''.'' + @TableName)
	Order By Column_Id
	
End
' 
END
GO
/****** Object:  StoredProcedure [dbo].[usp_DataObjects_GetNextID]    Script Date: 10/18/2013 20:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_DataObjects_GetNextID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create Procedure [dbo].[usp_DataObjects_GetNextID]
@TableName VarChar(Max)
As
Begin
	Declare @LastID BigInt
	Declare @Ct Int

	Select @Ct = Count(*)
	From DataObjects_Series
	Where TableName = @TableName
		
	If @Ct = 0
	Begin
		Insert Into DataObjects_Series (TableName, LastID) Values (@TableName, 0)
	End

	Select @LastID = LastID
	From DataObjects_Series
	Where TableName = @TableName
		
	Set @LastID = @LastID + 1
		
	Update DataObjects_Series
	Set LastID = @LastID 
	Where TableName = @TableName
	
	Select @LastID As [ID]
	
End

' 
END
GO
/****** Object:  View [dbo].[uvw_System_SelectionDefinition]    Script Date: 10/18/2013 20:17:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[uvw_System_SelectionDefinition]'))
EXEC dbo.sp_executesql @statement = N'Create View [dbo].[uvw_System_SelectionDefinition]
As
	Select 
		[Tb].* 
		, [Bd].Name As [System_BindDefinition_Name]
	From 
		System_SelectionDefinition As [Tb]
		Left Join System_BindDefinition As [Bd]
			On [Bd].System_BindDefinitionID = [Tb].System_BindDefinitionID'
GO
/****** Object:  View [dbo].[uvw_System_Modules_AccessLib]    Script Date: 10/18/2013 20:17:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[uvw_System_Modules_AccessLib]'))
EXEC dbo.sp_executesql @statement = N'Create  View [dbo].[uvw_System_Modules_AccessLib]
As
	Select
		Row_Number() Over (Order By System_ModulesID, System_Modules_AccessLibID) As [vw_System_Modules_AccessLibID],
		Sm.System_ModulesID,
		Sma.System_Modules_AccessLibID,
		Sm.[Name] As [System_Modules_Name],
		Sm.Code As [System_Modules_Code],
		Sma.[Desc]
	From
		System_Modules As Sm,
		System_Modules_AccessLib As Sma
'
GO
/****** Object:  View [dbo].[uvw_System_Modules]    Script Date: 10/18/2013 20:17:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[uvw_System_Modules]'))
EXEC dbo.sp_executesql @statement = N'CREATE View [dbo].[uvw_System_Modules]
As
	Select
		[Sm].*
		, [Psm].OrderIndex As [Parent_OrderIndex]
	From 
		System_Modules As [Sm]
		Left Join System_Modules As [Psm]
			On [Psm].System_ModulesID = [Sm].Parent_System_ModulesID
'
GO
/****** Object:  View [dbo].[uvw_System_Lookup_Details]    Script Date: 10/18/2013 20:17:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[uvw_System_Lookup_Details]'))
EXEC dbo.sp_executesql @statement = N'CREATE View [dbo].[uvw_System_Lookup_Details]
As
	Select 
		[Tbd].*
		, [Tb].[Name] As [Lookup_Name]
	From 
		System_Lookup_Details As [Tbd]
		Left Join System_Lookup As [Tb]
			On [Tb].System_LookupID = [Tbd].System_LookupID

'
GO
/****** Object:  View [dbo].[uvw_RowProperty]    Script Date: 10/18/2013 20:17:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[uvw_RowProperty]'))
EXEC dbo.sp_executesql @statement = N'CREATE View [dbo].[uvw_RowProperty]
As
	Select 
		[Tb].*
		, IsNull([Tb].Code,'''') + '' - '' + IsNull([Tb].Name,'''') As [CodeName]
		, (
		Case IsNull([Tb].IsActive,0)
			When 1 Then ''Yes''
			Else ''No''
		End
		) As [IsActive_Desc]		
	From 
		RowProperty As [Tb]
		'
GO
/****** Object:  View [dbo].[uvw_Mayari]    Script Date: 10/18/2013 20:17:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[uvw_Mayari]'))
EXEC dbo.sp_executesql @statement = N'Create View [dbo].[uvw_Mayari]
As
	Select
		[Tb].*
		
		, [Rp].Code
		, [Rp].Name
		, [Rp].CodeName
		, [Rp].IsActive
		, [Rp].IsActive_Desc
		, [Rp].Remarks
		, [Rp].DateCreated
		, [Rp].DateUpdated
		
		, [Rp].Code As [MayariCode]
		, [Rp].Name As [MayariName]
		, [Rp].CodeName As [MayariCodeName]
		
	From
		Mayari As [Tb]
		Left Join uvw_RowProperty As [Rp]
			On [Rp].RowPropertyID = [Tb].RowPropertyID
		
'
GO
/****** Object:  View [dbo].[uvw_System_Modules_Access]    Script Date: 10/18/2013 20:17:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[uvw_System_Modules_Access]'))
EXEC dbo.sp_executesql @statement = N'CREATE View [dbo].[uvw_System_Modules_Access]
As
	Select Top (100) Percent
		IsNull(Sm.[Parent_System_Modules_Name],''Root'') As [Parent_System_Modules_Name]
		, Smal.[System_Modules_Name]
		, Smal.[System_Modules_Code]
		, Smal.[Desc]
		, Sm.Parent_System_ModulesID
		, Sma.*
	From
		System_Modules_Access As [Sma]
		Left Join uvw_System_Modules_AccessLib As [Smal]
			On Smal.System_ModulesID = Sma.System_ModulesID
			And Smal.System_Modules_AccessLibID = Sma.System_Modules_AccessLibID
		Left Join
			(
			Select Top (100) Percent
				Psm.[Name] As [Parent_System_Modules_Name],
				Sm.System_ModulesID,
				Sm.Parent_System_ModulesID,
				Sm.OrderIndex,
				Sm.[Name] As [System_Modules_Name],
				Sm.[Code] As  [System_Modules_Code]			
			From 
				System_Modules As Sm
				Left Join System_Modules As Psm
					On Sm.Parent_System_ModulesID = Psm.System_ModulesID
			Order By
				Sm.Parent_System_ModulesID,
				Sm.OrderIndex
			) As Sm
			On Sm.System_ModulesID = Sma.System_ModulesID

	Order By
		Sm.Parent_System_ModulesID,
		Sm.OrderIndex
'
GO
/****** Object:  UserDefinedFunction [dbo].[udf_System_Lookup]    Script Date: 10/18/2013 20:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_System_Lookup]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'CREATE Function [dbo].[udf_System_Lookup]
(
	@Lookup_Name VarChar(Max)
)	
Returns Table
As
Return
	(
	Select
		System_Lookup_DetailsID As [System_LookupID]
		, [Name]
		, [Desc]
		, OrderIndex
	From uvw_System_Lookup_Details
	Where 
		Lookup_Name = @Lookup_Name
	)
' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[udf_Lookup]    Script Date: 10/18/2013 20:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[udf_Lookup]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'Create Function [dbo].[udf_Lookup]
(
	@Lookup_Name VarChar(Max)
)	
Returns Table
As
Return
	(
	Select 
		Lookup_DetailsID As [LookupID]
		, [Desc]
	From uvw_Lookup_Details
	Where 
		Lookup_Name = @Lookup_Name
		And IsNull(IsDeleted,0) = 0
		And IsNull(IsActive,0) = 1
	)
' 
END
GO
/****** Object:  StoredProcedure [dbo].[usp_DataObjects_Parameter_Get]    Script Date: 10/18/2013 20:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_DataObjects_Parameter_Get]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create Procedure [dbo].[usp_DataObjects_Parameter_Get]
@ParameterName VarChar(Max)
As
Begin
	Declare @ParameterValue As VarChar(Max)		
	Set @ParameterValue = ''''
	
	Declare @Ct As Int	
	Select @Ct = Count(1)
	From DataObjects_Parameters
	Where ParameterName = @ParameterName
	
	If @Ct = 0
	Begin
		Exec usp_DataObjects_Parameter_Require @ParameterName
	End
	Else
	Begin
		Select @ParameterValue = ParameterValue
		From DataObjects_Parameters
		Where ParameterName = @ParameterName
	End
	
	Select @ParameterValue As [ParameterValue]
End

' 
END
GO
/****** Object:  View [dbo].[uvw_Damit]    Script Date: 10/18/2013 20:17:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[uvw_Damit]'))
EXEC dbo.sp_executesql @statement = N'CREATE View [dbo].[uvw_Damit]
As
	Select
		[Tb].*
		
		, [Rp].Code
		, [Rp].Name
		, [Rp].CodeName
		, [Rp].IsActive
		, [Rp].IsActive_Desc
		, [Rp].Remarks
		, [Rp].DateCreated
		, [Rp].DateUpdated
		
		, [Rp].Code As [DamitCode]
		, [Rp].Name As [DamitName]
		, [Rp].CodeName As [DamitCodeName]
		
		, [Lkp_Category].[Desc] As [LkpDesc_Category]
		, [Lkp_Brand].[Desc] As [LkpDesc_Brand]
		, [Lkp_Color].[Desc] As [LkpDesc_Color]
		
	From
		Damit As [Tb]
		Left Join uvw_RowProperty As [Rp]
			On [Rp].RowPropertyID = [Tb].RowPropertyID
		Left Join udf_Lookup(''Category'') As [Lkp_Category]
			On [Lkp_Category].LookupID = [Tb].LookupID_Category
		Left Join udf_Lookup(''Brand'') As [Lkp_Brand]
			On [Lkp_Brand].LookupID = [Tb].LookupID_Brand
		Left Join udf_Lookup(''Color'') As [Lkp_Color]
			On [Lkp_Color].LookupID = [Tb].LookupID_Color

'
GO
/****** Object:  View [dbo].[uvw_Pinalaba]    Script Date: 10/18/2013 20:17:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[uvw_Pinalaba]'))
EXEC dbo.sp_executesql @statement = N'Create View [dbo].[uvw_Pinalaba]
As
	Select
		[Tb].*
		
		, [Rp].Code
		, [Rp].Name
		, [Rp].CodeName
		, [Rp].IsActive
		, [Rp].IsActive_Desc
		, [Rp].Remarks
		, [Rp].DateCreated
		, [Rp].DateUpdated
		
		, [M].MayariCode
		, [M].MayariName
		, [M].MayariCodeName
		
	From
		Pinalaba As [Tb]
		Left Join uvw_RowProperty As [Rp]
			On [Rp].RowPropertyID = [Tb].RowPropertyID
		Left Join uvw_Mayari As [M]	
			On [M].MayariID = [Tb].MayariID
'
GO
/****** Object:  View [dbo].[uvw_Pinalaba_Damit]    Script Date: 10/18/2013 20:17:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[uvw_Pinalaba_Damit]'))
EXEC dbo.sp_executesql @statement = N'CREATE View [dbo].[uvw_Pinalaba_Damit]
As
	Select
		[Tb].*
		
		, [D].DamitCode
		, [D].DamitName
		, [D].DamitCodeName
		
	From
		Pinalaba_Damit As [Tb]
		Left Join uvw_Damit As [D]
			On [D].DamitID = [Tb].DamitID

'
GO
