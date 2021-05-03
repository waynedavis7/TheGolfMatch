namespace TheMatch.Domain
{
    public class MatchHole : Hole
    {
        public int Score { get; set; }
        public string Notes { get; set; }
        public string Fairway { get; set; }
        public string Green { get; set; }
        public int Putts { get; set; }

        public int Points
        {
            get
            {

                if(Score ==0 ) { return 0; }

                switch(Score - Par)
                {
                    case -2:
                        return 8;
                    case -1:
                        return 4;
                    case 0:
                        return 2;
                    case 1:
                        return 1;
                    default:
                        return 0;
                }
            }

        }

        public string ScoreDescription
        {
            get
            {

                if (Score == 0) { return "notscored"; }

                switch (Score - Par)
                {
                    case -2:
                        return "eagle";
                    case -1:
                        return "birdie";
                    case 0:
                        return "par";
                    case 1:
                        return "bogey";
                    case 2:
                        return "doublebogey";
                    default:
                        return "other";
                }
            }

        }


    }
}
