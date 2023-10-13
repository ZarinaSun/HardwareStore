using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HardwareStore_Zarina.Component
{
    /// <summary>
    /// Логика взаимодействия для Technica.xaml
    /// </summary>
    public partial class Technica : Page
    {
        public Technica(Image image, string Title, int Evaluation, int Cost, int Discount)
        {
            InitializeComponent();
            TechnImage.Text = Title;
            EvaluationTechn.Text = Evaluation;
            CostTechn.Text = Cost;
            DiscountTB.Text = Discount;
        }
    }
}
