Create View [dbo].[uvw_System_SelectionDefinition]
As
	Select 
		[Tb].* 
		, [Bd].Name As [System_BindDefinition_Name]
	From 
		System_SelectionDefinition As [Tb]
		Left Join System_BindDefinition As [Bd]
			On [Bd].System_BindDefinitionID = [Tb].System_BindDefinitionID