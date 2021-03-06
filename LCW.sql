USE LCW;

CREATE TABLE COMPUTER(
ID_COMPUTER int NOT NULL PRIMARY KEY,
NAME_COMPUTER nvarchar(50),
TYPE_COMPUTER nvarchar(50),
);

CREATE TABLE SALE(
SALE_ID int NOT NULL PRIMARY KEY,
ID_COMPUTER int REFERENCES COMPUTER(ID_COMPUTER) NOT NULL,
REQUEST_ID int NOT NULL
);

CREATE TABLE TESTING(
ID_TESTING int NOT NULL PRIMARY KEY,
ID_COMPUTER int REFERENCES COMPUTER(ID_COMPUTER) NOT NULL,
ID_TESTER int NOT NULL,
TESTING_DATE date NOT NULL,
TESTING_RESULT nvarchar(14) NOT NULL
);

CREATE TABLE CLIENT(
ID_CLIENT int NOT NULL PRIMARY KEY,
CLIENT_ADDRESS nvarchar(50) NOT NULL,
CLIENT_SECOND_NAME nvarchar(50) NOT NULL,
CLIENT_PHONE_NUMBER nvarchar(20) NOT NULL
);

CREATE TABLE REQUEST(
REQUEST_ID int NOT NULL PRIMARY KEY,
ID_COMPUTER int REFERENCES COMPUTER(ID_COMPUTER) NOT NULL,
ID_CLIENT int REFERENCES CLIENT(ID_CLIENT) NOT NULL,
REQUEST_DATE date NOT NULL,
REQUEST_AMMOUNT int NULL,
EXECUTION_DATE date NOT NULL
);

CREATE TABLE TYPE_EMPLOYEE(
ID_POST_EMPLOYEE int PRIMARY KEY NOT NULL,
POST_EMPLOYEE nvarchar(20),
SALARY int	NOT NULL
);

CREATE TABLE EMPLOYEE(
ID_EMPLOYEE int NOT NULL PRIMARY KEY,
ID_POST_EMPLOYEE int NOT NULL REFERENCES TYPE_EMPLOYEE(ID_POST_EMPLOYEE),
NAME_EMPLOYEE nvarchar(14),
SECOND_NAME_EMPLOYEE nvarchar(14),
PATRONYMIC nvarchar(14) NOT NULL,
DATE_OF_BIRTH	date NOT NULL,
ADDRESS_EMPLOYEE nvarchar(14) NOT NULL,
PASSPORT nvarchar(14) NOT NULL,
);

CREATE TABLE ASSEMBLING(
ID_ASSEMBLING int NOT NULL PRIMARY KEY,
ID_GATHERER int NOT NULL,
ID_COMPUTER   int NOT NULL REFERENCES COMPUTER(ID_COMPUTER)
);

CREATE TABLE COMPONENT(
ID_COMPONENT int NOT NULL PRIMARY KEY,
MODEL nvarchar(14) NOT NULL,
COMPANY nvarchar(14) NOT NULL
);

CREATE TABLE COMP_COMPONENT(
ID_COMP_COMPONENT int NOT NULL PRIMARY KEY,
ID_COMPUTER int REFERENCES COMPUTER(ID_COMPUTER) NOT NULL,
ID_COMPONENT int REFERENCES COMPONENT(ID_COMPONENT) NOT NULL
);

CREATE TABLE CHARACTERISTIC(
ID_CHARACTERISTIC int NOT NULL PRIMARY KEY,
CHARA_NAME nvarchar(14) NOT NULL,
SOKET nvarchar(14) NOT NULL,
TYPE_RAM nvarchar(14) NOT NULL,
MEMORY nvarchar(14) NOT NULL,
BUS_BIT_WIDTH nvarchar(14) NOT NULL,
FREQUENCY nvarchar(14) NOT NULL,
MEMORY_BANDWIDTH nvarchar(14) NOT NULL,
TDP nvarchar(14) NOT NULL,
CORES nvarchar(14) NOT NULL,
REV_MIN nvarchar(14) NOT NULL,
SENSOR nvarchar(14) NOT NULL,
MAX_DPI nvarchar(14) NOT NULL,
SWITCH nvarchar(14) NOT NULL,
);

CREATE TABLE CHARACTERISTIC_COMP(
ID_CHAR int NOT NULL PRIMARY KEY,
ID_COMPONENT int REFERENCES COMPONENT(ID_COMPONENT)  NOT NULL,
ID_CHARACTERISTIC int NOT NULL,
CC_VALUE nvarchar(14) NOT NULL,
);