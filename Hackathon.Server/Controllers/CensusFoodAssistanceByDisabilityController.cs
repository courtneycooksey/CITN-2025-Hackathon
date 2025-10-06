using Microsoft.AspNetCore.Mvc;
using Hackathon.Server.Service;
using Hackathon.Server.Models;

namespace Hackathon.Server.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class CensusFoodAssistanceByDisabilityController : ControllerBase {
    private CensusFoodAssistanceByDisabilityService svc = new CensusFoodAssistanceByDisabilityService();

    //GET api/CensusFoodAssistanceByDisability
    [HttpGet]
    [Route("/api/CensusFoodAssistanceByDisability")]
    public ActionResult<List<CensusFoodAssistanceByDisability>> GetAll(){
      return svc.GetAll().ToList();
    }
    
    //GET api/CensusFoodAssistanceByDisability/5
    [HttpGet("{id}")]
    public ActionResult<CensusFoodAssistanceByDisability> Get(int id){
      var item = svc.Get(id);
      if(item == null){
        return NotFound();
      }
      return item;
    }
  }
}