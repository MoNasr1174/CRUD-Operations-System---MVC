using AutoMapper;
using Demo.DAL.Models;
using Demo.PL.ViewModels;
using MVC.DAL.Models;

namespace Demo.PL.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>();
        }
    }
}
