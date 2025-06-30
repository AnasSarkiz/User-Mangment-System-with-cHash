create database usersData;
use usersData;

CREATE TABLE Users (
    id INT PRIMARY KEY IDENTITY(1,1),
    username NVARCHAR(50),
    password_hash NVARCHAR(100),
    role NVARCHAR(20),
    failed_attempts INT DEFAULT 0,
    last_attempt DATETIME DEFAULT GETDATE()
);
ALTER TABLE Users
ADD IsLocked BIT NOT NULL DEFAULT 0;

EXEC sp_rename 'Users.is_Looked', 'is_locked', 'COLUMN';