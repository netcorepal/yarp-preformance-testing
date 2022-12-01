using System.Text;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "Hello World!").CacheOutput();
StringBuilder sb = new StringBuilder(); ;
for (var i = 0; i < 1000; i++)
{
    sb.Append("Hello World!");
}
app.MapGet("/longtext", () => sb.ToString()).CacheOutput();
app.Run();
