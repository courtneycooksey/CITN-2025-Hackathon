using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Server.Models;

[Table("Resource")]
public partial class Resource
{
    [Key]
    public int Id { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string City { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? State { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    public int? ZipCode { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? County { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? PhoneNumber { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(1500)]
    [Unicode(false)]
    public string? Website { get; set; }

    [StringLength(1500)]
    [Unicode(false)]
    public string? BusinessHours { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Neighborhood { get; set; }

    [ForeignKey("ResourceId")]
    [InverseProperty("Resources")]
    public virtual ICollection<ResourceType> ResourceTypes { get; set; } = new List<ResourceType>();
}
