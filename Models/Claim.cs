using System.ComponentModel.DataAnnotations;

namespace Prog2bPOEPart2.Models
{
    public class Claim
    {
        [Key]
        public int ClaimId { get; set; }

        public string? UserID { get; set; }

        public string? Name { get; set; }

        public DateTime DateSubmitted { get; set; }

        public double HoursWorked { get; set; }

        public double HourlyRate { get; set; }
        public double TotalEarning
        {
            get
            {
                return HoursWorked * HourlyRate;
            }
        }
        public string? ExtraNotes { get; set; }

        public string Status { get; set; } = "Pending";
        public ICollection<Document> Documents { get; set; } = new List<Document>();
    }
}
