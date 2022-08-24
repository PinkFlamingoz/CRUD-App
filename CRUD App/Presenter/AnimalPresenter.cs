using CRUD_App.Model;
using CRUD_App.Presenter.Common;
using CRUD_App.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace CRUD_App.Presenter
{
    public class AnimalPresenter
    {
        private InterfaceAnimalView _interfaceAnimalView;
        private InterfaceAnimalRepository _interfaceAnimalRepository;
        private BindingSource animalsBindingSource;
        private IEnumerable<AnimalModel> animalList;

        public AnimalPresenter(InterfaceAnimalView _interfaceAnimalView, InterfaceAnimalRepository _interfaceAnimalRepository)
        {
            this.animalsBindingSource = new BindingSource();
            this._interfaceAnimalView = _interfaceAnimalView;
            this._interfaceAnimalRepository = _interfaceAnimalRepository;

            this._interfaceAnimalView.searchEvent += searchData;
            this._interfaceAnimalView.addNewEvent += addData;
            this._interfaceAnimalView.editEvent += editData;
            this._interfaceAnimalView.saveEvent += saveData;
            this._interfaceAnimalView.deleteEvent += deleteData;
            this._interfaceAnimalView.cancelEvent += cancelDataEdit;

            this._interfaceAnimalView.setListBindingSource(animalsBindingSource);

            loadData();
            this._interfaceAnimalView.Show(); //!Important
        }

        private void loadData()
        {
            animalList = _interfaceAnimalRepository.GetAll();
            animalsBindingSource.DataSource = animalList;
        }

        private void cancelDataEdit(object sender, EventArgs e)
        {
            cleanView();
        }

        private void deleteData(object sender, EventArgs e)
        {
            try
            {
                var animal = (AnimalModel)animalsBindingSource.Current;
                _interfaceAnimalRepository.Delete(animal.AnimalID);
                _interfaceAnimalView.IisSuccessful = true;
                _interfaceAnimalView.Imessage = "Animal is vanquished :(";
                loadData();
            }
            catch
            {
                _interfaceAnimalView.IisSuccessful = false;
                _interfaceAnimalView.Imessage = "Animal did not vanquish ^_^";
            }
        }

        private void saveData(object sender, EventArgs e)
        {
            var model = new AnimalModel();
            model.AnimalID = Convert.ToInt32(_interfaceAnimalView.IanimalID);
            model.AnimalName = _interfaceAnimalView.IanimalName;
            model.AnimalType = _interfaceAnimalView.IanimalType;
            model.AnimalColor = _interfaceAnimalView.IanimalColor;
            model.AnimalAge = Convert.ToInt32(_interfaceAnimalView.IanimalAge);
            model.AnimalSex = _interfaceAnimalView.IanimalSex;
            model.AnimalBirthDate = Convert.ToDateTime(_interfaceAnimalView.IanimalBirthDate);
            model.AnimalOwner = _interfaceAnimalView.IanimalOwner;
            model.AnimalOwnerPhone = _interfaceAnimalView.IanimalOwnerPhone;
            try
            {
                new DataValidation().validate(model);
                if (_interfaceAnimalView.IisEdit)
                {
                    _interfaceAnimalRepository.Edit(model);
                    _interfaceAnimalView.Imessage = "Animal edit successful!";
                }
                else
                {
                    _interfaceAnimalRepository.Add(model);
                    _interfaceAnimalView.Imessage = "Animal add successful!";
                }
                _interfaceAnimalView.IisSuccessful = true;
                loadData();
                cleanView();
            }
            catch (Exception ex)
            {
                _interfaceAnimalView.IisSuccessful = false;
                _interfaceAnimalView.Imessage = ex.Message;
            }
        }

        private void cleanView()
        {
            _interfaceAnimalView.IanimalID = "0";
            _interfaceAnimalView.IanimalName = "";
            _interfaceAnimalView.IanimalType = "";
            _interfaceAnimalView.IanimalColor = "";
            _interfaceAnimalView.IanimalAge = 0;
            _interfaceAnimalView.IanimalSex = "";
            _interfaceAnimalView.IanimalBirthDate = DateTime.Now;
            _interfaceAnimalView.IanimalOwner = "";
            _interfaceAnimalView.IanimalOwnerPhone = "";
        }

        private void editData(object sender, EventArgs e)
        {
            var animal = (AnimalModel)animalsBindingSource.Current;
            _interfaceAnimalView.IanimalID = animal.AnimalID.ToString();
            _interfaceAnimalView.IanimalName = animal.AnimalName.ToString();
            _interfaceAnimalView.IanimalType = animal.AnimalType.ToString();
            _interfaceAnimalView.IanimalColor = animal.AnimalColor.ToString();
            _interfaceAnimalView.IanimalAge = animal.AnimalAge;
            _interfaceAnimalView.IanimalSex = animal.AnimalSex.ToString();
            _interfaceAnimalView.IanimalBirthDate = animal.AnimalBirthDate;
            _interfaceAnimalView.IanimalOwner = animal.AnimalOwner.ToString();
            _interfaceAnimalView.IanimalOwnerPhone = animal.AnimalOwnerPhone.ToString();
            _interfaceAnimalView.IisEdit = true;
        }

        private void addData(object sender, EventArgs e)
        {
            _interfaceAnimalView.IisEdit = false;
        }

        private void searchData(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this._interfaceAnimalView.IsearchValue);
            if (emptyValue == false)
            {
                animalList = _interfaceAnimalRepository.GetByValue(this._interfaceAnimalView.IsearchValue);
            }
            else
            {
                animalList = _interfaceAnimalRepository.GetAll();
            }
            animalsBindingSource.DataSource = animalList;
        }
    }
}
