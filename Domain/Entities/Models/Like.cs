

namespace Domain.Entities.Models
{
    /// <summary>
    /// the like model , handles likes on a item (clothe)
    /// </summary>
    public class Like
    {
        /// <summary>
        /// the like's id
        /// </summary>
        public string Id { get; set; } = Guid.NewGuid().ToString();
        /// <summary>
        /// the like icon's url
        /// </summary>
        public string IconUrl { get; set; } = string.Empty;
        /// <summary>
        /// the isliked property , handles like and unlike on a item(clothe)
        /// </summary>
        public Boolean IsLiked { get; set; } = false;
        /// <summary>
        /// the like's cration date & time
        /// </summary>
        public DateTime CreationDateTime { get; set; }
        /// <summary>
        /// navigavion property for the clothe model
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
        public string UserId {  get; set; } 
    }
}
