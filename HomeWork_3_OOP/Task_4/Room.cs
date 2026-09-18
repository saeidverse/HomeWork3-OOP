
using Task_4.Room_Full_Exception;

namespace Task_4
{
    class Room
    {
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public List<Patient> Patients { get; set; } = new List<Patient>();

        public Room(int roomNumber, int capacity)
        {
            RoomNumber = roomNumber;
            Capacity = capacity;
        }

        public void AssignPatient(Patient patient)
        {
            if (Patients.Count >= Capacity)
            {
                throw new RoomFullException();
            }
            else
            {
                Patients.Add(patient);
                Console.WriteLine($"Patient {patient.Name} added to room {RoomNumber}");
            }
        }



        public string GetDetailsRoom()
        {
            return $"RoomNumber: {RoomNumber} , Capacity: {Capacity}";
        }

    }
}
