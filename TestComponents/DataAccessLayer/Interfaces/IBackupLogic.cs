using System.Collections.Generic;

namespace DataAccessLayer.Interfaces
{
    public interface IBackupLogic<TModel>
    {
        void Backup(string filename);
        void Restore(List<TModel> models);
    }
}
