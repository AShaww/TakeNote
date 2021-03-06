using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TakeNote.Models
{
    [Table("Notes")]
    public class Note
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        [Display(Name = "Note")]
        public string Message { get; set; }

        [Display(Name = "Date Created")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Is Complete?")]
        public bool IsComplete { get; set; }
    }
}
