using System.Collections.Generic;

class ContactManager
{
    private readonly List<Contact> _contacts = new List<Contact>();

    public int Count => _contacts.Count;

    public bool Add(Contact contact)
    {
        foreach (Contact c in _contacts)
        {
            if (c.Phone == contact.Phone)
                return false;   // شماره‌ی تکراری
        }
        _contacts.Add(contact);
        return true;
    }

    public List<Contact> Search(string keyword)
    {
        List<Contact> results = new List<Contact>();
        string key = keyword.ToLower();

        foreach (Contact c in _contacts)
        {
            if (c.Name.ToLower().Contains(key) || c.Phone.Contains(key))
                results.Add(c);
        }
        return results;
    }

    public bool Delete(string phone)
    {
        foreach (Contact c in _contacts)
        {
            if (c.Phone == phone)
            {
                _contacts.Remove(c);
                return true;
            }
        }
        return false;
    }

    public List<Contact> GetAll()
    {
        return new List<Contact>(_contacts);
    }
}