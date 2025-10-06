using Microsoft.AspNetCore.Mvc;
using Hackathon.Server.Service;
using Hackathon.Server.Models;

namespace Hackathon.Server.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class CensusFoodAssistanceByHouseholdSeniorMembershipController : ControllerBase {
    private CensusFoodAssistanceByHouseholdSeniorMembershipService svc = new CensusFoodAssistanceByHouseholdSeniorMembershipService();

    //GET api/CensusFoodAssistanceByHouseholdSeniorMembership
    [HttpGet]
    [Route("/api/CensusFoodAssistanceByHouseholdSeniorMembership")]
    public ActionResult<List<CensusFoodAssistanceByHouseholdSeniorMembership>> GetAll(){
      return svc.GetAll().ToList();
    }
    
    //GET api/CensusFoodAssistanceByHouseholdSeniorMembership/5
    [HttpGet("{id}")]
    public ActionResult<CensusFoodAssistanceByHouseholdSeniorMembership> Get(int id){
      var item = svc.Get(id);
      if(item == null){
        return NotFound();
      }
      return item;
    }
  }
}