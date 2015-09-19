using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test__txt_Kommunikation
{
    class Controller
    {
        private Gui gui;
        public Controller(Gui gui)
        {
            this.gui = gui;
            gui.buttonClick += OnButtonClick;
        }

        private void OnButtonClick(object sender, ClickEventArgs e)
        {
            gui.WriteText(e.text);
        }

    }
}
