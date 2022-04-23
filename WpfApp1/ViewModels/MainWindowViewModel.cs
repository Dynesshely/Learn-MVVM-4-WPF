using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Commands;

namespace WpfApp1.ViewModels
{
    internal class MainWindowViewModel : NotificationObject
    {
        private double input1;

        public double Input1
        {
            get { return input1; }
            set
            {
                input1 = value;
                RaisePropertyChanged(nameof(Input1));
            }
        }

        private double input2;

        public double Input2
        {
            get { return input2; }
            set
            {
                input2 = value;
                RaisePropertyChanged(nameof(Input2));
            }
        }

        private double result;

        public double Result
        {
            get { return result; }
            set
            {
                result = value;
                RaisePropertyChanged(nameof(Result));
            }
        }

        public DelegateCommand? AddCommand { get; set; }
        public DelegateCommand? SaveCommand { get; set; }

        private void Add(object _)
        {
            Result = Input1 + Input2;
        }

        private void Save(object _)
        {
            SaveFileDialog sfd = new();
            sfd.ShowDialog();
        }

        public MainWindowViewModel()
        {
            AddCommand = new();
            AddCommand.ExecuteAction = new(Add);
            SaveCommand = new();
            SaveCommand.ExecuteAction = new(Save);
        }


    }
}
