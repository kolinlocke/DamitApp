Create View [dbo].[uvw_Damit]
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
		Left Join udf_Lookup('Category') As [Lkp_Category]
			On [Lkp_Category].LookupID = [Tb].LookupID_Category
		Left Join udf_Lookup('Brand') As [Lkp_Brand]
			On [Lkp_Brand].LookupID = [Tb].LookupID_Brand
		Left Join udf_Lookup('Color') As [Lkp_Color]
			On [Lkp_Color].LookupID = [Tb].LookupID_Color
