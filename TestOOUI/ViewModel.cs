using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace TestOOUI
{
    public class ViewModel:INotifyPropertyChanged
    {
        private ObservableCollection<Projects> _projects;
        public ViewModel()
        {
            _projects = new ObservableCollection<Projects>();
            // Insert customer and corresponding order information into 
            Projects c = new Projects() { ID = 1, Name = "Project Cool" };
            c.Info.Add(new Info() { ID = 1, Date = new DateTime(2018, 1, 1), Skill = "UX" });
            c.Info.Add(new Info() { ID = 1, Date = new DateTime(2018, 2, 1), Skill = "DB" });
            c.Info.Add(new Info() { ID = 1, Date = new DateTime(2018, 11, 10), Skill = "Cloud" });
            _projects.Add(c);
            c = new Projects() { ID = 2, Name = "Project Awesome" };
            c.Info.Add(new Info() { ID = 1, Date = new DateTime(2018, 1, 1), Skill = "CSS" });
            c.Info.Add(new Info() { ID = 1, Date = new DateTime(2018, 2, 1), Skill = "HTML" });
            _projects.Add(c);
            c = new Projects() { ID = 3, Name = "Project NANO" };
            c.Info.Add(new Info() { ID = 1, Date = new DateTime(2018, 1, 1), Skill = "HTML" });
            c.Info.Add(new Info() { ID = 1, Date = new DateTime(2018, 2, 1), Skill = "SEO" });
            c.Info.Add(new Info() { ID = 1, Date = new DateTime(2018, 11, 10), Skill = "JSON" });
            c.Info.Add(new Info() { ID = 1, Date = new DateTime(2018, 11, 10), Skill = "PHP" });
            c.Info.Add(new Info() { ID = 1, Date = new DateTime(2018, 11, 10), Skill = "CSS" });
            _projects.Add(c);
            c = new Projects() { ID = 4, Name = "Project Cheese" };
            c.Info.Add(new Info() { ID = 1, Date = new DateTime(2018, 1, 1), Skill = "JS" });
            _projects.Add(c);
        }
        public ObservableCollection<Projects> Projects
        {
            get { return _projects; }
        }
        #region INotifyPropertyChanged Members 
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion

    }
    public class Projects : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private ObservableCollection<Info> _info
            = new ObservableCollection<Info>();
        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public ObservableCollection<Info> Info
        {
            get { return _info; }
        }
        #region INotifyPropertyChanged Members 
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion
    }
    public class Info : INotifyPropertyChanged
    {
        private int _id;
        private DateTime _date;
        private string _skill;
        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged("Date");
            }
        }
        public string Skill
        {
            get { return _skill; }
            set
            {
                _skill = value;
                OnPropertyChanged("Skill");
            }
        }
        #region INotifyPropertyChanged Members 
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion
    }


}
