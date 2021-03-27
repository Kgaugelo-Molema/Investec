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
        public SearchFilter(IEnumerable<string> categories, IEnumerable<Character> characters)
        {
            Categories = categories;
            Characters = characters;
        }

        public IEnumerable<Character> Characters { get; }
        public IEnumerable<string> Categories { get; }
    }
}
