CREATE PROCEDURE [dbo].SPDeleteBooking
(
	@Original_bookingId int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [bookingTable] WHERE (([bookingId] = @Original_bookingId))