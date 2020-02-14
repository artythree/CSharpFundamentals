using _07_RepositoryPattern_Repository.contenttypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class streaming_repository : StreamingContentRepository
    {
        // get all shows
        public List<tv> GetAllShows()
        {
            //look at all streaming content to determine if show
            //add each show to a list of shows
            List<tv> tvList = new List<tv>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is tv t)
                {
                    //tvList.Add((tv)content);  <= casting
                    tvList.Add(t);// <= pattern matching
                    
                }
            }
            return tvList;
        }
        //get all movies
        public List<movie> GetAllMovies()
        {
            //look at all streaming content to determine if show
            //add each show to a list of shows
            List<movie> movieList = new List<movie>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is movie m)
                {
                    //movieList.Add((movie)content);  <= casting
                    movieList.Add(m);// <= pattern matching

                }
            }
            return movieList;
        }

        //get show by title
        //get movie by title

        //update existing show
        //update existing movie

        //delete show by title
        //delete movie by title

    }
}
