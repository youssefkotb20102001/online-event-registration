using Business;

namespace Nsoo7yDb
{
    public interface IScoresRepository
    {
        public Task AddScoresAsync(Scores score);
        public Task DeleteScoresAsync(int studentRegistrationNumber);
        public Task<IEnumerable<Scores>> GetScoresByIdAsync(int RegistrationNumber);
    
    }
}