using Microsoft.EntityFrameworkCore;
using Página_Blazor_Entity_Framework.Anime_Base_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Página_Blazor_Entity_Framework.Data
{
    public class AnimeService : IAnimeService
    {
        private readonly AnimeContext _Context;
        
        public AnimeService(AnimeContext context)
        {
            _Context = context;
        }

        public async Task<bool> DeleteAnime (int id)
        {
            var anime = await _Context.Animes.FindAsync(id);

            _Context.Animes.Remove(anime);

            return await _Context.SaveChangesAsync() > 0;      
        }

        public async Task<IEnumerable<Anime>> GetAllAnime()
        {
            return await _Context.Animes.ToListAsync();
        }

        public async Task<Anime> GetAnime(int id)
        {
            return await _Context.Animes.FindAsync(id);
        }

        public async Task<bool> InsertAnime(Anime anime)
        {
            _Context.Animes.Add(anime);
            return await _Context.SaveChangesAsync()>0;
        }

        public async Task<bool> SaveAnime(Anime anime)
        {
            if (anime.AnimeId > 0)
                return await UpdateAnime(anime);
            else
                return await InsertAnime(anime);
        }

        public async Task<bool> UpdateAnime(Anime anime)
        {
            _Context.Entry(anime).State = EntityState.Modified;
            return await _Context.SaveChangesAsync() > 0;
        }

        Task<Anime> IAnimeService.InsertAnime(Anime anime)
        {
            throw new NotImplementedException();
        }
    }
}
