CREATE PROCEDURE [dbo].SPMyBookings
	@client varchar(50)
AS
	Select * from bookingTable Inner Join ClientTable on ClientTable.passengerId = bookingTable.client
Inner Join FlightsTable on FlightsTable.flightId = bookingTable.flightName where bookingTable.client = @client
RETURN 0