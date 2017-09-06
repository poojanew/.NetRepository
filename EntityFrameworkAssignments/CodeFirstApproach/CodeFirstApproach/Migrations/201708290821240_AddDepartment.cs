namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartment : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.CodeFirstDeptClasses", name: "Id", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.CodeFirstDeptClasses", name: "Name", newName: "Id");
            RenameColumn(table: "dbo.CodeFirstDeptClasses", name: "__mig_tmp__0", newName: "Id1");
            AlterColumn("dbo.CodeFirstDeptClasses", "Id", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CodeFirstDeptClasses", "Id", c => c.Int(nullable: false, identity: true));
            RenameColumn(table: "dbo.CodeFirstDeptClasses", name: "Id1", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.CodeFirstDeptClasses", name: "Id", newName: "Name");
            RenameColumn(table: "dbo.CodeFirstDeptClasses", name: "__mig_tmp__0", newName: "Id");
        }
    }
}
