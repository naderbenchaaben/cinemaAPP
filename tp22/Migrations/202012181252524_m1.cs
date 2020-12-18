namespace tp22.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Participations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Role = c.Int(nullable: false),
                        MovieID = c.Int(nullable: false),
                        ActorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Actors", t => t.ActorID, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieID, cascadeDelete: true)
                .Index(t => t.MovieID)
                .Index(t => t.ActorID);
            
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Actors", "Firstname", c => c.String());
            AddColumn("dbo.Actors", "Lastname", c => c.String());
            AddColumn("dbo.Movies", "DirectorID", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "DirectorID");
            AddForeignKey("dbo.Movies", "DirectorID", "dbo.Directors", "ID", cascadeDelete: true);
            DropColumn("dbo.Actors", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Actors", "Name", c => c.String());
            DropForeignKey("dbo.Participations", "MovieID", "dbo.Movies");
            DropForeignKey("dbo.Movies", "DirectorID", "dbo.Directors");
            DropForeignKey("dbo.Participations", "ActorID", "dbo.Actors");
            DropIndex("dbo.Movies", new[] { "DirectorID" });
            DropIndex("dbo.Participations", new[] { "ActorID" });
            DropIndex("dbo.Participations", new[] { "MovieID" });
            DropColumn("dbo.Movies", "DirectorID");
            DropColumn("dbo.Actors", "Lastname");
            DropColumn("dbo.Actors", "Firstname");
            DropTable("dbo.Directors");
            DropTable("dbo.Participations");
        }
    }
}
