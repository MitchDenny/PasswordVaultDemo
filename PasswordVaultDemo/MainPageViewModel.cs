using PasswordVaultDemo.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Security.Credentials;
using Windows.UI.Popups;

namespace PasswordVaultDemo
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            AddCredentialCommand = new RelayCommand(AddCredential);
        }

        public ICommand AddCredentialCommand { get; private set; }

        public async void AddCredential()
        {
            var dialog = new MessageDialog("This dialog will allow you to add a credential.", "Add Credential");
            await dialog.ShowAsync();
        }

        public ICommand RemoveCredentialCommand { get; private set; }

        public async void RemoveCredential()
        {
            var dialog = new MessageDialog("This dialog will prompt you to confirm removing credentials.", "Remove Credetial");
            await dialog.ShowAsync();
        }

        public IEnumerable<PasswordCredential> Credentials { get; set; }
    }
}
