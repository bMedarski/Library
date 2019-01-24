namespace Library.Web.Shared
{
	using System.Collections.Generic;

	public class Book
	{
		public Book()
		{
			this.Authors = new HashSet<Author>();
		}
		public int Id { get; set; }
		public long GoodReadsId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
		public string SmallImageUrl { get; set; }
		public string Url { get; set; }
		public string Isbn { get; set; }
		public ICollection<Author> Authors { get; set; }
		public string Language { get; set; }
		public int Pages { get; set; }
		public bool IsRead { get; set; }
		public bool DoesHaveIt { get; set; }
		public bool IsPublished { get; set; }
		public bool InToDoList { get; set; }
	}
}
