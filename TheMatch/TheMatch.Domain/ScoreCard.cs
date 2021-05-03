using System.Collections.Generic;
using System.Linq;

namespace TheMatch.Domain
{
    public class ScoreCard
    {
        public ScoreCard()
        {
            Holes = new List<MatchHole>();
        }
        public List<MatchHole> Holes { get; set; }

        public int TotalScore
        {
            get
            {
                return Holes.Sum(x => x.Score);
            }
        }

        public int TotalFrontScore
        {
            get
            {
                return Holes.Where(y => y.Id < 10).Sum(x => x.Score);
            }
        }

        public int TotalBackScore
        {
            get
            {
                return Holes.Where(y => y.Id >= 10).Sum(x => x.Score);
            }
        }

        public int TotalPoints
        {
            get
            {
                return Holes.Sum(x => x.Points);
            }
        }

        public int TotalFrontPoints
        {
            get
            {
                return Holes.Where(y => y.Id < 10).Sum(x => x.Points);
            }
        }

        public int TotalBackPoints
        {
            get
            {
                return Holes.Where(y => y.Id >= 10).Sum(x => x.Points);
            }
        }

        public int TotalPutts
        {
            get
            {
                return Holes.Sum(x => x.Putts);

            }
        }

        public string TotalGreens
        {
            get
            {
                double greensHit = Holes.Where(x => x.Green == "Yes").Count();
                double greensTotal = Holes.Where(x => x.Score != 0).Count();

                if (greensTotal == 0)
                {
                    return "";
                }
                else
                {
                    var percent = (int)((greensHit / greensTotal) * 100);
                    return $"{greensHit} of {greensTotal}  ({percent} %)";
                }
            }

        }

        public string TotalFairways
        {
            get
            {

                double fairwaysHit = Holes.Where(x => x.Par > 3 && x.Fairway == "Fairway").Count();
                double fairwaysTotal = Holes.Where(x => x.Par > 3 && x.Score != 0).Count();

                if (fairwaysTotal == 0)
                {
                    return "";
                }
                else
                {
                    var percent = (int)((fairwaysHit / fairwaysTotal) * 100);
                    return $"{fairwaysHit} of {fairwaysTotal}  ({percent} %)";
                }
            }
        }

        public string ScoreRelativeToPar
        {
            get
            {

                int par = Holes.Where(x => x.Score > 0).Sum(y=>y.Par);
                int score = Holes.Where(x => x.Score > 0).Sum(y => y.Score);

                if (par == 0)
                {
                    return "";
                }
                else
                {
                    var total = score - par;
                    var symbol = total > 0 ? "+" : total < 0 ? "-" : "E" ;

                    if (total == 0)
                    {
                        return "(E)";
                    }
                    else {
                        return $" ({symbol}{System.Math.Abs(total)})";
                    }

                }
            }
        }

    }
}
