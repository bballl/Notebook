namespace Notebook.Database
{
    /// <summary>
    /// Класс выполняет функцию создания и первичного заполнения базы данных.
    /// </summary>
    public class FillDatabase
    {
        /// <summary>
        /// Если база данных отсутствует, то она создается и заполняется данными из этого класса.
        /// </summary>
        public static void Fill()
        {
            NotebookDbContext db = new NotebookDbContext();

            //db.Database.EnsureDeleted();
            bool isDatabaseExists = db.Database.EnsureCreated();

            if (isDatabaseExists == false) return;

            Entry e1 = new Entry()
            {
                LastName = "Иванов",
                FirstName = "Иван",
                MiddleName = "Иванович",
                Phone = "123",
                Address = "Russia",
                Description = "Какое-то описание"
            };

            Entry e2 = new Entry()
            {
                LastName = "Смирнов",
                FirstName = "Иван",
                MiddleName = "Николаевич",
                Phone = "124",
                Address = "Russia",
                Description = "Какое-то описание"
            };

            Entry e3 = new Entry()
            {
                LastName = "Фролов",
                FirstName = "Семен",
                MiddleName = "Васильевич",
                Phone = "125",
                Address = "Russia",
                Description = "Какое-то описание"
            };

            db.Entries.Add(e1);
            db.Entries.Add(e2);
            db.Entries.Add(e3);

            db.SaveChanges();
        }
    }
}

