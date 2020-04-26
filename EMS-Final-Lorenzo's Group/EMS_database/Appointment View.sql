CREATE VIEW [Appointment_View] AS
SELECT a.Date,convert(varchar(8),[Time],0) As [Time],p.FirstName,p.LastName,ph.title, ph.Last_Name
FROM Appointments a
JOIN Patients p on p.id = a.Patient_id
JOIN Physicians ph on ph.id = a.Physician_id



--use Ember_medical_service_db;