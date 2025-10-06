using Microsoft.AspNetCore.Mvc;
using Hackathon.Server.Service;
using Hackathon.Server.Models;

namespace Hackathon.Server.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class RawCensusDataPovertyController : ControllerBase {
    private RawCensusDataPovertyService svc = new RawCensusDataPovertyService();

    //GET api/RawCensusDataPoverty
    [HttpGet]
    [Route("/api/RawCensusDataPoverty")]
    public ActionResult<List<RawCensusDataPoverty>> GetAll(){
      return svc.GetAll().ToList();
    }
    
    //GET api/RawCensusDataPoverty/5
    [HttpGet("{id}")]
    public ActionResult<RawCensusDataPoverty> Get(int id){
      var item = svc.Get(id);
      if(item == null){
        return NotFound();
      }
      return item;
    }
  }
}