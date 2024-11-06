using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
	class Program
	{
		
		//static Program()
		//{
		//	connection = new SqlConnection(connectionString);
		//}
		static void Main(string[] args)
		{
			//SelectAuthors();
			//SelectBooks();
			//Select("book_id,title,last_name,first_name", "Books,Authors", "author=author_id");

			//Console.Write("Введите имя: ");
			//string first_name = Console.ReadLine();
			//Console.Write("Введите фамилию: ");
			//string last_name = Console.ReadLine();
			//InsertAuthor(first_name, last_name);

			//Console.WriteLine(GetAuthorID("James", "Cameron"));
			//SelectAuthors();

			//Console.Write("Введите название книги: ");
			//string title = Console.ReadLine();
			//Console.Write("Введите имя автора: ");
			//string first_name = Console.ReadLine();
			//Console.Write("Введите фамилию автора: ");
			//string last_name = Console.ReadLine();
			//Library.InsertBook(title, first_name, last_name);
			//Library.SelectBooks();

			Library.SelectAuthors();
			//Library.Select("title,first_name,last_name", "Authors,Books", "author=author_id;DROP TABLE Genres");
			Console.WriteLine(Library.GetAuthorID("James", "Cameron"));
			Library.InsertBook("Windows via C/C++ 5th Edition", "Jeffrey", "Richter");
			Library.SelectBooks();
		}
		
	}
}
