using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public enum StreamingQualityType { SD240, SD360, SD480, HD720, FHD1080, UHD4k}
    public enum ContentRatings { G, PG, PG13, R, NC17}
    public class StreamingContent
    {
        public string Genre { get; set; }
        public string Title { get; set; }
        public int QualityRating { get; set; }
        public StreamingQualityType TypeOfStreamingQuality { get; set; }
        public ContentRatings Rating { get; set; }

        public string Description { get; set; }
        public string Language { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                //string rating = Rating.ToLower();
                //if (rating == "g" || rating == "pg")
                //{

                //    Console.WriteLine("This movie is family friendly");
                //    return IsFamilyFriendly;
                //}
                //else
                //{
                //    Console.WriteLine("This is not family friendly");
                //    return false;

                switch (Rating)//sw tab tab
                {
                    case ContentRatings.G:
                    case ContentRatings.PG:
                    case ContentRatings.PG13:
                        return true;
                    default:
                        return false;
                }
            }

            
            
        }
        public StreamingContent() { }
        public StreamingContent(string genre, string title, int qualityRating, StreamingQualityType typeofstreamingquality, string description, string language, ContentRatings rating)
        {
            Genre = genre;
            Title = title;
            QualityRating = qualityRating;
            TypeOfStreamingQuality = typeofstreamingquality;
            Description = description;
            Language = language; 
            Rating = rating;

        }
    }
}
