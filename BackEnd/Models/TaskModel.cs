namespace BackEnd.Models
{
    /// <summary>
    /// Here is a Model for the Task table. It appears in different BackEnd project because both
    /// WPF layer and Entity Framework Layer need it to function properly.
    /// </summary>
    public class TaskModel
    {
        
        public Guid Id { get; }
        public string TaskName { get; }
        public string TaskDescription { get; }
        public string TaskPriority { get; }
        public string TaskLocation { get; }
        public TaskModel(Guid id, string taskName, string taskDescription, string taskPriority, string taskLocation)
        {
            Id = id;
            TaskName = taskName;
            TaskDescription = taskDescription;
            TaskPriority = taskPriority;
            TaskLocation = taskLocation;
        }
    }
}
