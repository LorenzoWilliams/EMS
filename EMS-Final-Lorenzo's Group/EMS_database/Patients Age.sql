CREATE VIEW [Patients_Age] AS
Select FirstName,LastName,year(getdate())-year([D.O.B]) as age from Patients;
