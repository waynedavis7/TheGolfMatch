using System.Collections.Generic;
using System.Linq;

namespace TheMatch.Domain
{
    public class Tee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Hole> Holes { get; set; }

        public int ScoreToPar()
        {
            return Holes.Sum(x => x.Par);
        }
        public int ScoreToParFront9()
        {
            return Holes.Where(x => x.Id < 10).Sum(x => x.Par);
        }
        public int ScoreToParBack9()
        {
            return Holes.Where(x => x.Id >= 10).Sum(x => x.Par);
        }
    }
}
