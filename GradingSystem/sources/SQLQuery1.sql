create database GradingSystem;
go 

use GradingSystem;
go 

-- identity: auto- increament --- tu dong tang 
create table Users (
	UID int primary key identity,
	username nvarchar(50) not null,
	password nvarchar(50) not null,
	email nvarchar(50) not null,
	role nvarchar(10) not null,
	profile_picture nvarchar(MAX)
);
go

create table Exams (
	EID int primary key identity,
	exam_name nvarchar(250) not null, 
	start_time datetime,
	end_time datetime,
	TID int foreign key references Users(UID),
	time_limit int not null,
	attempt int not null,
	status nvarchar(100) not null
);
go 

create table Questions (
	QID int primary key identity,
	EID int foreign key references Exams(EID),
	QuestionText nvarchar(max) not null,
	Option1 nvarchar(100) not null,
	Option2 nvarchar(100) not null,
	Option3 nvarchar(100) not null,
	Option4 nvarchar(100) not null,
	correct_answer nvarchar(100) not null,
	point float not null, 
);
go 

create table StudentAnswers (
	ID int primary key identity,
	student_id int foreign key references Users(UID),
	EID int foreign key references Exams(EID),
	QID int foreign key references Questions(QID),
	Selected nvarchar(100),
	MarkObtained float not null,
	Submission datetime
);
go

create table Report (
	ID int primary key identity, 
	student_id int foreign key references Users(UID),
	EID int foreign key references Exams(EID),
	Total_score float not null,
	Submission datetime not null,
	Feedback nvarchar(MAX)
);
go

-- insert 3 teachers
insert into Users (username, password, email, role, profile_picture) values
('JohnB', 'john123', 'johnBeaty@gmail.com', 'teacher', null), 
('jane_smith', 'password456', 'jane.smith@example.com', 'teacher', NULL),
('alice_johnson', 'password789', 'alice.johnson@example.com', 'teacher', NULL),
-- insert 3 students
('michael_brown', 'password123', 'michael.brown@example.com', 'student', NULL),
('emily_davis', 'password456', 'emily.davis@example.com', 'student', NULL),
('sarah_wilson', 'password789', 'sarah.wilson@example.com', 'student', NULL);
go 

-- insert questions
insert into Questions (EID, QuestionText, Option1, Option2,Option3, Option4, correct_answer, point) values
(1, 'What is the derivative of x^2?', 'x', '2x', 'x^2', '2', '2x', 1.0),
(1, 'Solve the equation: 2x + 3 = 7.', 'x = 1', 'x = 2', 'x = 3', 'x = 4', 'x = 2', 1.0),
-- computer science
(2, 'What is the time complexity of binary search?', 'O(n)', 'O(log n)', 'O(n^2)', 'O(1)', 'O(log n)', 1.0),
(2, 'Explain the concept of object-oriented programming.', 'Encapsulation', 'Polymorphism', 'Inheritance', 'All of the above', 'All of the above', 1.0),
-- history
(3, 'Who was the first President of the United States?', 'George Washington', 'Thomas Jefferson', 'John Adams', 'James Madison', 'George Washington', 1.0),
(3, 'What year did World War II end?', '1943', '1944', '1945', '1946', '1945', 1.0);
go

insert into Exams values
('Quiz 1', GETDATE(), DATEDIFF(day, getdate(), 3), 1, 30, 1, 'Upcoming'),
('Quiz 2', GETDATE(), DATEDIFF(day, getdate(), 3), 2, 15, 1, 'Active'),
('Quiz 3', GETDATE(), DATEDIFF(day, getdate(), 3), 3, 60, 2, 'Active');
go

select * from Exams