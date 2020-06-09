using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XenaTech.CalPids.LKPApi.Domain
{
    [Table("LKP")]
    public class LKP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(50)]
        public string ID { get; set; }

        [Required]
        public int CarNum { get; set; }

        [Required]
        [MaxLength(50)]
        public string Protocol { get; set; }

        [Required]
        public int Date { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public double Time { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public double Latitude { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public double Longitude { get; set; }

        [Required]
        [MaxLength(50)]
        public string Speed { get; set; }

        [Required]
        [MaxLength(50)]
        public string Bearing { get; set; }

        [Required]
        [MaxLength(50)]
        public string SatellitesInUse { get; set; }

        [Required]
        [MaxLength(50)]
        public string HDOP { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime DBTime { get; set; }

        [Required]
        [MaxLength(50)]
        public string Corridor { get; set; }

        [Required]
        [MaxLength(50)]
        public string MileMarker { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public double TrackPointNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string Direction { get; set; }
    }
}
