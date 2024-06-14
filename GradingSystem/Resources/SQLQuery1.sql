create database GradingSystem;
go 

use GradingSystem;
go 

-- identity: auto- increament --- tu dong tang 
create table Users (
	user_id int primary key identity,
	username nvarchar(50) not null,
	password nvarchar(50) not null,
	email nvarchar(50) not null,
	role nvarchar(10) not null,
	profile_picture nvarchar(MAX),
    constraint UQ_UserID unique (username)
);
go

create table Exams (
	exam_id int primary key identity,
	exam_name nvarchar(250) not null, 
	start_time datetime,
	end_time datetime,
	teacher_id int foreign key references Users(user_id),
	time_limit time
);
go 

create table Questions (
	question_id int primary key identity,
	exam_id int foreign key references Exams(exam_id),
	QuestionText nvarchar(850) not null,
	Option1 nvarchar(100) not null,
	Option2 nvarchar(100) not null,
	Option3 nvarchar(100) not null,
	Option4 nvarchar(100) not null,
	correct_answer nvarchar(100) not null,
	point float not null, 
    constraint UQ_QuestionText unique (QuestionText)
);
go 

create table StudentAnswers (
	ID int primary key identity,
	student_id int foreign key references Users(user_id),
	EID int foreign key references Exams(exam_id),
	QID int foreign key references Questions(question_id),
	SelectedOption nvarchar(100),
	MarkObtained float not null, 
);
go

-- insert 3 teachers
insert into Users (username, password, email, role) values
('JohnB', 'john123', 'johnBeaty@gmail.com', 'teacher'), 
('jane_smith', 'password456', 'jane.smith@example.com', 'teacher'),
('alice_johnson', 'password789', 'alice.johnson@example.com', 'teacher'),
-- insert 3 students
('michael_brown', 'password123', 'michael.brown@example.com', 'student'),
('emily_davis', 'password456', 'emily.davis@example.com', 'student'),
('sarah_wilson', 'password789', 'sarah.wilson@example.com', 'student');

-- insert exams -- datetime format: YYYY/MM/DD
insert into Exams (exam_name, start_time, end_time, teacher_id, time_limit) values 
('Quiz 1', '2024/05/21', '2024/05/23', 1, '00:30:00'),
('Quiz 1', '2024/05/21', '2024/05/23', 2, '03:15:00'),
('Quiz 1', '2024/05/21', '2024/05/25', 3, '03:45:00');

-- insert questions
insert into Questions (exam_id, QuestionText, Option1, Option2,Option3, Option4, correct_answer, point) values
(1, 'What is the derivative of x^2?', 'x', '2x', 'x^2', '2', '2x', 1.0),
(1, 'Solve the equation: 2x + 3 = 7.', 'x = 1', 'x = 2', 'x = 3', 'x = 4', 'x = 2', 1.0),
-- computer science
(2, 'What is the time complexity of binary search?', 'O(n)', 'O(log n)', 'O(n^2)', 'O(1)', 'O(log n)', 1.0),
(2, 'Explain the concept of object-oriented programming.', 'Encapsulation', 'Polymorphism', 'Inheritance', 'All of the above', 'All of the above', 1.0),
-- history
(3, 'Who was the first President of the United States?', 'George Washington', 'Thomas Jefferson', 'John Adams', 'James Madison', 'George Washington', 1.0),
(3, 'What year did World War II end?', '1943', '1944', '1945', '1946', '1945', 1.0);

insert into StudentAnswers (student_id, EID, QID, SelectedOption, MarkObtained) values
(4, 1, 1, '2x', 1.0),
(5, 2, 3, 'O(1)', 0.0),
(6, 3, 5, 'George Washington', 1.0);
select * from Questions

