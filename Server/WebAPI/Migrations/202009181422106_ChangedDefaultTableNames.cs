namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDefaultTableNames : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.User", newName: "Users");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Users", newName: "User");
        }
    }
}
