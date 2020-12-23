using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public interface ITransportView
    {
        void Start();
        void Stop();
        void CreateVihecle();
        void CreateFuels();
        void ShowAllVehicles();
        bool TxtChecked();
        bool DocChecked();
        List<ToolStripProgressBar> GetProgressBArList();
        List<PictureBox> GetPictureBoxWithVehicle();
        List<RichTextBox> GetVehiclelogs();
    }
}
