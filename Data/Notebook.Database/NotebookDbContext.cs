using Microsoft.EntityFrameworkCore;

namespace Notebook.Database
{
    /// <summary>
    /// Класс представляет базу данных, в которой хранятся записи записной книжки.
    /// </summary>
    internal class NotebookDbContext : DbContext
    {
        /// <summary>
        /// Таблица с записями.
        /// </summary>
        public DbSet<Entry> Entries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=NotebookDatabase;Trusted_Connection=True;");
        }
    }
}
