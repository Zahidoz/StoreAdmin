using StoreAdmin.Commands;
using StoreAdmin.Models;
using StoreAdmin.Repos;
using StoreAdmin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StoreAdmin.ViewModels
{
    class MainViewModel
    {
        public Car car { get; set; }
        public List<Car> cars { get; set; } 
        public RelayCommand showInfo { get; set; } 
        public RelayCommand editInfo { get; set; }

        public EditViewModel editViewModel { get; set; }

        public MainViewModel()
        { 
            car = new Car
            {
                Id = 1,
                Vendor = "Porche",
                Model = "Chayene",
                Year = 2021
            };

            cars = new FakeRepo().cars;

            showInfo = new RelayCommand(
                a => { MessageBox.Show($"{car.Vendor} - {car.Model} - {car.Year}"); },
                p => true
                );

            editInfo = new RelayCommand(

                action =>
                {
                    editViewModel = new EditViewModel();
                    editViewModel.car = car;

                    var editView = new EditWindow();
                    editView.DataContext = editViewModel;
                    editView.ShowDialog();
                },
                predicate => true
            );
            

            
        }
    }
}
