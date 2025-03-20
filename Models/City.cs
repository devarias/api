using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;

        public City()
        {
        }
    }
}