namespace Models
{
    public class Symptom {
        public int id { get; set; }
        public string name { get; set; }
        public Category mainCategory { get; set; }
        public ICollection<Category> categories { get; set; }
    }
}