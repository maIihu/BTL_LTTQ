Cách đặt tên: 


Giải thích 3 lớp:
- Lớp DTO (Data Tranfer Object): chứa các dữ liệu, các thuộc tính tương ứng với các trường trong cơ sở dữ liệu.
- Lớp DAL (Data Access Layer): lớp truy cập dữ liệu, chịu trách nhiệm tương tác với cơ sở dữ liệu, chứa các phương thức để lấy dữ liệu từ cơ sở dữ liệu và trả về cho tầng BLL.
- Lớp BLL (Business Login Layer): Chứa các quy tắc nghiệp vụ và logic xử lý của ứng dụng, kiểm tra tính hợp lệ của dữ liệu trước khi thêm/sửa/xóa trong cơ sở dữ liệu.

Cách đặt tên file: 
- Trong lớp BLL thì đặt tên là "CaiGiDo".BLL (Ví dụ: KhachHangBLL.cs)
- Trong lớp DAL thì đặt tên là "CaiGiDo".DAL (Ví dụ: KhachHangDAL.cs)
- Trong lớp DTO thì đặt tên là "CaiGiDo".DTO (Ví dụ: KhachHangDTO.cs)
- Trong lớp GUI thì đặt tên form là f"CaiGiDo".cs (Ví dụ: fKhachHang.cs)

Cách dùng lớp DataProvider: 
- Chứa những phương thức để xử lý Cơ sở dữ liệu trong SQL chỉ cần kết nối CSDL trong mySQL là sử dụng được
- Từng phương thức đã có cách dùng rồi
- Khi dùng chỉ cần gọi tên class chấm Instance chấm tên phương thức (Ví dụ: DataProvider.Instance.ExecuteScalar)
