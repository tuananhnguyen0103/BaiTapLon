using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BaiTapLon10118350.DataAccessLayer.Entity;

namespace BaiTapLon10118350.DataAccessLayer.DataAccess
{
    public class DAL_SinhVien : DBConnect
    {
        public DataTable getSinhVien()
        {
            sqlCon.Open();
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter("Select * From dbo.SinhVien", strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdap.Fill(dataTable);
            sqlCon.Close();
            return dataTable;
        }
        public DataTable getSinhVienTheoLop(string maLop)
        {
            sqlCon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format("Select * From dbo.SinhVien Where maLop = '{0}'", maLop), strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlCon.Close();
            return dataTable;
        }
        public DataTable GetSinhVienTheoKhoa(string maKhoa)
        {
            sqlCon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format(@"
                            Select SV.*  From dbo.SINHVIEN sv inner join dbo.Lop l
	                            on sv.maLop = l.maLop
		                            right join dbo.Khoa K
			                            on k.maKhoa = l.maKhoa	
				                            Where k.maKhoa = '{0}'", maKhoa), strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlCon.Close();
            return dataTable;
        }

        public DataTable GetSinhVienTheoLop(string maLop)
        {
            sqlCon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format(@"
                            Select SV.*  From dbo.SINHVIEN sv inner join dbo.Lop l
	                            on sv.maLop = l.maLop
				                            Where l.maLop = '{0}'", maLop), strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlCon.Close();
            return dataTable;
        }

        public DataTable GetSinhVienTheoMonHoc(string maMonHoc)
        {
            sqlCon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format(@"
                            Select SV.*  From dbo.SINHVIEN sv inner join dbo.DIEM d
	                                on sv.maSinhVien = d.maSinhVien
		                                right join dbo.MONHOC mh on mh.maMonHoc = d.maMonHoc
				                                Where d.maMonHoc = '{0}'", maMonHoc), strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlCon.Close();
            return dataTable;
        }
        public DataTable GetSinhVienTheoDiem(int diem1, int diem2)
        {
            sqlCon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format(@"
                            Select sv.maSinhVien,sv.maLop,sv.tenSinhVien,sv.ngaySinh,sv.gioiTinh, Round(sum(d.diemlan1*mh.soTinChi+d.diemlan2*mh.soTinChi)/sum(mh.soTinChi)/2,2) as [DiemTrungBinh] From dbo.SinhVien SV left join dbo.DIEM d 
	                            On d.maSinhVien = sv.maSinhVien inner join dbo.MONHOC Mh
		                            on mh.maMonHoc = d.maMonHoc
                            Group by sv.maSinhVien,sv.maLop,sv.tenSinhVien,sv.ngaySinh,sv.gioiTinh
                            Having Round(sum(d.diemlan1*mh.soTinChi+d.diemlan2*mh.soTinChi)/sum(mh.soTinChi)/2,2) >{0} and Round(sum(d.diemlan1*mh.soTinChi+d.diemlan2*mh.soTinChi)/sum(mh.soTinChi)/2,2) < {1}
                            Order By Round(sum(d.diemlan1*mh.soTinChi+d.diemlan2*mh.soTinChi)/sum(mh.soTinChi)/2,2) DESC", diem1,diem2), strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlCon.Close();
            return dataTable;
        }
        public int SoLuongGetSinhVienTheoDiem(int diem1, int diem2)
        {
            int soLuong = 0;
            sqlCon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format(@"
                            Select sv.maSinhVien,sv.maLop,sv.tenSinhVien,sv.ngaySinh,sv.gioiTinh, Round(sum(d.diemlan1*mh.soTinChi+d.diemlan2*mh.soTinChi)/sum(mh.soTinChi)/2,2) as [DiemTrungBinh] From dbo.SinhVien SV left join dbo.DIEM d 
	                            On d.maSinhVien = sv.maSinhVien inner join dbo.MONHOC Mh
		                            on mh.maMonHoc = d.maMonHoc
                            Group by sv.maSinhVien,sv.maLop,sv.tenSinhVien,sv.ngaySinh,sv.gioiTinh
                            Having Round(sum(d.diemlan1*mh.soTinChi+d.diemlan2*mh.soTinChi)/sum(mh.soTinChi)/2,2) >{0} and Round(sum(d.diemlan1*mh.soTinChi+d.diemlan2*mh.soTinChi)/sum(mh.soTinChi)/2,2) < {1}
                            Order By Round(sum(d.diemlan1*mh.soTinChi+d.diemlan2*mh.soTinChi)/sum(mh.soTinChi)/2,2) DESC", diem1, diem2), strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlCon.Close();
            soLuong = dataTable.Rows.Count;
            return soLuong;
        }
        public int SoLuongGetSinhVienTheoKhoa(string maKhoa)
        {
            int soLuong = 0;
            sqlCon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format(@"
                            Select Count(*)  From dbo.SINHVIEN sv inner join dbo.Lop l
	                            on sv.maLop = l.maLop
		                            right join dbo.Khoa K
			                            on k.maKhoa = l.maKhoa	
				                            Where k.maKhoa = '{0}'", maKhoa), strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            soLuong = int.Parse(dataTable.Rows[0][0].ToString());
            sqlCon.Close();
            return soLuong;
        }

        public int SoLuongGetSinhVienTheoLop(string maLop)
        {
            int soLuong = 0;
            sqlCon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format(@"
                            Select Count(*)  From dbo.SINHVIEN sv inner join dbo.Lop l
	                            on sv.maLop = l.maLop
				                            Where l.malop = '{0}'", maLop), strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            soLuong = int.Parse(dataTable.Rows[0][0].ToString());
            sqlCon.Close();
            return soLuong;
        }
        public int SoLuongGetSinhVienTheoMonHoc(string maMonHoc)
        {
            int soLuong = 0;
            sqlCon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format(@"
                            Select Count(*)  From dbo.SINHVIEN sv inner join dbo.DIEM d
	                        on sv.maSinhVien = d.maSinhVien
		                        right join dbo.MONHOC mh on mh.maMonHoc = d.maMonHoc
				                        Where d.maMonHoc = '{0}'", maMonHoc), strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            soLuong = int.Parse(dataTable.Rows[0][0].ToString());
            sqlCon.Close();
            return soLuong;
        }
        public DataTable getLop()
        {
            sqlCon.Open();
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter("Select * From dbo.Lop", strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdap.Fill(dataTable);
            sqlCon.Close();
            return dataTable;
        }
        public DataTable GetSinHVienTheoTen(string tenSinhVien)
        {
            sqlCon.Open();
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(string.Format("Select * From dbo.SinhVien Where tenSinhVien =N'%{0}%'",tenSinhVien), strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdap.Fill(dataTable);
            sqlCon.Close();
            return dataTable;
        }
        public string getMaLop(string tenLop)
        {
            string maLop = "";
            sqlCon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From dbo.Lop", strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            int i = 0;
            while (i < dataTable.Rows.Count)
            {
                if (tenLop == dataTable.Rows[i][1].ToString())
                {
                    maLop = dataTable.Rows[i][0].ToString();
                    break;
                }
                i++;
            }
            sqlCon.Close();
            return maLop;
        }
        public string getTenLop(string maLop)
        {
            string tenLop = "";
            sqlCon.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From dbo.Lop", strConnect);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlCon.Close();
            int i = 0;
            while (i < dataTable.Rows.Count)
            {
                if (maLop == dataTable.Rows[i][0].ToString())
                {
                    tenLop = dataTable.Rows[i][2].ToString();
                    break;
                }
                i++;
            }
            sqlCon.Close();
            return tenLop;
        }

        public int KiemTraMaTrung(string ma)
        {
            // Giá trị trả ra nếu là 1 là trùng, 0 là không tồn tại mã trong cơ sở dữ liệu
            int i;
            // Kết nối với cơ sở dữ liệu
            sqlCon.Open();
            // Câu truy vấn để kiểm tra mã có tồn tại hay không?
            string strCheck = string.Format(@"Select Count(*) From dbo.SinhVien Where maSinhVien ='{0}'", ma);

            SqlCommand sqlCom = new SqlCommand(strCheck, sqlCon);
            i = (int)sqlCom.ExecuteScalar();
            sqlCon.Close();
            return i;

        }
        public void ThemSinhVien(DTO_SinhVien SinhVien)
        {
            try
            {
                // Kết Nối với cơ sở dữ liệu
                sqlCon.Open();
                // Câu truy vấn để thêm thông tin
                string strQuery = string.Format(@"Insert Into dbo.SinhVien (maSinhVien,maLop,tenSinhVien,queQuan,ngaySinh,gioiTinh)
                                                 Values('{0}','{1}',N'{2}',N'{3}','{4}',N'{5}')", SinhVien.MaSinhVien, SinhVien.MaLop, SinhVien.TenSinhVien, SinhVien.QueQuan,SinhVien.NgaySinh,SinhVien.GioiTinh);
                // Dùng đối tượng sqlCommand để thao tác với cơ sở dữ liệu với 2 tham số truyền vào là câu truy vấn và đối tượng thực thi
                SqlCommand sqlCom = new SqlCommand(strQuery, sqlCon);
                sqlCom.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
        public void SuaSinhVien(string maSinhVien, DTO_SinhVien SinhVien)
        {
            try
            {
                sqlCon.Open();
                string strQuery = string.Format(@"Update dbo.SinHVien Set maLop='{0}',tenSinHVien=N'{1}',queQuan=N'{3}',ngaySinh='{2}',gioiTinh=N'{4}'
                                                Where maSinhVien ='{5}'", SinhVien.MaLop, SinhVien.TenSinhVien, SinhVien.NgaySinh, SinhVien.QueQuan, SinhVien.GioiTinh, maSinhVien);
                SqlCommand sqlCom = new SqlCommand(strQuery, sqlCon);
                sqlCom.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
        public void XoaSinhVien(string maSinhVien)
        {
            try
            {
                sqlCon.Open();
                string strQuery = string.Format(@"Delete From dbo.SinhVien Where maSinhVien='{0}'", maSinhVien);
                SqlCommand sqlCom = new SqlCommand(strQuery, sqlCon);
                sqlCom.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
    }
}
