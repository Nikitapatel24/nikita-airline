CREATE PROCEDURE [dbo].SPInsertClient
(
	@title varchar(50),
	@firstName varchar(50),
	@lastName varchar(50),
	@dob varchar(50),
	@email varchar(50),
	@ppassword varchar(50),
	@phone varchar(50),
	@address varchar(50)
	
)
AS
	SET NOCOUNT OFF;
INSERT INTO [ClientTable] ([title], [firstName], [lastName], [dob], [email], [ppassword], [phone], [address]) VALUES ( @title, @firstName, @lastName, @dob, @email, @ppassword, @phone, @address);
	
return  SCOPE_IDENTITY()