using System.Text;
using FirstApp.Interfaces;
using FirstApp.Models;
using Newtonsoft.Json;

namespace FirstApp.Services;

public class ContactService : IContactService
{
    private readonly string URL_BASE = "http://localhost:3000";
    public List<ContactModel> List()
    {
        var data = new List<ContactModel>();

        try
        {
            using(var client = new HttpClient())
            {
                var response = client.GetStringAsync(URL_BASE + "/contacts");
                response.Wait();
                
                data = JsonConvert.DeserializeObject<ContactModel[]>(response.Result).ToList();
            }
        }catch{
            
        }
        return data;

    }

    public ContactModel Create(ContactModel contact)
    {
        var newContact = new ContactModel();

        try
        {
           using(var client = new HttpClient())
           {
                string jsonObject = JsonConvert.SerializeObject(contact);
                var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                var response = client.PostAsync(URL_BASE + "/contacts", content);
                response.Wait();
                if(response.Result.IsSuccessStatusCode) {
                    var r = response.Result.Content.ReadAsStringAsync();
                    newContact = JsonConvert.DeserializeObject<ContactModel>(r.Result);
                }
           }
        }
        catch(Exception)
        {
            throw;
        }

        return newContact;
    }

    public ContactModel Update(ContactModel contact)
    {
        var newContact = new ContactModel();

        try
        {
           using(var client = new HttpClient())
           {
                string jsonObject = JsonConvert.SerializeObject(contact);
                var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                var response = client.PostAsync(URL_BASE + "/contacts", content);
                response.Wait();
                if(response.Result.IsSuccessStatusCode) {
                    var r = response.Result.Content.ReadAsStringAsync();
                    newContact = JsonConvert.DeserializeObject<ContactModel>(r.Result);
                }
           }
        }
        catch(Exception)
        {
            throw;
        }

        return newContact;
    }
}
