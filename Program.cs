using Microsoft.EntityFrameworkCore;

namespace EntityFramwork.net5 // .net5 == .net core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            #region eager loading

            var query =
                context.Departments.AsSplitQuery() // to split and filter quers
                .Include(e => e.projects)
                .Include(d => d.Empolyees)
                .ThenInclude(p => p.Attendances).ToList(); // from last included

            #endregion

            var query1 =
                from emps in context.Empolyee 
                where emps.ID > 2
                select new { emps.ID, EmpolyeeName = emps.Name , emps.Salary };


            foreach(var e in query1)
            {
                Console.WriteLine($"Id {e.ID} \t Name {e.EmpolyeeName} \t Salary {e.Salary}");
            }

            // lazy loading prevented in EF Core
            //foreach (var dept in query)
            //{
            //    foreach (var emp in dept.Empolyees)
            //    {
            //        Console.WriteLine(emp.Name);
            //    }
            //    //Console.WriteLine($"DId {dept.ID} \t DName {dept.Name} \t Branch Id {dept.BranchID}");
            //}
        }
    }
}