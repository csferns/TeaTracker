using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeaTracker.Common.Enums;
using UnitsNet.Units;

namespace TeaTracker.Data.Entities
{
    [Table("History", Schema = "core")]
    public class History
    {
        [Key]
        public int HistoryId { get; set; }
        public DrinkTypeEnum DrinkType { get; set; }
        public DateTime DrinkTime { get; set; }
        public VolumeUnit VolumeUnit { get; set; }
        public double CupSize { get; set; }

        public IdentityUser User { get; set; }
    }
}
