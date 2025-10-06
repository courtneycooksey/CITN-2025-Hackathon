using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Server.Models;

public partial class CensusData
{
    public int Id { get; set; }

    [Key]
    public int ZipCode { get; set; }

    public int TotalPopulation { get; set; }

    public double EmploymentRate { get; set; }

    public int TotalEmployerEstablishments { get; set; }

    public double MedianHouseholdIncome { get; set; }

    public int TotalHousingUnits { get; set; }

    public int TotalHouseholds { get; set; }

    public double BachelorDegreeOrHigher { get; set; }

    public double WithoutHealthCareCoverage { get; set; }

    public double MedianAge { get; set; }

    public double MedianGrossRent { get; set; }

    public double HomeownershipRate { get; set; }

    public double DisabledPopulation { get; set; }

    public int TotalHouseholdsReceivingFoodStampsSNAP { get; set; }

    public double PercentHouseholdsReceivingFoodStampsSNAP { get; set; }

    [InverseProperty("ZipCodeNavigation")]
    public virtual ICollection<CensusFoodAssistanceByDisability> CensusFoodAssistanceByDisabilities { get; set; } = new List<CensusFoodAssistanceByDisability>();

    [InverseProperty("ZipCodeNavigation")]
    public virtual ICollection<CensusFoodAssistanceByHouseholdSeniorMembership> CensusFoodAssistanceByHouseholdSeniorMemberships { get; set; } = new List<CensusFoodAssistanceByHouseholdSeniorMembership>();

    [InverseProperty("ZipCodeNavigation")]
    public virtual ICollection<CensusFoodAssistanceByPovertyStatus> CensusFoodAssistanceByPovertyStatuses { get; set; } = new List<CensusFoodAssistanceByPovertyStatus>();

    [InverseProperty("ZipCodeNavigation")]
    public virtual ICollection<CensusFoodAssistanceByWorkStatus> CensusFoodAssistanceByWorkStatuses { get; set; } = new List<CensusFoodAssistanceByWorkStatus>();

    [InverseProperty("ZipCodeNavigation")]
    public virtual ICollection<CensusPovertyByEmploymentStatus> CensusPovertyByEmploymentStatuses { get; set; } = new List<CensusPovertyByEmploymentStatus>();

    [InverseProperty("ZipCodeNavigation")]
    public virtual ICollection<CensusPovertyByLevelOfEducation> CensusPovertyByLevelOfEducations { get; set; } = new List<CensusPovertyByLevelOfEducation>();

    [InverseProperty("ZipCodeNavigation")]
    public virtual ICollection<CensusPovertyByWorkExperience> CensusPovertyByWorkExperiences { get; set; } = new List<CensusPovertyByWorkExperience>();

    [InverseProperty("ZipCodeNavigation")]
    public virtual CensusPovertyData? CensusPovertyData { get; set; }
}
