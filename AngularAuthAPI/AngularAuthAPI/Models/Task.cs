using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularAuthAPI.Models
{
    public class Task
    {
        [Key]
        public int Task_Id { get; set; }              
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Priority { get; set; }
        public string? Due_date { get; set; }
        public string? Status { get; set; }
        public string? Creation_date { get; set; }
        public int? Id { get; set; }
        [ForeignKey("Id")]
        public virtual Users Users {get; set; }
    }
}
