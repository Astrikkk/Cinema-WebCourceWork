using AutoMapper;
using CinemaApp2.Data.Entities;
using CinemaApp2.Models;

namespace CinemaApp2
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Define mappings
            CreateMap<SessionFormModel, Session>();
            CreateMap<Session, SessionFormModel>();

            CreateMap<FilmFormModel, Film>();
            CreateMap<Film, FilmFormModel>();
        }
    }
}
