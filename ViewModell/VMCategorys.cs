using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika27.ViewModell
{
    public class VMCategories : INotifyPropertyChanged
    {
        public ObservableCollection<Context.CategoriesContext> Categories { get; set; }
        public VMCategories() =>
            Categories = Context.CategoriesContext.AllCategories();

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
