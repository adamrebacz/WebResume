using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WebResume.Auth.Graph;
using WebResume.Models;
using WebResume.MVC.DataAccess.Repository.IRepository;

namespace WebResume.MVC.Controllers
{
    //[Authorize]
    [AllowAnonymous]
    public class AdministrationController : Controller
    {
        private readonly ILogger<AdministrationController> _logger;
        private readonly IUnitOfWork _unitOfWOrk;
        private readonly IConfiguration _configuration;
        private readonly IGraphSdkHelper _graphSdkHelper;

        public AdministrationController(
            IConfiguration configuration,
            ILogger<AdministrationController> logger,
            IUnitOfWork unitOfWork,
            IGraphSdkHelper graphSdkHelper)
        {
            _logger = logger;
            _unitOfWOrk = unitOfWork;
            _configuration = configuration;
            _graphSdkHelper = graphSdkHelper;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region Sections
        public async Task<IActionResult> Sections()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllSections()
        {
            return Json(new
            {
                data = await _unitOfWOrk.Section.GetAllAsync()
            });
        }

        public async Task<IActionResult> RemoveSection(int id)
        {
            Section section = await _unitOfWOrk.Section.GetAsync(id);
            return PartialView("_DeleteSectionForm", section);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteSection([FromBody]string sectionId)
        {
            if (!string.IsNullOrEmpty(sectionId))
            {
                int value = int.Parse(sectionId);
                _unitOfWOrk.Section.Remove(value);
                await _unitOfWOrk.SaveAsync();

                return Json(new { message = "OK" });
            }
            return Json(new { message = "ERROR" });
        }

        public async Task<IActionResult> EditSection(int id)
        {
            Section section = await _unitOfWOrk.Section.GetAsync(id);
            return PartialView("_EditSectionForm", section);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSection([FromBody]Section _section)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWOrk.Section.UpdateAsync(_section);
                return Json(new { message = "OK" });
            }
            //if (!string.IsNullOrEmpty(sectionId))
            //{
            //    int value = int.Parse(sectionId);
            //    _unitOfWOrk.Section.Remove(value);
            //    await _unitOfWOrk.SaveAsync();

            //    
            //}
            return Json(new { message = "ERROR" });
        }

        public IActionResult AddSection(int id)
        {
            Section section = new Section();
            return PartialView("_SectionForm");
        }

        [HttpPost]
        public async Task<IActionResult> CreateSection([FromBody]Section data)
        {
            if (ModelState.IsValid)
            {
                data.Visible = true;

                _unitOfWOrk.Section.Add(data);
                await _unitOfWOrk.SaveAsync();

                return Json(new { message = "OK" });
            }
            return Json(new { message = "ERROR" });
        }

        #endregion

        #region Date Item

        #endregion
    }
}