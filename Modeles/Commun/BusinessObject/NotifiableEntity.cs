namespace Modeles.Commun.BusinessObject
{
    using System.ComponentModel;

    public abstract class NotifiableEntity<T> : INotifyPropertyChanged
    {
        public virtual event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(T obj, string p)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(obj, new PropertyChangedEventArgs(p));
            }
        }

    }
}
