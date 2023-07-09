using Microsoft.AspNetCore.Mvc;
using WebApplication1.Common;
using WebApplication1.Model;
using WebApplication1.Model.Entitys;
using WebApplication1.Service;
using WebApplication1.Service.Flower;
using WebApplication1.Service.Flower.Dto; 

namespace WebApplication1.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ToolsController : ControllerBase
    { 
        private IflowerService _iflowerService;

        public ToolsController(IflowerService iflowerService)
        {
            this._iflowerService = iflowerService;
        }

        [HttpGet]
        public void InitDatabase()
        {
            DBContext.InitDataBase();
        }

        [HttpPost]
        public ApiResult GetFlowers(FlowerReq req) {

            ApiResult apiResult = new ApiResult() { IsSuccess=true};
            apiResult.Result = _iflowerService.GetFlowers(req);
            return apiResult;
        }


    }
}
