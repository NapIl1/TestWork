using System.Collections.Generic;

namespace AprioritDenysKarpenko
{
    public class Folder
    {
        public int Id { get; set; }
        public string FolerName { get; set; }
        public int? ParentId { get; set; }
        public virtual Folder Parent { get; set; }
        public virtual ICollection<Folder> Childs { get; set; }
    }
}