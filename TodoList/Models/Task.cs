namespace TodoList.Models;

public class Task
{
    public Guid Id { get; }
    public string Title { get; }
    public string Description { get; }
    public DateTime Deadline { get; }
    public DateTime LastModifiedDateTime { get; }
    public List<string> Tags { get; }
    
    public Task(Guid id, string title, string description, DateTime deadline, DateTime lastModifiedDateTime, List<string> tags)
    {
        Id = id;
        Title = title;
        Description = description;
        Deadline = deadline;
        LastModifiedDateTime = lastModifiedDateTime;
        Tags = tags;
    }
}