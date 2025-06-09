
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlbumApp.Entities
{
    public class Album
    {
        public int Id { get; set; } 

        [Required(ErrorMessage = "Please enter Title.")]
        public string Title { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please enter Artist.")]
        public string Artist { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter Rating.")]
        [Range(0.0, 10.0, ErrorMessage = "Rating must be between 0.0 and 10.0.")]
        [Column(TypeName = "decimal(3,1)")] 
        public decimal Rating { get; set; }

        public string Songs { get; set; } = string.Empty; 

      
        public string DisplayText => string.IsNullOrEmpty(Title) ? "No Title" : (Title.Length <= 12 ? Title : Title.Substring(0, 12) + "...");

    }
}

