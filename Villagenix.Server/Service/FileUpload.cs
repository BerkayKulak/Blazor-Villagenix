using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;
using Villagenix.Server.Service.IService;

namespace Villagenix.Server.Service
{
    public class FileUpload:IFileUpload
    {
        public Task<string> UploadFile(IBrowserFile file)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteFile(string fileName)
        {
            throw new System.NotImplementedException();
        }
    }
}
