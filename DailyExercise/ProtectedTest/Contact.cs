using System;

namespace ProtectedTest
{
    public class Contact : PadItem
    {
        private void Save()
        {
            Console.WriteLine(ObjectKey);
        }

        private void Load(PadItem padItem)
        {
            //padItem.ObjectKey = new Guid(); //Error
            ObjectKey = new Guid();

            Contact contact = padItem as Contact;
            if (contact != null)
            {
                contact.ObjectKey = new Guid();
            }
        }
    }
}