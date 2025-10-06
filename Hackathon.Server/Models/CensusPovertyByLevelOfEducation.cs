using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Server.Models;

[Table("CensusPovertyByLevelOfEducation")]
public partial class CensusPovertyByLevelOfEducation
{
    [Key]
    public int Id { get; set; }

    public int ZipCode { get; set; }

    public int? TotalPopulation25YearsAndOlder { get; set; }

    public int? TotalPopulation25YearsAndOlderBelowPovertyLevel { get; set; }

    public double? PercentPopulation25YearsAndOlderBelowPovertyLevel { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string LevelOfEducation { get; set; } = null!;

    public int TotalPopulationByLevelOfEducation { get; set; }

    public int TotalBelowPovertyLevel { get; set; }

    public double PercentBelowPovertyLevel { get; set; }

    [ForeignKey("ZipCode")]
    [InverseProperty("CensusPovertyByLevelOfEducations")]
    public virtual CensusData ZipCodeNavigation { get; set; } = null!;
}
