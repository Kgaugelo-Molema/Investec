using Model;
using Movies.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
