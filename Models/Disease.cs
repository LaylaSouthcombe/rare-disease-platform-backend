namespace Models
{
    public class Disease {
        public int id { get; set; }
        public string name { get; set; }
        public Category mainCategory { get; set; }
        public ICollection<Category> categories { get; set; }
        public ICollection<Symptom> Symptoms {get; set;}
    }
}