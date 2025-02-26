using Business;

namespace Nsoo7yDb
{
    public interface IStudentRepository
    {
        public  Task AddStudentAsync(Students student);
        public  Task DeleteStudentAsync(int studentRegistrationNumber);
        public  Task<IEnumerable<Students>> GetStudentByNameAsync(string name);
        public  Task<Students> GetStudentByIdAsync(int RegistrationNumber);
        public  Task UpdateStudentAsync(Students student);
        

    }
}