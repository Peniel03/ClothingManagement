﻿namespace Domain.Entities.Models
{
    /// <summary>
    /// the collection model , handles user's collections
    /// </summary>
    public class Collection
    {
        /// <summary>
        /// the comment id
        /// </summary>
        public string Id { get; set; } = Guid.NewGuid().ToString();
        /// <summary>
        /// the collection name
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// the collection description
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// the collection image's url
        /// </summary>
        public string ImageUrl { get; set; } = string.Empty;
        /// <summary>
        /// the colection's tag
        /// </summary>
        public string Tag { get; set; } = string.Empty;
        /// <summary>
        /// the Custom_Int1_State , handles the state of teh first (int) 
        /// custom optional field
        /// </summary>
        public Boolean Custom_Int1_State { get; set; } = false;
        /// <summary>
        /// the Custom_Int1_Name , handles the name of the first(int)
        /// custom field
        /// </summary>
        public int Custom_Int1_Name { get; set; }
        public Boolean Custom_Int2_State { get; set; } = false;
        public int Custom_Int2_Name { get; set; }
        public Boolean Custom_Int3_State { get; set; } = false;
        public int Custom_Int3_Name { get; set; }
        public Boolean Custom_String1_State { get; set; } = false;
        public string Custom_String1_Name { get; set; } = string.Empty;
        public Boolean Custom_String2_State { get;set; } = false;
        public string Custom_String2_Name { get; set; } = string.Empty;
        public Boolean Custom_String3_State { get; set; } = false;
        public string Custom_String3_Name { get; set; } = string.Empty;
        public Boolean Custom_MultiplelineText1_State { get; set; } = false;
        public string Custom_MultiplelineText1_Name { get; set; } = string.Empty;
        public Boolean Custom_MultiplelineText2_State { get; set; } = false;
        public string Custom_MultiplelineText2_Name { get; set; } = string.Empty;
        public Boolean Custom_MultiplelineText3_State { get; set; } = false;
        public string Custom_MultiplelineText3_Name { get; set; } = string.Empty;
        public Boolean Custom_Checkbox1_State { get; set; } = false;
        public Boolean Custom_Checkbox1_Name { get; set; } = false;
        public Boolean Custom_Checkbox2_State { get; set; } = false;
        public Boolean Custom_Checkbox2_Name { get; set; } = false;
        public Boolean Custom_Checkbox3_State { get; set; } = false;
        public Boolean Custom_Checkbox3_Name { get; set; } = false;
        public Boolean Custom_DateTime1_State { get; set; } = false;
        public DateTime Custom_DateTime1_Name { get; set; }
        public Boolean Custom_DateTime2_State { get; set; } = false;
        public DateTime Custom_DateTime2_Name { get; set; }
        public Boolean Custom_DateTime3_State { get; set; } = false;
        public DateTime Custom_DateTime3_Name { get; set; }
        public User? User { get; set; }
        public string UserId { get; set; }
        public Category? Category { get; set; }
        public string CategoryId { get; set; }
        public IList<Clothe>? Clothes { get;set; }
    }
}
