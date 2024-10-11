CREATE DATABASE JobApplicationDB;
GO

USE JobApplicationDB;
GO

-- Bảng User
CREATE TABLE [dbo].[User] (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    Role NVARCHAR(50) NOT NULL -- Ví dụ: Admin, Applicant, Recruiter
);
GO

-- Bảng Job
CREATE TABLE [dbo].[Job] (
    JobID INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(200) NOT NULL,
    Description NVARCHAR(MAX) NOT NULL,
    Location NVARCHAR(100) NOT NULL,
    PostedDate DATETIME DEFAULT GETDATE(),
    Status NVARCHAR(50) NOT NULL -- Ví dụ: Open, Closed
);
GO

-- Bảng Application
CREATE TABLE [dbo].[Application] (
    ApplicationID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    JobID INT NOT NULL,
    ApplicationDate DATETIME DEFAULT GETDATE(),
    Status NVARCHAR(50) NOT NULL, -- Ví dụ: Pending, Accepted, Rejected
    FOREIGN KEY (UserID) REFERENCES [dbo].[User](UserID),
    FOREIGN KEY (JobID) REFERENCES [dbo].[Job](JobID)
);
GO

-- Bảng JobPost
CREATE TABLE [dbo].[JobPost] (
    JobPostID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    Title NVARCHAR(200) NOT NULL,
    Description NVARCHAR(MAX) NOT NULL,
    Location NVARCHAR(100) NOT NULL,
    PostedDate DATETIME DEFAULT GETDATE(),
    Status NVARCHAR(50) NOT NULL, -- Ví dụ: Active, Inactive
    FOREIGN KEY (UserID) REFERENCES [dbo].[User](UserID)
);
GO

-- Bảng Message
CREATE TABLE [dbo].[Message] (
    MessageID INT IDENTITY(1,1) PRIMARY KEY,
    SenderID INT NOT NULL,
    ReceiverID INT NOT NULL,
    Content NVARCHAR(MAX) NOT NULL,
    Timestamp DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (SenderID) REFERENCES [dbo].[User](UserID),
    FOREIGN KEY (ReceiverID) REFERENCES [dbo].[User](UserID)
);
GO

-- Bảng Skill
CREATE TABLE [dbo].[Skill] (
    SkillID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(MAX) NULL
);
GO

-- Bảng JobSkill
CREATE TABLE [dbo].[JobSkill] (
    JobSkillID INT IDENTITY(1,1) PRIMARY KEY,
    JobID INT NOT NULL,
    SkillID INT NOT NULL,
    FOREIGN KEY (JobID) REFERENCES [dbo].[Job](JobID),
    FOREIGN KEY (SkillID) REFERENCES [dbo].[Skill](SkillID)
);
GO

-- Bảng UserSkill
CREATE TABLE [dbo].[UserSkill] (
    UserSkillID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    SkillID INT NOT NULL,
    ProficiencyLevel NVARCHAR(50) NOT NULL, -- Ví dụ: Beginner, Intermediate, Advanced
    FOREIGN KEY (UserID) REFERENCES [dbo].[User](UserID),
    FOREIGN KEY (SkillID) REFERENCES [dbo].[Skill](SkillID)
);
GO

-- Bảng Review
CREATE TABLE [dbo].[Review] (
    ReviewID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    JobID INT NOT NULL,
    Rating INT CHECK (Rating BETWEEN 1 AND 5),
    Comment NVARCHAR(MAX) NULL,
    ReviewDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (UserID) REFERENCES [dbo].[User](UserID),
    FOREIGN KEY (JobID) REFERENCES [dbo].[Job](JobID)
);
GO
