namespace SyncfusionBlazorProfessionalDataGrid.Client.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {LastName}";
        public string Title { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
    }
}
