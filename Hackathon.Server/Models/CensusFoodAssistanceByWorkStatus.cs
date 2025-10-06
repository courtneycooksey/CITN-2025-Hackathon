using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Server.Models;

[Table("CensusFoodAssistanceByWorkStatus")]
[Index("ZipCode", Name = "CensusFoodAssistanceByWorkStatus_ZipCode_index")]
public partial class CensusFoodAssistanceByWorkStatus
{
    [Key]
    public int Id { get; set; }

    public int ZipCode { get; set; }

    public int FamiliesWithWorkStatusEstimatedTotal { get; set; }

    public int FamiliesWithWorkStatusTotalReceivingFoodStampsSNAP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string NumberOfWorkersInPast12Months { get; set; } = null!;

    public int TotalHouseholdsByNumWorkers { get; set; }

    public double PercentHouseholdsByNumWorkers { get; set; }

    public int TotalReceivingFoodStampsSNAPByNumWorkers { get; set; }

    public double PercentReceivingFoodStampsSNAPByNumWorkers { get; set; }

    [ForeignKey("ZipCode")]
    [InverseProperty("CensusFoodAssistanceByWorkStatuses")]
    public virtual CensusData ZipCodeNavigation { get; set; } = null!;
}
