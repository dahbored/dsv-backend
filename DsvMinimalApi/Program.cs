using DsvMinimalApi;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PostalCodeDB>(opt => opt.UseInMemoryDatabase("ColimaPostalCodes"));
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
	var services = scope.ServiceProvider;
	DataGenerator.Initialize(services);
}

app.MapGet("/codigopostal/{cp}", async (string cp, PostalCodeDB db) =>
{
	var result = await db.PostalCodeInfos.Where(x=> x.d_codigo == cp).ToListAsync();
	if (result.Count == 0)
	{
		return Results.NotFound();
	}

	return Results.Ok(result);
});

app.Run();
