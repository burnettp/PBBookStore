#pragma checksum "C:\Users\parke\source\repos\PBBookStore\Pages\Admin\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcfb5f1260fe3be520ed9c4e61abe1cd9572f9f6"
// <auto-generated/>
#pragma warning disable 1591
namespace PBBookStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\parke\source\repos\PBBookStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\parke\source\repos\PBBookStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\parke\source\repos\PBBookStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\parke\source\repos\PBBookStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\parke\source\repos\PBBookStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\parke\source\repos\PBBookStore\Pages\Admin\_Imports.razor"
using PBBookStore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/details/{id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"bg-info text-white text-center p-1\">Details</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-sm table-bordered table-striped");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "<th>Book ID:</th>");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 7 "C:\Users\parke\source\repos\PBBookStore\Pages\Admin\Details.razor"
                                  book.BookId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "<th>Title:</th>");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 8 "C:\Users\parke\source\repos\PBBookStore\Pages\Admin\Details.razor"
                                book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "<th>Author:</th>");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 9 "C:\Users\parke\source\repos\PBBookStore\Pages\Admin\Details.razor"
                                 book.Author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "<th>Publisher:</th>");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 10 "C:\Users\parke\source\repos\PBBookStore\Pages\Admin\Details.razor"
                                    book.Publisher

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "<th>Isbn:</th>");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 11 "C:\Users\parke\source\repos\PBBookStore\Pages\Admin\Details.razor"
                               book.Isbn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "tr");
            __builder.AddMarkupContent(32, "<th>Classification:</th>");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 12 "C:\Users\parke\source\repos\PBBookStore\Pages\Admin\Details.razor"
                                         book.Classification

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "tr");
            __builder.AddMarkupContent(37, "<th>Category:</th>");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 13 "C:\Users\parke\source\repos\PBBookStore\Pages\Admin\Details.razor"
                                   book.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "tr");
            __builder.AddMarkupContent(42, "<th>Page Count:</th>");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 14 "C:\Users\parke\source\repos\PBBookStore\Pages\Admin\Details.razor"
                                     book.PageCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "tr");
            __builder.AddMarkupContent(47, "<th>Price:</th>");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 15 "C:\Users\parke\source\repos\PBBookStore\Pages\Admin\Details.razor"
                                book.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(53);
            __builder.AddAttribute(54, "class", "btn btn-warning");
            __builder.AddAttribute(55, "href", 
#nullable restore
#line 19 "C:\Users\parke\source\repos\PBBookStore\Pages\Admin\Details.razor"
                                        EditUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(57, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(58, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(59);
            __builder.AddAttribute(60, "class", "btn btn-Secondary");
            __builder.AddAttribute(61, "href", "/admin/books");
            __builder.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(63, "Back");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\parke\source\repos\PBBookStore\Pages\Admin\Details.razor"
      

    [Inject]
    public IBookstoreRepository repo { get; set; }

    [Parameter]
    public long Id { get; set; }

    public Book book { get; set; }

    protected override void OnParametersSet()
    {
        book = repo.Books.FirstOrDefault(x => x.BookId == Id);
    }

    public string EditUrl => $"/admin/books/edit/{book.BookId}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
