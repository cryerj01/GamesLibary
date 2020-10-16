using System;
using System.ComponentModel.DataAnnotations;

namespace LibaryOfGames.Models
{
    public class Games
    {
        [Key]
        public int id { set; get; }
        public string GameTitle { set; get; }
        public string Genre { set; get; }

        [DataType(DataType.Date)]
        public DateTime published { set; get; }
        public double price { set; get; }


    }
}
