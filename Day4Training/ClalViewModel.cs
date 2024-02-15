using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Day4Training
{
    public class ClalViewModel : INotifyPropertyChanged
    {
        public ClalViewModel() {


            AddCommand = new Command(() =>
            {
                Result = Add().ToString();
            });

            SubCommand = new Command(() =>
            {
                Result = Sub().ToString();
            });

            MulCommand = new Command(() =>
            {
                Result = Mul().ToString();
            });

            DivCommand = new Command(() =>
            {
                Result = Div().ToString();
            });


        }
        int _num1;    
        int _num2;
        string _result;

        public int Num1
        {
            get => _num1; 
            set
            {
                _num1 = value; var args = new PropertyChangedEventArgs(nameof(Num1));
                PropertyChanged?.Invoke(this, args);
            }
        }
      
        public int Num2
        {
            get => _num2;
            set
            {
                _num2 = value; var args = new PropertyChangedEventArgs(nameof(Num2));
                PropertyChanged?.Invoke(this, args);
            }
        }
        public string Result
        {
            get => _result;
            set
            {
                _result = value; var args = new PropertyChangedEventArgs(nameof(Result));
                PropertyChanged?.Invoke(this, args);
            }
        }
       


        public int Add()
        {
            return Num1 + Num2;


        }

        public int Sub()
        {
            return Num1 - Num2;


        }
        public int Mul()
        {
            return Num1 * Num2;


        }
        public int Div()
        {
            
           

            return Num1 / Num2;


        }



        public Command AddCommand { get;  }
        public Command SubCommand { get;  }
        public Command MulCommand { get;  }
        public Command DivCommand { get;  }
      
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
