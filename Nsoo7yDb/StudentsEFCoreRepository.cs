using Business;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsoo7yDb
{
    public class StudentsEFCoreRepository:IStudentRepository
    {
        private readonly IDbContextFactory<NsoohyContext> contextFactory;

        public StudentsEFCoreRepository(IDbContextFactory<NsoohyContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public async Task AddStudentAsync(Students student)
        {
           using(var Db = this.contextFactory.CreateDbContext())
            {
                Db.Students?.Add(student);
                await Db.SaveChangesAsync();
            }
        }

        public async Task DeleteStudentAsync(int studentRegistrationNumber)
        {
            using var Db = this.contextFactory.CreateDbContext();
            var student=Db.Students.Find(studentRegistrationNumber);
            if (student is null) return;
            Db.Students.Remove(student);

        await Db.SaveChangesAsync();


        }

        public async Task<Students> GetStudentByIdAsync(int RegistrationNumber)
        {
            using var Db = this.contextFactory.CreateDbContext();
            var student=await Db.Students.FindAsync(RegistrationNumber);
            if (student is not null) return student;
            return new Students();
        }

        public async Task<IEnumerable<Students>> GetStudentByNameAsync(string name)
        {
            using var Db = this.contextFactory.CreateDbContext();
            return await Db.Students.Where(x => x.FirstName.ToLower().IndexOf(name.ToLower()) >= 0).ToListAsync();
        }

        public async Task UpdateStudentAsync(Students student)
        {
            using var Db = this.contextFactory.CreateDbContext();
            var inv=await Db.Students.FindAsync(student.RegistrationNumber);
            if(inv is not null)
            {
                inv.RegistrationNumber = student.RegistrationNumber;
                inv.FirstName = student.FirstName;
                inv.LastName = student.LastName;
                inv.PhoneNumber = student.PhoneNumber;
                await Db.SaveChangesAsync();
            }
            
        }

    }
}
