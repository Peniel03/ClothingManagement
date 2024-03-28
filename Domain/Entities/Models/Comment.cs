

namespace Domain.Entities.Models
{
    /// <summary>
    /// the comment model , handles comments on a item (clothe)
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// the commment's id
        /// </summary>
        public string Id { get; set; } = Guid.NewGuid().ToString();
        /// <summary>
        /// the comment icon's url
        /// </summary>
        public string IconUrl { get; set; } = string.Empty;
        /// <summary>
        /// the comment text
        /// </summary>
        public string CommentText { get; set; } = string.Empty;
        /// <summary>
        /// the comment creation date & time
        /// </summary>
        public DateTime CreationDateTime { get; set; }
        /// <summary>
        /// navigation property for the clothe model 
        /// </summary>
        public Clothe? Clothe { get; set; }
        /// <summary>
        /// the clothe model's id
        /// </summary>
        public string ClotheId { get; set; }
        /// <summary>
        /// navigation property for the user model
        /// </summary>
        public User? User { get; set; }
        /// <summary>
        /// the user model's id
        /// </summary>
        public string UserId { get; set; }
    }
}
