using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiXeBLL
    {
        private LoaiXeDAL _loaiXeDAl;
        public LoaiXeBLL()
        {
            _loaiXeDAl = new LoaiXeDAL();
        }
        public bool ThemLoaiXe(LoaiXeDTO obj)
        {
            return this._loaiXeDAl.ThemLoaiXe(obj);
        }
        public bool SuaLoaiXe(LoaiXeDTO obj)
        {
            return this._loaiXeDAl.SuaLoaiXe(obj);
        }
        public bool XoaLoaiXe(string maLoai)
        {
            return _loaiXeDAl.XoaLoaiXe(maLoai);
        }
        public List<LoaiXeDTO> LayDanhSachLoaiXe()
        {
            return _loaiXeDAl.LayDanhSachLoaiXe();
        }
    }
}