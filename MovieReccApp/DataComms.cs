using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Newtonsoft.Json;
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
        public string LINK;

        //Consrtuctors
        public DataComms()
        {
            Genres = null;
            recList = new ArrayList();
            MovieResult = new MovieResult();
            MovieID.Add("Action", 28);
            MovieID.Add("Adventure", 12);
            MovieID.Add("Animation", 16);
            MovieID.Add("Comedy", 35);
            MovieID.Add("Crime", 80);
            MovieID.Add("Documentary", 99);
            MovieID.Add("Drama", 18);
            MovieID.Add("Family", 10751);
            MovieID.Add("Fantasy", 14);
            MovieID.Add("History", 36);
            MovieID.Add("Horror", 27);
            MovieID.Add("Music", 10402);
            MovieID.Add("Mystery", 9648);
            MovieID.Add("Romance", 10749);
            MovieID.Add("ScienceFiction", 878);
            MovieID.Add("TVMovie", 10770);
            MovieID.Add("Thriller", 53);
            MovieID.Add("War", 10752);
            MovieID.Add("Western", 37);
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
            while (recList.Count != 10)
            {
                //Setting up url for accessing API
                string front = "https://api.themoviedb.org/3/discover/movie?include_adult=false&include_video=false&language=en-US&page=";
                int pagenum = 1; //page number as int
                string page = ""; //page number string
                string middle = "&sort_by=popularity.desc&";
                string genres = "";//list of genre ids in format #%2C for "and" #%7C for "or"
                //convert name to id

                page = pagenum.ToString(); //convert int to string
                string link = front + page + middle + genres; //sew string together to get complete link
                LINK = link;
                Uri requestLink = new Uri(link, UriKind.Absolute);

                //making request to database
                var options = new RestClientOptions(requestLink);
                var client = new RestClient(options);
                var request = new RestRequest("");
                request.AddHeader("accept", "application/json");
                request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiI1NDIyNDg3MjhiYjNmMWRjMWQ5MGVmOGVkNWU3YTExNSIsInN1YiI6IjY1NDY2YWI1MWFjMjkyN2IzMzg3MDZlMyIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.dITRGCQRBupaOk03PcyVXX2mBxWMLdu43KMfZa_xWfk");
                var response = await client.GetAsync(request);
                MovieResult movieResult = JsonConvert.DeserializeObject<MovieResult>(response.Content);
                if (response.IsSuccessStatusCode == false) break; //check if at end of

                //putting results into movie list
                int i = 0; //counter
                foreach (Movie movie in movieResult.Results)
                {
                    recList.Add(movie); //add movie into results
                    if (i < 15) i++; else break; //grab at most 15 results
                }
                pagenum++;
            }
            return;
        }   
    }
}
