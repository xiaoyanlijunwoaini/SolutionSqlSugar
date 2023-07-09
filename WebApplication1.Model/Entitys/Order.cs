using SqlSugar;

namespace WebApplication1.Model.Entitys
{
    public class Order
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey =true,IsIdentity =true)]
        public long Id { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [SugarColumn(IsNullable =false)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [SugarColumn(IsNullable =false)]
        public decimal Price { get; set; }

        /// <summary>
        /// 订单日期
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// xiang'hu
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public long FlowerId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [SugarColumn(IsNullable = false)]
        public long UserId { get; set; }
    }
}
