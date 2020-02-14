using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();
        
        public List<StreamingContent> GetAllContent()
        {
            return _contentDirectory;
        }
        
        public bool AddContentToDirectory(StreamingContent content)
        {
            int directorylength = _contentDirectory.Count();
            _contentDirectory.Add(content);
            bool wasadded = directorylength + 1 == _contentDirectory.Count();
            return wasadded;
        }
        public List<StreamingContent> ReadContentFromDirectory()
        {
            return _contentDirectory;
        }
        public StreamingContent GetContentbyTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }

            }
            return null;
        }
        public bool UpdateyBoi(string originaltitle, StreamingContent newcontent)
        {
            StreamingContent oldyboi = GetContentbyTitle(originaltitle);
            if (oldyboi != null)
            {
                oldyboi.Title = newcontent.Title;
                oldyboi.Description = newcontent.Description;
                oldyboi.QualityRating = newcontent.QualityRating;
                oldyboi.Rating = newcontent.Rating;
                oldyboi.Genre = newcontent.Genre;
                oldyboi.Language = newcontent.Language;
                oldyboi.TypeOfStreamingQuality = newcontent.TypeOfStreamingQuality;
                return true;
                //evaluate for null or whitespace
            }
            return false;
        }
        public bool DeleteyBoi(string title)
        {
            StreamingContent ftopayrespects = GetContentbyTitle(title);
            bool deletionboi = _contentDirectory.Remove(ftopayrespects);
            return deletionboi;
        }

        public StreamingContent GetContentbystarrange(int number)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.QualityRating == number)
                {
                    return content;
                }

            }
            return null;
        }

    }       
}
