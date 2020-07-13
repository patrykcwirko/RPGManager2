using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionManager.Database
{
    class SystemFateModel
    {
		private List<string> aspect = new List<string>(5);
		private List<string> ability5 = new List<string>(5);
		private List<string> ability4 = new List<string>(5);
		private List<string> ability3 = new List<string>(5);
		private List<string> ability2 = new List<string>(5);
		private List<string> ability1 = new List<string>(5);

		public List<string> Aspect
		{
			get { return aspect; }
			set { aspect = value; }
		}
		public List<string> Ability5
		{
			get { return ability5; }
			set { ability5 = value; }
		}
		public List<string> Ability4
		{
			get { return ability4; }
			set { ability4 = value; }
		}
		public List<string> Ability3
		{
			get { return ability3; }
			set { ability3 = value; }
		}
		public List<string> Ability2
		{
			get { return ability2; }
			set { ability2 = value; }
		}
		public List<string> Ability1
		{
			get { return ability2; }
			set { ability2 = value; }
		}


	}
}
