using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.Models
{
    public class SongCategory
    {
        public int SongID { get; set; }
        public Song song { get; set; }
        public int CategoryID { get; set; }
        public Category category { get; set; }
    }

}
