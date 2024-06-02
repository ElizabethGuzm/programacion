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
		Grupo.Add(new Grupos
		{
			Image ="amarillo.png",
		});
    Grupo.Add(new Grupos
          {
              Image = "cafe.png",
          });
Grupo.Add(new Grupos
          {
              Image = "morado.png",
          });
Grupo.Add(new Grupos
{
    Image = "naranja.png",
});
Grupo.Add(new Grupos
{
    Image = "rojo.png",
});
Grupo.Add(new Grupos
{
    Image = "verde.png",
});
	}
}