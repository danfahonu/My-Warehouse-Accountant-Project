$files = @(
"d:\aa\FormBangBaoGia.Designer.cs",
"d:\aa\FormBaoCaoQuy.Designer.cs",
"d:\aa\FormBaoCaoTonKho.Designer.cs",
"d:\aa\FormHeThongTaiKhoanKeToan.Designer.cs",
"d:\aa\FormKhachHang.Designer.cs",
"d:\aa\FormNhaCungCap.Designer.cs",
"d:\aa\FormNhanVien.Designer.cs",
"d:\aa\FormNhomHang.Designer.cs",
"d:\aa\FormPhieuXuat.Designer.cs",
"d:\aa\FormQuanLyHeThong.Designer.cs",
"d:\aa\FormQuanLyTaiKhoanNganHang.Designer.cs",
"d:\aa\FormTamUngChamCong.Designer.cs",
"d:\aa\FormYeuCauNhapKho.Designer.cs"
)

foreach ($file in $files) {
    Write-Host "Processing $file..."
    (Get-Content $file) -replace 'lblTitle', 'lblHeaderTitle' | Set-Content $file
}
