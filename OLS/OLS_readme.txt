HƯỚNG DẪN CÀI ĐẶT OLS

Bước 1: Cài đặt OLS và enable user LBACSYS

Hướng dẫn: https://docs.oracle.com/database/121/OLSAG/getting_started.htm#OLSAG3097

Bước 2: Chạy file QLBV_LBACSYS (vs vai trò là LBACSYS)
Bước 3: Chạy file User_OLS (vs vai trò là DBA)
Bước 3: Connect vs user NVNS. Gọi bảng nhân viên ra
	+ Nếu thấy nhân viên tên Giám đốc => fail
	+ Nếu không thấy => success
