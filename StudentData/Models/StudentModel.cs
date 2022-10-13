using System.ComponentModel.DataAnnotations;

namespace StudentData.Models
{
    public class StudentModel
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? StudentUserName { get; set; }
        [Required]
        public string? StudentPassword { get; set; }
        [Required]
        public string? FathersName { get; set; }
        [Required]
        public string? StudentAddress { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string? ContactNumber { get; set; }
        [Required]
        public DateTime DateOfbirth { get; set; }
        [Required]
        public DateTime DateOfJoining { get; set; }





        

    }
}