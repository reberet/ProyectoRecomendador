namespace RecomendadorBot.Interfaces; // La interfaz define qué debe tener cualquier cosa que pueda ser recomendada.

public interface IRecomendable
{
    int Id { get; }
    string Nombre { get; }
    List<string> Atributos { get; }
}