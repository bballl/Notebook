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
        /// ������ �� ������ � �������� ������.
        /// </summary>
        public Entry? person;
        
        /// <summary>
        /// ��������� Get-��������, ��������� ID, ������������� ��� � ��� int, 
        /// �� �������� id ������������� ������ �� ��������������� ������ � ���� ������.
        /// </summary>
        /// <param name="id"></param>
        public void OnGet(string id)
        {
            person = new Entry();

            int Id = Convert.ToInt32(id);

            person = Find(Id);
        }

        /// <summary>
        /// ��������� ����� �� ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>������ ������ Entry - ��������� ������ � �������� ������.</returns>
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
                LastName = "������ �� �������",
                Phone = "��� ������",
                Address = "��� ������",
                Description = "��� ������"
            };
        }
    }
}
