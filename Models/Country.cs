using System.ComponentModel.DataAnnotations;
namespace learnAsp.Models
{
    public class Country
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string? description { get; set; }
    }

}
