
namespace Task_4
{
    class Doctor : Person
    {
        public int DoctorId { get; set; }
        public string Specialization { get; set; }

        public Doctor(string name, int age, string nationalId, int doctorId, string specialization):base(name,age,nationalId)
        {
            DoctorId = doctorId;
            Specialization = specialization;
        }

        public void Diagnose(Patient patient, string disease)
        {
            patient.AddToMedicalHistory(disease);
        }

        public override string GetDetails()
        {
            return base.GetDetails() + $"DoctorId: {DoctorId} ,Specialization: {Specialization}" ;
        }


    }


}
