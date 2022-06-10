using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Página_Blazor_Entity_Framework.Anime_Base_de_datos;

namespace Página_Blazor_Entity_Framework.Data
{
    public interface IAnimeService
    {
   
        Task<IEnumerable<Anime>> GetAllAnime(); //Devuelve todos

        Task<Anime> GetAnime(int id); //Devuelve uno

        Task<Anime> InsertAnime(Anime anime); //Inserte

        Task<bool> UpdateAnime(Anime anime); //Actualize

        Task <bool> DeleteAnime(int id);  //Elimine
            
        Task <bool> SaveAnime(Anime anime); 
    }
}
