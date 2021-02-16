using Rank.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rank.Data.Services
{
    public class RankedBeingInMemory : IRankedBeingData
    {
        List<RankedBeing> rankedBeings;
        public RankedBeingInMemory()
        {
            rankedBeings = new List<RankedBeing>()
            {
                new RankedBeing() { Rank = 7, Id = 1, MagicType = MagicType.Ice, Name = "Jotun" },
                new RankedBeing() { Rank = 8, Id = 2, MagicType = MagicType.Fire, Name = "Mike" },
                new RankedBeing() { Rank = 9, Id = 3, MagicType = MagicType.Light, Name = "Fred" }
            };
        }

        public void Add(RankedBeing rankedBeing)
        {
            rankedBeing.Id = rankedBeings.Max(m => m.Id) + 1;
            rankedBeings.Add(rankedBeing);
        }

        public IEnumerable<RankedBeing> GetAll()
        {
            return rankedBeings.OrderBy(n => n.Name);
        }

        public RankedBeing GetSingleRankedBeing(int id)
        {
            return rankedBeings.Find(rb => rb.Id == id);
        }

        public void Update(RankedBeing rankedBeing)
        {
            var rankedBeingRemove = rankedBeings.Single(r => r.Id == rankedBeing.Id);
            rankedBeings.Remove(rankedBeingRemove);
            rankedBeings.Add(rankedBeing);
        }
    }
}
