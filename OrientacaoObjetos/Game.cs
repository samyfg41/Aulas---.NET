namespace OrientacaoObjetos;

public class Game : Title
{
    public GamePlataform Plataform { get; set; }

    public override string ToString() => 
        $"Game: {Name} -  MetaScore: {(MetaScore == null ? "tbd" : MetaScore)} - Reviews {Reviews} - Plataform: {Plataform}";
}