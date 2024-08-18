namespace EmployeeAdminPortal.Models
{
    public class UpdateEmployeeDto
    {
        public string? Phone { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public decimal Salary { get; set; }
    }
}
