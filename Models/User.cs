namespace TheBigZuydChallenge.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Vul deze veld in")]
        [StringLength(50)]
        [Display(Name = "Voornaam")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Vul deze veld in")]
        [StringLength(50)]
        [Display(Name = "Achternaam")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Vul deze veld in")]
        [StringLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vul deze veld in")]
        [StringLength(50)]
        [Display(Name = "Gebruikersnaam")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Vul deze veld in")]
        [DataType(DataType.Password)]

        [StringLength(50)]
        [Display(Name = "Wachtwoord")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Herhaal Wachtwoord")]
        [Compare("Password")]
        [StringLength(50)]
        public string ConfirmPassword { get; set; }
    }
}
