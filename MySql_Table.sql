SHOW CREATE TABLE Department;

DROP TABLE IF EXISTS Department;

CREATE TABLE Department (
    Id INT NOT NULL AUTO_INCREMENT,
    Name VARCHAR(255) NOT NULL,
    PRIMARY KEY (Id)
);

INSERT INTO Department (Name) VALUES ('Dummy Department');