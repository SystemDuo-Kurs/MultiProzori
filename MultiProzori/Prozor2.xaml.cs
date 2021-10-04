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
using System.Windows.Shapes;

namespace MultiProzori
{
	/// <summary>
	/// Interaction logic for Prozor2.xaml
	/// </summary>
	public partial class Prozor2 : Window
	{
		public bool SveOk;
		public Prozor2()
		{
			InitializeComponent();
			DataContext = new Osoba();
		}

		private void Unos(object sender, RoutedEventArgs e)
		{
			Osoba o = DataContext as Osoba;
			if (!(string.IsNullOrEmpty(o.Ime) || string.IsNullOrWhiteSpace(o.Ime)))
			{
				o.Ime = o.Ime.Trim();
				SveOk = true;
				Close();
			} else
			{
				MessageBox.Show("GRRRRRR");
			}
		}
	}
}
