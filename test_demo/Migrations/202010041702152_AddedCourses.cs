namespace test_demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCourses : DbMigration
    {
        public override void Up()
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
                    })
                .PrimaryKey(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Courses");
        }
    }
}
