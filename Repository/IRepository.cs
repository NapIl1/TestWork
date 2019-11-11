using System.Collections.Generic;
using System.Threading.Tasks;

namespace AprioritDenysKarpenko
{
    public interface IRepository
    {
        Task<ICollection<Folder>> GetFoldersByNameAsync(string folderName);
    }
}