namespace Domain.Models
{
    public class Vacancy : BaseEntity
    {
        public string VacancyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public decimal Salary { get; set; }
        public int MaxApplications { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsArchived { get; set; }
        public ICollection<Application>? Applications { get; set; }
    }
}