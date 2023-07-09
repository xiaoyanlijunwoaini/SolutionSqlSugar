using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Service
{
    public class FlowerReq
    {
        public long id { get; set; }       
             
        public int? Type { get; set; }
    }
}
