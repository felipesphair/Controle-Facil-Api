using AutoMapper;
using ControleFacil.Api.Contract.Apagar;
using ControleFacil.Api.Damain.Models;

namespace ControleFacil.Api.AutoMapper
{
    public class ApagarProfile : Profile
    {
        public ApagarProfile(){
            CreateMap<Apagar, ApagarRequestContract>().ReverseMap();
            CreateMap<Apagar, ApagarResponseContract>().ReverseMap();

        }
    }
}