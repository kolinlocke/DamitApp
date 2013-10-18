/*
[Query] eSystem_Lookup
*/

Select Replace([Lookup_Name], ' ','_') + '_' + Replace([Name], ' ','_') + ' = ' + Cast(System_Lookup_DetailsID As VarChar) + ',' As eSystem_Lookup
From uvw_System_Lookup_Details
Order By System_LookupID, System_Lookup_DetailsID