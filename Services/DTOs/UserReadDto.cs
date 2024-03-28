using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class UserReadDto
    {
        /// <summary>
        /// the user's firstname
        /// </summary>
        public string FirstName { get; set; } = string.Empty;
        /// <summary>
        /// the user's lastnmae
        /// </summary>
        public string LastName { get; set; } = string.Empty;
       
    }
}
