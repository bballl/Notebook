using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Notebook.Database;
using System.Net;
using System.Numerics;

namespace Notebook.Web.Pages
{
    public class PersonModel : PageModel
    {
        /// <summary>
        /// Ссылка на запись в записной книжке.
        /// </summary>
        public Entry? person;
        
        /// <summary>
        /// Обработка Get-запросов, принимает ID, конвертитрует его в тип int, 
        /// по значению id устанавливает ссылку на соответствующую запись в базе данных.
        /// </summary>
        /// <param name="id"></param>
        public void OnGet(string id)
        {
            person = new Entry();

            int Id = Convert.ToInt32(id);

            person = Find(Id);
        }

        /// <summary>
        /// Выполняет поиск по ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Объект класса Entry - отдельная запись в записной книжке.</returns>
        private Entry Find(int id)
        {
            var list = GetListEntries.Get();

            foreach (var entry in list)
            {
                if (entry.Id == id)
                {
                    return entry;
                }
            }

            return new Entry()
            {
                LastName = "Данные не найдены",
                Phone = "нет данных",
                Address = "нет данных",
                Description = "нет данных"
            };
        }
    }
}
