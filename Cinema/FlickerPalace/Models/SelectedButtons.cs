using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickerPalace.Models
{
    public class SelectedButtons
    {
        public MovieSchedule Movie { get; set; }
        public string ButtonName { get; set; }
        public bool IsChecked { get; set; }
    }
}
