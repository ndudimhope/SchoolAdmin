using SchoolAdmin.Lookup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Facilities
{
    class LibraryCatalogQueries
    {
        public IEnumerable<Book> Books = new List<Book>()
        {
            new Book(){Title="Half of a Yellow Sun", Author="Chimamanda Adichie"},
            new Book(){Title="Purple Hibiscus", Author="Chimamanda Adichie"},
            new Book(){Title="Devta Ka Ban", Author="Chinua Achebe"},
            new Book(){Title="TheFishermen", Author="Chigozie Obioma"},
            new Book(){Title="White is for Witching", Author="Helen Oyeyemi"},
            new Book(){Title="Stay With Me", Author="Ayobami Adebayo"},
            new Book(){Title="No Longer At Ease", Author="Chinua Achebe"},
            new Book(){Title="Who Fears Death", Author="Nnedi Okoroafor"},
            new Book(){Title="The Thing Around Your Neck", Author="Chimamanda Adichie"},
            new Book(){Title="Gifted Hands", Author="Ben Carson"}
        };

        //Fetch All Books in the Library, sorted in Ascending Order

        public void GetAllBooksInAscendingOrderQuery() 
        {
            IEnumerable<Book> allBooksSortQuery = Books.OrderBy(b => b.Title);

            Console.WriteLine("\n\n List of all Books, with Title Sorted in Ascending Order");
            Console.WriteLine("\nTitle\t\tAuthor");

            foreach (Book objBook in allBooksSortQuery)
            {
                Console.WriteLine($"{objBook.Title} \t {objBook.Author}");

            }
        }


        //Fetch all books in the library, with title in ascending order and author in descending order
        public void GetAllBooksInAscendingOrderAndAuthorInDescQuery()
        {
            IEnumerable<Book> allBooksTitleAndAuthorSortQuery = Books.OrderBy(f => f.Title).ThenByDescending(f => f.Author);

            Console.WriteLine("\n\n List of all Books, with Title Sorted in Ascending Order and Author in Descending Order");
            Console.WriteLine("\nTitle\t\tAuthor");

            foreach (Book objBook in allBooksTitleAndAuthorSortQuery)
            {
                Console.WriteLine($"{objBook.Title} \t {objBook.Author}");

            }
        }


        //Fetchall books written by a specific author

        public void GetAllBooksBySpecAuthor() 
        {
            IEnumerable<Book> listOfBookBySpecAuthorQuery = Books.Where(b => b.Author.Contains("Chimamanda"));

            Console.WriteLine("\n\n List of all Books, sorted by specific author");
            Console.WriteLine("\nTitle\t\tAuthor");

            foreach (Book objBook in listOfBookBySpecAuthorQuery)
            {
                Console.WriteLine($"{objBook.Title} \t {objBook.Author}");

            }

        }

        //Fetch title and author of any book, containing a specified string value, and return in uppercase

        public void GetTitleAndAuthorOfBooksConStrValue()
        {
            IEnumerable<Book> titleAndAuthorByStrValueQuery = Books.Where(b => b.Author.Contains("C"));

            Console.WriteLine("\n\n List of all Books, sorted by specific author");
            Console.WriteLine("\nTitle\t\tAuthor");

            foreach (Book objBook in titleAndAuthorByStrValueQuery)
            {
                Console.WriteLine($"{objBook.Title.ToUpper()} \t {objBook.Author.ToUpper()}");

            }

        }

        //Get count of books written by each author
        public void GetBookCountByEachAuthor()
        {
            IEnumerable<Book> bookCountByEachAuthorQuery = Books.

            Console.WriteLine("\n\n List of all Books, sorted by specific author");
            Console.WriteLine("\nTitle\t\tAuthor");

            foreach (Book objBook in bookCountByEachAuthorQuery)
            {
                Console.WriteLine($"{objBook.Title} \t {objBook.Author}");

            }
        }


    }
}
