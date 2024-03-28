using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs
{
    public class LikeDto
    {
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
    }
}
