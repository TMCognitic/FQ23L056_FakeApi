using FQ23L056_FakeApi.Bll.Entities;

namespace FQ23L056_FakeApi.Bll.Repositories
{
    public interface ITaskRepository
    {
        IEnumerable<UserTask> Get();
        UserTask? Get(int id);
        bool Insert(UserTask entity);
        bool Update(int id, UserTask entity);
        bool Delete(int id);
    }
}
