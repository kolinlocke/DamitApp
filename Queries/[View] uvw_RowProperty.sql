Create View [dbo].[uvw_RowProperty]
As
	Select 
		[Tb].*
		, IsNull([Tb].Code,'') + ' - ' + IsNull([Tb].Name,'') As [CodeName]
		, (
		Case IsNull([Tb].IsActive,0)
			When 1 Then 'Yes'
			Else 'No'
		End
		) As [IsActive_Desc]		
	From 
		RowProperty As [Tb]
		