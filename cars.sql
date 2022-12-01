create table Cars (
    Rego VARCHAR(7) primary key,
    Make VARCHAR(50),
    Model VARCHAR(50)
)

Insert into Cars (Rego, Make, Model) values ('ABC-123', 'Toyota', 'Hilux');
Insert into Cars (Rego, Make, Model) values ('QWF-321', 'Ford', 'Falcon');
Insert into Cars (Rego, Make, Model) values ('VBK-665', 'Holden', 'Commodore');
Insert into Cars (Rego, Make, Model) values ('JLU-987', 'Subaru', 'WRX');

select * from cars;