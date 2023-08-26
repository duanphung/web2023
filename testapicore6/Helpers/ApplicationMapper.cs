using testapicore6.Data;
using AutoMapper;
using testapicore6.Models;

namespace testapicore6.Helpers
{
    public class ApplicationMapper :Profile
    {
        public ApplicationMapper() { 
            CreateMap<Test,TestModel>().ReverseMap();
            
        }
    }
}
