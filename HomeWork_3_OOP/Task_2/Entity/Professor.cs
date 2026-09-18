

namespace Task_2.Entity
{
    class Professor:Person
    {
        public int ProfessorID { get; set; }
        public string Subject { get; set; }

        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine($", ProfessorID : {ProfessorID} ,Subject: {Subject} ");
        }


    }
}
