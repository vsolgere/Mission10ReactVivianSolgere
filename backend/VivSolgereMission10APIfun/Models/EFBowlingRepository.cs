using Microsoft.EntityFrameworkCore;

namespace VivSolgereMission10APIfun.Models
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _context;
        public EFBowlingRepository(BowlingLeagueContext temp) { 
            _context = temp;
        }
        public IEnumerable<Bowler> bowlers => _context.Bowlers;

        public IEnumerable<Team> teams => _context.Teams;
    }
}
