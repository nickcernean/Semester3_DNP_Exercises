// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Ex2_ToDoTutorial.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Semester3\DNP31Y\DNP_Exercises\Ex2_ToDoTutorial\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Semester3\DNP31Y\DNP_Exercises\Ex2_ToDoTutorial\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Semester3\DNP31Y\DNP_Exercises\Ex2_ToDoTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Semester3\DNP31Y\DNP_Exercises\Ex2_ToDoTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Semester3\DNP31Y\DNP_Exercises\Ex2_ToDoTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Semester3\DNP31Y\DNP_Exercises\Ex2_ToDoTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Semester3\DNP31Y\DNP_Exercises\Ex2_ToDoTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Semester3\DNP31Y\DNP_Exercises\Ex2_ToDoTutorial\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Semester3\DNP31Y\DNP_Exercises\Ex2_ToDoTutorial\_Imports.razor"
using Ex2_ToDoTutorial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Semester3\DNP31Y\DNP_Exercises\Ex2_ToDoTutorial\_Imports.razor"
using Ex2_ToDoTutorial.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Semester3\DNP31Y\DNP_Exercises\Ex2_ToDoTutorial\Pages\Todos.razor"
using Ex2_ToDoTutorial.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Semester3\DNP31Y\DNP_Exercises\Ex2_ToDoTutorial\Pages\Todos.razor"
using Ex2_ToDoTutorial.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Semester3\DNP31Y\DNP_Exercises\Ex2_ToDoTutorial\Pages\Todos.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Semester3\DNP31Y\DNP_Exercises\Ex2_ToDoTutorial\Pages\Todos.razor"
using Microsoft.AspNetCore.Mvc.Filters;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Todos")]
    public partial class Todos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "D:\Semester3\DNP31Y\DNP_Exercises\Ex2_ToDoTutorial\Pages\Todos.razor"
       
    private IList<ToDo> allTodos;
    private IList<ToDo> todosToShow;

    private int? filterById;
    private bool? filterByIsCompleted;

    protected override async Task OnInitializedAsync()
    {
        allTodos = TodoData.GetTodos();
        todosToShow = allTodos;
    }

    private void RemoveTodo(int todoId)
    {
        ToDo toDoToRemove = allTodos.First(t => t.TodoId == todoId);
        TodoData.RemoveTodo(todoId);
        allTodos.Remove(toDoToRemove);
        todosToShow.Remove(toDoToRemove);
    }

    private void CompletedChange(ChangeEventArgs evt, ToDo toDo)
    {
        toDo.IsCompleted = (bool) evt.Value;
        TodoData.Update(toDo);
    }

    private void FilterByUserId(ChangeEventArgs eventArg)
    {
        filterById = null;
        try
        {
            filterById = int.Parse(eventArg.Value.ToString());
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void FilterByCompletedStatus(ChangeEventArgs eventArg)
    {
        filterByIsCompleted = null;
        try
        {
            filterByIsCompleted = bool.Parse(eventArg.Value.ToString());
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        todosToShow = allTodos.Where(t => (filterById != null && t.UserId == filterById || filterById == null)
                                          && (filterByIsCompleted != null && t.IsCompleted == filterByIsCompleted || filterByIsCompleted == null)).ToList();
    }

    private void Edit(int id)
    {
        NavMgr.NavigateTo($"Edit/{id}");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITodosData TodoData { get; set; }
    }
}
#pragma warning restore 1591
