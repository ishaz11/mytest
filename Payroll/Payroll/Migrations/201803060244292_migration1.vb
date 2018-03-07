Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class migration1
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Users",
                Function(c) New With
                    {
                        .UserID = c.Int(nullable := False, identity := True),
                        .Username = c.String(),
                        .Password = c.String(),
                        .Fname = c.String(),
                        .Lname = c.String(),
                        .Status = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.UserID)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Users")
        End Sub
    End Class
End Namespace
