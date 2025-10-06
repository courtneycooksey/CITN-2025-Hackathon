using Microsoft.AspNetCore.Mvc;
using Hackathon.Server.Service;
using Hackathon.Server.Models;

namespace Hackathon.Server.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class ResourceController : ControllerBase {
    private ResourceService svc = new ResourceService();

    //GET api/Resource
    [HttpGet]
    [Route("/api/Resource")]
    public ActionResult<List<Resource>> GetAll(){
      return svc.GetAll().ToList();
    }
    
    //GET api/Resource/5
    [HttpGet("{id}")]
    public ActionResult<Resource> Get(int id){
      var item = svc.Get(id);
      if(item == null){
        return NotFound();
      }
      return item;
    }
  }
}