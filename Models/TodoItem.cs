using System.ComponentModel.DataAnnotations;


public class TodoItem{
    public int Id { get; set;}

    [Required]
    required public string Title { get; set;}

    public bool IsCompleted { get; set;}

}