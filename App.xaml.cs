using collection.MVVM.View;

namespace collection
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DataView();
        }
    }
}
