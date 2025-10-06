using Microsoft.AspNetCore.Mvc;
using Hackathon.Server.Service;
using Hackathon.Server.Models;

namespace Hackathon.Server.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class ResourceTypeController : ControllerBase {
    private ResourceTypeService svc = new ResourceTypeService();

    //GET api/ResourceType
    [HttpGet]
    [Route("/api/ResourceType")]
    public ActionResult<List<ResourceType>> GetAll(){
      return svc.GetAll().ToList();
    }
    
    //GET api/ResourceType/5
    [HttpGet("{id}")]
    public ActionResult<ResourceType> Get(int id){
      var item = svc.Get(id);
      if(item == null){
        return NotFound();
      }
      return item;
    }
  }
}