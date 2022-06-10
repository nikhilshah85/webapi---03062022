using productsWebAPI.Repository.ProductsRepository;
using productsWebAPI.DataSource.InMemoryCollection;
using productsWebAPI.DataSource.SQLServerSource;
var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddSingleton<IProductRepository, ProductsCollection >();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
