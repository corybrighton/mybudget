CREATE TABLE User (
  ID VARCHAR(255),
  Email VARCHAR(100),
  UserName VARCHAR(100),
  Hash VARCHAR(255),
  PRIMARY KEY(ID)
);

CREATE TABLE Asset (
  ID INT NOT NULL AUTO_INCREMENT,
  UserID VARCHAR(255),
  AssetName VARCHAR(25) NOT NULL,
  InitialValue DEC,
  CurrentValue DEC,
  InterestRate DEC,
  IncludeWorthStat BOOL,
  DeletedDate DATE
  PRIMARY KEY(ID),
  FOREIGN KEY(UserID) REFERENCES User(ID)
);

CREATE TABLE Bank (
  ID INT NOT NULL AUTO_INCREMENT,
  BankName VARCHAR(100),
  PRIMARY KEY(ID)
);

CREATE TABLE Account(
  ID INT NOT NULL AUTO_INCREMENT,
  PRIMARY KEY(ID),
  IsLoan BOOL,
  AccountType VARCHAR(50),
  BankID INT,
  UserID VARCHAR(255),
  FOREIGN KEY (UserID) REFERENCES User(ID),
  Balance DEC,
  Interest rate DEC,
  MonthlyPayment DEC,
  IsFlow BOOL,
  IncludeWorthStat BOOL,
  DeletedDate DATE
);

CREATE TABLE SnowBall (
  ID INT NOT NULL AUTO_INCREMENT,
  PRIMARY KEY(ID),
  UserID VARCHAR(255),
  FOREIGN KEY (UserID) REFERENCES User(ID),
  Planned DEC,
  MonthlyPay DEC,
  ExtraPay DEC
);

CREATE TABLE SnowBallAccount (
  ID INT NOT NULL AUTO_INCREMENT,
  PRIMARY KEY(ID),
  UserID VARCHAR(255),
  FOREIGN KEY (UserID) REFERENCES User(ID),
  AccountID INT,
  MonthlyMinPay DEC,
  IntailValue DEC,
  CreatedDate DATE
);

CREATE TABLE Payee(
  ID INT NOT NULL AUTO_INCREMENT,
  Payee VARCHAR(100)
);

CREATE TABLE Transcation(
  ID INT NOT NULL AUTO_INCREMENT,
  PRIMARY KEY(ID),
  UserID VARCHAR(255),
  FOREIGN KEY (UserID) REFERENCES User(ID),
  PayeeID INT,
  FOREIGN KEY(PayeeID) REFERENCES Payee(ID) 
  Amount DEC,
  EnvelopAllotmentID INT,
  AccountID INT,
  FOREIGN KEY(AccountID) REFERENCES Account(ID),
  ActionDate DATE,
  Cleared BOOL,
  DeletedDate DATE
);

CREATE TABLE AccountTransfer(
  ID INT NOT NULL AUTO_INCREMENT,
  PRIMARY KEY(ID),
  UserID VARCHAR(255),
  FOREIGN KEY (UserID) REFERENCES User(ID),
  AccountID INT,
  FOREIGN KEY(AccountID) REFERENCES Account(ID),
  ToAccountID INT,
  CHECK (ToAccountID <> AccountID),
  FOREIGN KEY(AccountID) REFERENCES Account(ID),
  Amount DEC,
  TransferDate DATE,
  Cleared BOOL,
  DeletedDate DATE
);

CREATE TABLE Budget (
  ID INT NOT NULL AUTO_INCREMENT,
  PRIMARY KEY(ID),
  BudgetName String 
);

CREATE TABLE Envelope (
  ID INT NOT NULL AUTO_INCREMENT,
  PRIMARY KEY(ID),
  EnvelopName String 
);

CREATE TABLE BudgetAllotment(
  ID INT NOT NULL AUTO_INCREMENT,
  PRIMARY KEY(ID),
  BudgetID Int,
  FOREIGN KEY(BudgetID) REFERENCES Budget(ID),
  UserID VARCHAR(255),
  FOREIGN KEY (UserID) REFERENCES User(ID),
  CreatedMonth INT,
  CreatedYear INT,
  Budgeted DEC,
  Spent DEC,
  Cleared DEC,
  Average DEC,
  DeletedDate DATE 
);

CREATE TABLE EnvelopeAllotment (
  ID INT NOT NULL AUTO_INCREMENT,
  PRIMARY KEY(ID), 
  BudgetID INT, 
  FOREIGN KEY(BudgetID) REFERENCES Budget(ID),
  EnvelopeID INT, 
  FOREIGN KEY(EnvelopeID) REFERENCES Envelope(ID),
  UserID VARCHAR(255),
  FOREIGN KEY (UserID) REFERENCES User(ID),
  CreatedMonth INT,
  CreatedYear INT,
  Budgeted DEC,
  Spent DEC,
  Cleared DEC,
  DeletedDate Date 
);
