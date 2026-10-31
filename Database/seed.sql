PRAGMA foreign_keys = ON;
       
       INSERT INTO CauHinh(K, V) VALUES 
                   ('TenPhongKham', 'PHÒNG KHÁM ĐA KHOA AN TÂM'),                  
                    ('DiaChi', '123 Nguyễn Oanh, Quân 3, TP.HCM'),
                    ('DienThoai', '02837492944'),
                   ('TienKham',     '150000'),
                   ('HanMucChi',    '2000000');

INSERT INTO NguoiDung (TenDangNhap, MatKhau, HoTen, VaiTro) VALUES
 ('admin',     '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 'Phạm Quốc Kiệt',     'Admin'),
 ('letan',     '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 'Nguyễn Thị Lan',    'LeTan'),
 ('dieuduong', '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 'Lê Thị Mai',        'DieuDuong'),
('bacsi',    '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 'BS. Trần Đăng Khôi', 'BacSi'),
 ('thungan',   '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 'Phạm Thị Hoa',      'ThuNgan'),
('duocsi',    '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 'Võ Văn Nam',        'DuocSi');


INSERT INTO BenhNhan (HoTen, NgaySinh, GioiTinh, SoDT, DiaChi, TienSuDiUng) VALUES
('Nguyễn Văn Minh', '2004-03-12', 'Nam', '0901234567', 'Quận 5, TP.HCM',  ''),
 ('Lê Thị Ngọc An', '2006-07-06', 'Nữ',  '0912345678', 'Quận 10, TP.HCM', 'Penicillin');