using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MultiProzori
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		ObservableCollection<Osoba> Osobe { get; set; } = new();
		public MainWindow()
		{
			InitializeComponent();
			dg.ItemsSource = Osobe;
			
		}

		private void Kliik(object sender, RoutedEventArgs e)
		{
			Prozor2 p = new();
			p.Owner = this;
			p.ShowDialog();
			if (p.SveOk)
				Osobe.Add(p.DataContext as Osoba);

		}
	}
}
