using FQ23L056_FakeApi.Dal.Entities;

namespace FQ23L056_FakeApi.Dal.Repositories
{
    public interface ITaskRepository
    {
        IEnumerable<UserTask> Get();
        UserTask? Get(int id);
        bool Insert(UserTask entity);
        bool Update(UserTask entity);
        bool Delete(int id);
    }
}
