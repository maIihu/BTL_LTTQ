using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class PhuTungBLL
    {
        private PhuTungDAL _phuTungDAL;
        public PhuTungBLL()
        {
            _phuTungDAL = new PhuTungDAL();
        }
        public PhuTungDTO LayPhuTung(string maPt)
        {
            var result = _phuTungDAL.LayPhuTung(maPt);
            if (result != null)
            {
                return new PhuTungDTO
                {
                    TenPhuTung = result[0].ToString(),
                    SoLuong = int.Parse(result[1].ToString()),
                    DonGiaNhap = decimal.Parse(result[2].ToString()),
                    DonGiaBan = decimal.Parse(result[3].ToString())
                };
            }
            return null; // Trả về null nếu không tìm thấy bản ghi
        }
        public bool TimPhuTung(string ma)
        {
            return _phuTungDAL.KiemTraPhuTung(ma);
        }
        public bool SuaPhuTung(string ma, int sl)
        {
            return _phuTungDAL.SuaPhuTung(ma, sl);
        }
        public bool ThemPhuTung(PhuTungDTO phuTung)
        {
            return _phuTungDAL.ThemPhuTung(phuTung);
        }
        public List<PhuTungDTO> TimDsTheoTen(string ma)
        {
            return _phuTungDAL.TimDsTheoTen(ma);
        }
        public List<PhuTungDTO> LayDSPhuTung()
        {
            return _phuTungDAL.LayDSKhoPhuTung();
        }

    }
}
