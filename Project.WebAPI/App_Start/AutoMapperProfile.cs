using AutoMapper;
using Project.Common.PagedResultCommon;
using Project.Model;
using Project.Model.Common;
using Project.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.WebAPI.App_Start
{
    public class AutoMapperProfile : Profile
    {
        //Auto Mapper Profile
        public AutoMapperProfile()
        {
            CreateMap<IVehicleMake, VehicleMakeVM>().ReverseMap();
            CreateMap<IVehicleModel, VehicleModelVM>().ReverseMap();
            CreateMap<VehicleMake, VehicleMakeVM>().ReverseMap();
            CreateMap<VehicleModel, VehicleModelVM>().ReverseMap();
            CreateMap<IPagedResult<VehicleMakeVM>,IPagedResult<IVehicleMake>>().ReverseMap();
            CreateMap<IPagedResult<VehicleModelVM>, IPagedResult<IVehicleModel>>().ReverseMap();
        }
    }
}