using bindingExample.View;
using bindingExample.Model;

namespace bindingExample
{
    public class UIManager : IUIManager
    {
        public void showMessage(Department d)
        {

            DepartmentInfoView div = new DepartmentInfoView();
            div.DataContext = d;
            div.Show();
            
        }
    }
}
