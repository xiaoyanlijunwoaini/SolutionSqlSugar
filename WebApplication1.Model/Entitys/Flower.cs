using SqlSugar;
using System.Security.Principal;

namespace WebApplication1.Model.Entitys
{
    public class Flower
    {

        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public long Id { get; set; }

        [SugarColumn(IsNullable = true)]
        public string? Title { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public string? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public string? BigImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public string? Description { get; set; }



        [SugarColumn(IsNullable = true)]
        public long Price { get; set; }

        [SugarColumn(IsNullable = true)]
        public string Language { get; set; }

        [SugarColumn(IsNullable = true)]
        public string? Material { get; set; }

        [SugarColumn(IsNullable = true)]
        public string? Packing { get; set; }


        [SugarColumn(IsNullable = true)]
        public string? DeliveryRemarks { get; set; }


        [SugarColumn(IsNullable = true)]
        public int? Type { get; set; }

    }
}
