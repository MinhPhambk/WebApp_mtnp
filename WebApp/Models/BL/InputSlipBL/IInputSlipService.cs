using System.Threading.Tasks;
using System.Collections.Generic;

namespace WebApp.Models.BL.InputSlipBL
{
    public interface IInputSlipService
    {
        public Task<List<InputSlipDTO>> GetInputSlips();
        public Task<string> DeleteAsync(string id);
        public Task<string> CreateAsync(InputSlipDTO inputSlipDTO);
        public Task<string> UpdateAsync(InputSlipDTO inputSlipDTO);
    }
}