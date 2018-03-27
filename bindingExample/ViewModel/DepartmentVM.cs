using bindingExample.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace bindingExample.ViewModel
{
    public class DepartmentVM : PropertyObservable
    {
        Dictionary<Key,int> keyIntMapping = new Dictionary<Key,int>();
        int count;
        List<Department> d = new List<Department>();
        public DepartmentVM()
        {
            keyIntMapping.Add(Key.NumPad1, 1);
            keyIntMapping.Add(Key.NumPad2, 2);
            keyIntMapping.Add(Key.NumPad3, 3);
            keyIntMapping.Add(Key.NumPad4, 4);
            keyIntMapping.Add(Key.NumPad5, 5);
            keyIntMapping.Add(Key.NumPad6, 6);
            keyIntMapping.Add(Key.NumPad7, 7);
            keyIntMapping.Add(Key.NumPad8, 8);
            keyIntMapping.Add(Key.NumPad9, 9);


            createDepartments();

        }
        public List<Department> D { get => d; set => d = value; }
    

        public void createDepartments()
        {
            for (int i = 0; i < 5; i++)
            {

                Department department = new Department();
                department.Id = ++count;
                department.name = "Department" + department.Id;
                d.Add(department);

            }


        }

        private ICommand departmentClick;
        public ICommand DepartmentClick { get => departmentClick?? new RelayCommand(viewDepartment); set => departmentClick = value; }


        private ICommand openDepartmentWithNumbers;
        public ICommand OpenDepartmentWithNumbers
        {

            get {

                return openDepartmentWithNumbers ?? new RelayCommand(viewDepartmentUsingId, canExecute => App.UIM.applicationStatus()); }
            set => openDepartmentWithNumbers = value;

        }

        private ICommand makeBusy;
        public ICommand MakeBusy {

            get { return makeBusy ?? new RelayCommand(makeBusyAsync); }
            set => makeBusy = value;

        }

        private void viewDepartment(object obj)
        {
            App.UIM.showMessage((Department)obj);
        }

        private void viewDepartmentUsingId(object obj)
        {
            KeyEventArgs e = (KeyEventArgs)obj;
            if (keyIntMapping.ContainsKey(e.Key) && keyIntMapping[e.Key] <= D.Count())
            {
                App.UIM.showMessage(D.FirstOrDefault(d => d.Id == keyIntMapping[e.Key]));

            }

           
        }

     private async void makeBusyAsync(object obj) {

            App.UIM.makeBusy(true);

             await Task.Run(()=> { Thread.Sleep(5000); });

            App.UIM.makeBusy(false);


        }

    }
}
