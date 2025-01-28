
using System.Windows.Controls;

namespace WPF_Pruebas.Domain.UIServices;
public class Navigator
{
    // Patron de Diseño Singleton
    private static Navigator? _instance;
    private MainWindow? _mainWindow;


    private Navigator() { }

    public static Navigator Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Navigator();
            return _instance;
        }
    }

    public void Init(MainWindow mainWindow)
    {
        _mainWindow = mainWindow;
    }


 

}
