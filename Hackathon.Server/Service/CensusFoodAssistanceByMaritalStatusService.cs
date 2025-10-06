using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Hackathon.Server.Models;

namespace Hackathon.Server.Service {
  public class CensusFoodAssistanceByMaritalStatusService {
    
    private static DbContextOptions<citnhackdbContext> options = new DbContextOptions<citnhackdbContext>(); 
    public citnhackdbContext _context = new citnhackdbContext(options); 

    public IQueryable<CensusFoodAssistanceByMaritalStatus> GetAll(){
      return _context.CensusFoodAssistanceByMaritalStatuses;
    }
    
    public CensusFoodAssistanceByMaritalStatus Get(int id){
      return GetAll().FirstOrDefault(i => i.Id == id);
    }

  }
}