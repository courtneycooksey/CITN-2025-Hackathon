using Microsoft.AspNetCore.Mvc;
using Hackathon.Server.Service;
using Hackathon.Server.Models;

namespace Hackathon.Server.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class CensusPovertyDataController : ControllerBase {
    private CensusPovertyDataService svc = new CensusPovertyDataService();

    //GET api/CensusPovertyData
    [HttpGet]
    [Route("/api/CensusPovertyData")]
    public ActionResult<List<CensusPovertyData>> GetAll(){
      return svc.GetAll().ToList();
    }
    
    //GET api/CensusPovertyData/5
    [HttpGet("{id}")]
    public ActionResult<CensusPovertyData> Get(int id){
      var item = svc.Get(id);
      if(item == null){
        return NotFound();
      }
      return item;
    }
  }
}