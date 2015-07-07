using Cinema.AppServices.DTOs;
using Cinema.Core.Entities;
using Cinema.Core.Interfaces;
using Cinema.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.AppServices
{
    public class GenreService 
    {
        private IGenreRepository _genreRepository;

        public GenreService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public void AddGenre(GenreDto dto) //ovaa metoda ke prima dto objekt
        {
            if (String.IsNullOrEmpty(dto.Name))
                throw new Exception("Name Can not be Null");
            Genre entity = new Genre();  //transferiranje na vrednostite ni koristi dto - to zaradi toa kreirame nov objekt od tip Genre i na toj entitet mu go dodavame dto objektot
            entity.Name = dto.Name;

            _genreRepository.Add(entity);
            _genreRepository.Save();
        }
        public List<GenreDto> GetAll()
        {
            var result = _genreRepository.GetAll();
            return result.Select(x => new GenreDto()
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}
