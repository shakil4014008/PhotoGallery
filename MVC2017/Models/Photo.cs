using System;
using System.ComponentModel.DataAnnotations;

namespace MVC2017.Models
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }

        [Display(Name = "Description")]
        [Required]
        public String Description { get; set; }

        [Display(Name = "Image Path")]
        public String ImagePath { get; set; }

        [Display(Name = "Thumb Path")]
        public String ThumbPath { get; set; }


        [Display(Name = "Created On")]
        public DateTime CreatedOn { get; set; }
    }

}