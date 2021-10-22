using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WebApiClientSecond.Models;

namespace WebApiClientSecond.Services
{
    public class MyApiService
    {
        HttpClient client = new HttpClient();
        string uri = "http://localhost:3021/api/todoes";

        public async Task<IEnumerable<ToDo>> GetTodos()
        {
            var resp = await client.GetAsync(uri);
            var result = resp.Content.ReadAsStringAsync().Result;
            var todos = JsonConvert.DeserializeObject<List<ToDo>>(result);
            return todos;
        }

        public async Task<ToDo> GetTodoByID(long id)
        {
            var resp = await client.GetAsync(uri + $"/{id}");
            var result = resp.Content.ReadAsStringAsync().Result;
            var todo = JsonConvert.DeserializeObject<ToDo>(result);
            return todo;
        }
        public async Task<HttpStatusCode> AddUser(ToDo todo)
        {
            var content = new StringContent(JsonConvert.SerializeObject(todo),
                System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(
                uri, content);
            return response.StatusCode;
        }

        public async Task<HttpStatusCode> EditUser(long id, ToDo todo)
        {
            var content = new StringContent(JsonConvert.SerializeObject(todo),
                System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(
                uri+$"/{id}", content);
            return response.StatusCode;
        }

        public async Task<HttpStatusCode> DeleteUser(long id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                uri + $"/{id}");
            return response.StatusCode;
        }



    }
}
