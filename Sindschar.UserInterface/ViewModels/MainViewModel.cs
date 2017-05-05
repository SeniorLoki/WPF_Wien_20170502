using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Sindschar.Core.Interfaces;
using Sindschar.Core.Models;
using System.Collections.ObjectModel;

namespace Sindschar.UserInterface.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public MainViewModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        private ObservableCollection<Employee> _employees;
        public ObservableCollection<Employee> Employees
        {
            get { return _employees; }
            set { Set(ref _employees, value); }
        }

        private Employee _selectedEmployee;
        public Employee SelectedEmployee
        {
            get { return _selectedEmployee; }
            set { Set(ref _selectedEmployee, value); }
        }


        private RelayCommand _initialzeCommand;
        public RelayCommand InitializeCommand
        {
            get
            {
                return _initialzeCommand ??
                    (_initialzeCommand = new RelayCommand(
                        () => Employees = new ObservableCollection<Employee>(_employeeRepository.GetAll())));
            }
        }

        private RelayCommand<Employee> _deleteCommand;
        public RelayCommand<Employee> DeleteCommand
        {
            get
            {
                return _deleteCommand ??
                    (_deleteCommand = new RelayCommand<Employee>(
                        e => Employees.Remove(e)));
            }
        }
    }
}