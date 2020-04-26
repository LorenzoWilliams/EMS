create view [staff_members] as
select FirstName[First Name], Last_Name[Last Name], Gender,
Department_id[Department], Position_id, Address,Email,Phone
from ((Receptionists r
inner join Departments d on d.id = r.Department_id)
inner join Positions p on p.id = r.Position_id)
UNION
select FirstName[First Name], Last_Name[Last Name], Gender,
Department_id[Department], Position_id, Address,Email,Phone
from ((Nurses n
inner join Departments d on d.id = n.Department_id)
inner join Positions p on p.id = n.Position_id)
UNION
select FirstName[First Name], Last_Name[Last Name], Gender,
Department_id[Department], Position_id, Address,Email,Phone
from ((Physicians ph
inner join Departments d on d.id = ph.Department_id)
inner join Positions p on p.id = ph.Position_id)

--use Ember_medical_service_db;