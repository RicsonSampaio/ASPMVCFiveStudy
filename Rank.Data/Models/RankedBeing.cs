using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rank.Data.Models
{
    public class RankedBeing
    {
        public int Id { get; set; }

        [Required]
        public int Rank { get; set; }

        [Required]
        public string Name { get; set; }
        public MagicType MagicType { get; set; }
    }
}
