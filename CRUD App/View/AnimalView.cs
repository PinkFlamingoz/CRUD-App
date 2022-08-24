using System;
using System.Windows.Forms;

namespace CRUD_App.View
{
    public partial class AnimalView : Form, InterfaceAnimalView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public AnimalView()
        {
            InitializeComponent();
            getViewEvents();
            tabControlAnimals.TabPages.Remove(Detales);
            buttonClose.Click += delegate { this.Close(); };
        }

        private void getViewEvents()
        {
            buttonSearch.Click += delegate { searchEvent?.Invoke(this, EventArgs.Empty); };

            textBoxSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    searchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            buttonAdd.Click += delegate { addNewEvent?.Invoke(this, EventArgs.Empty); tabControlAnimals.TabPages.Remove(PetArchive); tabControlAnimals.TabPages.Add(Detales); Detales.Text = "Add new animal!"; };
            buttonEdit.Click += delegate { editEvent?.Invoke(this, EventArgs.Empty); tabControlAnimals.TabPages.Remove(PetArchive); tabControlAnimals.TabPages.Add(Detales); Detales.Text = "Edit Archive!"; };
            buttonSave.Click += delegate
            {
                saveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControlAnimals.TabPages.Remove(Detales);
                    tabControlAnimals.TabPages.Add(PetArchive);
                }
                MessageBox.Show(Imessage);
            };
            buttonDelete.Click += delegate
            {
                var answer = MessageBox.Show("Are you absolutly sure you want to delete this animal", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    deleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Imessage);
                }
            };
            buttonCancel.Click += delegate { cancelEvent?.Invoke(this, EventArgs.Empty); tabControlAnimals.TabPages.Remove(Detales); tabControlAnimals.TabPages.Add(PetArchive); };
        }

        public string IanimalID { get { return textBoxID.Text; } set { textBoxID.Text = value; } }
        public string IanimalName { get { return textBoxName.Text; } set { textBoxName.Text = value; } }
        public string IanimalType { get { return textBoxType.Text; } set { textBoxType.Text = value; } }
        public string IanimalColor { get { return textBoxColor.Text; } set { textBoxColor.Text = value; } }
        public int IanimalAge { get { return (int)numericUpDownAge.Value; } set { numericUpDownAge.Value = value; } }
        public string IanimalSex { get { return textBoxSex.Text; } set { textBoxSex.Text = value; } }
        public DateTime IanimalBirthDate { get { return dateTimePickerBirth.Value; } set { dateTimePickerBirth.Value = value; } }
        public string IanimalOwner { get { return textBoxOwner.Text; } set { textBoxOwner.Text = value; } }
        public string IanimalOwnerPhone { get { return textBoxOwnerPhone.Text; } set { textBoxOwnerPhone.Text = value; } }
        public string IsearchValue { get { return textBoxSearch.Text; } set { textBoxSearch.Text = value; } }
        public bool IisEdit { get { return isEdit; } set { isEdit = value; } }
        public bool IisSuccessful { get { return isSuccessful; } set { isSuccessful = value; } }
        public string Imessage { get { return message; } set { message = value; } }

        public event EventHandler searchEvent;
        public event EventHandler addNewEvent;
        public event EventHandler editEvent;
        public event EventHandler saveEvent;
        public event EventHandler deleteEvent;
        public event EventHandler cancelEvent;

        public void setListBindingSource(BindingSource animalList)
        {
            dataGridView1.DataSource = animalList;
        }

        private static AnimalView instance;
        public static AnimalView getInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AnimalView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();

                if (instance != null || instance.IsAccessible)
                {
                    instance.Dispose();
                }
            }
            return instance;
        }

        //Microsoft bug where if you click many times on the button that opens the view it bugs out the validator reference :( (Solution: close it with the X button and open it again with the exmple: Animals button))
        //Microsoft bug where it resets the font if you load columns.width :(
        private void AnimalView_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[6].Width = 120;
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[8].Width = 150;
        }
    }
}
