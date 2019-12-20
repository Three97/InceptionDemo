namespace Inception.Data.Sql.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Licenses")]
    public class License
    {
        [Column("Id"), Key]
        public Guid Id { get; set; }
        
        public ICollection<AppModule> AppModules { get; set; }
    }
}