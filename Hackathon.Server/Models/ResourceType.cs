using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Server.Models;

[Table("ResourceType")]
public partial class ResourceType
{
    [Key]
    public int Id { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [ForeignKey("ResourceTypeId")]
    [InverseProperty("ResourceTypes")]
    public virtual ICollection<Resource> Resources { get; set; } = new List<Resource>();
}
