using System;
using System.Collections.Generic;
using System.Text;
using tasksManagement.DAL.models;

namespace DTO
{
    public class AutoMapperProfile:AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<volunteerDTO, volunteer>();
            CreateMap<volunteer, volunteerDTO>();
        }
    }
}
