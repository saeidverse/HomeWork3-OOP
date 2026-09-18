

using Task_4;


List<Patient> patients = new List<Patient>();
patients.Add(new Patient("Ali", 30, 12345, 1001));
patients.Add(new Patient("Reza", 45, 23456, 1002));
patients.Add(new Patient("Sara", 28, 34567, 1003));
patients.Add(new Patient("Mina", 22, 78523, 1004));


List<Doctor> doctors = new List<Doctor>();
doctors.Add ( new Doctor("Ahmad", 50, 45678, 2001, "Cardiologist"));
doctors.Add ( new Doctor("Maryam", 40, 56789, 2002, "Neurologist"));

doctors[0].Diagnose(patients[0], "Heart Attack");
doctors[1].Diagnose(patients[1], "Migraine");
doctors[1].Diagnose(patients[2], "Stroke");

Room room1 = new Room(101, 2);
Room room2 = new Room(102, 2);

room1.AssignPatient(patients[0]);
room1.AssignPatient(patients[1]);

room2.AssignPatient(patients[2]);


Hospital hospital = new Hospital();

hospital.Doctors.Add(doctors[0]);
hospital.Doctors.Add(doctors[1]);

hospital.Rooms.Add(room1);
hospital.Rooms.Add(room2);


hospital.AdmitPatient(patients[3]);

hospital.DischargePatient(patients[1]);





