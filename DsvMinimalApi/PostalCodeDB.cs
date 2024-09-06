using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace DsvMinimalApi
{
	public class PostalCodeDB : DbContext
	{
        public PostalCodeDB(DbContextOptions<PostalCodeDB> options) : base(options)
		{
			
        }

		public DbSet<PostalCodeInfo> PostalCodeInfos => Set<PostalCodeInfo>();
	}
}
