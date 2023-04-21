using System.Threading.Tasks;
using System.Collections.Generic;

namespace WebApp.Models.BL.InputSlipDetailBL
{
    public interface IInputSlipDetailService
    {
        public Task<List<InputSlipDetailDTO>> GetInputSlipDetails();
        public Task<string> DeleteAsync(string id);
        public Task<string> CreateAsync(InputSlipDetailDTO inputSlipDetailDTO);
        public Task<string> UpdateAsync(InputSlipDetailDTO inputSlipDetailDTO);
    }
}