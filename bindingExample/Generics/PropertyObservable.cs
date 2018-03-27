﻿
using System.ComponentModel;


namespace bindingExample {

    public class PropertyObservable : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName) {

            PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if (propertyChanged != null)

                propertyChanged(this, new PropertyChangedEventArgs(propertyName));

        }

    }
}