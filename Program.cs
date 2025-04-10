using ApiFuncional.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.AddApiConfig()
        .AddCorsConfig()
        .AddSwaggerConfig()
        .AddDbContextConfig()
        .AddIdentityConfig();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("Development");
}
else
{
    app.UseCors("Production");
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
