


using Task_1.Entity;

Library library = new Library();
library.AddBook(new Book { Title = "c#", Author = "saeid", ISBN = "1", IsAvailable = true });
library.AddBook(new Book { Title = "asp.net", Author = "saeid", ISBN = "2", IsAvailable = true });
library.AddBook(new Book { Title = "sql", Author = "saeid", ISBN = "3", IsAvailable = true });


library.BorrowBook(" sql");

library.StatusLibrary();


library.ReturnBook("Sql");

library.StatusLibrary();





