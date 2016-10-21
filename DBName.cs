public partial class MyClass : DbContext
{
  public MyClass() : base ("Name=DBName")
  {
    this.Configuration.LazyLoadingEnabled = false;
    this.Configuration.AntuDetectChangesEnabled = false;
    this.Configuration.ValidateOnsaveEnabled = false;
    
    // Clear out the code first trying to put to the database
    Database.SetInitializaer<DBName>(null);
    // log sql to the output window
    Database.Log = (s=>System.Diagnostics.Debug.WriteLine(s));
  }
  
  public virtual DbSet<MyTable> MyTables {get; set;} 
}
