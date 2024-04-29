using Dapper;
using EMS_API.Model;
using Microsoft.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EMS_API.Utilities
{
	

	public class EmployeeService : IEmployeeService
	{
		private readonly IConfiguration _configuration;
        string connectionString = "Data Source=HO-DEV-HMOHALE\\MSSQLSERVER04;Initial Catalog=EmployeeManagementSystem;Integrated Security=True;Encrypt=False";

        public EmployeeService(IConfiguration config)
		{
			_configuration = config;
		}

		public async Task<List<EmployeeModel>> GetEmployeeListAsync()
		{

			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
                    return (await connection.QueryAsync<EmployeeModel>("prc_GetEmployeeList", new { }, commandType: CommandType.StoredProcedure)).ToList();
                }
			}
			catch (Exception ex)
			{
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw ex;
            }
		}

        public async Task<List<EmployeeModel>> GetEmployeeByIdAsync(int Id)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    return (await connection.QueryAsync<EmployeeModel>("prc_GetEmployeeById", new {employeeId = Id}, commandType: CommandType.StoredProcedure)).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw ex;
            }
        }
    }
}
