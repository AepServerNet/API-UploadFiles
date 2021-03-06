using System.Threading.Tasks;
using API_UploadFiles.Models.InputModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace API_UploadFiles.Models.Services.Infrastructure
{
    public interface IUploadFilesService
    {
        Task UploadFileAsync(InputUploadFile model, [FromServices] IWebHostEnvironment env);
    }
}