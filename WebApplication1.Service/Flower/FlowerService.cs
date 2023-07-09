using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Common;
using WebApplication1.Service.Flower.Dto;

namespace WebApplication1.Service.Flower
{
    public class FlowerService : IflowerService
    {
        private readonly IMapper _mapper;
        public FlowerService(IMapper mapper) {
            _mapper = mapper;
        }

        public List<FlowerRes> GetFlowers(FlowerReq req)
        {
            List<WebApplication1.Model.Entitys.Flower> res = new List<WebApplication1.Model.Entitys.Flower>();
            res = DBContext.db.Queryable<WebApplication1.Model.Entitys.Flower>().WhereIF(req.id > 0, x => x.Id == req.id).ToList();
            return _mapper.Map<List<FlowerRes>>(res);
        }
    }
}
