namespace Googlemaps.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GoogleMaps",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Latitude = c.String(),
                        Longitude = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GoogleMaps");
        }
    }
}
