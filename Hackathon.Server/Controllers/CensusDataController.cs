using Microsoft.AspNetCore.Mvc;
using Hackathon.Server.Service;
using Hackathon.Server.Models;

namespace Hackathon.Server.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class CensusDataController : ControllerBase {
    private CensusDataService svc = new CensusDataService();

    //GET api/CensusData
    [HttpGet]
    [Route("/api/CensusData")]
    public ActionResult<List<CensusData>> GetAll(){
      return svc.GetAll().ToList();
    }
    
    //GET api/CensusData/5
    [HttpGet("{id}")]
    public ActionResult<CensusData> Get(int id){
      var item = svc.Get(id);
      if(item == null){
        return NotFound();
      }
      return item;
    }
  }
}