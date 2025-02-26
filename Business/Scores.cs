using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Scores
    {
        [Key]
        public int Id { get; set; }
        public int Score { get; set; }
        public int RegistrationNumber { get; set; }




    }
}
