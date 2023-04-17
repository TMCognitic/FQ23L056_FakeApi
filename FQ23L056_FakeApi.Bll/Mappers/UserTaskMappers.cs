using DalUserTask = FQ23L056_FakeApi.Dal.Entities.UserTask;
using FQ23L056_FakeApi.Bll.Entities;

namespace FQ23L056_FakeApi.Bll.Mappers
{
    internal static partial class Mappers
    {
        internal static UserTask ToBll(this DalUserTask entity)
        {
            return new UserTask(entity.Id, entity.Title, entity.Done);
        }

        internal static DalUserTask ToDal(this UserTask entity)
        {
            return new DalUserTask() { Id = entity.Id, Title = entity.Title, Done = entity.Done };
        }
    }
}
