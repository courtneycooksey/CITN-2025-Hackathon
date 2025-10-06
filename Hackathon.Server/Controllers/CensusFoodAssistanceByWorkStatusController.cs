using Microsoft.AspNetCore.Mvc;
using Hackathon.Server.Service;
using Hackathon.Server.Models;

namespace Hackathon.Server.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class CensusFoodAssistanceByWorkStatusController : ControllerBase {
    private CensusFoodAssistanceByWorkStatusService svc = new CensusFoodAssistanceByWorkStatusService();

    //GET api/CensusFoodAssistanceByWorkStatus
    [HttpGet]
    [Route("/api/CensusFoodAssistanceByWorkStatus")]
    public ActionResult<List<CensusFoodAssistanceByWorkStatus>> GetAll(){
      return svc.GetAll().ToList();
    }
    
    //GET api/CensusFoodAssistanceByWorkStatus/5
    [HttpGet("{id}")]
    public ActionResult<CensusFoodAssistanceByWorkStatus> Get(int id){
      var item = svc.Get(id);
      if(item == null){
        return NotFound();
      }
      return item;
    }
  }
}