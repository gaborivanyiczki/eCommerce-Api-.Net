namespace eCommerceFLANCO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsersAndRoles : DbMigration
    {
        public override void Up()
        {
           Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1531c80a-7af4-417b-a980-e15480592cf0', N'xd.gaga@yahoo.com', 0, N'AJG0a+9yfv0Jwkqj5TjFXdJAzFmT6ygIW715jmMI1mw9nbi8GVDwnOQ5fG+/kMn7Nw==', N'adb3b56f-adf2-405e-a9de-7a0cc49da48d', NULL, 0, 0, NULL, 1, 0, N'xd.gaga@yahoo.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'728f436d-c280-4591-b268-f1c1243a05fd', N'gabor.ivanyiczki@yahoo.com', 0, N'AB1j/b2x5Y6AyvHCAko/aKFBLuEX9zQmfEKRxVwrrqjHd6QPnjZ5ueqbl3HkDkrlag==', N'c05152b0-d8e2-41f4-82fd-a25f7da79abb', NULL, 0, 0, NULL, 1, 0, N'gabor.ivanyiczki@yahoo.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'98a558c3-4084-4881-b2b0-53eb9bae5d35', N'Administrator')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'728f436d-c280-4591-b268-f1c1243a05fd', N'98a558c3-4084-4881-b2b0-53eb9bae5d35')

");
        }
        
        public override void Down()
        {
            
        }
    }
}
