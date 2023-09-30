using Lab1Triangle;
using Serilog;

string template = "{Timestamp:HH:mm:ss} | [{Level:u3}] | {Message:lj}{NewLine}{Exception}";
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console(outputTemplate: template)
    .WriteTo.File("logs/file_.txt", outputTemplate: template)
    .CreateLogger();

Log.Verbose("Логгер сконфигурирован");
Log.Information("Приложение запущено");

(var s, var d) = Triangle.GetTriangleData("3", "4", "5");

Log.CloseAndFlush();