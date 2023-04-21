using System.Threading.Tasks;
using System.Collections.Generic;

namespace WebApp.Models.BL.OutputSlipBL
{
    public interface IOutputSlipService
    {
        public Task<List<OutputSlipDTO>> GetOutputSlips();
        public Task<string> DeleteAsync(string id);
        public Task<string> CreateAsync(OutputSlipDTO outputSlipDTO);
        public Task<string> UpdateAsync(OutputSlipDTO outputSlipDTO);
    }
}
