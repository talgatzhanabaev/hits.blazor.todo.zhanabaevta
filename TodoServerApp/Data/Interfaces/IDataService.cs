namespace TodoServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<IEnumerable<TaskItem>> GetAllAsync();
        Task SaveAsync(TaskItem item);
        Task<TaskItem> GetTaskItemsAsync(int id);
        Task DeleteAsync(int id);
    }
}
