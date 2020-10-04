namespace test_demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCarModal : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Id", "dbo.AspNetUsers");
            DropIndex("dbo.Courses", new[] { "Id" });
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarName = c.String(),
                        CarMake = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Courses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        CourseCode = c.String(),
                        Fee = c.Int(nullable: false),
                        ProfessorName = c.String(),
                        Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CourseId);
            
            DropTable("dbo.Cars");
            CreateIndex("dbo.Courses", "Id");
            AddForeignKey("dbo.Courses", "Id", "dbo.AspNetUsers", "Id");
        }
    }
}
