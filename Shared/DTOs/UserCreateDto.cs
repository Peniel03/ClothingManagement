
namespace Shared.DTOs
{
    public class UserCreateDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// the user's firstname
        /// </summary>
        public string FirstName { get; set; } = string.Empty;
        /// <summary>
        /// the user's lastnmae
        /// </summary>
        public string LastName { get; set; } = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PhoneNumber {  get; set; }
        /// <summary>
        /// the user's password
        /// </summary>
        public string Password { get; set; } = string.Empty;
        /// <summary>
        /// isblocked property allow admins to block and unblock users
        /// </summary>
        public Boolean IsBlocked { get; set; } = false; 
    }
}
