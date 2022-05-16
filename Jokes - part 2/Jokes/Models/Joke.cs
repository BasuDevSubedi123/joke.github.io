namespace Jokes.Models
{
    public class Joke
    {
        public int Id{ get; set; }
        public String jokeQuestion { get; set; }

        public String  JokeAnswer { get; set; }

        public String Language { get; set; }

        public Joke()
        {

        }
   }
}
