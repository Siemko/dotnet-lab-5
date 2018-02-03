using System.Data.Entity.Migrations;

namespace Lab5.Migrations
{
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Users",
                    c => new
                    {
                        Id = c.Int(false, true),
                        Username = c.String(false, 20),
                        Password = c.String(false, 50),
                        Name = c.String(false, 20),
                        Surname = c.String(false, 20)
                    })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}