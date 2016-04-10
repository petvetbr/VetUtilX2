using System;
using Xamarin.Forms;

namespace VetUtilX2
{
    public class MasterPageItem: BindableObject
    {
        string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged(nameof(Title));
                }
            }
        }
        string _IconSource;
        public string IconSource
        {
            get
            {
                return _IconSource;
            }
            set
            {
                if (_IconSource != value)
                {
                    _IconSource = value;
                    OnPropertyChanged(nameof(IconSource));
                }
            }
        }
        Type _TargetType;
        public Type TargetType
        {
            get
            {
                return _TargetType;
            }
            set
            {
                if (_TargetType != value)
                {
                    _TargetType = value;
                    OnPropertyChanged(nameof(TargetType));
                }
            }
        }


    }
}