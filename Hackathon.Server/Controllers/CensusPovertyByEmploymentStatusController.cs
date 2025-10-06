using Microsoft.AspNetCore.Mvc;
using Hackathon.Server.Service;
using Hackathon.Server.Models;

namespace Hackathon.Server.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class CensusPovertyByEmploymentStatusController : ControllerBase {
    private CensusPovertyByEmploymentStatusService svc = new CensusPovertyByEmploymentStatusService();

    //GET api/CensusPovertyByEmploymentStatus
    [HttpGet]
    [Route("/api/CensusPovertyByEmploymentStatus")]
    public ActionResult<List<CensusPovertyByEmploymentStatus>> GetAll(){
      return svc.GetAll().ToList();
    }
    
    //GET api/CensusPovertyByEmploymentStatus/5
    [HttpGet("{id}")]
    public ActionResult<CensusPovertyByEmploymentStatus> Get(int id){
      var item = svc.Get(id);
      if(item == null){
        return NotFound();
      }
      return item;
    }
  }
}