using System.Data.Entity;

namespace AprioritDenysKarpenko
{
    public interface IFolderDbContext
    {
        DbSet<Folder> Folders { get; set; }
    }
}