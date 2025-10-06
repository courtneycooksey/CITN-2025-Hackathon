using Microsoft.AspNetCore.Mvc;
using Hackathon.Server.Service;
using Hackathon.Server.Models;

namespace Hackathon.Server.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class CensusFoodAssistanceByMaritalStatusController : ControllerBase {
    private CensusFoodAssistanceByMaritalStatusService svc = new CensusFoodAssistanceByMaritalStatusService();

    //GET api/CensusFoodAssistanceByMaritalStatus
    [HttpGet]
    [Route("/api/CensusFoodAssistanceByMaritalStatus")]
    public ActionResult<List<CensusFoodAssistanceByMaritalStatus>> GetAll(){
      return svc.GetAll().ToList();
    }
    
    //GET api/CensusFoodAssistanceByMaritalStatus/5
    [HttpGet("{id}")]
    public ActionResult<CensusFoodAssistanceByMaritalStatus> Get(int id){
      var item = svc.Get(id);
      if(item == null){
        return NotFound();
      }
      return item;
    }
  }
}