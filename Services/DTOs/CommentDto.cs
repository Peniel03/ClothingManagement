using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class CommentDto
    {
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
    }
}
