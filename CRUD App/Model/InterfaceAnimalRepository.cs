using System.Collections.Generic;

namespace CRUD_App.Model
{
    public interface InterfaceAnimalRepository
    {
        void Add(AnimalModel animalModel);
        void Edit(AnimalModel animalModel);
        void Delete(int animalModelID);
        IEnumerable<AnimalModel> GetAll();
        IEnumerable<AnimalModel> GetByValue(string value);
    }
}
