using Rank.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rank.Data.Services
{
    public class ASPMVCFiveStudyDbContext : DbContext
    {
        public DbSet<RankedBeing> RankedBeings { get; set; }
    }
}
