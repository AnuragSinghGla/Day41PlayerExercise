using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppExercise.Models
{
    [Table("Player")]
    public class Players
    {
        [Key]
        public int PId { get; set; }
        public string PName { get; set; }
        public int BattingAverage { get; set; }
        public int BowlingAverage { get; set; }
        public string PTeam { get; set; }


    }
}