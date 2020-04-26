select Patients.Firstname as Patient_firstname, 
Patients.Lastname as Patient_lastname,
Appointments.Date as Date_of_Visit, 
convert(varchar(8),[Time],0) As [Appointment Time],  
Physicians.FirstName as Pysician_Firstname, 
Physicians.Last_Name as Physician_lastname
from Appointments
join Patients on Appointments.Patient_id = Patients.id
join Physicians
on Appointments.Physician_id = Physicians.id