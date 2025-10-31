using DatabaseTask.Core.Domain;
using DatabaseTask.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace DatabaseTask.Controllers
{
    public class EmployeeController : Controller
    {
        public DatabaseTaskDbContext _context;
        public IConfiguration _confiq;

        public EmployeeController (DatabaseTaskDbContext context, IConfiguration confiq)
        {
            _context = context;
            _confiq = confiq;
        }


        [HttpGet]
        public IActionResult Index()
        {
            string connectionStr = _confiq.GetConnectionString("DefaultConnection");
            
            using (SqlConnection con = new SqlConnection(connectionStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "spSearchEmployee";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                List<Employee> model = new List<Employee>();
                while (sdr.Read())
                {
                    var details = new Employee();
                    details.FirstName = sdr["FirstName"].ToString();
                    details.LastName = sdr["LastName"].ToString();
                    details.JobTitle = sdr["JobTitle"].ToString();
                    details.Salary = Convert.ToInt32(sdr["Salary"]);
                    model.Add(details);
                }

                return View(model);
            }
        }
    }
}
