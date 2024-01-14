var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Run(async (context) => await context.Response.SendFileAsync("C:\\Users\\Admin\\Desktop\\.net new\\myproject\\helloapp\\helloapp\\forest.jpg"));

app.Run();