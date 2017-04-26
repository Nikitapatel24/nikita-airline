CREATE PROCEDURE [dbo].SPInsertBooking
(
	@flightName varchar(50),
	@client varchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [bookingTable] ( [flightName], [client]) VALUES ( @flightName, @client);
	
return 0