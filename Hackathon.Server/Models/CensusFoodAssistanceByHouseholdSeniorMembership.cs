using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Server.Models;

[Table("CensusFoodAssistanceByHouseholdSeniorMembership")]
[Index("ZipCode", Name = "CensusFoodAssistanceByHouseholdSeniorMembership_ZipCode_index")]
public partial class CensusFoodAssistanceByHouseholdSeniorMembership
{
    [Key]
    public int Id { get; set; }

    public int ZipCode { get; set; }

    public bool HasMember60YearsOrOlder { get; set; }

    public int TotalHouseholds { get; set; }

    public double PercentHouseholds { get; set; }

    public int TotalReceivingFoodStampsSNAP { get; set; }

    public double PercentReceivingFoodStampsSNAP { get; set; }

    [ForeignKey("ZipCode")]
    [InverseProperty("CensusFoodAssistanceByHouseholdSeniorMemberships")]
    public virtual CensusData ZipCodeNavigation { get; set; } = null!;
}
