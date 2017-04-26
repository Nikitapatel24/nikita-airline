CREATE PROCEDURE [dbo].SPInsertFlight
(
	@flightId varchar(50),
	@from varchar(50),
	@to varchar(50),
	@flighttime varchar(50),
	@flightDate varchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [FlightsTable] ([flightId], [from], [to], [flighttime], [flightDate]) VALUES (@flightId, @from, @to, @flighttime, @flightDate);
	
return 0