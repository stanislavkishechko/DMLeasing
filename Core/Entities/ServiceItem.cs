using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ServiceItem : IEntityBase
    {
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Fill in the title of the service")]
        public string Title { get; set; }

        public string? Description { get; set; }

        public string? TitleImagePath { get; set; }

        [Required(ErrorMessage = "Fill in the subtitle of the service")]
        public string Subtitle { get; set; }

        [Required(ErrorMessage = "Fill in the price of the service")]
        public string Price { get; set; }

        [Required(ErrorMessage = "Fill in the type of the service")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Fill in the state of the service")]
        public string State { get; set; }
        public string? MetaTitle { get; set; }
        public string? MetaDescription { get; set; }
        public string? MetaKeywords { get; set  ; }
    }
}
