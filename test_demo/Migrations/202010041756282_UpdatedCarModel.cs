namespace test_demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedCarModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "CarName", c => c.String(nullable: false, maxLength: 3));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "CarName", c => c.String());
        }
    }
}
