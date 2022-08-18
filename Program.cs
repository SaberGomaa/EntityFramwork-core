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
                context.Departments.AsSplitQuery() // 
                .Include(e => e.projects)
                .Include(d => d.Empolyees)
                .ThenInclude(p => p.Attendances).ToList(); // from last included

            #endregion


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