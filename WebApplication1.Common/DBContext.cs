using SqlSugar;
using System.Reflection;
using WebApplication1.Model.Entitys;

namespace WebApplication1.Common
{
    public class DBContext
    {
        public static SqlSugarClient db = new SqlSugarClient(new ConnectionConfig {

            //ConnectionString = "server=DESKTOP-SBGTMOS;database=GarageDb2;Connection Timeout=200;Persist Security Info=True;Pooling=true;uid=sa;pwd=Wchy@2015",
            ConnectionString= "Data Source=DESKTOP-SBGTMOS;Initial Catalog=GarageDb2;User Id=sa;Password=Wchy@2015",
            DbType =DbType.SqlServer,//数据库类型
            IsAutoCloseConnection=true //不设成true 要手动close 

        });

        public static void InitDataBase()
        {
            //初始化数据库：如果不存在则创建数据库
            db.DbMaintenance.CreateDatabase();

            string nspace = "WebApplication1.Model.Entitys";
            Type[] ass = Assembly.LoadFrom("bin/Debug/net7.0/WebApplication1.Model.dll").GetTypes().Where(p => p.Namespace == nspace).ToArray();
            db.CodeFirst.SetStringDefaultLength(200).InitTables(ass);
            
            #region  加入测试数据
            List<Flower> flowers = new List<Flower>() { 
            new Flower(){
                Image="/images/content/a1.jpg",
                BigImage="/images/content/a1.jpg",
                Description="Description",
                Price=200,
                Language="dkfjldkdkdkdj",
                Packing="kdfjdkfss",
                DeliveryRemarks="dfdf",
                Type=1
            },
            new Flower(){
                Image="/images/content/a1.jpg",
                BigImage="/images/content/a1.jpg",
                Description="Description",
                Price=200,
                Language="232323dkdkdj",
                Packing="kdfjdkfss",
                DeliveryRemarks="dfdf",
                Type=1
            }
            };
            #endregion

            //插入数据到数据库中 dddddd
            db.Insertable(flowers).ExecuteCommand();
        }
    }
}
