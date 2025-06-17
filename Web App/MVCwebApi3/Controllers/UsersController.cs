using MVCwebApi3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MVCwebApi3.Controllers
{
    public class UsersController : Controller
    {
        private readonly string apiUrl = "http://localhost:63151/api/users"; // Update with your Web API URL

        // GET: Users
        public async Task<ActionResult> Index()
        {
            try
            {
                List<User> users = new List<User>();

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        users = JsonConvert.DeserializeObject<List<User>>(result);
                    }
                    else
                    {
                        TempData["ErrorMessage"] = "Failed to load users. Please try again later.";
                    }
                }

                return View(users);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error: {ex.Message}";
                return View(new List<User>());
            }
        }

        // GET: Users/Details/5
        public async Task<ActionResult> Details(int id)
        {
            try
            {
                User user = null;

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"{apiUrl}/{id}");
                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        user = JsonConvert.DeserializeObject<User>(result);
                    }
                }

                return View(user);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(User user)
        {
            if (!ModelState.IsValid)
                return View(user);

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(user);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                        return RedirectToAction("Index");

                    TempData["ErrorMessage"] = "Failed to create user. Please try again.";
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error: {ex.Message}";
            }

            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            try
            {
                User user = null;

                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync($"{apiUrl}/{id}");

                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        user = JsonConvert.DeserializeObject<User>(result);
                    }
                }

                return View(user);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(User user)
        {
            if (!ModelState.IsValid)
                return View(user);

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(user);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PutAsync($"{apiUrl}/{user.UserID}", content);

                    if (response.IsSuccessStatusCode)
                        return RedirectToAction("Index");

                    TempData["ErrorMessage"] = "Failed to update user. Please try again.";
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error: {ex.Message}";
            }

            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.DeleteAsync($"{apiUrl}/{id}");

                    if (!response.IsSuccessStatusCode)
                        TempData["ErrorMessage"] = "Failed to delete user. Please try again.";
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error: {ex.Message}";
            }

            return RedirectToAction("Index");
        }
    }
}
