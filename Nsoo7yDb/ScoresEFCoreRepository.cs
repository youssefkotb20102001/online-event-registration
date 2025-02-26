using Business;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsoo7yDb
{
    public class ScoresEFCoreRepository : IScoresRepository
    {
        private readonly IDbContextFactory<NsoohyContext> contextFactory;

        public ScoresEFCoreRepository(IDbContextFactory<NsoohyContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public async Task AddScoresAsync(Scores score)
        {
            using (var Db = this.contextFactory.CreateDbContext())
            {
                Db.Scores?.Add(score);
                await Db.SaveChangesAsync();
            }
        }

        public async Task DeleteScoresAsync(int studentRegistrationNumber)
        {
            using var Db = this.contextFactory.CreateDbContext();
            var score = Db.Scores.Find(studentRegistrationNumber);
            if (score is null) return;
            Db.Scores.Remove(score);

            await Db.SaveChangesAsync();


        }

        public async Task<IEnumerable<Scores>> GetScoresByIdAsync(int RegistrationNumber)
        {
            using var Db = this.contextFactory.CreateDbContext();
            var data= await Db.Scores.Where(x => x.RegistrationNumber == RegistrationNumber).ToListAsync(); 
            if(data.Count() == 0) {

                return null;
                    }
            else
            {
                return data;
            }
        }

    }
}
