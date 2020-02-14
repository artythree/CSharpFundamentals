using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository.contenttypes
{
    public class movie : StreamingContent
    {
        public movie(){}
        
        public movie(string genre, string title, int qualityRating, StreamingQualityType typeofstreamingquality, string description, string language, ContentRatings rating, double runTime)
            : base(genre, title, qualityRating, typeofstreamingquality, description, language, rating)
        {
            runTime = RunTime;
        }
        public double RunTime { get; set; }
    }
}
