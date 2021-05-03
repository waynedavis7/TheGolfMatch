using System.ComponentModel.DataAnnotations;

namespace TheMatch.Domain
{
    public class Player
    {
        [Required]
        public string Id { get; set; }
        [Required] 
        public string Name { get; set; }
    }
}
