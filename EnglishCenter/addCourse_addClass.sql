INSERT INTO COURSE(course_ID,course_name)
VALUES
	('TOE',N'Khóa học Toeic'),
	('SPK',N'Khóa học tiếng anh giao tiếp');
EXEC insertClass N'Lớp học Toeic Foundation',24,2000000,'TOE'
EXEC insertClass N'Lớp Toeic Intensive',22,3500000,'TOE'
EXEC insertClass N'Lớp Toeic luyện đề',20,1500000,'TOE'
EXEC insertClass N'Lớp Toeic Hoàn Hảo',20,6500000,'TOE'
EXEC insertClass N'Lớp phản xạ giao tiếp cơ bản',16,2500000,'SPK'
EXEC insertClass N'Lớp phản xạ giao tiếp toàn diện',20,5000000,'SPK'