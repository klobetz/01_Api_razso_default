using ConsoleApp_API.ViewModel;
using System.Net.Http.Json;

Console.WriteLine("Alap api kiíratás");
HttpClient client = new HttpClient();

// API hívás és JSON válasz deszerializálása egy lépésben
var userList = await client.GetFromJsonAsync<List<UserVM>>("https://localhost:7186/api/teszt/user");


if (userList != null)
{
    foreach (var user in userList)
        Console.WriteLine($"{user.FullName} | {user.Email} | {user.Password}");
}
else
{
    Console.WriteLine("nincs válasz");
}

Console.ReadLine();