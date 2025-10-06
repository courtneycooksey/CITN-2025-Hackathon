using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Hackathon.Server.Models;

namespace Hackathon.Server.Service {
  public class CensusFoodAssistanceByHouseholdSeniorMembershipService {
    
    private static DbContextOptions<citnhackdbContext> options = new DbContextOptions<citnhackdbContext>(); 
    public citnhackdbContext _context = new citnhackdbContext(options); 

    public IQueryable<CensusFoodAssistanceByHouseholdSeniorMembership> GetAll(){
      return _context.CensusFoodAssistanceByHouseholdSeniorMemberships;
    }
    
    public CensusFoodAssistanceByHouseholdSeniorMembership Get(int id){
      return GetAll().FirstOrDefault(i => i.Id == id);
    }

  }
}