# MEnU-image-oriented-social-media
MEnU là ứng dụng Desktop (Windows) lấy cảm hứng hoàn toàn từ Locket Widget (Mobile). Đây là đề tài cho đồ án môn học NT106 - Lập Trình Mạng Căn Bản tại trường Đại học Công nghệ thông tin - ĐHQGHCM (UIT). Được thực hiện bởi Nhóm 05, lớp NT106.Q13, học kì I, năm học 2025-2026

> [!WARNING]  
> Sau khi clone dự án, hoặc là sử dụng Visual Studio để chạy MEnU.sln và build như bình thường, hoặc là giải nén file MEnU.zip vào một thư mục. Dù thực hiện cách nào, thì người dùng phải chạy file **register_protocol.bat** tại thư mục chứa MEnU.exe (đối với solution, truy cập MEnU\bin\Debug\net8.0-windows\). File register_protocol.bat đều nằm sẵn bên trong nơi chứa MEnU.exe khi clone repository về.  Điều này là cần thiết để tính năng Quên mật khẩu được thực hiện đúng cách. 

---
## Danh sách thành viên đóng góp
`1. Phạm Thành Danh - 24520265 - zankuit - Nhóm trưởng`

`2. Phan Vũ Nhật Huy - 24520696 - NhatHuy-Haz`

`3. Văng Minh Thùy Dương - 24520364 - vangminhthuyduong`

`4. Nguyễn Thị Mỹ Hạnh - 24520452 - HanhNguyen-stat`

---
## Một số nội dung liên quan
* Timeline: https://docs.google.com/spreadsheets/d/10dK7PhoKmGV_YuX-MbFdc4k_-uNCDVPv/edit?usp=sharing&ouid=116693850793280528206&rtpof=true&sd=true
* Slide thuyết trình: https://drive.google.com/file/d/1_Rlau1n0NJuIrs6Ag9ZW5ee8p06QkuT8/view?usp=sharing
* Báo cáo:
* Demo: https://drive.google.com/file/d/1cKogLF35dITpkOQFu0N3nnU47p3Hqoei/view?usp=sharing
> [!NOTE]  
> Demo chưa có chức năng Quên mật khẩu (reset mật khẩu). Chức năng này gọi một api để server gửi mail đặt lại mật khẩu. Nhấp vào đường link có dạng "menuapp://%" để thực hiện Deep linking, mở ứng dụng ở form Reset mật khẩu và đồng thời truyền vào một reset password token. Deep linking chỉ có thể được thực hiện nếu file register_protocol.bat đã được chạy với quyền quản trị viên.
---
## register_protocol.bat
```bat
@echo off
cls
echo ================================================
echo   Installing custom URL protocol: menuapp://
echo ================================================

net session >nul 2>&1
if %errorlevel% neq 0 (
    echo This script must be run as Administrator.
    pause
    exit /b
)

set EXE_PATH=%~dp0MEnU.exe

if not exist "%EXE_PATH%" (
    echo ERROR: MEnU.exe not found in the same folder.
    pause
    exit /b
)

reg delete "HKCR\menuapp" /f >nul 2>&1

reg add "HKCR\menuapp" /ve /d "URL:MEnU Custom Protocol" /f
reg add "HKCR\menuapp" /v "URL Protocol" /d "" /f
reg add "HKCR\menuapp\shell\open\command" /ve /d "\"%EXE_PATH%\" \"%%1\"" /f

echo.
echo Done! menuapp:// is now handled by MEnU.exe
pause
```
Đây là trong trường hợp bất kì ai cảm thấy file register_protocol.bat có chút đáng ngờ @@
