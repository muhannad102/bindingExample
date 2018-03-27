using bindingExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            for (int i = 0; i < 10; i++)
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

            get { return openDepartmentWithNumbers ?? new RelayCommand(viewDepartmentUsingId); }
            set => openDepartmentWithNumbers = value;

        }

        private void viewDepartment(object obj)
        {
            App.UIM.showMessage((Department)obj);
        }

        private void viewDepartmentUsingId(object obj)
        {
            var e = (KeyEventArgs)obj;
            if (keyIntMapping.ContainsKey(e.Key))
            {
                App.UIM.showMessage(D.FirstOrDefault(d => d.Id == keyIntMapping[e.Key]));

            }

           
        }

   

    }
}
