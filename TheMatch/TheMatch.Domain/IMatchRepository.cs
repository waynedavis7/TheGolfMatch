using System.Collections.Generic;

namespace TheMatch.Domain
{
    public interface IMatchRepository
    {
        List<Match> GetMatches();
        Match GetMatch(int matchid);
        void Add(Match match);
        void Delete(Match match);
        void Save();
        void Save(Match match);
    }
}
