using System.Net;
using RestSharp;
using System.Text.Json;

RestClient client = new RestClient("https://pokeapi.co/api/v2/");

RestRequest request = new RestRequest("pokemon/pikachu");

RestResponse result = await client.GetAsync(request);

if (result.IsSuccessful)
{
    Pokemon pokemon = JsonSerializer.Deserialize<Pokemon>(result.Content);
    Console.WriteLine("Name: " + pokemon.Name);
    Console.WriteLine("Id Index: " + pokemon.Id);
    Console.WriteLine("Base Experience: " + pokemon.Id);
    Console.WriteLine("Weight: " + pokemon.Weight);
    Console.WriteLine("Location Area Encounters: " + pokemon.LocationAreaEncounters);
}
else if (result.StatusCode == HttpStatusCode.NotFound)
{
    Console.WriteLine("Not found!");
}

Console.ReadLine();
