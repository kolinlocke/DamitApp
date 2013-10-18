Create View [dbo].[uvw_Mayari]
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
		
