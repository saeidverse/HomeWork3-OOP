

namespace Task_1.Entity
{
    public class Library
    {
          public List<Book> Books { get;  } = new List<Book>();

        public void AddBook(Book book)
        {
          
            Books.Add(book);
        }


        public void BorrowBook(string nameBook)
        {
            bool found = false;
            foreach (var book in Books)
            {

                if (book.Title.ToLower().Trim() == nameBook.ToLower().Trim())
                {
                    found = true;
                    if (book.IsAvailable)
                    {
                        book.IsAvailable = false;
                        Console.WriteLine($"book {book.Title}  available and  Borrowed ");
                    }
                    else
                    {
                        Console.WriteLine("Not Available Book");

                    }
                    break;
                }


            }

            if (!found)
            {
                Console.WriteLine("not found book");
            }


        }
        public void ReturnBook(string nameBook)
        {
            bool found = false;
            foreach (var book in Books)
            {

                if (book.Title.ToLower().Trim() == nameBook.ToLower().Trim())
                {
                    found = true;
                    if (!book.IsAvailable)
                    {
                        book.IsAvailable = true;
                        Console.WriteLine($"book {book.Title}  Returned");
                    }
                    else
                    {
                        Console.WriteLine("Book is already in library");
                    }
                    break;
                }


            }

            if (!found)
            {
                Console.WriteLine("not found book in library for returned ");
            }


        }


        public void StatusLibrary()
        {
            Console.WriteLine("show library : ");
            foreach (var book in Books)
            {
                Console.WriteLine($" Title:{book.Title} - IsAvailable:{book.IsAvailable}");
            }

            Console.WriteLine("-------------------------------------------------------------------");
        }


    }
}
