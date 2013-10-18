Create Function [dbo].[udf_DataObjects_TextFiller]
(
@TextInput As VarChar(8000),
@Filler As VarChar(1),
@TextLength Int
)
Returns VarChar(8000)
As
Begin
	Declare @ReturnValue VarChar(8000)
	Set @ReturnValue = Right(Replicate(@Filler,@TextLength) + Ltrim(Left(IsNull(@TextInput,''),@TextLength)),@TextLength) 
	Return @ReturnValue	
End
