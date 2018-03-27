using bindingExample.View;
using bindingExample.Model;
using System;

namespace bindingExample
{
    public class UIManager : PropertyObservable, IUIManager 
    {
        private bool isBusy;

        public bool IsBusy { get => isBusy; set { isBusy = value; OnPropertyChanged("IsBusy"); } }

      
        public void makeBusy(bool b) {

            IsBusy = b;

        }

        public void showMessage(Department d)
        {

            DepartmentInfoView div = new DepartmentInfoView();
            div.DataContext = d;
            div.Show();
            
        }

        public bool applicationStatus() {
            return !isBusy;
        }

    }
}
