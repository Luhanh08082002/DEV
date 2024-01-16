CREATE PROC proc_logic
@user nvarchar(50),
@pass nvarchar(50)
as 
BEGIN 
SELECT * FROM tbl_users WHERE TaiKhoan = @user AND MatKhau = @pass
END