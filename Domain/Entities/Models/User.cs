using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.Models
{
    /// <summary>
    /// User model that inherit from IdentityUser
    /// </summary>
    public class User:IdentityUser
    {
        /// <summary>
        /// the user's firstname
        /// </summary>
        public string FirstName {  get; set; } = string.Empty;
        /// <summary>
        /// the user's lastnmae
        /// </summary>
        public string LastName {  get; set; } = string.Empty;
        /// <summary>
        /// the user's password
        /// </summary>
        public string Password { get; set; } = string.Empty;
        /// <summary>
        /// isblocked property allow admins to block and unblock users
        /// </summary>
        public Boolean IsBlocked { get; set; } = false;
        /// <summary>
        /// navigation property for the collection model
        /// </summary>
        public IList<Collection>? Collections { get; set; }
        /// <summary>
        /// navigation property for the like model
        /// </summary>
        public IList<Like>? Likes { get;set; }
        /// <summary>
        /// navigation property for the comment model
        /// </summary>
        public IList<Comment>? Comments { get; set; }  
    }
}
