using CsvHelper.Configuration;
using CsvHelper;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace DsvMinimalApi
{
	public class DataGenerator
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new PostalCodeDB(serviceProvider.GetRequiredService<DbContextOptions<PostalCodeDB>>()))
			{
				if (context.PostalCodeInfos.Any())
				{
					return;
				}

				IReaderConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
				{
					Delimiter = "|"
				};
				using (var reader = new StreamReader("Colima.txt"))
				using (var csv = new CsvReader(reader, config))
				{
					var records = csv.GetRecords<PostalCodeInfo>();
					context.PostalCodeInfos.AddRange(records);
				}

				context.SaveChanges();
			}
		}
	}
}
