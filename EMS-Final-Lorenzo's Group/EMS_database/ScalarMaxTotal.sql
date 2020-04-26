use Ember_medical_service_db;

-- ================================================
-- Template generated from Template Explorer using:
-- Create Scalar Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION getMaxTotal 
(
	-- Add the parameters for the function here

)
RETURNS float
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Total float

	-- Add the T-SQL statements to compute the return value here
	SELECT @Total = max(Total) from Bills

	-- Return the result of the function
	RETURN @Total

END
GO

