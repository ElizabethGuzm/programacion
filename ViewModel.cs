using collection.MVVM.Models;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace collection.MVVM.ViewModels;

public class ViewModel : BindableObject
{
	public ObservableCollection<Grupos> Grupo { get; set; }
	public ViewModel()
	{
		Grupo = new ObservableCollection<Grupos>();
		new Grupos 
		{
			Image ="amarillo.png",
            Name= "Amarillo",
		};
    new Grupos
          {
              Image = "cafe.png",
              Name="Cafe",
          };
new Grupos
          {
              Image = "morado.png",
              Name = "Morado"
          };
new Grupos
{
    Image = "naranja.png",
    Name = "Naranja",
};
new Grupos
{
    Image = "rojo.png",
    Name = "Rojo",
};
new Grupos
{
    Image = "verde.png",
    Name = "Verde",
};
	}
}