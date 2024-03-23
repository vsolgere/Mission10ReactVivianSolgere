using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VivSolgereMission10APIfun.Models;

namespace VivSolgereMission10APIfun.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;
        public BowlingController(IBowlingRepository temp) { 
            _bowlingRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var teamNames = new[] { "Marlins", "Sharks" };

            var bowlingData = from bowler in _bowlingRepository.bowlers
                             join team in _bowlingRepository.teams
                             on bowler.TeamId equals team.TeamId
                              where teamNames.Contains(team.TeamName)
                              select new Bowler
                             {
                                 BowlerId = bowler.BowlerId,
                                 BowlerLastName = bowler.BowlerLastName,
                                 BowlerFirstName = bowler.BowlerFirstName,
                                 BowlerMiddleInit = bowler.BowlerMiddleInit,
                                 BowlerAddress = bowler.BowlerAddress,
                                 BowlerCity = bowler.BowlerCity,
                                 BowlerState = bowler.BowlerState,
                                 BowlerZip = bowler.BowlerZip,
                                 BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                                 TeamId = team.TeamId,
                                 Team = bowler.Team,
                             };

            return bowlingData.ToList(); 
        }
    }
}
