using PropertyChanged;
using System.ComponentModel;

namespace Plex
{
    /// <summary>
    /// A base view model that fires property changed events
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The event that is fired when any child property changes it's value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => {};
        
        
        /// <summary>
        /// Call this to fire a <see cref="PropertyChanged"/>
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }



}
