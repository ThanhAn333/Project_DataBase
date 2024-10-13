using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.Models
{
    public abstract class BaseEntity
    {
        public int ID { get; protected set; }
        public DateTime CreatedDate { get; private set; } = DateTime.Now;

        protected BaseEntity(int id)
        {
            ID = id;
        }
    }
}
