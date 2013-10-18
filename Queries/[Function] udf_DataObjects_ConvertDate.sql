Create Function [dbo].[udf_DataObjects_ConvertDate]
(
@DateInput DateTime	
	
)
Returns DateTime
As
Begin
	Declare @DateOutput DateTime
	
	Set @DateOutput = (Convert(DateTime,(Cast(DatePart(yyyy,@DateInput) as VarChar)
			+ '-' + 
			Cast(DatePart(mm,@DateInput) as VarChar)
			+ '-' + 
			Cast(DatePart(dd,@DateInput) as VarChar)),102))
	Return @DateOutput
End
