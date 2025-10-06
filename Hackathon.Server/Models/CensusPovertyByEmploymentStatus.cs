using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Server.Models;

[Table("CensusPovertyByEmploymentStatus")]
[Index("ZipCode", Name = "CensusPovertyByEmploymentStatus_ZipCode_index")]
public partial class CensusPovertyByEmploymentStatus
{
    [Key]
    public int Id { get; set; }

    public int ZipCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string EmploymentStatus { get; set; } = null!;

    public int TotalPopulationByEmploymentStatus { get; set; }

    public int PopulationBelowPovertyLevel { get; set; }

    public double PercentPopulationBelowPovertyLevel { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Gender { get; set; } = null!;

    public int TotalPopulationByGender { get; set; }

    public int PopulationBelowPovertyLevelByGender { get; set; }

    public double PercentPopulationBelowPovertyLevelByGender { get; set; }

    [ForeignKey("ZipCode")]
    [InverseProperty("CensusPovertyByEmploymentStatuses")]
    public virtual CensusData ZipCodeNavigation { get; set; } = null!;
}
