using System;
using System.ComponentModel.DataAnnotations;

namespace CreateReceiptsDomainAbstractions.Entities
{
    public interface IDbEntity
    {
        [Key]
        Guid Id { get; set; }
    }
}
