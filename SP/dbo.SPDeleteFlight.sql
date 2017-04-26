CREATE PROCEDURE [dbo].SPDeleteFlight
(
	@Original_flightId varchar(50)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [FlightsTable] WHERE (([flightId] = @Original_flightId))