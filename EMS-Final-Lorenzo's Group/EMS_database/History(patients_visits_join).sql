use Ember_medical_service_db;

select p.FirstName'First Name',p.LastName'Last Name',v.Date,v.Blood_Pressure'Blood Pressure',
v.Blood_Sugar'Blood Sugar',v.Symptoms,v.Diagnosis,v.Prescription,v.Comments
from Patients p
inner join Visits v on p.id = v.Patient_id;




