using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using RestSharp;

namespace MovieReccApp
{
    public class DataComms
    {
        //dictionary for converting 
        IDictionary<string, int> MovieID = new Dictionary<string, int>();
        //Class variables
        public Object[] Genres; //array to store genres currently used
        public ArrayList recList; //array to store movie rec list
        public MovieResult MovieResult; 

        //Consrtuctors
        public DataComms()
        {
            Genres = null;

        }

        //grabs genres from mainWindow and sets it in class
        //returns -1 on error
        //returns 1 on success
        public int setGenres(ArrayList genres)
        {
            //check that input was valid
            if (genres == null)
                return -1;

            //Convert the array list to an array and store in Class variable
            Genres = genres.ToArray();
            return 1;
        }

        //get Genres
        public Object getGenres()
        {
            return Genres;
        }

        public ArrayList getMovieResults()
        {
            return recList;
        }

        //sends request to API to search for movies with the requested genres
        public async void GetRecsFromDatabase()
        {
            string front = "https://api.themoviedb.org/3/discover/movie?include_adult=false&include_video=false&language=en-US&page=1&sort_by=popularity.desc&";
            string genres = "";

            while (recList.length != 10)
            {
                var options = new RestClientOptions("https://api.themoviedb.org/3/discover/movie?include_adult=false&include_video=false&language=en-US&page=1&sort_by=popularity.desc&with_genres=18");
                var client = new RestClient(options);
                var request = new RestRequest("");
                request.AddHeader("accept", "application/json");
                request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiI1NDIyNDg3MjhiYjNmMWRjMWQ5MGVmOGVkNWU3YTExNSIsInN1YiI6IjY1NDY2YWI1MWFjMjkyN2IzMzg3MDZlMyIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.dITRGCQRBupaOk03PcyVXX2mBxWMLdu43KMfZa_xWfk");
                var response = await client.GetAsync(request);
            }

            return;
        }   
    }
}
