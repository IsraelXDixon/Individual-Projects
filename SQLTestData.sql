--Israel Dixon
--SQlTestQA

--Creating Q/A Table
create table onlineexam
(
	QID int not null identity(1,1) primary key,
	Question nvarchar(150),
	Option1 nvarchar(150),
	Option2 nvarchar(150),
	Option3 nvarchar(150),
	Option4 nvarchar(150),
	Correctans nvarchar(150)
);

--Data Test
select * from onlineexam