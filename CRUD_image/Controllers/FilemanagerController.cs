using Microsoft.AspNetCore.Mvc;

namespace CRUD_image.Controllers
{
    public class FilemanagerController : Controller
    {
        private IWebHostEnvironment _hostEnv;
        public FilemanagerController(IWebHostEnvironment _hostEnv)
        {
            this._hostEnv = _hostEnv;
        }
        public IActionResult Index()
        {
            ViewBag.msg = TempData["msg"];
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile fileToUpload)
        {
            string msg = "";
            if (fileToUpload != null && fileToUpload.Length > 0)
            {
                string webroot= _hostEnv.WebRootPath;
                string folder = "Images";
                string fileName = Guid.NewGuid().ToString()+"_"+fileToUpload.FileName;
                string fileToWrite = Path.Combine(webroot, folder, fileName);
                //save
                using (var stream = new FileStream(fileToWrite, FileMode.Create))
                {
                    await fileToUpload.CopyToAsync(stream);
                    msg = "File [" + fileName + "] is uploaded successfully!!!";
                    
                }
            }
            else
            {
                msg = "Please select a valid file to upload!!";
            }
            TempData["msg"] = msg;
            return RedirectToAction("Index");
        }
    }
}
