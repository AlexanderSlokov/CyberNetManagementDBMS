CREATE TRIGGER tr_thongbao ON user_using_computer
AFTER INSERT, UPDATE
AS
PRINT('Đã thêm computer mới')

/*
Tao mot trigger khi computer duoc update hoac insert se in ra
thong bao 'Da them computer moi'
*/