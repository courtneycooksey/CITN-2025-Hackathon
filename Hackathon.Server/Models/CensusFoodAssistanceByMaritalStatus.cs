using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Server.Models;

[Keyless]
[Table("CensusFoodAssistanceByMaritalStatus")]
public partial class CensusFoodAssistanceByMaritalStatus
{
    public int Id { get; set; }

    public int ZipCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string HouseholdMaritalStatus { get; set; } = null!;

    public int TotalHouseholdsByMaritalStatus { get; set; }

    public double PercentOfHouseholdsByMaritalStatus { get; set; }

    public int TotalReceivingFoodStampsSNAP { get; set; }

    public double PercentReceivingFoodStampsSNAP { get; set; }

    public bool HasChildrenUnder18 { get; set; }

    public int TotalHouseholdsByChildren { get; set; }

    public double PercentOfHouseholdsByChildren { get; set; }

    public int TotalReceivingFoodStampsSNAPByChildren { get; set; }

    public double PercentReceivingFoodStampsSNAPByChildren { get; set; }

    [ForeignKey("ZipCode")]
    public virtual CensusData ZipCodeNavigation { get; set; } = null!;
}
