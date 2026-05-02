-- Seed 3 Roles
INSERT INTO Roles (RoleName) VALUES ('Admin'), ('Analyst'), ('Reporter');

-- Seed 3 Statuses
INSERT INTO CaseStatusWorkflow (StatusName, Description) 
VALUES 
('New', 'Initial report received'), 
('In Progress', 'Investigation underway'), 
('Resolved', 'Threat neutralized');


INSERT INTO Users (FullName, Email, PasswordHash, RoleID, Department, status) VALUES 
('Cairoz Santos', 'cairoz@lpu.edu.ph', 'hashed_pass_1', 1, 'IT', 'active'), -- Admin
('Juan Dela Cruz', 'juan@lpu.edu.ph', 'hashed_pass_2', 2, 'IT', 'active'),  -- Analyst
('Maria Clara', 'maria@lpu.edu.ph', 'hashed_pass_3', 3, 'HR', 'active'),   -- Reporter
('Jose Rizal', 'jose@lpu.edu.ph', 'hashed_pass_4', 2, 'IT', 'active'),    -- Analyst
('Gabriela Silang', 'gabriela@lpu.edu.ph', 'hashed_pass_5', 3, 'Accounting', 'active'); -- Reporter


INSERT INTO IncidentReports (Title, Description, Severity, ReporterID, AssignedAdminID, StatusID, DiscoveryDate) VALUES 
('Phishing Attempt', 'Suspicious email in HR', 'High', 3, 1, 1, '2026-05-01'),
('Unauthorized Login', 'Failed attempts on Server A', 'Critical', 5, 4, 2, '2026-05-01'),
('Malware Detected', 'Trojan found on Lab PC 10', 'Medium', 3, 1, 3, '2026-05-02'),
('Slow Network', 'Possible DDoS on Gateway', 'Critical', 5, 4, 1, '2026-05-02'),
('Physical Breach', 'Server room door left open', 'Low', 3, 1, 2, '2026-05-02');

-- Evidence connected to Case 1 and Case 2
INSERT INTO EvidenceMetadata (CaseID, FileName, FilePath, FileHash) VALUES 
(1, 'email_header.txt', 'C:\CyberTrack\Storage\1\header.txt', 'hash_sha256_001'),
(2, 'server_logs.csv', 'C:\CyberTrack\Storage\2\logs.csv', 'hash_sha256_002'),
(2, 'ip_list.xlsx', 'C:\CyberTrack\Storage\2\ips.xlsx', 'hash_sha256_003'),
(3, 'virus_scan.pdf', 'C:\CyberTrack\Storage\3\scan.pdf', 'hash_sha256_004'),
(4, 'traffic_capture.pcap', 'C:\CyberTrack\Storage\4\cap.pcap', 'hash_sha256_005');

-- Audit Logs for Case 1 and 2
INSERT INTO AuditLogs (CaseID, ChangedByUserID, ActionType, OldValue, NewValue) VALUES 
(1, 1, 'Assignment', 'None', 'Assigned to Admin Cairoz'),
(2, 4, 'Status Update', 'New', 'In Progress'),
(3, 1, 'Status Update', 'In Progress', 'Resolved'),
(2, 4, 'Note Added', '', 'Investigating IP range from Russia'),
(5, 1, 'Severity Change', 'Low', 'Medium');

