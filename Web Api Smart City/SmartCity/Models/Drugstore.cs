﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.Models
{
    public class Drugstore
    {
        public Drugstore()
        {
            this.Holiday = new HashSet<Holiday>();
            this.Schedule = new HashSet<Schedule>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public Boolean Watch { get; set; }
        [StringLength(80)]
        [Url(ErrorMessage = "L'Url n'est pas valide !")]
        public string URLWebSite { get; set; }
        [Required]
        [StringLength(80)]
        public string Name { get; set; }
        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(60)]
        public string Street { get; set; }
        [Required]
        [StringLength(6)]
        public string Number { get; set; }
        [Required]
        public virtual Locality Locality { get; set; }
        [Required]
        public double longitude { get; set; }
        [Required]
        public double latitude { get; set; }
        public virtual ICollection<Holiday> Holiday { get; set; }
        public virtual ICollection<Schedule> Schedule { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
