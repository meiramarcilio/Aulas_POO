using System.Text.Json;

string WriteJson()
{
    var weatherForecast = new WeatherForecast
    {
        Date = DateTime.Parse("2019-08-01"),
        TemperatureCelsius = 25,
        Summary = "Hot"
    };
    var options = new JsonSerializerOptions { WriteIndented = true };
    // string jsonString = JsonSerializer.Serialize(weatherForecast, options);
    byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(weatherForecast, options);

    var path = Environment.GetFolderPath
        (Environment.SpecialFolder.MyDocuments) +
        "\\weatherforecastUtf8.json";
    //File.WriteAllText(path, jsonString);
    File.WriteAllBytes(path, jsonUtf8Bytes);

    return path;
}

void ReadJson()
{
    var path = Environment.GetFolderPath
        (Environment.SpecialFolder.MyDocuments) +
        "\\weatherforecast.json";
    string jsonString = File.ReadAllText(path);
    var obj = JsonSerializer.Deserialize<WeatherForecast>(jsonString);
    Console.WriteLine($"Date: {obj.Date}");
    Console.WriteLine($"TemperatureCelsius: {obj.TemperatureCelsius}");
    Console.WriteLine($"Summary: {obj.Summary}");
}
ReadJson();
//Console.WriteLine($"Arquivo JSON salvo em: {WriteJson()}");