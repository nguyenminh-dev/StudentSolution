using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Student.Application.MSinhVien
{
    public interface ISinhVienService
    {
        public Task<int> Create(SinhVienDto request);
        public Task<int> Update(SinhVienDto request);
        public Task<int> Delete(SinhVienDto request);
        public Task<List<SinhVienDto>> GetAll();
    }
}
