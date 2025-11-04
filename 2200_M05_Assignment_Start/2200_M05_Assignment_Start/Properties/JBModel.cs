using System;
using System.Data.Entity;
using System.Linq;

namespace _2200_M05_Assignment_Start.Properties
{
    public class JBModel : DbContext
    {
        // Your context has been configured to use a 'JBModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // '_2200_M05_Assignment_Start.Properties.JBModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'JBModel' 
        // connection string in the application configuration file.
        public JBModel()
            : base("name=JBModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<JellyBelly> JellyBellies { get; set; } // your class is called JellyBelly if you copy and pasted the code provided.
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}