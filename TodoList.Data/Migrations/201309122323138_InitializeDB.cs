namespace TodoList.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        TaskId = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        TaskName = c.String(),
                        TaskDescription = c.String(),
                        TaskBegin = c.DateTime(nullable: false),
                        TaskEnd = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TaskId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        Description = c.String(),
                        Task_TaskId = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryId)
                .ForeignKey("dbo.Tasks", t => t.Task_TaskId)
                .Index(t => t.Task_TaskId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Categories", new[] { "Task_TaskId" });
            DropForeignKey("dbo.Categories", "Task_TaskId", "dbo.Tasks");
            DropTable("dbo.Categories");
            DropTable("dbo.Tasks");
        }
    }
}
