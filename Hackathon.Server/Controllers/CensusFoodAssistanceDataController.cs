using Microsoft.AspNetCore.Mvc;
using Hackathon.Server.Service;
using Hackathon.Server.Models;

namespace Hackathon.Server.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class CensusFoodAssistanceDataController : ControllerBase {
    private CensusFoodAssistanceDataService svc = new CensusFoodAssistanceDataService();

    //GET api/CensusFoodAssistanceData
    [HttpGet]
    [Route("/api/CensusFoodAssistanceData")]
    public ActionResult<List<CensusFoodAssistanceData>> GetAll(){
      return svc.GetAll().ToList();
    }
    
    //GET api/CensusFoodAssistanceData/5
    [HttpGet("{id}")]
    public ActionResult<CensusFoodAssistanceData> Get(int id){
      var item = svc.Get(id);
      if(item == null){
        return NotFound();
      }
      return item;
    }
  }
}