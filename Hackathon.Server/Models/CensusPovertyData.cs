using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Server.Models;

public partial class CensusPovertyData
{
    [Key]
    public int ZipCode { get; set; }

    public int? TotalPopulationPovertyStatusIsDetermined { get; set; }

    public int? BelowPovertyPopulationPovertyStatusIsDetermined { get; set; }

    public double? PercentBelowPovertyLevelPopulationPovertyStatusIsDetermined { get; set; }

    public int? TotalAGEUnder18Years { get; set; }

    public int? BelowPovertyAGEUnder18Years { get; set; }

    public double? PercentBelowPovertyLevelAGEUnder18Years { get; set; }

    public int? TotalAGEUnder5Years { get; set; }

    public int? BelowPovertyAGEUnder5Years { get; set; }

    public double? PercentBelowPovertyLevelAGEUnder5Years { get; set; }

    public int? TotalPopulationMale { get; set; }

    public int? BelowPovertyPopulationMale { get; set; }

    public double? PercentBelowPovertyLevelPopulationMale { get; set; }

    public int? TotalPopulationFemale { get; set; }

    public int? BelowPovertyPopulationFemale { get; set; }

    public double? PercentBelowPovertyLevelPopulationFemale { get; set; }

    public int? TotalAGE25YearsAndOver { get; set; }

    public int? BelowPovertyAGE25YearsAndOver { get; set; }

    public double? PercentBelowPovertyLevelAGE25YearsAndOver { get; set; }

    public int? TotalLessThanHighSchoolEducation { get; set; }

    public int? BelowPovertyLessThanHighSchoolEducation { get; set; }

    public double? PercentBelowPovertyLevelLessThanHighSchoolEducation { get; set; }

    public int? TotalHighSchoolEducation { get; set; }

    public int? BelowPovertyHighSchoolEducation { get; set; }

    public double? PercentBelowPovertyLevelHighSchoolEducation { get; set; }

    public int? TotalSomeCollegeAssociateDegree { get; set; }

    public int? BelowPovertySomeCollegeAssociateDegree { get; set; }

    public double? PercentBelowPovertyLevelSomeCollegeAssociateDegree { get; set; }

    public int? TotalBachelorDegreeOrHigher { get; set; }

    public int? BelowPovertyBachelorDegreeOrHigher { get; set; }

    public double? PercentBelowPovertyLevelBachelorDegreeOrHigher { get; set; }

    public int? TotalCivilianLaborForce16YearsAndOver { get; set; }

    public int? BelowPovertyCivilianLaborForce16YearsAndOver { get; set; }

    public double? PercentBelowPovertyLevelCivilianLaborForce16YearsAndOver { get; set; }

    public int? TotalEmployed { get; set; }

    public int? BelowPovertyEmployed { get; set; }

    public double? PercentBelowPovertyLevelEmployed { get; set; }

    public int? TotalEmployedMale { get; set; }

    public int? BelowPovertyEmployedMale { get; set; }

    public double? PercentBelowPovertyLevelEmployedMale { get; set; }

    public int? TotalEmployedFemale { get; set; }

    public int? BelowPovertyEmployedFemale { get; set; }

    public double? PercentBelowPovertyLevelEmployedFemale { get; set; }

    public int? TotalUnemployed { get; set; }

    public int? BelowPovertyUnemployed { get; set; }

    public double? PercentBelowPovertyLevelUnemployed { get; set; }

    public int? TotalUnemployedMale { get; set; }

    public int? BelowPovertyUnemployedMale { get; set; }

    public double? PercentBelowPovertyLevelUnemployedMale { get; set; }

    public int? TotalUnemployedFemale { get; set; }

    public int? BelowPovertyUnemployedFemale { get; set; }

    public double? PercentBelowPovertyLevelUnemployedFemale { get; set; }

    public int? TotalAGE16YearsAndOver { get; set; }

    public int? BelowPovertyAGE16YearsAndOver { get; set; }

    public double? PercentBelowPovertyLevelAGE16YearsAndOver { get; set; }

    public int? TotalWorkedFullTimeYearRoundPast12Months { get; set; }

    public int? BelowPovertyWorkedFullTimeYearRoundPast12Months { get; set; }

    public double? PercentBelowPovertyLevelWorkedFullTimeYearRoundPast12Months { get; set; }

    public int? TotalWorkedPartTimeOrPartYearPast12Months { get; set; }

    public int? BelowPovertyWorkedPartTimeOrPartYearPast12Months { get; set; }

    public double? PercentBelowPovertyLevelWorkedPartTimeOrPartYearPast12Months { get; set; }

    public int? TotalDidNotWork { get; set; }

    public int? BelowPovertyDidNotWork { get; set; }

    public double? PercentBelowPovertyLevelDidNotWork { get; set; }

    public int? PopulationWithIncomeBelow50PercentOfPovertyLevel { get; set; }

    public int? PopulationWithIncomeBelow125PercentOfPovertyLevel { get; set; }

    public int? PopulationWithIncomeBelow150PercentOfPovertyLevel { get; set; }

    public int? PopulationWithIncomeBelow185PercentOfPovertyLevel { get; set; }

    public int? PopulationWithIncomeBelow200PercentOfPovertyLevel { get; set; }

    public int? PopulationWithIncomeBelow300PercentOfPovertyLevel { get; set; }

    public int? PopulationWithIncomeBelow400PercentOfPovertyLevel { get; set; }

    public int? PopulationWithIncomeBelow500PercentOfPovertyLevel { get; set; }

    [ForeignKey("ZipCode")]
    [InverseProperty("CensusPovertyData")]
    public virtual CensusData ZipCodeNavigation { get; set; } = null!;
}
