using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Server.Models;

[Table("CensusFoodAssistanceByPovertyStatus")]
[Index("ZipCode", Name = "CensusFoodAssistanceByPovertyStatus_ZipCode_index")]
public partial class CensusFoodAssistanceByPovertyStatus
{
    [Key]
    public int Id { get; set; }

    public int ZipCode { get; set; }

    public bool WasBelowPovertyLevelInPast12Months { get; set; }

    public int TotalHouseholds { get; set; }

    public double PercentHouseholds { get; set; }

    public int TotalReceivingFoodStampsSNAP { get; set; }

    public double PercentReceivingFoodStampsSNAP { get; set; }

    [ForeignKey("ZipCode")]
    [InverseProperty("CensusFoodAssistanceByPovertyStatuses")]
    public virtual CensusData ZipCodeNavigation { get; set; } = null!;
}
