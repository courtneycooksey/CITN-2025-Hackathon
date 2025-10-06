using Microsoft.AspNetCore.Mvc;
using Hackathon.Server.Service;
using Hackathon.Server.Models;

namespace Hackathon.Server.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class CensusPovertyByLevelOfEducationController : ControllerBase {
    private CensusPovertyByLevelOfEducationService svc = new CensusPovertyByLevelOfEducationService();

    //GET api/CensusPovertyByLevelOfEducation
    [HttpGet]
    [Route("/api/CensusPovertyByLevelOfEducation")]
    public ActionResult<List<CensusPovertyByLevelOfEducation>> GetAll(){
      return svc.GetAll().ToList();
    }
    
    //GET api/CensusPovertyByLevelOfEducation/5
    [HttpGet("{id}")]
    public ActionResult<CensusPovertyByLevelOfEducation> Get(int id){
      var item = svc.Get(id);
      if(item == null){
        return NotFound();
      }
      return item;
    }
  }
}