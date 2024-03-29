using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public class UserReadDto
    {
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
        /// the user's email
        /// </summary>
        public string Email { get; set; } = string.Empty;
       
    }
}
