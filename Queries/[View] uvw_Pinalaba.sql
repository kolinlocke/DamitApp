Create View [dbo].[uvw_Pinalaba]
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
