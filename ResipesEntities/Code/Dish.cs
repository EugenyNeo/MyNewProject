using CreateReceiptDomainAbstractions.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace ResipesEntities.Code
{
    [Table("Dishes")]
    public class Dish : DbEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new public Guid Id { get; set; }

        [StringLength(64)]
        public string Name { get; set; }
        public virtual Receipt Receipt { get; set; }
    }
}
