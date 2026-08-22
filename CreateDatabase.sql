-- ============================================================================
-- 1. DATABASE CREATION
-- ============================================================================
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'TrailGuardDB')
BEGIN
    CREATE DATABASE TrailGuardDB;
END
GO

USE TrailGuardDB;
GO

-- ============================================================================
-- 2. TABLE CREATION & CONSTRAINTS
-- ============================================================================

-- Table 1: EmergencyContact
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'EmergencyContact')
BEGIN
    CREATE TABLE EmergencyContact (
        EmergencyContactID INT IDENTITY(1,1) PRIMARY KEY,
        FirstName VARCHAR(100) NOT NULL,
        PhoneNumber VARCHAR(20) NOT NULL,
        RelationshipToParticipant VARCHAR(50) NOT NULL
    );
END

-- Table 2: Park
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Park')
BEGIN
    CREATE TABLE Park (
        ParkID INT IDENTITY(1,1) PRIMARY KEY,
        ParkName VARCHAR(100) NOT NULL,
        Province VARCHAR(100) NOT NULL,
        OfficeNumber VARCHAR(20) NULL
    );
END

-- Table 3: Participant
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Participant')
BEGIN
    CREATE TABLE Participant (
        ParticipantID INT IDENTITY(1,1) PRIMARY KEY,
        FirstName VARCHAR(100) NOT NULL,
        LastName VARCHAR(100) NOT NULL,
        IDNumber VARCHAR(20) NOT NULL,
        PhoneNumber VARCHAR(20) NOT NULL,
        EmailAddress VARCHAR(150) NULL,
        HomeAddress VARCHAR(255) NULL,
        MedicalNotes VARCHAR(MAX) NULL,
        EmergencyContactID INT NULL,
        CONSTRAINT FK_Participant_EmergencyContact 
            FOREIGN KEY (EmergencyContactID) REFERENCES EmergencyContact(EmergencyContactID)
            ON DELETE SET NULL ON UPDATE CASCADE
    );
END

-- Table 4: Trail
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Trail')
BEGIN
    CREATE TABLE Trail (
        TrailID INT IDENTITY(1,1) PRIMARY KEY,
        ParkID INT NOT NULL,
        TrailName VARCHAR(100) NOT NULL,
        DifficultyLevel INT NOT NULL,
        MaximumHikers INT NOT NULL,
        Status VARCHAR(10) NOT NULL,
        CONSTRAINT FK_Trail_Park 
            FOREIGN KEY (ParkID) REFERENCES Park(ParkID)
            ON DELETE CASCADE ON UPDATE CASCADE,
        CONSTRAINT CK_Trail_DifficultyLevel 
            CHECK (DifficultyLevel >= 1 AND DifficultyLevel <= 5),
        CONSTRAINT CK_Trail_Status 
            CHECK (Status IN ('Open', 'Closed'))
    );
END

-- Table 5: Permit
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Permit')
BEGIN
    CREATE TABLE Permit (
        PermitID INT IDENTITY(1,1) PRIMARY KEY,
        TrailID INT NOT NULL,
        CheckInTime TIME NULL,
        ExpectedReturnTime TIME NULL,
        Date DATE NOT NULL,
        Status VARCHAR(50) NOT NULL,
        CONSTRAINT FK_Permit_Trail 
            FOREIGN KEY (TrailID) REFERENCES Trail(TrailID)
            ON DELETE CASCADE ON UPDATE CASCADE
    );
END

-- Table 6: IncidentReport
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'IncidentReport')
BEGIN
    CREATE TABLE IncidentReport (
        IncidentReportID INT IDENTITY(1,1) PRIMARY KEY,
        PermitID INT NOT NULL,
        Description VARCHAR(MAX) NOT NULL,
        DateReported DATETIME NOT NULL DEFAULT GETDATE(),
        ActionTaken VARCHAR(MAX) NULL,
        Status VARCHAR(50) NOT NULL,
        CONSTRAINT FK_IncidentReport_Permit 
            FOREIGN KEY (PermitID) REFERENCES Permit(PermitID)
            ON DELETE CASCADE ON UPDATE CASCADE
    );
END

-- Table 7: Permit_Participant (Junction Table)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Permit_Participant')
BEGIN
    CREATE TABLE Permit_Participant (
        PermitID INT NOT NULL,
        ParticipantID INT NOT NULL,
        PRIMARY KEY (PermitID, ParticipantID),
        CONSTRAINT FK_PermitParticipant_Permit 
            FOREIGN KEY (PermitID) REFERENCES Permit(PermitID)
            ON DELETE CASCADE ON UPDATE CASCADE,
        CONSTRAINT FK_PermitParticipant_Participant 
            FOREIGN KEY (ParticipantID) REFERENCES Participant(ParticipantID)
            ON DELETE CASCADE ON UPDATE CASCADE
    );
END
GO




-- ============================================================================
-- 3. MOCK DATA SEEDING
-- ============================================================================

-- 1. EmergencyContact
IF NOT EXISTS (SELECT 1 FROM EmergencyContact)
BEGIN
    INSERT INTO EmergencyContact (FirstName, PhoneNumber, RelationshipToParticipant)
    VALUES 
    ('Sipho', '0824567890', 'Spouse'),
    ('Annika', '0731234567', 'Parent'),
    ('Johan', '0849876543', 'Sibling'),
    ('Thabo', '0715551234', 'Friend');
END

-- 2. Park
IF NOT EXISTS (SELECT 1 FROM Park)
BEGIN
    INSERT INTO Park (ParkName, Province, OfficeNumber)
    VALUES 
    ('Kruger National Park', 'Mpumalanga', '0137354000'),
    ('Table Mountain National Park', 'Western Cape', '0217127471'),
    ('Golden Gate Highlands National Park', 'Free State', '0512550000');
END

-- 3. Participant
IF NOT EXISTS (SELECT 1 FROM Participant)
BEGIN
    INSERT INTO Participant (FirstName, LastName, IDNumber, PhoneNumber, EmailAddress, HomeAddress, MedicalNotes, EmergencyContactID)
    VALUES 
    ('Pieter', 'van der Merwe', '8803155092084', '0832109876', 'pieter.vdm@gmail.com', '12 Mimosa Way, Bloemfontein', 'Asthma - carries inhaler', 1),
    ('Nomvula', 'Dlamini', '9507220145089', '0723456789', 'nomvula.d@yahoo.com', '45 Protea Street, Nelspruit', 'No known allergies', 2),
    ('Kobus', 'Coetzee', '9111055231086', '0814567890', 'kobus.c@outlook.com', '88 Church St, Polokwane', 'Bee sting allergy (EpiPen in bag)', 3),
    ('Zanele', 'Khumalo', '0004120891083', '0601234567', 'zanele.k@gmail.com', '101 Waterfront Rd, Cape Town', NULL, 4);
END

-- 4. Trail
IF NOT EXISTS (SELECT 1 FROM Trail)
BEGIN
    INSERT INTO Trail (ParkID, TrailName, DifficultyLevel, MaximumHikers, Status)
    VALUES 
    (1, 'Mpuluzi Bush Trail', 3, 12, 'Open'),
    (2, 'Platteklip Gorge', 4, 20, 'Open'),
    (2, 'Lion''s Head Loop', 3, 15, 'Closed'),
    (3, 'Ribbok Trail', 5, 8, 'Open');
END

-- 5. Permit
IF NOT EXISTS (SELECT 1 FROM Permit)
BEGIN
    INSERT INTO Permit (TrailID, CheckInTime, ExpectedReturnTime, Date, Status)
    VALUES 
    (1, '06:30:00', '14:00:00', '2026-08-10', 'Active'),
    (2, '07:00:00', '12:30:00', '2026-08-11', 'Completed'),
    (4, '05:45:00', '17:00:00', '2026-08-12', 'Registered');
END

-- 6. IncidentReport
IF NOT EXISTS (SELECT 1 FROM IncidentReport)
BEGIN
    INSERT INTO IncidentReport (PermitID, Description, DateReported, ActionTaken, Status)
    VALUES 
    (2, 'Hiker sustained a mild ankle sprain near the summit.', '2026-08-11 11:15:00', 'Assisted down by ranger team. First aid applied on-site.', 'Closed'),
    (3, 'Group delayed due to unexpected heavy fog and poor visibility.', '2026-08-12 16:30:00', 'Ranger dispatched to escort trail group back safely.', 'In Progress');
END

-- 7. Permit_Participant
IF NOT EXISTS (SELECT 1 FROM Permit_Participant)
BEGIN
    INSERT INTO Permit_Participant (PermitID, ParticipantID)
    VALUES 
    (1, 1),
    (1, 2),
    (2, 3),
    (3, 1),
    (3, 4);
END
GO

-- ============================================================================
-- Stored Procedures
-- ============================================================================

-- Stored procedure to create a new participant using SQL INSERT

-- Create a Table Type to hold the list of Participant IDs
CREATE TYPE IntListType AS TABLE (
    ID INT
);
GO

-- Create the Stored Procedure
CREATE PROCEDURE sp_CreatePermitWithParticipants
    @TrailID INT,
    @ExpectedReturnTime TIME,  
    @Date DATE,
    @Status VARCHAR(50),
    @ParticipantIDs IntListType READONLY
AS
BEGIN
    SET NOCOUNT ON;

    -- Wrap operations in a transaction inside SQL
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Insert into Permit parent table
        INSERT INTO Permit (TrailID, ExpectedReturnTime, [Date], [Status])
        VALUES (@TrailID, @ExpectedReturnTime, @Date, @Status);

        -- Capture the newly generated Primary Key
        DECLARE @NewPermitID INT = SCOPE_IDENTITY();

        -- Bulk-insert all linked participants from the table parameter
        INSERT INTO Permit_Participant (PermitID, ParticipantID)
        SELECT @NewPermitID, ID
        FROM @ParticipantIDs;

        -- Commit if all operations succeed
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback on error
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        -- Re-throw exception back to C#
        THROW;
    END CATCH
END;
GO

--Stored procedure to Update a Permit and it Participants via Permit_Participant

CREATE PROCEDURE sp_UpdatePermitWithParticipants
    @PermitID INT,
    @TrailID INT,
    @ExpectedReturnTime TIME,
    @Date DATE,
    @ParticipantIDs IntListType READONLY
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;

    BEGIN TRY
        -- Update the parent Permit details
        UPDATE Permit 
        SET TrailID = @TrailID, 
            ExpectedReturnTime = @ExpectedReturnTime, 
            [Date] = @Date 
        WHERE PermitID = @PermitID;

        -- Remove existing participant linkages for this permit
        DELETE FROM Permit_Participant 
        WHERE PermitID = @PermitID;

        --Re-insert the updated participant list from the Table-Valued Parameter
        INSERT INTO Permit_Participant (PermitID, ParticipantID)
        SELECT @PermitID, ID
        FROM @ParticipantIDs;

        -- Commit all changes if everything succeeds
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback on failure
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        -- Pass exception details back to C#
        THROW;
    END CATCH
END;
GO