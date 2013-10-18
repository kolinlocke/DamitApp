Create View [dbo].[uvw_Pinalaba_Damit]
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
