#pragma checksum "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\Pages\Employee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d315d8f663068298830361f21dcaba625547f254"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\_Imports.razor"
using BlazorCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\_Imports.razor"
using BlazorCRUD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\Pages\Employee.razor"
using BlazorCRUD.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employee")]
    public partial class Employee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "class", "nav-link");
            __builder.AddAttribute(2, "href", "AddEmployee");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    <span class=\"oi oi-plus\" aria-hidden=\"true\"></span>Add new\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<h1>Employee Information</h1>\r\n");
#nullable restore
#line 10 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\Pages\Employee.razor"
 if (objEmp == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.AddMarkupContent(8, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\Pages\Employee.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddMarkupContent(13, @"<thead>
            <tr>
                <th>Employee ID</th>
                <th>Name</th>
                <th>Gender</th>
                <th>Country</th>
                <th>City</th>
                <th>Action</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 28 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\Pages\Employee.razor"
             foreach(var emp in objEmp)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "            ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 31 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\Pages\Employee.razor"
                     emp.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 32 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\Pages\Employee.razor"
                     emp.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 33 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\Pages\Employee.razor"
                     emp.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 34 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\Pages\Employee.razor"
                     emp.Country

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 35 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\Pages\Employee.razor"
                     emp.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "a");
            __builder.AddAttribute(37, "class", "nav-link");
            __builder.AddAttribute(38, "href", "EditEmployee/" + (
#nullable restore
#line 37 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\Pages\Employee.razor"
                                                            emp.EmployeeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(39, "\r\n                        <span class=\"oi oi-pencil\" aria-hidden=\"true\"></span>Edit\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "a");
            __builder.AddAttribute(42, "class", "nav-link");
            __builder.AddAttribute(43, "href", "DeleteEmployee/" + (
#nullable restore
#line 40 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\Pages\Employee.razor"
                                                              emp.EmployeeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "\r\n                        <span class=\"oi oi-trash\" aria-hidden=\"true\"></span>Delete  \r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 45 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\Pages\Employee.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 49 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\Pages\Employee.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\fuads\source\repos\BlazorCRUD\BlazorCRUD\Pages\Employee.razor"
       
    List<EmployeeInfo> objEmp;
    protected override async Task OnInitializedAsync()
    {
        objEmp = await Task.Run(() => objEmpService.GetEmployee());
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService objEmpService { get; set; }
    }
}
#pragma warning restore 1591
