using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Server.Models;

public partial class CensusFoodAssistanceData
{
    [Key]
    public int? ZipCode { get; set; }

    public int? HouseholdsEstimatedTotal { get; set; }

    public int? HouseholdsTotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsPercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsWithAnyMember60YearsOrOlderEstimatedTotal { get; set; }

    public double? HouseholdsWithAnyMember60YearsOrOlderPercent { get; set; }

    public int? HouseholdsWithAnyMember60YearsOrOlderTotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsWithAnyMember60YearsOrOlderPercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsWithoutAMember60YearsOrOlderEstimatedTotal { get; set; }

    public double? HouseholdsWithoutAMember60YearsOrOlderPercent { get; set; }

    public int? HouseholdsWithoutAMember60YearsOrOlderTotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsWithoutAMember60YearsOrOlderPercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsWithMarriedCoupleEstimatedTotal { get; set; }

    public double? HouseholdsWithMarriedCouplePercent { get; set; }

    public int? HouseholdsWithMarriedCoupleTotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsWithMarriedCouplePercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsNonMarriedCoupleEstimatedTotal { get; set; }

    public double? HouseholdsNonMarriedCouplePercent { get; set; }

    public int? HouseholdsNonMarriedCoupleTotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsNonMarriedCouplePercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsMaleHouseholderNoSpouseEstimatedTotal { get; set; }

    public double? HouseholdsMaleHouseholderNoSpousePercent { get; set; }

    public int? HouseholdsMaleHouseholderNoSpouseTotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsMaleHouseholderNoSpousePercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsFemaleHouseholderNoSpouseEstimatedTotal { get; set; }

    public double? HouseholdsFemaleHouseholderNoSpousePercent { get; set; }

    public int? HouseholdsFemaleHouseholderNoSpouseTotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsFemaleHouseholderNoSpousePercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsNonFamilyHouseholdsEstimatedTotal { get; set; }

    public double? HouseholdsNonFamilyHouseholdsPercent { get; set; }

    public int? HouseholdsNonFamilyHouseholdsTotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsNonFamilyHouseholdsPercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsWithChildrenUnder18EstimatedTotal { get; set; }

    public double? HouseholdsWithChildrenUnder18Percent { get; set; }

    public int? HouseholdsWithChildrenUnder18TotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsWithChildrenUnder18PercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsWithMarriedCoupleAndChildrenUnder18EstimatedTotal { get; set; }

    public double? HouseholdsWithMarriedCoupleAndChildrenUnder18Percent { get; set; }

    public int? HouseholdsWithMarriedCoupleAndChildrenUnder18TotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsWithMarriedCoupleAndChildrenUnder18PercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsWithNonMarriedCoupleAndChildrenUnder18EstimatedTotal { get; set; }

    public double? HouseholdsWithNonMarriedCoupleAndChildrenUnder18Percent { get; set; }

    public int? HouseholdsWithNonMarriedCoupleAndChildrenUnder18TotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsWithNonMarriedCoupleAndChildrenUnder18PercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsWithMaleHouseholderNoSpouseAndChildrenUnder18EstimatedTotal { get; set; }

    public double? HouseholdsWithMaleHouseholderNoSpouseAndChildrenUnder18Percent { get; set; }

    public int? HouseholdsWithMaleHouseholderNoSpouseAndChildrenUnder18TotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsWithMaleHouseholderNoSpouseAndChildrenUnder18PercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsWithFemaleHouseholderNoSpouseAndChildrenUnder18EstimatedTotal { get; set; }

    public double? HouseholdsWithFemaleHouseholderNoSpouseAndChildrenUnder18Percent { get; set; }

    public int? HouseholdsWithFemaleHouseholderNoSpouseAndChildrenUnder18TotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsWithFemaleHouseholderNoSpouseAndChildrenUnder18PercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsNonFamilyHouseholdsWithChildrenUnder18EstimatedTotal { get; set; }

    public double? HouseholdsNonFamilyHouseholdsWithChildrenUnder18Percent { get; set; }

    public int? HouseholdsNonFamilyHouseholdsWithChildrenUnder18TotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsNonFamilyHouseholdsWithChildrenUnder18PercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsWithoutChildrenUnder18EstimatedTotal { get; set; }

    public double? HouseholdsWithoutChildrenUnder18Percent { get; set; }

    public int? HouseholdsWithoutChildrenUnder18TotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsWithoutChildrenUnder18PercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsWithMarriedCoupleNoChildrenUnder18EstimatedTotal { get; set; }

    public double? HouseholdsWithMarriedCoupleNoChildrenUnder18Percent { get; set; }

    public int? HouseholdsWithMarriedCoupleNoChildrenUnder18TotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsWithMarriedCoupleNoChildrenUnder18PercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsWithNonMarriedCoupleNoChildrenUnder18EstimatedTotal { get; set; }

    public double? HouseholdsWithNonMarriedCoupleNoChildrenUnder18Percent { get; set; }

    public int? HouseholdsWithNonMarriedCoupleNoChildrenUnder18TotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsWithNonMarriedCoupleNoChildrenUnder18PercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsWithMaleHouseholderNoSpouseNoChildrenUnder18EstimatedTotal { get; set; }

    public double? HouseholdsWithMaleHouseholderNoSpouseNoChildrenUnder18Percent { get; set; }

    public int? HouseholdsWithMaleHouseholderNoSpouseNoChildrenUnder18TotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsWithMaleHouseholderNoSpouseNoChildrenUnder18PercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsWithFemaleHouseholderNoSpouseNoChildrenUnder18EstimatedTotal { get; set; }

    public double? HouseholdsWithFemaleHouseholderNoSpouseNoChildrenUnder18Percent { get; set; }

    public int? HouseholdsWithFemaleHouseholderNoSpouseNoChildrenUnder18TotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsWithFemaleHouseholderNoSpouseNoChildrenUnder18PercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsNonFamilyHouseholdsWithoutChildrenUnder18EstimatedTotal { get; set; }

    public double? HouseholdsNonFamilyHouseholdsWithoutChildrenUnder18Percent { get; set; }

    public int? HouseholdsNonFamilyHouseholdsWithoutChildrenUnder18TotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsNonFamilyHouseholdsWithoutChildrenUnder18PercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsWithPovertyStatusInThePast12MonthsBelowPovertyLevelEstimatedTotal { get; set; }

    public double? HouseholdsWithPovertyStatusInThePast12MonthsBelowPovertyLevelPercent { get; set; }

    public int? HouseholdsWithPovertyStatusInThePast12MonthsBelowPovertyLevelTotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsWithPovertyStatusInThePast12MonthsBelowPovertyLevelPercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsWithPovertyStatusInThePast12MonthsAtOrAbovePovertyLevelEstimatedTotal { get; set; }

    public double? HouseholdsWithPovertyStatusInThePast12MonthsAtOrAbovePovertyLevelPercent { get; set; }

    public int? HouseholdsWithPovertyStatusInThePast12MonthsAtOrAbovePovertyLevelTotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsWithPovertyStatusInThePast12MonthsAtOrAbovePovertyLevelPercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsWithDisabledMemberEstimatedTotal { get; set; }

    public double? HouseholdsWithDisabledMemberPercent { get; set; }

    public int? HouseholdsWithDisabledMemberTotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsWithDisabledMemberPercentReceivingFoodStampsSNAP { get; set; }

    public int? HouseholdsWithoutAnyDisabledMembersEstimatedTotal { get; set; }

    public double? HouseholdsWithoutAnyDisabledMembersPercent { get; set; }

    public int? HouseholdsWithoutAnyDisabledMembersTotalReceivingFoodStampsSNAP { get; set; }

    public double? HouseholdsWithoutAnyDisabledMembersPercentReceivingFoodStampsSNAP { get; set; }

    public int? FamiliesWithWorkStatusEstimatedTotal { get; set; }

    public int? FamiliesWithWorkStatusTotalReceivingFoodStampsSNAP { get; set; }

    public int? FamiliesWithNoWorkersInPast12MonthsEstimatedTotal { get; set; }

    public double? FamiliesWithNoWorkersInPast12MonthsPercent { get; set; }

    public int? FamiliesWithNoWorkersInPast12MonthsTotalReceivingFoodStampsSNAP { get; set; }

    public double? FamiliesWithNoWorkersInPast12MonthsPercentReceivingFoodStampsSNAP { get; set; }

    public int? FamiliesWithOneWorkerInPast12MonthsEstimatedTotal { get; set; }

    public double? FamiliesWithOneWorkerInPast12MonthsPercent { get; set; }

    public int? FamiliesWithOneWorkerInPast12MonthsTotalReceivingFoodStampsSNAP { get; set; }

    public double? FamiliesWithOneWorkerInPast12MonthsPercentReceivingFoodStampsSNAP { get; set; }

    public int? FamiliesWithTwoOrMoreWorkersInPast12MonthsEstimatedTotal { get; set; }

    public double? FamiliesWithTwoOrMoreWorkersInPast12MonthsPercent { get; set; }

    public int? FamiliesWithTwoOrMoreWorkersInPast12MonthsTotalReceivingFoodStampsSNAP { get; set; }

    public double? FamiliesWithTwoOrMoreWorkersInPast12MonthsPercentReceivingFoodStampsSNAP { get; set; }

    [ForeignKey("ZipCode")]
    public virtual CensusData? ZipCodeNavigation { get; set; }
}
