    -- ACCESS CONTROL TABLES
    CREATE TABLE Roles (
        RoleID INT PRIMARY KEY IDENTITY(1,1),
        RoleName VARCHAR(50) NOT NULL UNIQUE -- 'Admin', 'Analyst', 'Reporter'
    );

    CREATE TABLE Users (
        UserID INT PRIMARY KEY IDENTITY(1,1),
        FullName VARCHAR(100) NOT NULL,
        Email VARCHAR(100) UNIQUE NOT NULL,
        PasswordHash VARCHAR(255) NOT NULL,
        RoleID INT,
        Department VARCHAR(100),
        status VARCHAR(50) DEFAULT 'active', -- 'Active', 'Inactive'
        CreatedAt DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
    );

    -- WORKFLOW & SYSTEM REFERENCE
    CREATE TABLE CaseStatusWorkflow (
        StatusID INT PRIMARY KEY IDENTITY(1,1),
        StatusName VARCHAR(50) NOT NULL UNIQUE, -- 'New', 'In Progress', 'Resolved'
        Description NVARCHAR(MAX)
    );

    -- CORE INCIDENT MANAGEMENT
    CREATE TABLE IncidentReports (
        CaseID INT PRIMARY KEY IDENTITY(1,1),
        Title VARCHAR(255) NOT NULL,
        Description NVARCHAR(MAX) NOT NULL,
        Severity VARCHAR(50) NOT NULL DEFAULT 'Low', -- 'Low', 'Medium', 'High', 'Critical'
        ReporterID INT,
        AssignedAdminID INT NULL,
        StatusID INT DEFAULT 1,
        DiscoveryDate DATETIME NOT NULL,
        SubmittedAt DATETIME DEFAULT GETDATE(),
        LastUpdated DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (ReporterID) REFERENCES Users(UserID),
        FOREIGN KEY (AssignedAdminID) REFERENCES Users(UserID),
        FOREIGN KEY (StatusID) REFERENCES CaseStatusWorkflow(StatusID)
    );

    -- EVIDENCE & ASSET TRACKING
    CREATE TABLE EvidenceMetadata (
        EvidenceID INT PRIMARY KEY IDENTITY(1,1),
        CaseID INT,
        FileName VARCHAR(255) NOT NULL,
        FilePath VARCHAR(500) NOT NULL,
        FileHash VARCHAR(64) NOT NULL, -- SHA-256 for integrity check
        UploadedAt DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (CaseID) REFERENCES IncidentReports(CaseID) ON DELETE CASCADE
    );

    -- AUDIT & LOGGING
    CREATE TABLE AuditLogs (
        LogID INT PRIMARY KEY IDENTITY(1,1),
        CaseID INT,
        ChangedByUserID INT,
        ActionType VARCHAR(50), -- 'Status Update', 'Assigned User'
        OldValue NVARCHAR(MAX),
        NewValue NVARCHAR(MAX),
        Timestamp DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (CaseID) REFERENCES IncidentReports(CaseID),
        FOREIGN KEY (ChangedByUserID) REFERENCES Users(UserID)
    );
