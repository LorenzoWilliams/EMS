use Ember_medical_service_db;


select * from Patients;
select * from Bills;
select * from Visits;
select * from Payments;
select dbo.getMaxTotal(); 
select dbo.getMaxHeight(); 
select * from dbo.AppointmentRange('2019-01-01','2019-12-31');
select * from dbo.AppointmentScheduled('2019-12-27','12:00');
