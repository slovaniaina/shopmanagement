using System;
using System.ComponentModel.DataAnnotations;

namespace ShopManagement.Models
{
    public class Article
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public decimal Price { get; set; }

        [Display(Name = "Creation Date")]
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Modification Date")]
        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; }

        public Article()
        {

        }
    }
}
