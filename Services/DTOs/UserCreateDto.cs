
namespace Services.DTOs
{
    public class UserCreateDto
    {
        /// <summary>
        /// the user's firstname
        /// </summary>
        public string FirstName { get; set; } = string.Empty;
        /// <summary>
        /// the user's lastnmae
        /// </summary>
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; }
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
