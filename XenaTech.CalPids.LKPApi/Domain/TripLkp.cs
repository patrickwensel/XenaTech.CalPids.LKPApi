using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XenaTech.CalPids.LKPApi.Domain
{
    [Table("TripLkps")]
    public class TripLkp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        public Guid TripId { get; set; }

        public Guid? SubstituteVehicleId { get; set; }

        public Guid TripStatusTypeId { get; set; }

        public string Direction { get; set; }

        public double Lat { get; set; }

        public double Lng { get; set; }

        public double Heading { get; set; }

        public double Speed { get; set; }

        public int Interval { get; set; }

        public double MileMark { get; set; }

        public DateTime Timestamp { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; } 

        public string CreatedBy { get; set; }

        public string CreatedByFullName { get; set; }

        public string ModifiedBy { get; set; }

        public string ModifiedByFullName { get; set; }
    }
}
