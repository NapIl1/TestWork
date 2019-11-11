using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AprioritDenysKarpenko
{
    public class FolderRepository : IRepository
    {
        private readonly IFolderDbContext context;
        public FolderRepository(IFolderDbContext context)
        {
            this.context = context;
        }

        public async Task<ICollection<Folder>> GetFoldersByNameAsync(string folderName)
        {
            var folders = await context.Folders
                .Where(x => x.FolerName.ToLower() == folderName.ToLower())
                .Include(x => x.Childs)
                .AsNoTracking()
                .ToListAsync();

            return folders;
        }
    }
}