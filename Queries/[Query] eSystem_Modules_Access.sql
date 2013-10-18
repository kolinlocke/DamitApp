--[Query] eSystem_Modules_AccessLib
Select 
	'eSystem_Modules_AccessLib_' + Replace([Desc],' ','_') 
	+ ' = ' + Cast([System_Modules_AccessLibID] As VarChar) As [eSystem_Modules_AccessLib]
From
	System_Modules_AccessLib
Where
	[Desc] <> 'Unused'