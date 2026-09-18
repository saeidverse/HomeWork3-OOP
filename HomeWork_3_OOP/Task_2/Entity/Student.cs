

namespace Task_2.Entity
{
    class Student : Person
    {
        public int StudentID { get; set; }
        public string Major { get; set; }



        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine($" , StudentID : {StudentID} ,Major: {Major} ");
        }
    }

}

  


