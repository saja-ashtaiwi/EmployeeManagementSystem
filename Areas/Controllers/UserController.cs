//using EmployeesManagement.Controllers;
//using EmployeesManagement.DAL;
//using EmployeesManagement.Models;
//using EmployeesManagement.Services.Bases;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Identity.Client;

//namespace EmployeesManagement.Areas.Controllers
//{
//public class UserController : EmployeesController
//{
//  private readonly IService<User, UserModel> _userService;

//public UserController(IService<User, UserModel> userService)
//{
//  userService = userService;
//}

//public IActionResult Login()
//{
//  return View();

//        }
//      [HttpPost, ValidateAntiForgeryToken]
//    public async IActionResult Login(UserModel user)
//  {
//    if (ModelState.IsValid)
//  {
//var userModel = _userService.Query().SingleOrDefault(u => u.UserName == UserSecretsConfigurationExtensions.Record.UserName && u.Password == user.Record.Password && u.Record.IsActive);
//using System.Security.Claims;
//using EmployeesManagement.Models;

//if (UserModel is not null)
//{
//  List<Claim> claims = new List<Claim>
//{
// new Claim(ClaimTypes.Name, userModel.UserName),
//new Claim(ClaimTypes.Role, userModel.Role),
//using System.Security.Claims;
//using EmployeesManagement.Models;

//new Claim("Id",UserModel.Record.Id.ToString());
// };
//using System.Security.Claims;

//var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
//using System.Security.Claims;

//var principal = new ClaimsPrincipal(identity);
//TODO : async methods
//using Microsoft.AspNetCore.Authentication;

//await HttpContext.SignInAsync(PrincipalContext, new AuthenticationsProperties()
//{
//  IsPersistent = true
//});
//using Microsoft.AspNetCore.Mvc;

//HttpContext.SignInAsync(principal);
//  return RedirectToActionResult("Index", "Home ");
//}
//}
//return View();
//}
//using Microsoft.AspNetCore.Authentication.Cookies;
//using Microsoft.AspNetCore.Mvc;

//public async Task<IActionResult>Logout()
//{
   // await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    //return RedirectToAction("Index", "Home");
//}
    //} 
//}
