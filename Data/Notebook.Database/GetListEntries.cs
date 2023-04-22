namespace Notebook.Database
{
    /// <summary>
    /// Класс конвертирует данные из базы данных в список.
    /// </summary>
    public class GetListEntries
    {
        /// <summary>
        /// Метод обращается к базе данных и конвертирует данные из таблицы Entries в список.
        /// </summary>
        /// <returns>Данные таблицы Entries, конвертированные в список</returns>
        public static List<Entry> Get()
        {
            NotebookDbContext db = new NotebookDbContext();

            var entries = db.Entries.ToList();

            return entries;
        }
    }
}
