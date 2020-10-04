namespace test_demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUserWithCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Courses", "Id");
            AddForeignKey("dbo.Courses", "Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Id", "dbo.AspNetUsers");
            DropIndex("dbo.Courses", new[] { "Id" });
            DropColumn("dbo.Courses", "Id");
        }
    }
}
