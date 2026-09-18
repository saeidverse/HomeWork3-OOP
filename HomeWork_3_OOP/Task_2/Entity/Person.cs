namespace Task_2.Entity
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public virtual void GetDetails()
        {
            Console.Write($"name: {Name} ,age: {Age}" );
        }


    }
}
