namespace Codefirstapproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CVMaker : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.educations",
                c => new
                    {
                        eduid = c.Int(nullable: false, identity: true),
                        institute = c.String(nullable: false, maxLength: 50),
                        title = c.String(nullable: false, maxLength: 50),
                        degree = c.String(nullable: false, maxLength: 50),
                        start_date = c.String(nullable: false, maxLength: 50),
                        end_date = c.String(nullable: false),
                        address = c.String(nullable: false),
                        userid = c.Int(),
                    })
                .PrimaryKey(t => t.eduid)
                .ForeignKey("dbo.users", t => t.userid)
                .Index(t => t.userid);
            
            CreateTable(
                "dbo.users",
                c => new
                    {
                        userid = c.Int(nullable: false, identity: true),
                        username = c.String(nullable: false, maxLength: 50),
                        email = c.String(nullable: false, maxLength: 50),
                        password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.userid);
            
            CreateTable(
                "dbo.personalinfoes",
                c => new
                    {
                        pid = c.Int(nullable: false, identity: true),
                        fname = c.String(nullable: false, maxLength: 50),
                        date_birth = c.String(nullable: false),
                        address = c.String(nullable: false, maxLength: 50),
                        nationality = c.String(nullable: false, maxLength: 50),
                        phone = c.String(nullable: false),
                        email = c.String(nullable: false, maxLength: 50),
                        userid = c.Int(),
                    })
                .PrimaryKey(t => t.pid)
                .ForeignKey("dbo.users", t => t.userid)
                .Index(t => t.userid);
            
            CreateTable(
                "dbo.skills",
                c => new
                    {
                        skillid = c.Int(nullable: false, identity: true),
                        skil = c.String(nullable: false, maxLength: 50),
                        userid = c.Int(),
                    })
                .PrimaryKey(t => t.skillid)
                .ForeignKey("dbo.users", t => t.userid)
                .Index(t => t.userid);
            
            CreateTable(
                "dbo.workexperiences",
                c => new
                    {
                        workid = c.Int(nullable: false, identity: true),
                        company_name = c.String(nullable: false, maxLength: 50),
                        title = c.String(nullable: false, maxLength: 50),
                        countary = c.String(nullable: false, maxLength: 50),
                        start_date = c.String(nullable: false),
                        end_date = c.String(nullable: false),
                        description = c.String(nullable: false, maxLength: 50),
                        userid = c.Int(),
                    })
                .PrimaryKey(t => t.workid)
                .ForeignKey("dbo.users", t => t.userid)
                .Index(t => t.userid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.workexperiences", "userid", "dbo.users");
            DropForeignKey("dbo.skills", "userid", "dbo.users");
            DropForeignKey("dbo.personalinfoes", "userid", "dbo.users");
            DropForeignKey("dbo.educations", "userid", "dbo.users");
            DropIndex("dbo.workexperiences", new[] { "userid" });
            DropIndex("dbo.skills", new[] { "userid" });
            DropIndex("dbo.personalinfoes", new[] { "userid" });
            DropIndex("dbo.educations", new[] { "userid" });
            DropTable("dbo.workexperiences");
            DropTable("dbo.skills");
            DropTable("dbo.personalinfoes");
            DropTable("dbo.users");
            DropTable("dbo.educations");
        }
    }
}
