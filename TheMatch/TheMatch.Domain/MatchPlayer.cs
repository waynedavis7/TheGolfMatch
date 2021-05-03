using System.ComponentModel.DataAnnotations;

namespace TheMatch.Domain
{
    public class MatchPlayer : Player
    {
        [Range(1, int.MaxValue)]
        public int RequiredPoints { get; set; }
        public ScoreCard ScoreCard { get; set; }
    }
}
