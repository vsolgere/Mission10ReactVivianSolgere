using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VivSolgereMission10APIfun.Models;

public partial class Team
{
    [Key]
    [Required]
    public int TeamId { get; set; }

    public string TeamName { get; set; } = null!;

    public int? CaptainId { get; set; }

    [JsonIgnore]
    public virtual ICollection<Bowler> Bowlers { get; set; } = new List<Bowler>();

}
