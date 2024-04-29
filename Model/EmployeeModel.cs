namespace EMS_API.Model
{
	public class EmployeeModel
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public DateTime HireDate { get; set; }
		public int DepartmentId { get; set; }
		public bool IsDeleted { get; set; }
	}
}
