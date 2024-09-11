using ConsoleApp_API.ViewModel;
using System.Net.Http.Json;

Console.WriteLine("User adatok megjelenítése");
HttpClient client = new HttpClient();

var userList = await client.GetFromJsonAsync<List<UserVM>>("https://localhost:7186/api/teszt/user");

if (userList != null)
{
    foreach (var user in userList)
    {
        Console.WriteLine($"{user.FullName} | {user.Email} | {user.Password}");
    }
}
else
{
    Console.WriteLine("Nincs válasz!");
}

Console.ReadLine();