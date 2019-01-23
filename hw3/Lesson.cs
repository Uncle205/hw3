using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
   public  class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mark { get; set; }
        public virtual ICollection<Users> User { get; set; }
        public Lesson()
        {
            User = new List<Users>();
        }
    }
}
