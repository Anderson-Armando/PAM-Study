using CommunityToolkit.Mvvm.ComponentModel;
using PAM_Study.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PAM_Study.viewModels
{
    public class MonitorViewModels : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Models.Monitor> monitores;

        public MonitorViewModels()
        {
            getMonitoresCommand = new Command(getMonitores);
            getMonitoresCommand.Execute(this);

        }

        private ICommand getMonitoresCommand { get; }

        public async void getMonitores()
        {
            monitores = await new MonitorService().getAllMonitorsAsync();
        }

    }
}
