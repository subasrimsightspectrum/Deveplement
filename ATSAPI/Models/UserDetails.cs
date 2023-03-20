namespace WebApiCoreWithEF.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Userdetails")]
    public class UserDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string CurrentPosition { get; set; }
        public string Skillset { get; set; }
        public string Location { get; set; }
        public DateTime? LastWorkingDate { get; set; }
    }
}
