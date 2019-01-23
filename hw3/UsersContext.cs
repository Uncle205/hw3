namespace hw3
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class UsersContext : DbContext
    {
        // Контекст настроен для использования строки подключения "UsersContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "hw3.UsersContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "UsersContext" 
        // в файле конфигурации приложения.
        public UsersContext()
            : base("name=UsersContext")
        {
        }
        public DbSet<Users> User { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}