using CreateReceiptDomainAbstractions.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReseiptsEntities.Code
{
    [Table("Products")]
    public class Product : DbEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new public Guid Id { get; set; }

        [StringLength(32)]
        public string Name { get; set; }

        public int Count { get; set; }

        [StringLength(8)]
        public string Dimension { get; set; }

        public virtual List<Receipt> Receipts {get; set;}
    }
}
