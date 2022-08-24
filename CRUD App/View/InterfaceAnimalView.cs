using System;
using System.Windows.Forms;

namespace CRUD_App.View
{
    public interface InterfaceAnimalView
    {
        string IanimalID { get; set; }
        string IanimalName { get; set; }
        string IanimalType { get; set; }
        string IanimalColor { get; set; }
        int IanimalAge { get; set; }
        string IanimalSex { get; set; }
        DateTime IanimalBirthDate { get; set; }
        string IanimalOwner { get; set; }
        string IanimalOwnerPhone { get; set; }
        string IsearchValue { get; set; }
        bool IisEdit { get; set; }
        bool IisSuccessful { get; set; }
        string Imessage { get; set; }

        event EventHandler searchEvent;
        event EventHandler addNewEvent;
        event EventHandler editEvent;
        event EventHandler saveEvent;
        event EventHandler deleteEvent;
        event EventHandler cancelEvent;


        void setListBindingSource(BindingSource animalList);
        void Show(); //!Important
    }
}
