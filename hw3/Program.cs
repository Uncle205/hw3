using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context=new UsersContext())
            {
                var user1 = new Users
                {
                    Name = "Vasia"

                };
                var user2 = new Users
                {
                    Name = "Natali"
                };
                var lesson = new Lesson();

                lesson.User.Add(user1);
                lesson.User.Add(user2);
                user1.Lessons.Add(lesson);
                user2.Lessons.Add(lesson);

                context.Lessons.Add(lesson);
                context.User.Add(user1);
                context.User.Add(user2);

                context.SaveChanges();
            }
            
        }
    }
}
