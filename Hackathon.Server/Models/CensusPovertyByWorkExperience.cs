using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Server.Models;

[Table("CensusPovertyByWorkExperience")]
[Index("ZipCode", Name = "CensusPovertyByWorkExperience_ZipCode_index")]
public partial class CensusPovertyByWorkExperience
{
    [Key]
    public int Id { get; set; }

    public int ZipCode { get; set; }

    public int TotalPopulationAge16YearsOrOlder { get; set; }

    public int TotalPopulationBelowPovertyLevelAge16YearsOrOlder { get; set; }

    public double PercentPopulationBelowPovertyLevelAge16YearsOrOlder { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string WorkExperienceInPast12Months { get; set; } = null!;

    public int TotalPopulationByWorkExperience { get; set; }

    public int TotalBelowPovertyLevel { get; set; }

    public double PercentBelowPovertyLevel { get; set; }

    [ForeignKey("ZipCode")]
    [InverseProperty("CensusPovertyByWorkExperiences")]
    public virtual CensusData ZipCodeNavigation { get; set; } = null!;
}
