using EMS_API.Model;

namespace EMS_API.Utilities
{
	public interface IEmployeeService
	{
	 public	Task<List<EmployeeModel>> GetEmployeeListAsync();
		public Task<List<EmployeeModel>> GetEmployeeByIdAsync(int Id);
	}
}
