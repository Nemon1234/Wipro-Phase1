using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Pages;

namespace RazorPagesApp.Pages
{
    public class ItemListModel : PageModel
    {
        // Define the Items property
        public List<string> Items { get; set; }

        public void OnGet()
        {
            // Get the list of items from AddItemModel (or some other source)
            Items = AddItemModel.Items;
        }
    }
}
