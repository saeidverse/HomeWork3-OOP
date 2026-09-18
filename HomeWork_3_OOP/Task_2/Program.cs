

using Task_2.Entity;

List<Person> Persons = new List<Person>();

Persons.Add(new Student { Name = "saeid", Age = 32, Major = "electronic", StudentID = 1001 });
Persons.Add(new Student { Name = "reza", Age = 39, Major = "software", StudentID = 1002 });
Persons.Add(new Professor { Name = "Prof.mohammad", Age = 50, Subject = "electronic", ProfessorID = 2001 });
Persons.Add(new Professor { Name = "Prof.miladi", Age = 52, Subject = "software", ProfessorID = 2002 });



foreach (var person in Persons)
{
    person.GetDetails();
}


