using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace HalloMVVM.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void OnPropertyChanged<T>(Expression<Func<T>> propertyExpression)
        {
            var body = propertyExpression.Body as MemberExpression;
            OnPropertyChanged(body.Member.Name);
        }

        public void SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if(field == null || !field.Equals(value))
            {
                field = value;
                OnPropertyChanged(propertyName);
            }
        }

        public void SetProperty<T>(ref T field, T value, Expression<Func<T>> propertyExpression)
        {
            if (field == null || !field.Equals(value))
            {
                field = value;
                var body = propertyExpression.Body as MemberExpression;
                OnPropertyChanged(body.Member.Name);
            }
        }
    }
}
