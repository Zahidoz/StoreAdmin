using StoreAdmin.Commands;
using StoreAdmin.Models;
using StoreAdmin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StoreAdmin.ViewModels
{
    public class EditViewModel
    {
        public Car car { get; set; }
        public RelayCommand saveCommand { get; set; }


        public EditViewModel()
        {

            saveCommand = new RelayCommand(
                action => { 
                    MessageBox.Show("Saved");
                },
                predicate => true
                );
        }
    }
}
