using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeRU.Shared
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ImageURL { get; set; } = string.Empty;
        public string Video { get; set; } = string.Empty; 
        
    }
}
