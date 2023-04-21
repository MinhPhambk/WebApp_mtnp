using System.Threading.Tasks;
using System.Collections.Generic;

namespace WebApp.Models.BL.OutputSlipDetailBL
{
    public interface IOutputSlipDetailService
    {
        public Task<List<OutputSlipDetailDTO>> GetOutputSlipDetails();
        public Task<string> DeleteAsync(string id);
        public Task<string> CreateAsync(OutputSlipDetailDTO outputSlipDetailDTO);
        public Task<string> UpdateAsync(OutputSlipDetailDTO outputSlipDetailDTO);
    }
}