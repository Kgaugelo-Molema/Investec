using Movies.Model;
using System.Collections;
using System.Collections.Generic;

namespace Model
{
    public class JokeData
    {
        public int total { get; set; }
        public IEnumerable<Joke> result { get; set; }
    }
}
