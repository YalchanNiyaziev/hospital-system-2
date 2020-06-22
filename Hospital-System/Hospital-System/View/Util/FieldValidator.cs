using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System.View.Util
{
    static class FieldValidator
    {
        public static bool HasEmptyFields(Control[] controls)
        {
            bool hasEmpty = false;
            foreach (var c in controls)
            {
                if (string.IsNullOrEmpty(c.Text))
                {
                    hasEmpty = true;
                    break;
                }
            }
            return hasEmpty;
        }
        
    }
}
