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
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.CategoryTasks",
                c => new
                    {
                        Category_CategoryId = c.Int(nullable: false),
                        Task_TaskId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Category_CategoryId, t.Task_TaskId })
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Tasks", t => t.Task_TaskId, cascadeDelete: true)
                .Index(t => t.Category_CategoryId)
                .Index(t => t.Task_TaskId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.CategoryTasks", new[] { "Task_TaskId" });
            DropIndex("dbo.CategoryTasks", new[] { "Category_CategoryId" });
            DropForeignKey("dbo.CategoryTasks", "Task_TaskId", "dbo.Tasks");
            DropForeignKey("dbo.CategoryTasks", "Category_CategoryId", "dbo.Categories");
            DropTable("dbo.CategoryTasks");
            DropTable("dbo.Categories");
            DropTable("dbo.Tasks");
        }
    }
}
