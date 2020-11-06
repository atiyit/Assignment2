#pragma checksum "D:\dnp\Assignment2\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62fe177fa5b640114c413c7734c6e42694d72a51"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\dnp\Assignment2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dnp\Assignment2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dnp\Assignment2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dnp\Assignment2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dnp\Assignment2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dnp\Assignment2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dnp\Assignment2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dnp\Assignment2\_Imports.razor"
using Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dnp\Assignment2\_Imports.razor"
using Assignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dnp\Assignment2\Pages\Search.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dnp\Assignment2\Pages\Search.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dnp\Assignment2\Pages\Search.razor"
using Assignment.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Search")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>View and search person</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div> Min age </div> ");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "text");
            __builder.AddAttribute(4, "oninput", "value=value.replace(/[^\\d]/g,\'\')");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "D:\dnp\Assignment2\Pages\Search.razor"
                                                                                                minAge

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => minAge = __value, minAge));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.AddMarkupContent(8, "<div> Max age </div> ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "oninput", "value=value.replace(/[^\\d]/g,\'\')");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "D:\dnp\Assignment2\Pages\Search.razor"
                                                                                                maxAge

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => maxAge = __value, maxAge));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.AddMarkupContent(15, "<div> LastName </div> ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\dnp\Assignment2\Pages\Search.razor"
                                                      lastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lastName = __value, lastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.AddMarkupContent(21, "<div> FirstName </div> ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "text");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "D:\dnp\Assignment2\Pages\Search.razor"
                                                       firstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstName = __value, firstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.AddMarkupContent(27, "<div> Sex </div> ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "text");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "D:\dnp\Assignment2\Pages\Search.razor"
                                                 sex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sex = __value, sex));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n");
            __builder.OpenElement(33, "div");
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\dnp\Assignment2\Pages\Search.razor"
                      search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, " search ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\dnp\Assignment2\Pages\Search.razor"
                      clear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, " clear ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
            __builder.OpenElement(44, "div");
            __builder.OpenElement(45, "label");
            __builder.AddContent(46, " ");
            __builder.AddContent(47, 
#nullable restore
#line 18 "D:\dnp\Assignment2\Pages\Search.razor"
              message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n");
            __Blazor.Assignment.Pages.Search.TypeInference.CreateTableTemplate_0(__builder, 49, 50, 
#nullable restore
#line 20 "D:\dnp\Assignment2\Pages\Search.razor"
                      result

#line default
#line hidden
#nullable disable
            , 51, (__builder2) => {
                __builder2.AddMarkupContent(52, "\r\n        ");
                __builder2.AddMarkupContent(53, "<th>ID</th>\r\n        ");
                __builder2.AddMarkupContent(54, "<th>firstName</th>\r\n        ");
                __builder2.AddMarkupContent(55, "<th>lastName</th>\r\n        ");
                __builder2.AddMarkupContent(56, "<th>Age</th>\r\n        ");
                __builder2.AddMarkupContent(57, "<th>Sex</th>\r\n        ");
                __builder2.AddMarkupContent(58, "<th>Job</th>\r\n        ");
                __builder2.AddMarkupContent(59, "<th>HairColor</th>\r\n        ");
                __builder2.AddMarkupContent(60, "<th>EyeColor</th>\r\n        ");
                __builder2.AddMarkupContent(61, "<th>Height</th>\r\n        ");
                __builder2.AddMarkupContent(62, "<th>Weight</th>\r\n    ");
            }
            , 63, (context) => (__builder2) => {
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.OpenElement(65, "td");
                __builder2.AddContent(66, 
#nullable restore
#line 34 "D:\dnp\Assignment2\Pages\Search.razor"
             context.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.OpenElement(68, "td");
                __builder2.AddContent(69, 
#nullable restore
#line 35 "D:\dnp\Assignment2\Pages\Search.razor"
             context.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n        ");
                __builder2.OpenElement(71, "td");
                __builder2.AddContent(72, 
#nullable restore
#line 36 "D:\dnp\Assignment2\Pages\Search.razor"
             context.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n        ");
                __builder2.OpenElement(74, "td");
                __builder2.AddContent(75, 
#nullable restore
#line 37 "D:\dnp\Assignment2\Pages\Search.razor"
             context.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n        ");
                __builder2.OpenElement(77, "td");
                __builder2.AddContent(78, 
#nullable restore
#line 38 "D:\dnp\Assignment2\Pages\Search.razor"
             context.Sex

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n        ");
                __builder2.OpenElement(80, "td");
                __builder2.AddContent(81, 
#nullable restore
#line 39 "D:\dnp\Assignment2\Pages\Search.razor"
             context.JobTitle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n        ");
                __builder2.OpenElement(83, "td");
                __builder2.AddContent(84, 
#nullable restore
#line 40 "D:\dnp\Assignment2\Pages\Search.razor"
             context.HairColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n        ");
                __builder2.OpenElement(86, "td");
                __builder2.AddContent(87, 
#nullable restore
#line 41 "D:\dnp\Assignment2\Pages\Search.razor"
             context.EyeColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n        ");
                __builder2.OpenElement(89, "td");
                __builder2.AddContent(90, 
#nullable restore
#line 42 "D:\dnp\Assignment2\Pages\Search.razor"
             context.Height

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n        ");
                __builder2.OpenElement(92, "td");
                __builder2.AddContent(93, 
#nullable restore
#line 43 "D:\dnp\Assignment2\Pages\Search.razor"
             context.Weight

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n    ");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "D:\dnp\Assignment2\Pages\Search.razor"
       
    private int minAge;
    private int maxAge;
    private string lastName;
    private string firstName;
    private string sex;
    List<Adult> result = new List<Adult>();
    private string message;
    private int count;
    
    public async Task search()
    {
        FileContext fileContext = new FileContext();
        IList<Adult> adults = fileContext.Adults;
        message = "";
        result.Clear();
        
        for (int i = 0; i < adults.Count; i++)
        {
            if (lastName ==null && firstName ==null)
            {
                if (adults[i].Age >= minAge && adults[i].Age <= maxAge && adults[i].Sex == sex)
                {
                    Adult adult = adults[i];
                    result.Add(adult);
                }
            }
            else if (lastName == null)
            {
                if (adults[i].Age >= minAge && adults[i].Age <= maxAge && adults[i].Sex == sex && adults[i].FirstName==firstName)
                {
                    Adult adult = adults[i];
                    result.Add(adult);
                }
            }
            else if (firstName == null)
            {
                if (adults[i].Age >= minAge && adults[i].Age <= maxAge && adults[i].Sex == sex && adults[i].LastName==lastName)
                {
                    Adult adult = adults[i];
                    result.Add(adult);
                }
            }
            else
            {
                if (adults[i].Age >= minAge && adults[i].Age <= maxAge && adults[i].Sex == sex && adults[i].FirstName==firstName && adults[i].LastName==lastName)
                {
                    Adult adult = adults[i];
                    result.Add(adult);
                }
            }
        }
        if (result.Count == 0)
        {
            message = "No match!";
        }
    }
    
    
    public async Task clear()
    {
        result.Clear();
        message = "";
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Assignment.Pages.Search
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTableTemplate_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IReadOnlyList<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg2)
        {
        __builder.OpenComponent<global::Assignment.Pages.TableTemplate<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "TableHeader", __arg1);
        __builder.AddAttribute(__seq2, "RowTemplate", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591