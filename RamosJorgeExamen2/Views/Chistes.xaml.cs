using System.Text.Json;

namespace RamosJorgeExamen2.Views;

public partial class Chistes : ContentPage
{

    public Chistes()
    {
        InitializeComponent();
        CargarChiste();
    }

    private async void OnOtroChisteClicked(object sender, EventArgs e)
    {
        await CargarChiste();
    }

    private async Task CargarChiste()
    {

        var httpClient = new HttpClient();
        var json = await httpClient.GetStringAsync("https://official-joke-api.appspot.com/random_joke");
        var joke = JsonSerializer.Deserialize<Joke>(json);
        Chiste.Text = $"{joke.setup}\n\n{joke.punchline}";

    }

    public class Joke
    {
        public string setup { get; set; }
        public string punchline { get; set; }
    }
}

