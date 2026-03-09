// See https://aka.ms/new-console-template for more information

using HtmlAgilityPack;

Console.WriteLine("Iniciando Scrapping do site...");

var urls = new[]
{
    "https://www.metacritic.com/game/soulcalibur/",
    "https://www.metacritic.com/game/grand-theft-auto-iv/",
    "https://www.metacritic.com/game/super-mario-galaxy/",
    "https://www.metacritic.com/game/super-mario-galaxy-2/",
    "https://www.metacritic.com/game/the-legend-of-zelda-breath-of-the-wild/",
    "https://www.metacritic.com/game/perfect-dark-2000/",
    "https://www.metacritic.com/game/tony-hawks-pro-skater-3/",
    "https://www.metacritic.com/game/red-dead-redemption-2/",
    "https://www.metacritic.com/game/grand-theft-auto-v/"
};

foreach (var url in urls)
{
    var jogo = await ScrappingUrl(url);
}

return;

static async Task<string> ScrappingUrl(string url)
{
    var web = new HtmlWeb();
    var doc =
        web.Load(url);
        //await web.LoadFromWebAsync(url);
        //estava dando erro

    if (doc == null)
    {
        Console.WriteLine("HTML não encontrado");
        return "Não encontrado";
    }

    /*var web = new HtmlWeb();
    var doc =
        await web.LoadFromWebAsync(
            "https://www.metacritic.com/game/the-legend-of-zelda-ocarina-of-time/"
        );
        */

// Testar se o documento foi baixado
//Console.WriteLine(doc.DocumentNode.InnerHtml);

    var gameTitle = doc.DocumentNode.SelectSingleNode("//h1")?.InnerText ?? "Não Encontrado";

    
    var gamePlataform = doc.DocumentNode.SelectSingleNode("//div[@class='game-platform-logo__text']")?.InnerText ??
                        "Não Encontrado";
    

    var gameReleaseDate = doc.DocumentNode.SelectSingleNode("//div[@class='hero-release-date__value']")?
        .InnerText ?? "Não Encontrado";


    var gameMetaScore = doc.DocumentNode.SelectSingleNode("/html/body/div[1]/div[2]/main/div/div/div/section[1]/div/div[3]/div[4]/div/div[1]/div[1]/div/div[2]/div[2]")?
        .InnerText ?? "Não encontrado";

    var gameUserScore = doc.DocumentNode.SelectSingleNode("/html/body/div[1]/div[2]/main/div/div/div/section[1]/div/div[3]/div[4]/div/div[2]/div[1]/div/div[2]/div")?
        .InnerText ?? "Não encontrado";
    
    Console.WriteLine($"Title: {gameTitle}");
    Console.WriteLine($"Plataform: {gamePlataform}");
    Console.WriteLine($"Released Date: {gameReleaseDate}");
    Console.WriteLine($"Meta Score: {gameMetaScore}");
    Console.WriteLine($"User Score: {gameUserScore}");
    
    return gameTitle;
}