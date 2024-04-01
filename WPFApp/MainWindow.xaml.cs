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

            //Expresión Lambda:
            //(parámetros de entrada) => Expresión
            //EJ: () => Expresión
            // El operador lambda (=>) se lee como "Va Hacia"

            Task T3A = new Task(ShowMessage);
            Task T3 = new Task(() => ShowMessage());

            Task T4 = new Task(() => MessageBox.Show("Ejecutando la tarea 4"));

            Task T5 = new Task(() =>
                {
                    DateTime CurrentDate = DateTime.Today;
                    DateTime StartDate = CurrentDate.AddDays(30);
                    MessageBox.Show($"Tarea 5. Fecha Calculada: {StartDate}");
                }
                );

            Task T6 = new Task((message) => 
            MessageBox.Show(message.ToString()), "Expresión Lambda con parámetros");
        }

        void ShowMessage()
        {
            MessageBox.Show("Ejecutando el método ShowMessage");
        }


    }
}