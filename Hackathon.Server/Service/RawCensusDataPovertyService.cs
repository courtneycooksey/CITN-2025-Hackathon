using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Hackathon.Server.Models;

namespace Hackathon.Server.Service {
  public class RawCensusDataPovertyService {
    
    private static DbContextOptions<citnhackdbContext> options = new DbContextOptions<citnhackdbContext>(); 
    public citnhackdbContext _context = new citnhackdbContext(options); 

    public IQueryable<RawCensusDataPoverty> GetAll(){
      return _context.RawCensusDataPoverties;
    }
    
    public RawCensusDataPoverty Get(int zip){
      return GetAll().FirstOrDefault(i => i.Zipcode == zip);
    }

  }
}