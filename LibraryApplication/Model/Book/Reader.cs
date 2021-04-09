﻿namespace WinFormsLibraryManager.Model.Book
{
    public class Reader : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [Required] public string Email { get; set; }

        public string PhoneNumber { get; set; }

        [Required] public string Name { get; set; }

        public string Address { get; set; }

        public string Avatar { get; set; }

        [Required] public string Gender { get; set; } = "male";

        [Required] public int Limit { get; set; } = 0;

        [Column(TypeName = "Date")] public DateTime Birth { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}