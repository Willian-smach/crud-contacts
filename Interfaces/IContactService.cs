using FirstApp.Models;

namespace FirstApp.Interfaces;

public interface IContactService
{
    List<ContactModel> List();
    ContactModel Create(ContactModel contact);
    ContactModel Update(ContactModel contact);
}
