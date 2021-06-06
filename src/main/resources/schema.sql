#
# CREATE TABLE Branch (
#     ID SERIAL NOT NULL,
#     Location varchar(32) NOT NULL,
#     Name varchar(32) NOT NULL,
#     Mobile LONG NOT NULL,
#
#     PRIMARY KEY (ID, Location)
# );
#
# CREATE TABLE Employee (
#     ID SERIAL NOT NULL,
#     Name varchar(32) NOT NULL,
#     Branch_ID BIGINT UNSIGNED,
#     Branch_Location varchar(32) NOT NULL,
#     Mobile_Phone LONG NOT NULL,
#     Role varchar(32) NOT NULL,
#
#     PRIMARY KEY (ID),
#     FOREIGN KEY (Branch_ID,Branch_Location) REFERENCES Branch(ID,Location)
# );
#
# CREATE TABLE Deliverer (
#     ID BIGINT UNSIGNED,
#     Vehicle_Type varchar(32) NOT NULL,
#
#     UNIQUE KEY (ID),
#     FOREIGN KEY (ID) REFERENCES Employee(ID)
# );
#
# CREATE TABLE BranchEmployee (
#     ID BIGINT UNSIGNED,
#
#     UNIQUE KEY (ID),
#     FOREIGN KEY (ID) REFERENCES Employee(ID)
# );
#
# CREATE TABLE Customer (
#     ID SERIAL NOT NULL,
#     Name varchar(32) NOT NULL,
#     Mobile_Phone LONG NOT NULL,
#     Address varchar(32) NOT NULL,
#     Email varchar(32) NOT NULL,
#     Type varchar(32) NOT NULL ,
#
#     PRIMARY KEY (ID)
# );
#
# CREATE TABLE Sender (
#     ID BIGINT UNSIGNED,
#
#     UNIQUE KEY (ID),
#     FOREIGN KEY (ID) REFERENCES Customer(ID)
# );
#
# CREATE TABLE Receiver(
#     ID BIGINT UNSIGNED ,
#
#     UNIQUE KEY (ID),
#     FOREIGN KEY (ID)  REFERENCES Customer(ID)
# );
#
# CREATE TABLE Bill (
#     ID SERIAL NOT NULL,
#     Sender_ID BIGINT UNSIGNED,
#     Payment_Type varchar(32) NOT NULL,
#     Cost FLOAT NOT NULL,
#
#
#     PRIMARY KEY (ID),
#     FOREIGN KEY (Sender_ID) REFERENCES Sender(ID)
# );
#
# CREATE TABLE Cargo (
#     ID SERIAL NOT NULL,
#     Sender_ID BIGINT UNSIGNED,
#     Receiver_ID BIGINT UNSIGNED,
#     Deliverer_ID BIGINT UNSIGNED,
#     Br_Employee_ID BIGINT UNSIGNED,
#     Status varchar(32) NOT NULL,
#     Type varchar(32) NOT NULL,
#     Description varchar(255) NOT NULL,
#     Senders_Delivery_Date date NOT NULL,
#     Delivery_Date date NOT NULL,
#     Bill_ID BIGINT UNSIGNED,
#     Receiver_Address varchar(255),
#     Weight DOUBLE,
#
#     PRIMARY KEY (ID),
#     FOREIGN KEY (Br_Employee_ID) REFERENCES BranchEmployee(ID),
#     FOREIGN KEY (Deliverer_ID) REFERENCES Deliverer(ID),
#     FOREIGN KEY (Bill_ID) REFERENCES Bill(ID),
#     FOREIGN KEY (Sender_ID) REFERENCES Sender(ID),
#     FOREIGN KEY (Receiver_ID) REFERENCES Receiver(ID)
# );
#
#
# CREATE TABLE At (
#     Branch_ID BIGINT UNSIGNED,
#     Branch_Location varchar(32) NOT NULL,
#     Cargo_ID BIGINT UNSIGNED,
#     Received DATE NOT NULL,
#
#     FOREIGN KEY (Branch_ID, Branch_Location) REFERENCES Branch(ID, Location),
#     FOREIGN KEY (Cargo_ID) REFERENCES Cargo(ID)
# );