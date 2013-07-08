using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using MVVM_Sample.Models;

namespace MVVM_Sample.ViewModels
{
    public class DragControlViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        public void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        private readonly DragControlModel _model = new DragControlModel();


        public Point Position
        {
            get { return _model.Position; }
            set
            {
                _model.Position = value;
                OnPropertyChanged("Position");
            }
        }

        public string Content
        {
            get { return _model.Content; }
            set
            {
                _model.Content = value;
                OnPropertyChanged("Content");
            }
        }
    }
}
