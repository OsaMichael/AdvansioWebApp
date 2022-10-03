using AdvanWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static AdvanWeb.Controllers.Common.Enum;

namespace AdvanWeb.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _client;
        private readonly IConfiguration _configuration;
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration, HttpClient client)
        {
            _logger = logger;
            _configuration = configuration;
            _client = client;
        }

        public IActionResult Index()
        {
           
                return View();
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model )
        {
            if (ModelState.IsValid)
            {
                var url = _configuration.GetValue<string>("APIUrls:url1");
                ResponseData resp = new ResponseData();

                try
                {
                    var jObj = string.Empty;
                    if (model != null)
                        jObj = JsonConvert.SerializeObject(model);
                    var content = new StringContent(jObj, Encoding.UTF8, "application/json");
                    var request = _client.PostAsync(url, content).Result;
                    var result = request.Content.ReadAsStringAsync();
                    if (request.IsSuccessStatusCode)
                        resp = JsonConvert.DeserializeObject<ResponseData>(result.Result);
                    if (resp.AccountNumber != null )
                    {

                        TempData["message"] = "Account Balance" + " " +  resp.CurrentAccountBalance  ;

                        dynamic transRef = TempData["Message"];

                        Alert("success", transRef, NotificationType.success);

                        // _notifyService.Success($"{resp.message}");

                    }
                    else
                    {
                        dynamic transRef = TempData["Message"];

                        Alert("error", transRef, NotificationType.error);

                    }
                }
                catch (Exception ex)
                {
                    _ = ex.Message;
                   // _notifyService.Error($"{ex.Message}");


                }

            }
            return View();
        }

        public async Task<IActionResult> Login()
        {


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel login)
        {
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(login), Encoding.UTF8, "application/json");

                // call this endpoint login of external api to authenticate the credentials
                string endpoint = _configuration.GetValue<string>("APIUrls:url2");

                using (var Response = await client.PostAsync(endpoint, content))
                {
                    if (Response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                       // TempData["Profile"] = JsonConvert.SerializeObject(login);


                        TempData["message"] = "WELCOME TO OUR PORTAL";

                        dynamic transRef = TempData["Message"];

                        Alert("success", transRef, NotificationType.success);


                        return RedirectToAction("Index");


                    }
                    else
                    {
                        ModelState.Clear();
                        ModelState.AddModelError(string.Empty, "Username or Password is Incorrect");
                        return View();

                    }

                }
                
            }
            return View(login);

        }
        [HttpPost]
        public async Task<IActionResult> FundTransfer(TransferModel model)
        {
            if (ModelState.IsValid)
            {
                var url = _configuration.GetValue<string>("APIUrls:url3");
                ResponseData resp = new ResponseData();

                try
                {
                    var jObj = string.Empty;
                    if (model != null)
                        jObj = JsonConvert.SerializeObject(model);
                    var content = new StringContent(jObj, Encoding.UTF8, "application/json");
                    var request = _client.PostAsync(url, content).Result;
                    var result = request.Content.ReadAsStringAsync();
                    if (request.IsSuccessStatusCode)
                        resp = JsonConvert.DeserializeObject<ResponseData>(result.Result);
                    if (resp.AccountNumber != null)
                    {

                        TempData["message"] = "acct number" + " " + resp.AccountNumber + " was generated" + " " + resp.FirstName + "" + resp.LastName;

                        dynamic transRef = TempData["Message"];

                        Alert("success", transRef, NotificationType.success);

                        // _notifyService.Success($"{resp.message}");

                    }
                    else
                    {
                        dynamic transRef = TempData["Message"];

                        Alert("error", transRef, NotificationType.error);

                    }
                }
                catch (Exception ex)
                {
                    _ = ex.Message;
                    // _notifyService.Error($"{ex.Message}");


                }

            }
            return View();
        }
        
        [HttpGet]
        public async Task<IActionResult> GetWelletBalance(string AccountNumber)
        {
            if (ModelState.IsValid)
            {
                var url = _configuration.GetValue<string>("APIUrls:url3");
                ResponseData resp = new ResponseData();

                try
                {
                    var jObj = string.Empty;
                    if (AccountNumber != null)
                        jObj = JsonConvert.SerializeObject(AccountNumber);
                    var content = new StringContent(jObj, Encoding.UTF8, "application/json");
                    var request = _client.PostAsync(url, content).Result;
                    var result = request.Content.ReadAsStringAsync();
                    if (request.IsSuccessStatusCode)
                        resp = JsonConvert.DeserializeObject<ResponseData>(result.Result);
                    if (resp.AccountNumber != null)
                    {

                        TempData["message"] = "acct number" + " " + resp.AccountNumber + " was generated" + " " + resp.FirstName + "" + resp.LastName;

                        dynamic transRef = TempData["Message"];

                        Alert("success", transRef, NotificationType.success);

                        // _notifyService.Success($"{resp.message}");

                        return RedirectToAction("Index");

                    }
                    else
                    {
                        dynamic transRef = TempData["Message"];

                        Alert("error", transRef, NotificationType.error);

                    }
                }
                catch (Exception ex)
                {
                    _ = ex.Message;
                    // _notifyService.Error($"{ex.Message}");


                }

            }
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
