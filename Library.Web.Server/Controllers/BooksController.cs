namespace Library.Web.Server.Controllers
{
	using System.Threading.Tasks;
	using Goodreads;
	using Goodreads.Models.Response;
	using Microsoft.AspNetCore.Mvc;

	public class BooksController : Controller
	{
		public async Task<Book> Index()
		{

			// Define your Goodreads key and secret.
			const string apiKey = "acxtAUm4Iz4QEGAUbkog";
			const string apiSecret = "wSRUu2Fa6OrkOHU9oHM19FOTzAa6BswZ1k4SjuGRg0";

			// Create an unauthorized Goodreads client.
			var client = GoodreadsClient.Create(apiKey, apiSecret);

			// Now you are able to call some Goodreads endpoints that don't need the OAuth credentials. For example:
			// Get a book by specified id.
			var book = await client.Books.GetByBookId(817357);


			var searchTerm = "Dragon";
			var page = 1;
			var searchField = "Dragon";

			var bookWorks = await client.Books.Search(searchTerm);

			// Get a list of groups by search keyword.
			var groups = await client.Groups.GetGroups(search: "Arts");

			return book;
		}
	}
}