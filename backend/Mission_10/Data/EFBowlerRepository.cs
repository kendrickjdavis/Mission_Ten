using Microsoft.EntityFrameworkCore;

namespace Mission_10.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlerContext _bowlContext;
        public EFBowlerRepository(BowlerContext temp)
        {
            _bowlContext = temp;
        }
        public IEnumerable<Bowler> Bowlers => _bowlContext.Bowlers.Include("Team");
    
    }
}
