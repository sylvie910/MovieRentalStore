namespace MusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'526a334a-a63e-472f-b704-40ef098d163c', N'sylvie@vidly.com', 0, N'AB50uD3arsO4XPwc9iBLEArGKRUwYr5MjkZT7p9J6fTddCb83sKNOm3VcEhrz5iN6Q==', N'f9dece31-4c8f-44d6-a606-8529ab4b99ba', NULL, 0, 0, NULL, 1, 0, N'sylvie@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a2b306de-1829-4bed-9dc3-89e34da00058', N'guest@vidly.com', 0, N'AKJQMLTvsUyYu1zclASzgipSxRoJgj3oKCSzzz9bSwTGRk+8CzyoUbazHw5ZxGlZew==', N'44b3669f-a811-4638-b4c4-af1c89f3fdc2', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a46bf8f8-726d-43cc-b532-9962e62df69b', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'526a334a-a63e-472f-b704-40ef098d163c', N'a46bf8f8-726d-43cc-b532-9962e62df69b')

");
        }
        
        public override void Down()
        {
        }
    }
}
