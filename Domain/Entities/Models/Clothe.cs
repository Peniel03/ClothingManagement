
namespace Domain.Entities.Models
{
    public class Clothe
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public string ImagrUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Collection? Collection { get; set; }
        public string CollectionId { get; set; }                    
        public IList<Like>? Likes { get; set; }
        public IList<Comment>? Comments { get; set; } 
    }
}
