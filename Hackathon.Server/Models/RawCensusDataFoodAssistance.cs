using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Server.Models;

[Table("RawCensusDataFoodAssistance")]
public partial class RawCensusDataFoodAssistance
{
    [StringLength(300)]
    [Unicode(false)]
    public string? Label { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Households { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsWithAnyMember60YearsOrOlder { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsWithoutAMember60YearsOrOlder { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsWithMarriedCouple { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsNonMarriedCouple { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsMaleHouseholderNoSpouse { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsFemaleHouseholderNoSpouse { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsNonFamilyHouseholds { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsWithChildrenUnder18 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsWithMarriedCoupleAndChildrenUnder18 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsWithNonMarriedCoupleAndChildrenUnder18 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsWithMaleHouseholderNoSpouseAndChildrenUnder18 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsWithFemaleHouseholderNoSpouseAndChildrenUnder18 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsNonFamilyHouseholdsWithChildrenUnder18 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsWithoutChildrenUnder18 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsWithMarriedCoupleNoChildrenUnder18 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsWithNonMarriedCoupleNoChildrenUnder18 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsWithMaleHouseholderNoSpouseNoChildrenUnder18 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsWithFemaleHouseholderNoSpouseNoChildrenUnder18 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsNonFamilyHouseholdsWithoutChildrenUnder18 { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsWithPovertyStatusInThePast12MonthsBelowPovertyLevel { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsWithPovertyStatusInThePast12MonthsAtOrAbovePovertyLevel { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsWithDisabledMember { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? HouseholdsWithoutAnyDisabledMembers { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? FamiliesWithWorkStatus { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? FamiliesWithNoWorkersInPast12Months { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? FamiliesWithOneWorkerInPast12Months { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? FamiliesWithTwoOrMoreWorkersInPast12Months { get; set; }

    [Key]
    public int Id { get; set; }

    public int? ZipCode { get; set; }
}
