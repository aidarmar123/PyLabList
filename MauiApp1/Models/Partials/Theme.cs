using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public partial class Theme
    {
        private bool isExpanded;
        public bool IsExpanded { get; set; } = false;
        //{
        //    get => isExpanded;
        //    set
        //    {
        //        if (isExpanded != value)
        //        {
        //            isExpanded = value;
        //            OnPropertyChanged(nameof(IsExpanded));
        //        }
        //    }
        //}

        //public event PropertyChangedEventHandler PropertyChanged;

        //protected virtual void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}
