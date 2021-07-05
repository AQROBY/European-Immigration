namespace European_Immigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'52d548ee-e8bf-4a1a-948d-88d29f283494', N'aq_roby@yahoo.com', 0, N'AIZR+pYiARY9ZPWWqL0U5EIIh/s06F0gG7rJfYVluRmxeHkpyVlgpLBEbm94zYxdkw==', N'a923b9fc-7e70-4af6-856a-fefdf9961bd0', NULL, 0, 0, NULL, 1, 0, N'aq_roby@yahoo.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7380a3f4-14b4-4e72-8f88-2b500366f3cb', N'admin@admin.com', 0, N'AFDBCHNBEGL9Z4Q4jx8S1RZIm7PyfgmZ9cGTMtksZOMZrHfUJL86bvraNowy/WGrBg==', N'18f733e5-5062-49aa-8741-a621fd090621', NULL, 0, 0, NULL, 1, 0, N'admin@admin.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'54c1cecf-d233-408d-811c-6e61ced69a3a', N'Admin')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7380a3f4-14b4-4e72-8f88-2b500366f3cb', N'54c1cecf-d233-408d-811c-6e61ced69a3a')

");
        }
        
        public override void Down()
        {
        }
    }
}
