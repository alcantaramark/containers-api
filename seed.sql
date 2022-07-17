\connect dbTest

CREATE TABLE employee
(
    id serial PRIMARY KEY,
    name  VARCHAR (50)  NOT NULL,
    title  VARCHAR (100)  NOT NULL
);

ALTER TABLE "employee" OWNER TO "test-postgres";

Insert into employee(name, title) values( 'Employee 1','Manager');
Insert into employee(name, title) values( 'Employee 2','Team Lead');
Insert into employee(name, title) values( 'Employee 3','Developer');