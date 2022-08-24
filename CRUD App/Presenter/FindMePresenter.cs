using CRUD_App.View;
namespace CRUD_App.Presenter
{
    public class FindMePresenter
    {
        private InterfaceFindMe _interfaceFindMe;

        public FindMePresenter(InterfaceFindMe _interfaceFindMe)
        {
            this._interfaceFindMe = _interfaceFindMe;

            this._interfaceFindMe.Show(); //!Important
        }
    }
}
