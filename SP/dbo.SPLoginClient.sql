CREATE PROCEDURE [dbo].SPLoginClient
(
	@email varchar(50),
	@ppassword varchar(50)	
)
AS
	SET NOCOUNT OFF;

	
 SELECT passengerId, title, firstName, lastName, dob, email, ppassword, phone, address FROM ClientTable WHERE (email = @email)