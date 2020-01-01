using System.Collections.Generic;
using AndrewPino.BlogDb.DataModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AndrewPino.Models
{
    public class BlogEntry
    {
        public List<SelectListItem> AvailableBlogTags { get; set; }
        
        public Blog Blog { get; set; }
    }
}