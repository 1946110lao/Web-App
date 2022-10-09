namespace TheBigZuydChallenge.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;


    public partial class AdminReview
        {
        
  
            public int AdminReviewId { get; set; }
         
            [Required(ErrorMessage = "Vul deze veld in")]
            [StringLength(50)]
            [Display(Name = "Naam")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Vul deze veld in")]
            [StringLength(50)]
            [Display(Name = "Kenmerk 1")]
            public string Tag1 { get; set; }

            [StringLength(50)]
            [Display(Name = "Kenmerk 2 (optioneel)")]
            public string Tag2 { get; set; }

            [StringLength(50)]
            [Display(Name = "Kenmerk 3 (optioneel)")]
            public string Tag3 { get; set; }

            [Required(ErrorMessage = "Vul deze veld in")]
            [StringLength(50)]
            [Display(Name = "Kosten")]
            public string Costs { get; set; }

            [Required(ErrorMessage = "Vul deze veld in")]
            [StringLength(50)]
            [Display(Name = "Ideale tijdsstip")]
            public string IdealTime { get; set; }

            [Display(Name = "Duur")]
            [Required]
            public string Duration { get; set; }

            [Required(ErrorMessage = "Vul deze veld in")]
            [StringLength(50)]
            [Display (Name ="Grootte")]
            public string Size { get; set; }

            [StringLength(300)]
            [Required(ErrorMessage = "Vul deze veld in")]
            [Display(Name = "Beschrijving")]
             public string Description { get; set; }

 
        }
    }
