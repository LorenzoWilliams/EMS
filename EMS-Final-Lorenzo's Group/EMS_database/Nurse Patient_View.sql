
CREATE VIEW [Nurses_Patient_View] AS
SELECT v.Date,convert(varchar(8),[Time],0) As [Start],p.FirstName,p.LastName,n.Position_id, n.Last_Name
FROM Visits v
JOIN Patients p on p.id = v.Patient_id
JOIN Nurses n on n.id = v.Nurse_id

WHERE Nurse_id = '3';
