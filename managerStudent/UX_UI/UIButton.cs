using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerStudent.UX_UI
{
    internal class UIButton : Button
    {
        public UIButton()
        {
            // Cài đặt mặc định
            SetButtonColor(Color.Red, Color.White);
        }
        public void SetButtonColor(Color backGroundColor, Color fontColor)
        {
            this.BackColor = backGroundColor;
            this.ForeColor = fontColor; 
        }
    }
}
