namespace Library.Web.Server.Utilities
{
	using System.Threading.Tasks;
	using Shared;

	public interface IGoodReadsApi
	{
		Task<Book> GetBookById(string id);
	}
}
