using EMS_API.Utilities;
using EMS_API.Model;
using Microsoft.AspNetCore.Mvc;

namespace EMS_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		private readonly IEmployeeService _employeeService;

		public EmployeeController(IEmployeeService employeeService)
		{
			_employeeService = employeeService;
		}

		[HttpGet]
		public async Task<ActionResult<List<EmployeeModel>>> GetEmployeeList()
		{
			var employees = await _employeeService.GetEmployeeListAsync();
			return Ok(employees);
		}

		[HttpGet("{Id:int}")]

		public async Task<ActionResult<List<EmployeeModel>>> GetEmployeeByIdAsync(int Id)
		{
			var employees = await _employeeService.GetEmployeeByIdAsync(Id);
			return Ok(employees);
		}
	}
}
