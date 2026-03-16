using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika27.ViewModell
{
    public class VMItems : INotifyPropertyChanged
    {
       
        public ObservableCollection<Context.ItemsContext> Items { get; set; }
    
        public Classes.RelayCommand NewItem
        {
            get
            {
                return new Classes.RelayCommand(obj => { 
                    Context.ItemsContext newModel = new Context.ItemsContext(true);
                    Items.Add(newModel);
                    MainWindow.init.frame.Navigate(new View.Add(newModel));
                });
            }
        }
        public VMItems() =>
            Items = Context.ItemsContext.AllItems();
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
