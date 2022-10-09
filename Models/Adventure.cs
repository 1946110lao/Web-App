namespace TheBigZuydChallenge.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    public partial class Adventure
    {
     

        public int AdventureId { get; set; }

        [Required(ErrorMessage = "Vul deze veld in")]
        [StringLength(50)]
        [Display(Name="Naam")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vul deze veld in")]
        [StringLength(50)]
        [Display(Name ="Kenmerken")]
        public string Tag1 { get; set; }

        [StringLength(50)]

        public string Tag2 { get; set; }

        [StringLength(50)]

        public string Tag3 { get; set; }

        [Required(ErrorMessage = "Vul deze veld in")]
        [StringLength(50)]
        [Display(Name ="Details")]
        public string Costs { get; set; }

        [Required(ErrorMessage = "Vul deze veld in")]
        [StringLength(50)]
  
        public string IdealTime { get; set; }

        public string Duration { get; set; }

        [Required(ErrorMessage = "Vul deze veld in")]
        [StringLength(50)]

        public string Size { get; set; }

        [Required(ErrorMessage = "Vul deze veld in")]
        [StringLength(300)]
        public string Description { get; set; }

    }
}

