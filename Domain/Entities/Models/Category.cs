﻿
namespace Domain.Entities.Models
{
    public class Category
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public IList<Collection>? Collections { get; set; }
    }
}
