using RecomendadorBot.Interfaces;
using RecomendadorBot.Models;

namespace RecomendadorBot.Services;

public class Recomendador
{
    public List<IRecomendable> RecomendarPorPreferencias(
        Usuario usuario,
        List<IRecomendable> catalogo)
    {
        List<IRecomendable> resultado = new List<IRecomendable>();

        foreach (IRecomendable item in catalogo)
        {
            bool yaConsumido = false;

            foreach (int id in usuario.HistorialIds)
            {
                if (id == item.Id)
                {
                    yaConsumido = true;
                    break;
                }
            }

            if (yaConsumido)
            {
                continue;
            }

            bool coincide = false;

            foreach (string atributo in item.Atributos)
            {
                foreach (string preferencia in usuario.Preferencias)
                {
                    if (atributo == preferencia)
                    {
                        coincide = true;
                        break;
                    }
                }

                if (coincide)
                {
                    break;
                }
            }

            if (coincide)
            {
                resultado.Add(item);
            }
        }

        return resultado;
    }
}