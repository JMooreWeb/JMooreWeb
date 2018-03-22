using AutoMapper;
using JMooreWeb.Data;
using JMooreWeb.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace JMooreWeb.Controllers.api
{
   [Produces("application/json")]
	[Route("api/fileupload")]
	public class FileUploadController : BaseController
	{
		private readonly string path = @"D:\PhotoUploads";
		private readonly IMapper _mapper;

		public FileUploadController(
			UserManager<User> userManager,
			RoleManager<Role> roleManager,
			DatabaseContext context,
			//IPhotoRepository repo,
			IFileProvider fileProvider,
			IMapper mapper) : base(userManager, roleManager, context, /*repo, */fileProvider)
		{
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult Get()
		{
			return Ok();
		}

		[HttpPost]
		public async Task<IActionResult> Post(ICollection<IFormFile> files)
		{
			try
			{
				#region Try Block
				if (files == null || files.Count == 0)
					return Content("files not selected");

				if (ModelState.IsValid)
				{
					foreach (var file in files)
					{
						//var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\uploads", file.GetFilename());
						var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.ToString().Trim('"');

						using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
						{
							using (var memoryStream = new MemoryStream())
							{
								await file.CopyToAsync(memoryStream);

								//var photo = new Photo
								//{
								//	PropertyId = null,
								//	BuildingId = null,
								//	BuildingSeq = null,
								//	MasterPhoto = null,
								//	FrontPhoto = null,
								//	PublicPhoto = null,
								//	DateTaken = null, //FileHelper.GetDateTaken(Path.Combine(path, fileName)),
								//	ImageName = file.GetFilename(),
								//	ImageSize = file.Length / 1024,
								//	ImageData = memoryStream.ToArray(),
								//	UserId = Convert.ToInt32(_userManager.GetUserId(User)),
								//	UploadedBy = _userManager.GetUserName(User),
								//	UploadedDate = DateTime.Now,
								//	Status = "Not Tagged",
								//	Active = false,
								//};

								//_repo.AddPhoto(photo);

								//return Ok(_mapper.Map<Photo, PhotoViewModel>(photo));
							}
						}
					}
				}

				return Ok(); 
				#endregion
			}
			catch (Exception)
			{
				throw;
			}
			
		}
	}
}