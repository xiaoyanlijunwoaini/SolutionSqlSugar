using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Model.Entitys;
using WebApplication1.Service.Flower.Dto;

namespace WebApplication1.Service.Config
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<WebApplication1.Model.Entitys.Flower, FlowerRes>();
        }
    }
}
