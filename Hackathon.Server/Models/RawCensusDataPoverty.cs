using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Server.Models;

[Keyless]
[Table("RawCensusDataPoverty")]
public partial class RawCensusDataPoverty
{
    public int? Zipcode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Partition { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PopulationPovertyStatusIsDetermined { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AGEUnder18Years { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AGEUnder5Years { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PopulationMale { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PopulationFemale { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AGE25YearsAndOver { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LessThanHighSchoolEducation { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? HighSchoolEducation { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SomeCollegeAssociateDegree { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BachelorDegreeOrHigher { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CivilianLaborForce16YearsAndOver { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Employed { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EmployedMale { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EmployedFemale { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Unemployed { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UnemployedMale { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UnemployedFemale { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AGE16YearsAndOver { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WorkedFullTimeYearRoundPast12Months { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WorkedPartTimeOrPartYearPast12Months { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DidNotWork { get; set; }

    [Column("50PercentOfPovertyLevel")]
    [StringLength(50)]
    [Unicode(false)]
    public string? _50PercentOfPovertyLevel { get; set; }

    [Column("125PercentOfPovertyLevel")]
    [StringLength(50)]
    [Unicode(false)]
    public string? _125PercentOfPovertyLevel { get; set; }

    [Column("150PercentOfPovertyLevel")]
    [StringLength(50)]
    [Unicode(false)]
    public string? _150PercentOfPovertyLevel { get; set; }

    [Column("185PercentOfPovertyLevel")]
    [StringLength(50)]
    [Unicode(false)]
    public string? _185PercentOfPovertyLevel { get; set; }

    [Column("200PercentOfPovertyLevel")]
    [StringLength(50)]
    [Unicode(false)]
    public string? _200PercentOfPovertyLevel { get; set; }

    [Column("300PercentOfPovertyLevel")]
    [StringLength(50)]
    [Unicode(false)]
    public string? _300PercentOfPovertyLevel { get; set; }

    [Column("400PercentOfPovertyLevel")]
    [StringLength(50)]
    [Unicode(false)]
    public string? _400PercentOfPovertyLevel { get; set; }

    [Column("500PercentOfPovertyLevel")]
    [StringLength(50)]
    [Unicode(false)]
    public string? _500PercentOfPovertyLevel { get; set; }

    [Column("MeanIncomeDeficitForUnrelatedIndividuals(Dollars)")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MeanIncomeDeficitForUnrelatedIndividuals_Dollars_ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PovertyWorkedFullTimeYearRoundPast12Months { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PovertyWorkedPartTimeOrPartYearPast12Months { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PovertyDidNotWork { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PopulationInHousingUnitsForWhomPovertyStatusIsDetermined { get; set; }
}
