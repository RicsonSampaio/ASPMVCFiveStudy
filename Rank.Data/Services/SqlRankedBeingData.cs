using Rank.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rank.Data.Services
{
    public class SqlRankedBeingData : IRankedBeingData
    {
        private readonly ASPMVCFiveStudyDbContext context;

        public SqlRankedBeingData(ASPMVCFiveStudyDbContext context)
        {
            this.context = context;
        }

        public void Add(RankedBeing rankedBeing)
        {
            context.RankedBeings.Add(rankedBeing);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var rankedBeing = context.RankedBeings.Find(id);
            context.RankedBeings.Remove(rankedBeing);
            context.SaveChanges();
        }

        public IEnumerable<RankedBeing> GetAll()
        {
            return context.RankedBeings.OrderBy(rb => rb.Name);
        }

        public RankedBeing GetSingleRankedBeing(int id)
        {
            return context.RankedBeings.FirstOrDefault(rb => rb.Id == id);
        }

        public void Update(RankedBeing rankedBeing)
        {
            var entry = context.Entry(rankedBeing);
            entry.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
