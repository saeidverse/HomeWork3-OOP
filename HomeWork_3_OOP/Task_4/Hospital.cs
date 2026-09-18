

using Task_4.Room_Full_Exception;

namespace Task_4
{
    class Hospital
    {
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public List<Room> Rooms { get; set; } = new List<Room>();


        public void AdmitPatient(Patient patient)
        {
            foreach (Room room in Rooms)
            {
                try
                {
                    room.AssignPatient(patient);
                    return;
                }
                catch (RoomFullException)
                {
                    continue;
                }
            }

            Console.WriteLine("No room is available");
        }

        public void DischargePatient(Patient patient)
        {
            foreach (Room room in Rooms)
            {
                if (room.Patients.Contains(patient))
                {
                    room.Patients.Remove(patient);
                    Console.WriteLine($"Patient {patient.Name} discharged from room {room.RoomNumber}.");
                    return;
                }
            }
            Console.WriteLine("Patient not found.");
        }

        
    }
}
