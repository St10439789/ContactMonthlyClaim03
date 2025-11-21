namespace ContactMonthlyClaim02.Models
{
    public class ClaimViewModel
    {
        public int Id { get; set; }
        public string LecturerName { get; set; }
        public int Hours { get; set; }
        public int Sessions { get; set; } 
        public decimal Rate { get; set; }
        public decimal Total { get; set; }
        public string CoordinatorStatus { get; set; }
        public string ManagerStatus { get; set; }
        public string PaymentStatus { get; set; }
    }
}


