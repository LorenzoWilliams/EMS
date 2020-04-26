-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE InputPatients
	-- Add the parameters for the stored procedure here
	@Fname nvarchar (30),  
	@Lname nvarchar (30),
	@Gender varchar (1),
	@DOB date,
	@Address nvarchar (100),
	@email nvarchar (50),
	@phone nvarchar (15)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Patients ([FirstName],[LastName],[Gender],[D.O.B],[Address],[Email],[Phone] ) values
	(@Fname, @Lname, @Gender, @DOB, @Address, @email, @phone)
END
GO

--when ENTERING DOB use ''
-- This procedure is to allow staff to input/enter patient's information into the system more seemlessly