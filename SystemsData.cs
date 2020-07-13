using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionManager
{
    class SystemsData : ObservableCollection<string>
    {
        public SystemsData() : base()
        {
            Add("Fate Core");
            Add("DnD 5e");
            Add("Warhammer");
        }

    }

    public class Systems
    {
        private string name;

        public Systems(string SystemName)
        {
            this.name = SystemName;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private ObservableCollection<Systems> _systems;
    }

}
