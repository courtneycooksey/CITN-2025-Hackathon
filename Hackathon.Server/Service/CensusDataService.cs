using Microsoft.EntityFrameworkCore;
using Hackathon.Server.Models;

namespace Hackathon.Server.Service {
  public class CensusDataService {
    
    private static DbContextOptions<citnhackdbContext> options = new DbContextOptions<citnhackdbContext>(); 
    public citnhackdbContext _context = new citnhackdbContext(options); 

    public IQueryable<CensusData> GetAll(){
      return _context.CensusData;
    }
    
    public CensusData Get(int id){
      return GetAll().FirstOrDefault(i => i.Id == id);
    }
  }
}