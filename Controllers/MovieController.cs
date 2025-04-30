using Microsoft.AspNetCore.Mvc;

namespace modul10_103022300022.Controllers
{
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        static List<string> Stars = new List<string>
        {
            "Stephen King, Frank Darabont",
            "Marlon Brando, AI Pacino",
            "Christian Bale, Health Ledger",
        };

        private static List<Movie> dataMovie = new List<Movie>
        {
            new Movie("The Shawshank Redemption", "Frank Darabont", Stars, "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict" ),
            new Movie("The Godfather", "Frank Ford", Stars , "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son"),
            new Movie("The Dark Knight", "Christopher Nolan", Stars ,"When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness")
        };

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return dataMovie;
        }

        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return dataMovie[id];
        }

        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            dataMovie.Add(movie);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMovie.RemoveAt(id);
        }
    }
}
