namespace HttpRequests.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieHouses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieHouses",
                c => new
                    {
                        MovieHouseId = c.Int(nullable: false, identity: true),
                        MovieHouseName = c.String(nullable: false),
                        MovieHouseTelephone = c.String(nullable: false),
                        MovieHouseAdress = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MovieHouseId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MovieHouses");
        }
    }
}
