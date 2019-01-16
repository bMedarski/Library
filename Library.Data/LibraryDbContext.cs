﻿namespace Library.Data
{
	using Microsoft.EntityFrameworkCore;

	public class LibraryDbContext:  DbContext
	{
		public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
			: base(options)
		{
		}

	}
}
