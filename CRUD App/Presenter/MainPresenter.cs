using CRUD_App.Model;
using CRUD_App.Repository;
using CRUD_App.View;
using System;

namespace CRUD_App.Presenter
{
    public class MainPresenter
    {
        private MainInterface _mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(MainInterface _mainView, string sqlConnectionString)
        {
            this._mainView = _mainView;
            this.sqlConnectionString = sqlConnectionString;
            this._mainView.showAnimalView += showAnimalView;
            this._mainView.showFindMeView += showFindMeView;
        }

        private void showAnimalView(object sender, EventArgs e)
        {
            InterfaceAnimalView view = AnimalView.getInstance((MainView)_mainView);
            InterfaceAnimalRepository repository = new AnimalRepository(sqlConnectionString);
            new AnimalPresenter(view, repository);
        }


        private void showFindMeView(object sender, EventArgs e)
        {
            InterfaceFindMe view = FindMeView.getInstance((MainView)_mainView);
            new FindMePresenter(view);
        }
    }
}
