using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.Models
{
    public class Song
    {
        [Key]
        public int SongID { get; set; }
        public string Name { get; set; }
        public string Singer { get; set; }
        public string Url { get; set; }
        public ICollection<SongCategory> SongCategories { get; set; }


    }
}
