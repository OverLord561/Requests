namespace HttpRequests.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RequestInformations",
                c => new
                    {
                        RequestInformationId = c.Int(nullable: false, identity: true),
                        RequestInformationType = c.String(),
                        RequestInformationIp = c.String(),
                        RequestInformationUrl = c.String(),
                    })
                .PrimaryKey(t => t.RequestInformationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RequestInformations");
        }
    }
}
