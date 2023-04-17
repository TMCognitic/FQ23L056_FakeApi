using FQ23L056_FakeApi.Dal.Entities;
using FQ23L056_FakeApi.Dal.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FQ23L056_FakeApi.Dal.Services
{
    public class FakeTaskService : ITaskRepository
    {
        private readonly List<UserTask> _tasks;
        public FakeTaskService() 
        {
            _tasks = new List<UserTask>()
            {
                new UserTask() { Id = 1, Title = "Do Something" },
                new UserTask() { Id = 2, Title = "Create Fake Service", Done = true }
            };
        }

        public IEnumerable<UserTask> Get()
        {
            return _tasks;
        }

        public UserTask? Get(int id)
        {
            return _tasks.SingleOrDefault(t => t.Id == id);
        }

        public bool Insert(UserTask entity)
        {
            entity.Id = _tasks.Count == 0 ? 1 : _tasks.Max(t => t.Id) + 1;
            _tasks.Add(entity);
            return true;
        }

        public bool Update(UserTask entity)
        {
            UserTask? userTask = _tasks.SingleOrDefault(t => t.Id == entity.Id);
            if (userTask is null) 
            {
                return false;
            }

            userTask.Title = entity.Title;
            userTask.Done = entity.Done;
            return true;
        }
        public bool Delete(int id)
        {
            UserTask? userTask = _tasks.SingleOrDefault(t => t.Id == id);
            if (userTask is null)
            {
                return false;
            }

            _tasks.Remove(userTask);
            return true;
        }
    }
}
