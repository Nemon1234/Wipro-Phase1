using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp.Pages
{
    public class AddItemModel : PageModel
    {
        [BindProperty]
        public string NewItem { get; set; }

        // Static list to hold all items (shared between pages)
        public static List<string> Items { get; set; } = new List<string>();

        public IActionResult OnPost()
        {
            if (!string.IsNullOrEmpty(NewItem))
            {
                // Add the new item to the list
                Items.Add(NewItem);
            }
            return RedirectToPage("ItemList");
        }
    }
}
