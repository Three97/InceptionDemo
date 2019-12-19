namespace Inception.Data.Sql.Models
{
    using System;

    public class AppModule
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public string Title { get; set; }

        public string IconUrl { get; set; }
    }
}
