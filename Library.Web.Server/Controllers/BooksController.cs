﻿namespace Library.Web.Server.Controllers
{
	using System.Threading.Tasks;
	using Microsoft.AspNetCore.Mvc;
	using Shared;
	using Utilities;

	public class BooksController : Controller
	{
		private readonly IGoodReadsApi _client;

		public BooksController(IGoodReadsApi client)
		{
			this._client = client;
		}

		public IActionResult Index()
		{
			return this.View();
		}
		//public async Task<Book> Index()
		//{

		//	// Define your Goodreads key and secret.
		//	const string apiKey = "acxtAUm4Iz4QEGAUbkog";
		//	const string apiSecret = "wSRUu2Fa6OrkOHU9oHM19FOTzAa6BswZ1k4SjuGRg0";

		//	// Create an unauthorized Goodreads client.
		//	var client = GoodreadsClient.Create(apiKey, apiSecret);

		//	// Now you are able to call some GoodReads endpoints that don't need the OAuth credentials. For example:
		//	// Get a book by specified id.
		//	var book = await client.Books.GetByBookId(817357);


		//	var searchTerm = "Dragon";
		//	var page = 1;
		//	var searchField = "Dragon";

		//	var bookWorks = await client.Books.Search(searchTerm);

		//	// Get a list of groups by search keyword.
		//	var groups = await client.Groups.GetGroups(search: "Arts");

		//	return book;
		//}

		[HttpPost]
		public async Task<Book> GetBookFromGoodReads(string link)
		{
			var book = await this._client.GetBookById(link);
			return book;
		}
	}
}