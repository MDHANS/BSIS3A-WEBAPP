using System.Collections.Generic; 
using bsisweb_app.Models;


namespace bsisweb_app.Models.ViewModels
{
    public class TypeViewModel
    {
        public Type Type { get; set; }
        public IEnumerable<Item> Items { get; set; }
        
    }
}