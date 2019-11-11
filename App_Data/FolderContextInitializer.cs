using System.Collections.Generic;
using System.Data.Entity;

namespace AprioritDenysKarpenko
{
    internal class FolderContextInitializer : CreateDatabaseIfNotExists<FolderContext>
    {
        protected override void Seed(FolderContext context)
        {
            List<Folder> folders = new List<Folder>()
            {
                 new Folder { FolerName = "Creating Digital Images", Id = 1 },

                 new Folder { FolerName = "Resources", Id = 11, ParentId = 1},
                 new Folder { FolerName = "Primary Resources", Id = 111, ParentId = 11 },
                 new Folder { FolerName = "Secondary Resources", Id = 112, ParentId = 11 },

                 new Folder { FolerName = "Evidence", Id = 2, ParentId = 1 },

                 new Folder { FolerName = "Graphic Products", Id = 3, ParentId = 1 },
                 new Folder { FolerName = "Process", Id = 31, ParentId = 3 },
                 new Folder { FolerName = "Final Product", Id = 32, ParentId = 3 }
            };

            context.Folders.AddRange(folders);
            context.SaveChanges();
        }
    }
}