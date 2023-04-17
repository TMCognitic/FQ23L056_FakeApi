using IDalTaskRepository = FQ23L056_FakeApi.Dal.Repositories.ITaskRepository;
using FQ23L056_FakeApi.Bll.Repositories;
using FQ23L056_FakeApi.Bll.Entities;
using FQ23L056_FakeApi.Bll.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FQ23L056_FakeApi.Bll.Services
{
    public class TaskService : ITaskRepository
    {
        private readonly IDalTaskRepository _taskRepository;

        public TaskService(IDalTaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public IEnumerable<UserTask> Get()
        {
            return _taskRepository.Get().Select(t => t.ToBll());
        }

        public UserTask? Get(int id)
        {
            return _taskRepository.Get(id)?.ToBll();
        }

        public bool Insert(UserTask entity)
        {
            return _taskRepository.Insert(entity.ToDal());
        }

        public bool Update(int id, UserTask entity)
        {
            UserTask userTask = new UserTask(id, entity.Title, entity.Done);
            return _taskRepository.Update(userTask.ToDal());
        }

        public bool Delete(int id)
        {
            return _taskRepository.Delete(id);
        }
    }
}
