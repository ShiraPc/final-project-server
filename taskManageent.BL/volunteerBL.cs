using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using tasksManagement.DAL;
using tasksManagement.DAL.models;

namespace taskManageent.BL
{
    public class volunteerBL
    {
        volunteerDL _volunteerDl = new volunteerDL();
        IMapper mapper;
        public volunteerBL()
        {
           

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }

        public volunteerDTO Getvolunteer(string address)
        {
            // type User =סוג
            // זה המודל שנמצא בשכבת ה-DAL שיקוף של טבלה
            volunteer v = _volunteerDl.GetVolunteer(address);
            if (v == null)
                return null;
            return ConvertToVolunteerDTO(v);
        }
        public void PostVolunteer(volunteerDTO volunteer)
        {
            volunteer v = ConvertToVolunteer(volunteer);
            _volunteerDl.PostVolunteer(v);
        }
        public static volunteerDTO ConvertToVolunteerDTO(volunteer v)
        {
            volunteerDTO vd = new volunteerDTO();
            vd.name = v.name;
            vd.address = v.address;
            vd.telephone = v.telephone;
            return vd;
        }
        public static volunteer ConvertToVolunteer(volunteerDTO v)
        {
            volunteer vo = new volunteer();
            vo.name = v.name;
            vo.address = v.address;
            vo.telephone = v.telephone;
            return vo;
        }


    }
}
