
SET QUOTED_IDENTIFIER OFF;
GO
USE [TaskMan];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Task_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Task] DROP CONSTRAINT [FK_Task_User];
GO
IF OBJECT_ID(N'[dbo].[FK_UsersTasks_Task]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsersTasks] DROP CONSTRAINT [FK_UsersTasks_Task];
GO
IF OBJECT_ID(N'[dbo].[FK_UsersTasks_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsersTasks] DROP CONSTRAINT [FK_UsersTasks_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Task]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Task];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO
IF OBJECT_ID(N'[dbo].[UsersTasks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsersTasks];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Tasks'
CREATE TABLE [dbo].[Task] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AuthorId] int  NOT NULL,
    [Title] nvarchar(200)  NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [RealisationDate] datetime  NOT NULL,
    [Priority] int  NOT NULL
);
GO

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(50)  NOT NULL,
    [Password] nvarchar(250)  NOT NULL
);
GO

-- Creating table 'UsersTasks'
CREATE TABLE [dbo].[UsersTasks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] int  NOT NULL,
    [TaskId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Tasks'
ALTER TABLE [dbo].[Task]
ADD CONSTRAINT [PK_Task]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UsersTasks'
ALTER TABLE [dbo].[UsersTasks]
ADD CONSTRAINT [PK_UsersTasks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AuthorId] in table 'Tasks'
ALTER TABLE [dbo].[Task]
ADD CONSTRAINT [FK_Task_User]
    FOREIGN KEY ([AuthorId])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Tasks_Users'
CREATE INDEX [IX_FK_Task_User]
ON [dbo].[Task]
    ([AuthorId]);
GO

-- Creating foreign key on [TaskId] in table 'UsersTasks'
ALTER TABLE [dbo].[UsersTasks]
ADD CONSTRAINT [FK_UsersTasks_Task]
    FOREIGN KEY ([TaskId])
    REFERENCES [dbo].[Task]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsersTasks_Tasks'
CREATE INDEX [IX_FK_UsersTasks_Task]
ON [dbo].[UsersTasks]
    ([TaskId]);
GO

-- Creating foreign key on [UserId] in table 'UsersTasks'
ALTER TABLE [dbo].[UsersTasks]
ADD CONSTRAINT [FK_UsersTasks_User]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsersTasks_Users'
CREATE INDEX [IX_FK_UsersTasks_User]
ON [dbo].[UsersTasks]
    ([UserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------