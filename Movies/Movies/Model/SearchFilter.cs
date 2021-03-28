using Model;
using System.Collections.Generic;

namespace Movies.Model
{
    public class SearchFilter
    {
        public SearchFilter(IEnumerable<Character> characters, IEnumerable<Joke> jokes)
        {
            Characters = characters;
            Jokes = jokes;
        }

        public IEnumerable<Character> Characters { get; }
        public IEnumerable<Joke> Jokes { get; }
    }

}
