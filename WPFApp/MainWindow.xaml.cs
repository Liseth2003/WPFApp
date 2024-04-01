using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void CreateTask()
        {
            Task T;
            // ¿Qué es un delegado? Apuntadores a funciones.
            // EJEMPLO: Action y Func
            Action Code = new Action(ShowMessage);
            T = new Task(Code);
            Task T2 = new Task(delegate
            {
                MessageBox.Show("Ejecutando una tarea en un método anónimo.");
            }
            );

        }

        void ShowMessage()
        {
            MessageBox.Show("Ejecutando el método ShowMessage");
        }


    }
}