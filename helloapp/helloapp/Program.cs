WebApplicationBuilder builder = WebApplication.CreateBuilder();

WebApplication app = builder.Build();

app.MapGet("/", () => "Hello World!");

await app.StartAsync();
await Task.Delay(10000);
await app.StopAsync();  // ����� 10 ������ ��������� ���������� ����������