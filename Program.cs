using RecomendadorBot.Interfaces;
using RecomendadorBot.Models;
using RecomendadorBot.Services; //todos los using

Usuario usuario = new Usuario 
{
    Id = 1,
    Nombre = "Ana",
    Preferencias = new List<string> { "rock", "pop" },
    HistorialIds = new List<int> { 1 }
};

Usuario usuario2 = new Usuario 
{
    Id = 2,
    Nombre = "Renzo",
    Preferencias = new List<string> { "rap", "grunge" },
    HistorialIds = new List<int> { 3 }
};

List<IRecomendable> canciones = new List<IRecomendable>
{
    new Cancion { Id = 1, Nombre = "Ya escuchada", Artista = "Banda A", Atributos = new() { "rock" } },
    new Cancion { Id = 2, Nombre = "Rock nuevo", Artista = "Banda B", Atributos = new() { "rock" } },
    new Cancion { Id = 3, Nombre = "Clásica", Artista = "Banda C", Atributos = new() { "clasica" } },
    new Cancion { Id = 4, Nombre = "Pop moderno", Artista = "Banda D", Atributos = new() { "pop" } },
    new Cancion { Id = 5, Nombre = "Rap fuerte", Artista = "Artista X", Atributos = new() { "rap" } },
    new Cancion { Id = 6, Nombre = "Grunge clásico", Artista = "Nirvana", Atributos = new() { "grunge" } }
};

Recomendador recomendador = new Recomendador();

List<IRecomendable> recomendaciones =
    recomendador.RecomendarPorPreferencias(usuario, canciones);

Console.WriteLine($"Recomendaciones para {usuario.Nombre}:");

foreach (IRecomendable item in recomendaciones)
{
    Console.WriteLine($"- {item.Nombre}");
}

// Recomendaciones para Renzo
List<IRecomendable> recomendaciones2 =
    recomendador.RecomendarPorPreferencias(usuario2, canciones);

Console.WriteLine($"\nRecomendaciones para {usuario2.Nombre}:");

foreach (IRecomendable item in recomendaciones2)
{
    Console.WriteLine($"- {item.Nombre}");
}