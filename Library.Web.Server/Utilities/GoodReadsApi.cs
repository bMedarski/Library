namespace Library.Web.Server.Utilities
{
	using System.Threading.Tasks;
	using Goodreads;
	using Goodreads.Models.Response;
	using Author = Shared.Author;
	using Book = Shared.Book;

	public class GoodReadsApi:IGoodReadsApi
	{
		private readonly IGoodreadsClient _client;

		public GoodReadsApi()
		{
			this._client = GoodreadsClient.Create(Constants.GoodReadsApiKey, Constants.GoodReadsApiSecret);
		}

		public async Task<Book> GetBookById(string id)
		{
			var apiBook = await this._client.Books.GetByBookId(int.Parse(id));

			var book = new Book
			{
				GoodReadsId = apiBook.Id,
				Title = apiBook.Title,
				Description = apiBook.Description,
				SmallImageUrl = apiBook.SmallImageUrl,
				ImageUrl = apiBook.ImageUrl,
				Url = apiBook.Url,
				Isbn = apiBook.Isbn,
				Pages = apiBook.Pages,
				Language = apiBook.LanguageCode,
			};
			return book;
		}
	}
}
