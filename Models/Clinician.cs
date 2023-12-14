namespace Models
{
    public class Clinician {
        public int id { get; set; }
        public string salutation { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public Category mainSpecialty { get; set; }
        public ICollection<Category> specialties { get; set; }
    }    
}