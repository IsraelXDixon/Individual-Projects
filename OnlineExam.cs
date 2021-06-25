using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KnowItAlls.Models
{
    public class OnlineExam
    {
        [Key]
        public int Qid {get; set;}
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }

        public string Correctans { get; set; }


    }
}
