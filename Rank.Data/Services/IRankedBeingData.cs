using Rank.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rank.Data.Services
{
    public interface IRankedBeingData
    {
        IEnumerable<RankedBeing> GetAll();
        RankedBeing GetSingleRankedBeing(int id);
        void Add(RankedBeing rankedBeing);
        void Update(RankedBeing rankedBeing);
        void Delete(int id);
    }
}
