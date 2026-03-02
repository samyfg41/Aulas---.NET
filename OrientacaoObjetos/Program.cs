// See https://aka.ms/new-console-template for more information

using OrientacaoObjetos;

Console.WriteLine("Bem-vindo ao sistema de reviews!");

var newTitle = new Game
{
    Name = "Pokemon Pokopia",
    //Plataform = "Nintendo Switch"
};
newTitle.Reviews.Add(new Review(){Rating = 100, Comment = "Great Game!!!", Owner = "IGN"});
newTitle.Reviews.Add(new Review(){Rating = 100, Comment = "Best Pokemon Game Ever!", Owner = "Junin"});
newTitle.Reviews.Add(new Review(){Rating = 98, Comment = "Good Game", Owner = "Omelete"});

Console.WriteLine($"{newTitle}");

var newTitle2 = new Movie
{
    Name = "The Batman",
    Duration = 120
};

Console.WriteLine($"{newTitle2}");

/*
Console.WriteLine($"{newTitle}");
Object objeto = new Object();
objeto = (Title) objeto;
*/
