using Microsoft.AspNetCore.Mvc;
using Hackathon.Server.Service;
using Hackathon.Server.Models;

namespace Hackathon.Server.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class CensusPovertyByWorkExperienceController : ControllerBase {
    private CensusPovertyByWorkExperienceService svc = new CensusPovertyByWorkExperienceService();

    //GET api/CensusPovertyByWorkExperience
    [HttpGet]
    [Route("/api/CensusPovertyByWorkExperience")]
    public ActionResult<List<CensusPovertyByWorkExperience>> GetAll(){
      return svc.GetAll().ToList();
    }
    
    //GET api/CensusPovertyByWorkExperience/5
    [HttpGet("{id}")]
    public ActionResult<CensusPovertyByWorkExperience> Get(int id){
      var item = svc.Get(id);
      if(item == null){
        return NotFound();
      }
      return item;
    }
  }
}