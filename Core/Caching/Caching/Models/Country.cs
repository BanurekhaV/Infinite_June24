namespace Caching.Models
{
    public class Country
    {
        public int CountryId { get;set; }
        public string Name { get;set; } 
        public List<State> States { get; set; }
    }
}
