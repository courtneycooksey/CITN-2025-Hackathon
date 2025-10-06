using Microsoft.AspNetCore.Mvc;
using Hackathon.Server.Service;
using Hackathon.Server.Models;

namespace Hackathon.Server.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class RawCensusDataFoodAssistanceController : ControllerBase {
    private RawCensusDataFoodAssistanceService svc = new RawCensusDataFoodAssistanceService();

    //GET api/RawCensusDataFoodAssistance
    [HttpGet]
    [Route("/api/RawCensusDataFoodAssistance")]
    public ActionResult<List<RawCensusDataFoodAssistance>> GetAll(){
      return svc.GetAll().ToList();
    }
    
    //GET api/RawCensusDataFoodAssistance/5
    [HttpGet("{id}")]
    public ActionResult<RawCensusDataFoodAssistance> Get(int id){
      var item = svc.Get(id);
      if(item == null){
        return NotFound();
      }
      return item;
    }
  }
}