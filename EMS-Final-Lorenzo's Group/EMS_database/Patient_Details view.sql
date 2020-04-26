use Ember_medical_service_db;
go

create view [Patient_Details_View] as
select id,FirstName[First Name], LastName[Last Name], Gender,[D.O.B],
Email,Phone,Address, FirstName_em [Emerg. First Name],LastName_em [Emerg. Last Name],
Phone_em [Emerg. Phone],Address_em [Emerg. Address]
from Patients 

