using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VinyStore
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContaListView : ContentView
	{
		public ContaListView ()
		{
			InitializeComponent ();
		}
	}
}