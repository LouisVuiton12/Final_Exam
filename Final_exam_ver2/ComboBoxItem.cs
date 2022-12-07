using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_exam_ver2
{
    public class ComboBoxItem
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
        public ComboBoxItem(string id, string name) => (ID, Name) = (id, name);
    }
}
