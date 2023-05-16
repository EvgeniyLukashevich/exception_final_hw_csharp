using personDataInput.Data;
using personDataInput.Models;
using personDataInput.MVP;

class Program
{
    static void Main(string[] args)
    {
        Presenter presenter = new Presenter(new ModelFirst(), new ViewConsole(), new DataFirst());
        presenter.Start();
    }

}
