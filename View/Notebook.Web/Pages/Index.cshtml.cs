using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Notebook.Database;

namespace Notebook.Web.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// ������ ������� �������� ������.
        /// </summary>
        public List<Entry> list;
        
        public IndexModel()
        {
            list = GetListEntries.Get();
        }
        public void OnGet()
        {
        }
    }
}
