using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Hackathon.Server.Models;

namespace Hackathon.Server.Service {
  public class ResourceTypeService {
    
    private static DbContextOptions<citnhackdbContext> options = new DbContextOptions<citnhackdbContext>(); 
    public citnhackdbContext _context = new citnhackdbContext(options); 

    public IQueryable<ResourceType> GetAll(){
      return _context.ResourceTypes;
    }
    
    public ResourceType Get(int id){
      return GetAll().FirstOrDefault(i => i.Id == id);
    }

  }
}