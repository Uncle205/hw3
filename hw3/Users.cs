using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
   public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
        public Users()
        {
            Lessons= new List<Lesson>();
        }
    }
}
