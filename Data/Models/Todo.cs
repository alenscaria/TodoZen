
using System.ComponentModel.DataAnnotations;

namespace TODO_Blazer.Models
{
    public class Todo
    {
    [Key]
    public int TodoCount{get; set;}
    public string TodoItem{get; set;}
    public bool IsCompleted{get; set;}
    }
}