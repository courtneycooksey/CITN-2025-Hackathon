using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Hackathon.Server.Models;

public partial class citnhackdbContext : DbContext
{
    public citnhackdbContext()
    {
        
    }

    public citnhackdbContext(DbContextOptions<citnhackdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CensusData> CensusData { get; set; }

    public virtual DbSet<CensusFoodAssistanceByDisability> CensusFoodAssistanceByDisabilities { get; set; }

    public virtual DbSet<CensusFoodAssistanceByHouseholdSeniorMembership> CensusFoodAssistanceByHouseholdSeniorMemberships { get; set; }

    public virtual DbSet<CensusFoodAssistanceByMaritalStatus> CensusFoodAssistanceByMaritalStatuses { get; set; }

    public virtual DbSet<CensusFoodAssistanceByPovertyStatus> CensusFoodAssistanceByPovertyStatuses { get; set; }

    public virtual DbSet<CensusFoodAssistanceByWorkStatus> CensusFoodAssistanceByWorkStatuses { get; set; }

    public virtual DbSet<CensusFoodAssistanceData> CensusFoodAssistanceData { get; set; }

    public virtual DbSet<CensusPovertyByEmploymentStatus> CensusPovertyByEmploymentStatuses { get; set; }

    public virtual DbSet<CensusPovertyByLevelOfEducation> CensusPovertyByLevelOfEducations { get; set; }

    public virtual DbSet<CensusPovertyByWorkExperience> CensusPovertyByWorkExperiences { get; set; }

    public virtual DbSet<CensusPovertyData> CensusPovertyData { get; set; }

    public virtual DbSet<RawCensusDataFoodAssistance> RawCensusDataFoodAssistances { get; set; }

    public virtual DbSet<RawCensusDataPoverty> RawCensusDataPoverties { get; set; }

    public virtual DbSet<Resource> Resources { get; set; }

    public virtual DbSet<ResourceType> ResourceTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // Build configuration to read appsettings.json
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Get the connection string
            string connectionString = configuration.GetConnectionString("DefaultConnection");

            // Configure the DbContext to use SQL Server with the connection string
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CensusData>(entity =>
        {
            entity.HasKey(e => e.ZipCode).HasName("CensusData_pk");

            entity.Property(e => e.ZipCode).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CensusFoodAssistanceByDisability>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("CensusFoodAssistanceByDisability_pk");

            entity.HasOne(d => d.ZipCodeNavigation).WithMany(p => p.CensusFoodAssistanceByDisabilities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CensusFoodAssistanceByDisability_CensusData_ZipCode_fk");
        });

        modelBuilder.Entity<CensusFoodAssistanceByHouseholdSeniorMembership>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("CensusFoodAssistanceByHouseholdSeniorMembership_pk");

            entity.HasOne(d => d.ZipCodeNavigation).WithMany(p => p.CensusFoodAssistanceByHouseholdSeniorMemberships)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CensusFoodAssistanceByHouseholdSeniorMembership_CensusData_ZipCode_fk");
        });

        modelBuilder.Entity<CensusFoodAssistanceByMaritalStatus>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.ZipCodeNavigation).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CensusFoodAssistanceByMaritalStatus_CensusData_ZipCode_fk");
        });

        modelBuilder.Entity<CensusFoodAssistanceByPovertyStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("CensusFoodAssistanceByPovertyStatus_pk");

            entity.HasOne(d => d.ZipCodeNavigation).WithMany(p => p.CensusFoodAssistanceByPovertyStatuses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CensusFoodAssistanceByPovertyStatus_CensusData_ZipCode_fk");
        });

        modelBuilder.Entity<CensusFoodAssistanceByWorkStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("CensusFoodAssistanceByWorkStatus_pk");

            entity.HasOne(d => d.ZipCodeNavigation).WithMany(p => p.CensusFoodAssistanceByWorkStatuses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CensusFoodAssistanceByWorkStatus_CensusData_ZipCode_fk");
        });

        modelBuilder.Entity<CensusFoodAssistanceData>(entity =>
        {
            entity.HasOne(d => d.ZipCodeNavigation).WithMany().HasConstraintName("CensusFoodAssistanceData_CensusData_ZipCode_fk");
        });

        modelBuilder.Entity<CensusPovertyByEmploymentStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("CensusPovertyByEmploymentStatus_pk");

            entity.HasOne(d => d.ZipCodeNavigation).WithMany(p => p.CensusPovertyByEmploymentStatuses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CensusPovertyByEmploymentStatus_CensusData_ZipCode_fk");
        });

        modelBuilder.Entity<CensusPovertyByLevelOfEducation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("CensusPovertyByLevelOfEducation_pk");

            entity.HasOne(d => d.ZipCodeNavigation).WithMany(p => p.CensusPovertyByLevelOfEducations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CensusPovertyByLevelOfEducation_CensusData_ZipCode_fk");
        });

        modelBuilder.Entity<CensusPovertyByWorkExperience>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("CensusPovertyByWorkExperience_pk");

            entity.HasOne(d => d.ZipCodeNavigation).WithMany(p => p.CensusPovertyByWorkExperiences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CensusPovertyByWorkExperience_CensusData_ZipCode_fk");
        });

        modelBuilder.Entity<CensusPovertyData>(entity =>
        {
            entity.HasKey(e => e.ZipCode).HasName("CensusPovertyData_pk");

            entity.Property(e => e.ZipCode).ValueGeneratedNever();

            entity.HasOne(d => d.ZipCodeNavigation).WithOne(p => p.CensusPovertyData)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("CensusPovertyData_CensusData_ZipCode_fk");
        });

        modelBuilder.Entity<RawCensusDataFoodAssistance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("CensusDataFoodAssistancePivot_pk");
        });

        modelBuilder.Entity<Resource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Resource_pk");

            entity.HasMany(d => d.ResourceTypes).WithMany(p => p.Resources)
                .UsingEntity<Dictionary<string, object>>(
                    "Resource_ResourceType",
                    r => r.HasOne<ResourceType>().WithMany()
                        .HasForeignKey("ResourceTypeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("Resource_ResourceType_ResourceType_Id_fk"),
                    l => l.HasOne<Resource>().WithMany()
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("Resource_ResourceType_Resource_Id_fk"),
                    j =>
                    {
                        j.HasKey("ResourceId", "ResourceTypeId").HasName("Resource_ResourceType_pk");
                        j.ToTable("Resource_ResourceType");
                    });
        });

        modelBuilder.Entity<ResourceType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ResourceType_pk");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
