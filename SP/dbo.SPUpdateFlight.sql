CREATE PROCEDURE [dbo].SPUpdateFlight
(
	@flightId varchar(50),
	@from varchar(50),
	@to varchar(50),
	@flighttime varchar(50),
	@flightDate varchar(50),
	@Original_flightId varchar(50)
)
AS
	SET NOCOUNT OFF;
UPDATE [FlightsTable] SET [flightId] = @flightId, [from] = @from, [to] = @to, [flighttime] = @flighttime, [flightDate] = @flightDate WHERE (([flightId] = @Original_flightId));
	
SELECT flightId, [from], [to], flighttime, flightDate FROM FlightsTable WHERE (flightId = @flightId)