namespace Domain.Models
{
    public class Application : BaseEntity
    {
        public int VacancyId { get; set; }
        public string ApplicantId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string CoverLetter { get; set; }
        public string Resume { get; set; }
        public Vacancy Vacancy { get; set; }
        public ApplicationUser Applicant { get; set; }
    }
}