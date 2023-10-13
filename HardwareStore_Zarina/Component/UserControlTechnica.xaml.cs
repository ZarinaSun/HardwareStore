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
    /// Логика взаимодействия для UserControlTechnica.xaml
    /// </summary>
    public partial class UserControlTechnica : UserControl
    {
        public UserControlTechnica(Image image, string Title, int Evaluation, int Cost, int Discount)
        {
            InitializeComponent();
            EvaluationTechn.Text = Evaluation.ToString();
            CostTechn.Text = Cost.ToString();
            DiscountTB.Text = Discount.ToString();
        }
    }
}
