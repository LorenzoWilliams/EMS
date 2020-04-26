use Ember_medical_service_db;

alter table Patients
add constraint ck_email_Email UNIQUE(Email)

