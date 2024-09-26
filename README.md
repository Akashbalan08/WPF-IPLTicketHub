# WPF Application (IPL TicketHub)

###### IPTicketHub is a WPF application for booking tickets to the Indian Premier League (IPL)

## Images

![L_IPLTH01](https://github.com/user-attachments/assets/bbd42ee0-8ead-4801-b710-9c8ad8a15823)

## Database 

__Database name - IPLTicketHub__

```
CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Phone NVARCHAR(20),
    Email NVARCHAR(100) UNIQUE,
    Password NVARCHAR(100),
    SecurityQuestion NVARCHAR(100)
);
```
```
CREATE TABLE Matches (
    Id INT PRIMARY KEY,
    T1 VARCHAR(100),
    T2 VARCHAR(100),
    Venue VARCHAR(100),
    Time DATETIME
);
```
```
INSERT INTO Matches (Id, T1, T2, Venue, Time)
VALUES
(1, 'CSK', 'RCB', 'Chennai', '2023-07-03 20:00:00'),
(2, 'DC', 'RR', 'Rajasthan', '2023-07-04 20:00:00'),
(3, 'KKR', 'PK', 'Punjab', '2023-07-05 20:00:00'),
(4, 'MI', 'SR', 'Mumbai', '2023-07-06 20:00:00'),
(5, 'LSG', 'GT', 'Lucknow', '2023-07-07 20:00:00');
```
