create database Functional_Foods
go
Use Functional_Foods
go

CREATE TABLE Items
(
  ItemsID varchar(30) NOT NULL,
  ItemsName varchar(30) NOT NULL,
  ItemsPrice float NOT NULL,
  ItemsQuantity INT NOT NULL,
  Benefit varchar(30),
  PRIMARY KEY (ItemsID)
);

CREATE TABLE Agency
(
  AgentID varchar(30) NOT NULL,
  AgentName varchar(30) NOT NULL,
  PRIMARY KEY (AgentID)
);

CREATE TABLE OrderReceipt
(
  OrderID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  TotalOrderPrice float NOT NULL,
  TotalOrderQuantity INT NOT NULL,
  OrderedDate date NOT NULL,
  Status varchar(30) NOT NULL,
  AgentID varchar(30) NOT NULL,
  FOREIGN KEY (AgentID) REFERENCES Agency(AgentID)
);

CREATE TABLE Manager
(
  Manager_ID varchar(30) NOT NULL,
  Name varchar(30) NOT NULL,
  PRIMARY KEY (Manager_ID)
);

CREATE TABLE OrderProducts
(
  TotalProductQuantity INT NOT NULL,
  TotalProductPrice float NOT NULL,
  OrderID INT NOT NULL,
  ItemsID varchar(30) NOT NULL,
  PRIMARY KEY (OrderID, ItemsID),
  FOREIGN KEY (OrderID) REFERENCES OrderReceipt(OrderID),
  FOREIGN KEY (ItemsID) REFERENCES Items(ItemsID)
);


CREATE TABLE Goods_Received_Note
(
  Invoice_ID int NOT NULL IDENTITY(1,1),
  TotalQuantityItems INT NOT NULL,
  Total_Imported_Price float NOT NULL,
  CreatedDate date NOT NULL,
  Manager_ID varchar(30) NOT NULL,
  PRIMARY KEY (Invoice_ID),
  FOREIGN KEY (Manager_ID) REFERENCES Manager(Manager_ID)
);

CREATE TABLE ImportedItems
(
  TotalItemsQuantity INT NOT NULL,
  TotalItemsPrice float NOT NULL,
  Invoice_ID int NOT NULL,
  ItemsID varchar(30) NOT NULL,
  PRIMARY KEY (Invoice_ID, ItemsID),
  FOREIGN KEY (Invoice_ID) REFERENCES Goods_Received_Note(Invoice_ID),
  FOREIGN KEY (ItemsID) REFERENCES Items(ItemsID)
);
--List of manager--
INSERT INTO Manager (Manager_ID, Name) VALUES ('M01','Nguyen Quoc An');

INSERT INTO Manager (Manager_ID, Name) VALUES ('M02','Nguyen Quoc Khang');

INSERT INTO Manager (Manager_ID, Name) VALUES ('M03','Nguyen Ai Nhi');

INSERT INTO Manager (Manager_ID, Name) VALUES ('M04','Tran Chau Cang');

INSERT INTO Manager (Manager_ID, Name) VALUES ('M05','Le Van Huong');

INSERT INTO Manager (Manager_ID, Name) VALUES ('M06','Duong Tuan Kiet');

INSERT INTO Manager (Manager_ID, Name) VALUES ('M07','Nguyen Thi Cam Tho');

INSERT INTO Manager (Manager_ID, Name) VALUES ('M08','Peter Parker');

INSERT INTO Manager (Manager_ID, Name) VALUES ('M09','Le Van Dat');

INSERT INTO Manager (Manager_ID, Name) VALUES ('M10','Truong Tuan Tu');

--List of products--
INSERT INTO Items VALUES ('I001', 'Mass', 500000, 300, 'Gain Weight');
INSERT INTO Items VALUES ('I002', 'Whey', 3500000, 200, 'Gain And Lose Weight');
INSERT INTO Items VALUES ('I003', 'DHC', 80000, 500, 'Provide Vitamin C');
INSERT INTO Items VALUES ('I004', 'Collagen', 300000, 500, 'Lose Weight');
INSERT INTO Items VALUES ('I005', 'Natrol Gummies', 350000, 100, 'Sleep Faster');
INSERT INTO Items VALUES ('I006', 'Vitamin B', 90000, 750, 'Provide Vitamin B');
INSERT INTO Items VALUES ('I007', 'Vitamin E', 100000, 800, 'Provide Vitamin E')

INSERT INTO Agency VALUES ('A001', 'Big Boss');
INSERT INTO Agency VALUES ('A002', 'Second Boss');
INSERT INTO Agency VALUES ('A003', 'Third Boss');
INSERT INTO Agency VALUES ('A004', 'Fourth Boss');
INSERT INTO Agency VALUES ('A005', 'Fifth Boss');
INSERT INTO Agency VALUES ('A006', 'Sixth Boss'); 
INSERT INTO Agency VALUES ('A007', 'Seventh Boss');


DBCC CHECKIDENT (Goods_Received_Note, RESEED, 0)

CREATE PROC procItems
(
	@itemsID VARCHAR(30),
	@itemsName VARCHAR(30),
	@itemsPrice float,
	@itemsQuantity INT,
	@benefit VARCHAR(30)
)
AS
BEGIN
	IF NOT EXISTS(SELECT * FROM Items WHERE ItemsID = @itemsID)
		BEGIN
			INSERT INTO Items
			VALUES
			(@itemsID, @itemsName, @itemsPrice, @itemsQuantity,@benefit)
		END
	ELSE
		BEGIN
			UPDATE Items
			SET ItemsQuantity = ItemsQuantity + @itemsQuantity
			WHERE ItemsID = @itemsID
		END
END;

go
create TRIGGER QuantityUpdate ON OrderProducts after INSERT
as
	declare @quantity int
	declare @Product_code varchar(20)
	select @quantity = TotalProductQuantity,@Product_code = ItemsID from inserted
	UPDATE Items
	SET Items.ItemsQuantity = Items.ItemsQuantity - @quantity
	WHERE Items.ItemsID = @Product_code
go