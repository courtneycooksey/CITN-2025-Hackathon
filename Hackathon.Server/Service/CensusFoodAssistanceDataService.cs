using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Hackathon.Server.Models;

namespace Hackathon.Server.Service {
  public class CensusFoodAssistanceDataService {
    
    private static DbContextOptions<citnhackdbContext> options = new DbContextOptions<citnhackdbContext>(); 
    public citnhackdbContext _context = new citnhackdbContext(options); 

    public IQueryable<CensusFoodAssistanceData> GetAll(){
      return _context.CensusFoodAssistanceData;
    }
    
    public CensusFoodAssistanceData Get(int zip){
      return GetAll().FirstOrDefault(i => i.ZipCode == zip);
    }

  }
}