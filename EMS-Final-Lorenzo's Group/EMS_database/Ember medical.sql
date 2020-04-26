drop database Ember_medical_service_db

create database Ember_medical_service_db;
go

use Ember_medical_service_db;

create table Users(
	id int primary key identity(1,1),
	username nvarchar(50) NOT NULL,
	[password] nvarchar(50) NOT NULL,

);


create table Patients(
	id int primary key identity(1,1),
	FirstName nvarchar(30) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	Gender nvarchar (10)NOT NULL,
	[D.O.B] date NOT NULL,
	[Address] nvarchar(300) NOT NULL,
	Email nvarchar(50) NOT NULL,
	[Phone] nvarchar(15) NOT NULL,
	FirstName_em nvarchar(30),
	LastName_em nvarchar(50),
	[Address_em] nvarchar(300),
	[Phone_em] nvarchar(15),
);

create table Departments(
	id int primary key identity(1,1),
	Department nvarchar(30) NOT NULL,
);

create table Positions(
	id int primary key identity(1,1),
	Position nvarchar(30) NOT NULL,
);


create table Physicians(
	id int primary key identity(1,1),
	Title nvarchar(3) NOT NULL,
	FirstName nvarchar(30) NOT NULL,
	Last_Name nvarchar(50) NOT NULL,
	Gender nvarchar(10) NOT NULL,
	Department_id int FOREIGN KEY REFERENCES Departments(id),
	Position_id int FOREIGN KEY REFERENCES Positions(id),
	[Address] nvarchar(300) NOT NULL,
	Email nvarchar(50) NOT NULL,
	[Phone] nvarchar(15) NOT NULL,
);

create table Nurses(
	id int primary key identity(1,1),
	FirstName nvarchar(30) NOT NULL,
	Last_Name nvarchar(50) NOT NULL,
	Gender nvarchar(10) NOT NULL,
	Department_id int FOREIGN KEY REFERENCES Departments(id),
	Position_id int FOREIGN KEY REFERENCES Positions(id),
	[Address] nvarchar(300) NOT NULL,
	Email nvarchar(50) NOT NULL,
	[Phone] nvarchar(15) NOT NULL,
);

create table Receptionists(
	id int primary key identity(1,1),
	FirstName nvarchar(30) NOT NULL,
	Last_Name nvarchar(50) NOT NULL,
	Gender nvarchar(10) NOT NULL,
	Department_id int FOREIGN KEY REFERENCES Departments(id),
	Position_id int FOREIGN KEY REFERENCES Positions(id),
	[Address] nvarchar(300) NOT NULL,
	Email nvarchar(50) NOT NULL,
	[Phone] nvarchar(15) NOT NULL,
);

create table Appointments(
	id int primary key identity(1,1),
	[Date] date NOT NULL,
	[Time] Time NOT NULL,
	Physician_id int FOREIGN KEY REFERENCES Physicians(id) on delete cascade,
	Patient_id int FOREIGN KEY REFERENCES Patients(ID) on delete cascade,
	Comments nvarchar(300) NOT NULL,
);

create table Visits(
	id int primary key identity(1,1),
	[Date] date NOT NULL,
	[Time] time NOT NULL,
	Receptionist_id int FOREIGN KEY REFERENCES Receptionists(id) on delete cascade,
	Patient_id int FOREIGN KEY REFERENCES Patients(id) on delete cascade,
	Nurse_id int FOREIGN KEY REFERENCES Nurses(id) on delete cascade,
	Weight_lb float(6) NOT NULL,
	Height_cm float(7) NOT NULL,
	Blood_Pressure nvarchar(10) NOT NULL,
	Blood_Sugar nvarchar(10) NOT NULL,
	Physician_id int FOREIGN KEY REFERENCES Physicians(id) on delete cascade,
	Symptoms nvarchar(1000) NOT NUll,
	Diagnosis nvarchar(1000) NOT NUll,
	Prescription nvarchar(300) NOT NULL,
	Comments nvarchar(300) NOT NULL,
);

create table Bills(
	id int primary key identity(1,1),
	[Date] date NOT NULL,
	Currency nvarchar(3) NOT NULL,
	Total float(9) NOT NUll,
	Patient_id int FOREIGN KEY REFERENCES Patients(id),
);

create table Payments(
	id int primary key identity(1,1),
	Receptionist_id int FOREIGN KEY REFERENCES Receptionists(id),
	Bill_id int FOREIGN KEY REFERENCES Bills(id) on delete cascade,
	Patient_id int FOREIGN KEY REFERENCES Patients(id),
	Pay_Status nvarchar(30) NOT NULL,
);





INSERT INTO Patients(FirstName,LastName,Gender,[D.O.B],[Address],Email,[Phone])

VALUES ('Lorenzo','Williams','Male','1991-02-12', 'Portmore St. Catherine','L_Williams@yahoo.com','(876)473-1083'), 
        ('Omar','Reid','Male','1973-05-23','Eltham Farm St. Catherine','','(876)985-6589'), 
        ('Lorencio','Williams','Male','2019-05-29','Red Hills Road St. Andrew', '',''),
        ('Sharon','Reid','Female','1976-06-29','Manley Meadows Kingston','Reid.Sharon@gmail.com','(876)435-9021'),
        ('Joseph','Stephens','Male','1996-12-31','Lauriston Avenue St. Andrew','Joseph_S@outlook.com','(876)453-7182'), 
        ('Kip','Smithers','Male','1988-06-22','Beverly Hills Kingston','freshprince654@gmail.com','(876)989-4423'), 
        ('Maxwell','Sheffield','Male','1966-09-21','Oxford Terrace Kingston','M.Sheffield209@hotmail.com','(876)987-6543'),
        ('Lucille','Ball','Female','2017-05-23','Stanton Terrace Kinston','',''),
        ('Vivian','Banks','Female','1975-01-11','Cassia Park Road Kingston','banks_belair@rocketmail.com','(876)990-3213'), 
		('Frank','Finely','Female','1999-09-19','New Kingston St. Andrew','Frank.finely@live.com','(876)456-9023'), 
		('Tom','Hanks','Male','1967-04-05','Red Hills Road St. Andrew','polar_express@yahoo.com','(876)231-9965'), 
		('Ricardo','Gordon','Male','1999-02-13','Tavern Avenue Kingston','','(876)396-9785'), 
		('CeCe','Babcock','Female','1976-08-17','Elletson Flats St. Andrew','jnrsecretary@sheffpro.com','(876)428-4655'), 
		('George','Clooney','Male','1945-09-10','Chelsea Avenue Kingston','g.clooney@hotmail.com','(876)592-4100'), 
		('Scarlett','Johansen','Female','1979-09-14','Red Hills Road St. Andrew','','(876)901-2468');
 
 INSERT INTO Departments(Department)

 VALUES ('Physician'),('Nurse'),('Receptionists');

 INSERT INTO Positions(Position)

 VALUES ('General Practitioner'),('Cardiologist'),('Paediatrician'),
		('Obstetrician Gynaecologist'),('Dermatologist'),('Matron'),
		('Enrrolled Nurse'),('Registered Nurse'),('Receptionist');


INSERT INTO Physicians(Title,FirstName,Last_Name,Gender,Department_id,Position_id,[Address],Email,[Phone]) 

VALUES ('DR','Eric','Burke','Male','1','1','Retreat St. Thomas','e.burke@ems.org','(876)978-2476'), 
('DR','Richard','Notice','Male','1','2','Cardello Avenue Kingston','r.notice@ems.org','(876)787-5743'), 
('DR','Aung','Tin','Male','1','1','Beverly Hills Kingston','a.tin@ems.org','(876)9983745'), 
('DR','Isabela','Laudez','Female','1','3','Strawberry Hill St. Andrew','i.laudez@ems.org','(876)5694387'), 
('DR','Neville','Folkes','Male','1','4','West Albion Heights St. Thomas','n.folkes@ems.org','(876)7683927'), 
('DR','Kenneth','Appiah','Male','1','5','Mona Heights Kingston','k.appiah@ems.org','(876)9090987'); 

INSERT INTO Nurses(FirstName,Last_Name,Gender,Department_id,Position_id,[Address],Email,[Phone]) 

VALUES ('Anna','Lee','Female','2','6','Tinsen Pen Kingston','a.lee@ems.org.','(876)4590234'), 
('Brillena','Knight','Female','2','7','White Horses St. Thomas','b.knight@ems.org','(876)3447178'), 
('Nola','Frith','Female','2','8','August Town Kingston','n.frith@ems.org','(876)9698757');

INSERT INTO Receptionists(FirstName,Last_Name,Gender,Department_id,Position_id,[Address],Email,[Phone]) 

VALUES ('Jamie','Lee','Female','3','9','Tavern St. Andrew','j.lee@ems.org.','(876)8590264'), 
		('Nola','Gordon','Female','3','9','August Town Kingston','n.gordon@ems.org','(876)7958757');


INSERT INTO Appointments([Date],Physician_id,Patient_id,[Time],Comments ) 
VALUES ('2019-11-10','3','1','07:30',''), 
('2019-12-27','1','5','10:00',''), 
('2019-12-27','3','4','13:30',''), 
('2019-12-27','2','11','09:00',''), 
('2019-12-27','4','2','12:00',''), 
('2020-01-05','1','8','08:00',''), 
('2020-01-05','3','15','15:00',''), 
('2020-01-26','4','7','08:00',''), 
('2020-01-26','3','9','09:00',''), 
('2020-01-26','6','9','12:00',''), 
('2020-02-03','3','14','08:00',''), 
('2020-02-13','2','3','11:00',''), 
('2020-02-13','4','8','13:00',''), 
('2020-02-13','3','7','12:00',''), 
('2020-03-01','3','6','13:00',''), 
('2020-03-01','5','12','14:00',''), 
('2020-03-04','6','10','10:30',''), 
('2020-03-04','6','9','11:00','');

INSERT INTO Visits
([Date],[Time],Receptionist_id,Patient_id,Nurse_id,Weight_lb,Height_cm,Blood_Pressure,Blood_Sugar,Physician_id,Symptoms,Diagnosis,Prescription,Comments)
VALUES
('2019-11-10','07:30','2','1','1','120','178','120/60','111','3','back pain','pulled muscle','voltarin injection',''),
('2019-12-27','10:00','1','5','3','170','178','120/60','110','1','coughing','cold','paracetamol',''), 
('2019-12-27','13:30','1','4','2','190','166','130/80','90','3','tired, weak,shortness of breath','high blood pressure','',''), 
('2019-12-27','09:00','2','11','3','230','176','105/65','85','2','pain in chest,shortness of breath','heart failure','',''), 
('2019-12-27','12:00','2','2','1','15','40','120/60','110','4','coughing','cold','children panadol','2.5ml'); 

 
INSERT INTO Bills([Date],Currency,Total,Patient_id)
VALUES
('2019-11-10','JMD','10000','1'), 
('2019-12-27','JMD','5000','5'), 
('2019-12-27','JMD','5000','4'), 
('2019-12-27','JMD','11000','11'), 
('2019-12-27','JMD','7000','2'); 



INSERT INTO Payments(Receptionist_id,Bill_id,Patient_id,Pay_Status)
VALUES
('2','3','4','Paid'),
('1','1','1','Paid'),
('1','4','11','Pending'),
('2','2','5','Paid'),
('2','5','2','Paid');