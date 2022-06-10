using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Página_Blazor_Entity_Framework.Anime_Base_de_datos
{
    public class Anime
    {
        public int AnimeId { get; set; }
        public string NombreAnime { get; set; }
        public string StudioAnime { get; set; }
        public int CantidadEpisodios { get; set; }
        public DateTime FechaEmisión { get; set; }
        public DateTime FechaFinalización { get; set; }
        public string Genero { get; set; }

    }
}
