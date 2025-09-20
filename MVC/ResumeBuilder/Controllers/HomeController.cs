using Microsoft.AspNetCore.Mvc;
using ResumeBuilder.Models;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ResumeBuilder.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<HomeController> _logger;

        public static string connectionString = "Data Source=localhost;Initial Catalog=ResumesDB;Integrated Security=True;";
        public static SqlConnection conn = null;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // Retrieving all the data from db
            List<Resume> resumes = new List<Resume>();
            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("GetAllResumes", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            resumes.Add(
                                new Resume
                                {
                                    Name = dr["Name"].ToString(),
                                    Age = dr["Age"].ToString(),
                                    Email = dr["Email"].ToString(),
                                    Phone = dr["Phone"].ToString(),
                                    Gender = dr["Gender"].ToString(),
                                    Address = dr["Address"].ToString(),
                                    Summary = dr["Summary"].ToString(),
                                    SkillsStr = dr["Skills"].ToString(),
                                    Degree = dr["Degree"].ToString(),
                                    Year = dr["Year"].ToString(),
                                    University = dr["University"].ToString(),
                                    Company = dr["Company"].ToString(),
                                    Role = dr["Role"].ToString(),
                                    Exp = dr["Years"].ToString()
                                }
                            );
                        }
                    }
                }
            }
            finally
            {
                conn.Close();
            }

            return View(resumes);
        }

        [HttpPost]
        public IActionResult Index(Resume resume)
        {
            // Storing data into my db
            try
            {
                using (conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO resumes (Name, Age, Email, Phone, Gender, Address, Summary, Skills, Degree, Year, University, Company, Role, Years)" +
                                   "VALUES (@Name, @Age, @Email, @Phone, @Gender, @Address, @Summary, @Skills, @Degree, @Year, @University, @Company, @Role, @Years);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", resume.Name);
                        cmd.Parameters.AddWithValue("@Age", resume.Age);
                        cmd.Parameters.AddWithValue("@Email", resume.Email);
                        cmd.Parameters.AddWithValue("@Phone", resume.Phone);
                        cmd.Parameters.AddWithValue("@Gender", resume.Gender);
                        cmd.Parameters.AddWithValue("@Address", resume.Address);
                        cmd.Parameters.AddWithValue("@Summary", resume.Summary);
                        cmd.Parameters.AddWithValue("@Skills", resume.SkillsStr);
                        cmd.Parameters.AddWithValue("@Degree", resume.Degree);
                        cmd.Parameters.AddWithValue("@Year", resume.Year);
                        cmd.Parameters.AddWithValue("@University", resume.University);
                        cmd.Parameters.AddWithValue("@Company", resume.Company);
                        cmd.Parameters.AddWithValue("@Role", resume.Role);
                        cmd.Parameters.AddWithValue("@Years", resume.Exp);

                        cmd.ExecuteNonQuery();
                    }

                    TempData["Message"] = "Data Saved Successfully!";
                }
            } 
            catch(Exception ex)
            {
                TempData["Message"] = ex + "Something went wrong!";
            }
            finally
            {
                conn.Close();
            }

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}