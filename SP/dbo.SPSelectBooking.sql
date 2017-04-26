CREATE PROCEDURE [dbo].SPSelectBooking
AS
	SET NOCOUNT ON;
Select * from bookingTable Inner Join ClientTable on ClientTable.passengerId = bookingTable.client
Inner Join FlightsTable on FlightsTable.flightId = bookingTable.flightName
return 0