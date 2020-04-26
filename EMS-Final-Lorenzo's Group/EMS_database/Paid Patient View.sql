use Ember_medical_service_db;

go

CREATE VIEW [Paid_Patient] AS
SELECT p.FirstName'First Name',p.LastName'Last Name',pa.Pay_Status'Pay Status'
FROM Payments pa
JOIN Patients p on p.id = pa.Patient_id

WHERE Pay_status = 'paid';


