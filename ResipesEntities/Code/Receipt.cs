using CreateReceiptDomainAbstractions.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CreateReceptEntities.Code
{
    [Table("Receipts")]
    public class Receipt : DbEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new public Guid Id { get; set; }

        [StringLength(256)]
        public string TextRecipe { get; set; }
        
        public virtual Product Products { get; set; }
    }
}
