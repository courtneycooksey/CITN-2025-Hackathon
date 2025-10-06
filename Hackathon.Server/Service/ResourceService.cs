using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Hackathon.Server.Models;

namespace Hackathon.Server.Service {
  public class ResourceService {
    
    private static DbContextOptions<citnhackdbContext> options = new DbContextOptions<citnhackdbContext>(); 
    public citnhackdbContext _context = new citnhackdbContext(options); 

    public IQueryable<Resource> GetAll(){
      return _context.Resources;
    }
    
    public Resource Get(int id){
      return GetAll().FirstOrDefault(i => i.Id == id);
    }

  }
}