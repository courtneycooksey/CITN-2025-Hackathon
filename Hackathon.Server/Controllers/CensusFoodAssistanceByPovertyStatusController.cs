using Microsoft.AspNetCore.Mvc;
using Hackathon.Server.Service;
using Hackathon.Server.Models;

namespace Hackathon.Server.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class CensusFoodAssistanceByPovertyStatusController : ControllerBase {
    private CensusFoodAssistanceByPovertyStatusService svc = new CensusFoodAssistanceByPovertyStatusService();

    //GET api/CensusFoodAssistanceByPovertyStatus
    [HttpGet]
    [Route("/api/CensusFoodAssistanceByPovertyStatus")]
    public ActionResult<List<CensusFoodAssistanceByPovertyStatus>> GetAll(){
      return svc.GetAll().ToList();
    }
    
    //GET api/CensusFoodAssistanceByPovertyStatus/5
    [HttpGet("{id}")]
    public ActionResult<CensusFoodAssistanceByPovertyStatus> Get(int id){
      var item = svc.Get(id);
      if(item == null){
        return NotFound();
      }
      return item;
    }
  }
}