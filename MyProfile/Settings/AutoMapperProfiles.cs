using System;
using AutoMapper;
using MyProfile.Models;
using MyProfile.ViewModel;

namespace MyProfile.Settings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Project, ListOfProjectViewModel>().ReverseMap();
            CreateMap<Skill, LIstOfSkillsViewModel>().ReverseMap();
            CreateMap<Experience, ListOfExperiencesViewModel>().ReverseMap();
            
        }
    }
}
