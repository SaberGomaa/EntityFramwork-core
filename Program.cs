using Microsoft.EntityFrameworkCore;

namespace EntityFramwork.net5 // .net5 == .net core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            #region eager / Expicit loading
            #region eager loading

            //var query =
            //    context.Departments.AsSplitQuery() // to split and filter quers
            //    .Include(e => e.projects)
            //    .Include(d => d.Empolyees)
            //    .ThenInclude(p => p.Attendances).ToList(); // from last included

            #endregion

            /*
             * lazy loading prevented in EF Core
             * But can Add it using core.proxies package from NuGet
             * and make all navigation propertys Virtual 
            */

            //var query = context.Departments.ToList();

            //foreach (var dept in query)
            //{
            //    #region Explicit Loading

            //    //context.Entry(dept).Collection(d => d.Empolyees).Load();
            //    //context.Entry(dept).Reference(d => d.Branchs).Load();

            //    //var emps = 
            //    //    context.Entry(dept).Collection(d=>d.Empolyees).Query().Where(d=> d.ID > 1); 
            //    #endregion



            //    foreach (var emp in dept.Empolyees)
            //    {
            //        Console.WriteLine(emp.Name + " " + emp.ID);
            //    }
            //Console.WriteLine($"DId {dept.ID} \t DName {dept.Name} \t Branch Id {dept.BranchID}");
            //} 
            #endregion

            #region Client VS  Server Evaluation

            //var query =
            //    (from dept in context.Departments
            //     select string.Join(':', "Dept ", dept.Name)).ToList();
            #endregion

            #region EF Functios

            //var query =
            //    (from d in context.Departments
            //     where EF.Functions.Like(d.Name , "%T%") //d.Name.Contains("S")
            //     select d).ToList();

            #endregion
        
            foreach(var item in query)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}