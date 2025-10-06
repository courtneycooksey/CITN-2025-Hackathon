using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Hackathon.Server.Models;

namespace Hackathon.Server.Service {
  public class CensusPovertyDataService {
    
    private static DbContextOptions<citnhackdbContext> options = new DbContextOptions<citnhackdbContext>(); 
    public citnhackdbContext _context = new citnhackdbContext(options); 

    public IQueryable<CensusPovertyData> GetAll(){
      return _context.CensusPovertyData;
    }
    
    public CensusPovertyData Get(int zip){
      return GetAll().FirstOrDefault(i => i.ZipCode == zip);
    }

  }
}