QUY CHUẨN LOGIC & KIẾN TRÚC NGHIỆP VỤ (LOGIC GUIDELINES)

Dự án: Phần mềm Kế toán Kho (Inventory Accounting System)
Mục đích: Đảm bảo tính toàn vẹn dữ liệu, tránh lệch kho/lệch sổ cái, và thống nhất cách viết code logic (Back-end).

1. KIẾN TRÚC HỆ THỐNG (ARCHITECTURE)

Tuyệt đối không viết logic nghiệp vụ (Business Logic) trong Form (UI). Phải tuân thủ mô hình phân lớp rõ ràng:

GUI Layer (Forms):

Chỉ làm nhiệm vụ hiển thị dữ liệu (DataGridView, TextBox).

Thu thập input từ người dùng và gọi Service.

Hiển thị thông báo lỗi/thành công (MessageBox, Toast).

CẤM: Viết câu lệnh INSERT/UPDATE/DELETE SQL trực tiếp trong sự kiện Click hoặc Load.

Service Layer (BLL - Business Logic Layer):

Tạo thư mục/namespace mới: DoAnLapTrinhQuanLy.Services.

Chứa các class xử lý nghiệp vụ: InventoryService, AccountingService, ReportService.

Nhiệm vụ: Tính toán tổng tiền, kiểm tra tồn kho, gọi Transaction, xử lý FIFO, định khoản nợ có.

Data Layer (DAL):

Sử dụng class có sẵn DoAnLapTrinhQuanLy.Data.DbHelper.

Không được khởi tạo SqlConnection thủ công bên ngoài DbHelper.

2. QUY TẮC TƯƠNG TÁC CƠ SỞ DỮ LIỆU (DATABASE RULES)

2.1. Sử dụng DbHelper

Mọi thao tác database phải thông qua DbHelper.

Sử dụng các phương thức: Execute, Scalar, Query, ExecuteTran.

2.2. Bảo mật (Security & Parameters)

TUYỆT ĐỐI CẤM: Cộng chuỗi SQL ("SELECT ... WHERE ID = " + txtID.Text).

BẮT BUỘC: Sử dụng SqlParameter hoặc DbHelper.Param("@TenThamSo", giaTri).

2.3. Quản lý Giao Dịch (Transaction Management) - QUAN TRỌNG NHẤT

Mọi thao tác "Ghi" (Write) ảnh hưởng đến từ 2 bảng trở lên bắt buộc phải nằm trong một Transaction nguyên tử (Atomic). Sử dụng DbHelper.ExecuteTran.

Ví dụ nghiệp vụ Nhập Kho (4 bước bắt buộc):
Nếu 1 trong 4 bước lỗi, phải Rollback toàn bộ.

PHIEU: Insert Header phiếu (Ngày, NCC, Loại...).

PHIEU_CT: Insert chi tiết hàng hóa.

KHO_CHITIET_TONKHO: Tạo dòng nhập kho mới (để theo dõi tuổi hàng cho FIFO).

BUTTOAN_KETOAN: Ghi sổ cái (Nợ 156 / Có 331).

3. QUY ĐỊNH NGHIỆP VỤ KHO & KẾ TOÁN (BUSINESS RULES)

3.1. Logic Xuất Kho (FIFO - First In First Out)

Không được tự viết logic trừ kho bằng vòng lặp foreach trong C# (dễ sai sót và chậm).

BẮT BUỘC: Gọi Stored Procedure sp_XuatKho_FIFO (đã có trong FIFO_Implementation.sql).

Quy trình: Form chỉ gửi MaHH, SoLuong -> Service gọi SP -> SP tự động tìm lô cũ nhất trừ tồn và tính giá vốn.

3.2. Logic Nhập Kho

Khi nhập hàng, ngoài bảng PHIEU_CT, bắt buộc phải Insert vào bảng KHO_CHITIET_TONKHO.

Cột SO_LUONG_TON ban đầu phải bằng SO_LUONG_NHAP.

Cột DON_GIA_NHAP là giá gốc (chưa thuế hoặc đã phân bổ chi phí tùy cấu hình).

3.3. Logic Định Khoản (Accounting)

Mọi phiếu nhập/xuất/thu/chi khi lưu thành công phải tự động sinh bút toán.

Nhập Kho: Nợ 156 (Hàng hóa) / Có 331 (Phải trả NCC) hoặc 111 (Tiền mặt).

Xuất Kho:

Bút toán 1 (Giá vốn): Nợ 632 (GVHB) / Có 156 (Hàng hóa).

Bút toán 2 (Doanh thu): Nợ 131 (Phải thu) / Có 511 (Doanh thu).

Thu Tiền: Nợ 111 / Có 131.

Chi Tiền: Nợ 331 / Có 111.

4. UI/UX & XỬ LÝ LỖI (BEST PRACTICES)

4.1. Bất đồng bộ (Async/Await)

Để tránh treo giao diện (Not Responding) khi load dữ liệu lớn hoặc lưu phiếu:

Sử dụng Task.Run(() => { ... }) cho các tác vụ nặng gọi xuống Database.

Sử dụng Invoke hoặc BeginInvoke khi cập nhật lại UI từ thread khác.

4.2. Validation (Kiểm tra dữ liệu)

Phải kiểm tra dữ liệu trước khi gọi Service/Database.

ComboBox (Nhà cung cấp/Khách hàng): Không được null.

DataGridView (Chi tiết): Phải có ít nhất 1 dòng.

SoLuong: Phải > 0.

TonKho: (Với phiếu xuất) Check tồn kho hiện tại trên UI trước khi cho phép thêm vào lưới.

4.3. Thông báo lỗi

Sử dụng try-catch ở tầng Form.

Thông báo lỗi phải thân thiện tiếng Việt. Ví dụ: "Không đủ hàng trong kho để xuất" thay vì hiện lỗi tiếng Anh của SQL Server.

5. SYSTEM PROMPT (DÀNH CHO AI AGENT/DEV)

Khi yêu cầu AI refactor code, hãy dùng Prompt mẫu sau để đảm bảo tuân thủ quy tắc:

"Đóng vai Senior .NET Backend Developer. Hãy Refactor lại logic cho Form: [TÊN_FORM].

Yêu cầu tuân thủ logic_guidelines.md:

LAYER SEPARATION: Tách toàn bộ code logic (SQL, tính toán) trong sự kiện BtnLuu_Click ra một Service Class riêng (ví dụ: [TenForm]Service.cs).

TRANSACTION: Sử dụng DbHelper.ExecuteTran để bao bọc toàn bộ quá trình Insert vào các bảng (PHIEU, PHIEU_CT, KHO, BUTTOAN).

FIFO COMPLIANCE: Nếu là Form Xuất, bắt buộc gọi SP sp_XuatKho_FIFO. Nếu là Form Nhập, phải Insert vào KHO_CHITIET_TONKHO.

SECURITY: Chuyển hết các chuỗi SQL cộng gộp (String concatenation) sang SqlParameter.

OUTPUT: Trả về code C# của Service Class mới và code C# của Form (Code-behind) đã được dọn dẹp gọn gàng."