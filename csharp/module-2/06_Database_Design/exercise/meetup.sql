----let's write a creat script >:)

----switch to using the system database

--USE master;
--GO --batch separator, run the command and then move onto the next step

--DROP DATABASE IF EXISTS Meetups;

--CREATE DATABASE Meetups;
--GO

----in order to add tables and stuff to the Meetups DB, you gotta use the Meetups DB
--USE Meetups;
--GO

----now we start adding tables


--BEGIN TRANSACTION;

--CREATE TABLE member (

--member_id INT IDENTITY(1,1), --IDENTITY is a MS SQL Server auto-incrementing column
--last_name VARCHAR(50) NOT NULL,
--first_name VARCHAR(50) NOT NULL,
--email VARCHAR(50) NOT NULL,
--phone VARCHAR(14) NOT NULL,
--date_of_birth DATETIME NOT NULL,
--email_reminder BIT NOT NULL,

----Add the Primary key constraint 
----CONSTRAINT (constraint name) TYPE (column name)
--CONSTRAINT pk_member PRIMARY KEY (member_id)
--);


--CREATE TABLE interest_group(
--group_number INT IDENTITY(1,1),
--name VARCHAR(50), -- we will let the description be null

--CONSTRAINT pk_interest_group PRIMARY KEY (group_number),
--);

--CREATE TABLE event(
--event_number INT IDENTITY(1,1),
--event_name VARCHAR(50), -- we will let the description be null
--description VARCHAR(200),
--start_date_time DATETIME,
--duration INT,
--group_number INT NOT NULL

--CONSTRAINT pk_event PRIMARY KEY (event_number),
--CONSTRAINT fk_group_number FOREIGN KEY (group_number) REFERENCES interest_group(group_number),
--CONSTRAINT chk_event CHECK (duration >= 30)
--);


--CREATE TABLE member_group(
--member_id INT NOT NULL, --the id is coming from another table so no IDENTITY here
--group_number INT NOT NULL, 

--CONSTRAINT pk_member_group PRIMARY KEY (member_id, group_number), --composite key based on two columns
--CONSTRAINT fk_member_group_member FOREIGN KEY (member_id) REFERENCES member(member_id),
--CONSTRAINT fk_member_group_group FOREIGN KEY (group_number) REFERENCES interest_group(group_number)

--);

--CREATE TABLE member_event(
--member_id INT NOT NULL, --the id is coming from another table so no IDENTITY here
--event_number INT NOT NULL, 

--CONSTRAINT pk_member_event PRIMARY KEY (member_id, event_number), --composite key based on two columns
--CONSTRAINT fk_member_event_member FOREIGN KEY (member_id) REFERENCES member(member_id),
--CONSTRAINT fk_member_event_event FOREIGN KEY (event_number) REFERENCES event(event_number)

--);

--COMMIT;

--INSERT INTO interest_group (name)
--VALUES ('The First Group'), ('GreenHouse Party'), ('I Dunno Party')

--INSERT INTO event (event_name, description, start_date_time, duration, group_number)
--VALUES('Piano Tuners Meetup', 'This is an event for piano tuners!', GETDATE(), 45, 3)

--INSERT INTO member (last_name, first_name, email, phone, date_of_birth, email_reminder)
--VALUES('Brown', 'Eliot', 'ewb1@uakron.edu', '4407862759','2001-04-19',0), 
--('Sidle', 'Luke', 'lsidle@kent.edu', '3308769901','2004-06-20',0),
--('Raines', 'Sam', 'voodoohoneyjar@gmail.com', '3302985873','1998-09-12',0),
--('Martin', 'Jeremy', 'jmartin@kent.edu', '4403330099','2000-05-22',0),
--('Heinbuch', 'Hannah', 'stardreams@gmail.com', '2165580032','1999-06-15',0),
--('Rosales', 'Rebekah', 'goofykid@gmail.com', '6153329976','2001-11-08',0),
--('Elliott', 'Temilolu', 'pinkcristal@gmail.com', '4404309211','2001-02-16',0)

--INSERT INTO member_event (member_id,event_number)
--VALUES(1,2), (2,2), (3,1), (4,3), (5,4)

--SELECT last_name, first_name FROM member
--JOIN member_event ON member.member_id = member_event.member_id
--WHERE event_number = 2

--INSERT INTO member_group
--VALUES (7,2), (8,1)



SELECT * FROM member_group