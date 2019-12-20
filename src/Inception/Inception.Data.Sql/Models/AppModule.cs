namespace Inception.Data.Sql.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("AppModules")]
    public class AppModule
    {
        [Column("Id"), Key]
        public Guid Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }
        
        [Column("Url")]
        public string Url { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("IconUrl")]
        public string IconUrl { get; set; }
    }
}
