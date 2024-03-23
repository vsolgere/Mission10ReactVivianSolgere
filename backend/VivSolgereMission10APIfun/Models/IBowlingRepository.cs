namespace VivSolgereMission10APIfun.Models
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> bowlers { get; }
        IEnumerable<Team> teams { get; }
    }
}
