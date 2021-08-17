using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Student.Data;
using Student.Data.Entities;
namespace Student.Application.MSinhVien
{
    public class SinhVienService : ISinhVienService
    {
        private readonly StudentDbContext _schoolDbContext;
        public SinhVienService(StudentDbContext schoolDbContext)
        {
            _schoolDbContext = schoolDbContext;
        }
        public async Task<int> Create(SinhVienDto request)
        {
            var sinhvien = new SinhVien()
            {
                name = request.name,
                address = request.address
            };
            _schoolDbContext.SinhViens.Add(sinhvien);
            return await _schoolDbContext.SaveChangesAsync();
        }

        public async Task<int> Delete(SinhVienDto request)
        {
            var sinhvien = new SinhVien()
            {
                id = request.id
            };
            _schoolDbContext.SinhViens.Remove(sinhvien);
            return await _schoolDbContext.SaveChangesAsync();
        }

        public async Task<List<SinhVienDto>> GetAll()
        {
            var reponse = await _schoolDbContext.SinhViens.Select(x => new SinhVienDto()
            {
                id = x.id,
                name = x.name,
                address = x.address
            }).ToListAsync();
            return reponse;
        }

        public async Task<int> Update(SinhVienDto request)
        {
            var sinhvien = new SinhVien()
            {
                id = request.id,
                name = request.name,
                address = request.address
            };
            _schoolDbContext.SinhViens.Update(sinhvien);
            return await _schoolDbContext.SaveChangesAsync();
        }

        
    }
}
