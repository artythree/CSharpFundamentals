using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository.contenttypes
{
    public class tv : StreamingContent
    {
        public tv()
        {
            Episodes = new List<Episode>();
        }
        public tv(string genre, string title, int qualityRating, StreamingQualityType typeofstreamingquality, string description, string language, ContentRatings rating, List<Episode> episodes)
            : base(genre, title, qualityRating, typeofstreamingquality, description, language, rating)
        {
            episodes = Episodes;
        }

        //hashsets
        //check each episode and add season number to a collection
        //look for all unique season numbers
        public int SeasonCount { get
            {
                HashSet<int> seasonNumbers = new HashSet<int>();
                foreach (Episode episode in Episodes)
                {
                    seasonNumbers.Add(episode.SeasonNumber);
                }
                return seasonNumbers.Count;
            }
        }
        public int EpisodeCount
        {
            get => Episodes.Count; //shorthand for return in one line get only situation
        }
        public List<Episode> Episodes { get; set; }
        public double AvgRunTime
        {
            get
            {
                double TotalRuntime = 0d;
                foreach (Episode episode in Episodes)
                {
                    TotalRuntime += episode.RunTime;
                }
                Double AvgRuntime = TotalRuntime / EpisodeCount;
                return AvgRuntime;
            }
        }

        public class Episode
        {
            public string EpisodeTitle { get; set; }
            public string EpisodeDescription { get; set; }
            public double RunTime { get; set; }
            public int SeasonNumber { get; set; }
            public int EpisodeNumber { get; set; }
        }
    }
}
