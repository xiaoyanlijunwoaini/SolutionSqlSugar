using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Service.Flower.Dto;

namespace WebApplication1.Service.Flower
{
    public interface IflowerService
    {
        List<FlowerRes> GetFlowers(FlowerReq req);
    }
}
