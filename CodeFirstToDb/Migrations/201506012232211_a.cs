namespace CodeFirstToDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Females",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 25),
                        Age = c.Int(nullable: false),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "dbo.Male",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        HairColor = c.String(),
                        Name = c.String(maxLength: 25),
                        Age = c.Int(nullable: false),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "dbo.Phone",
                c => new
                    {
                        Number = c.String(nullable: false, maxLength: 128),
                        PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Number)
                .ForeignKey("dbo.Male", t => t.PersonID, cascadeDelete: true)
                .Index(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phone", "PersonID", "dbo.Male");
            DropIndex("dbo.Phone", new[] { "PersonID" });
            DropTable("dbo.Phone");
            DropTable("dbo.Male");
            DropTable("dbo.Females");
        }
    }
}
