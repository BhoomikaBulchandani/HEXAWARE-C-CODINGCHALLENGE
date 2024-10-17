-- Pets Table
CREATE TABLE Pets (
    PetID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100),
    Age INT,
    Breed VARCHAR(100),
    Type VARCHAR(50) -- Dog or Cat
);

-- Donations Table
CREATE TABLE Donations (
    DonationID INT PRIMARY KEY IDENTITY(1,1),
    DonorName VARCHAR(100),
    Amount DECIMAL(10, 2),
    DonationDate DATE,
	Type Varchar(20)
);

-- Adoption Events Table
CREATE TABLE AdoptionEvents (
    EventID INT PRIMARY KEY IDENTITY(1,1),
    EventName VARCHAR(100),
    EventDate DATE
);

-- Participants Table
CREATE TABLE Participants (
    ParticipantID INT PRIMARY KEY IDENTITY(1,1),
    EventID INT FOREIGN KEY REFERENCES AdoptionEvents(EventID),
    ParticipantName VARCHAR(100)
);


select * from AdoptionEvents