using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenter;
using View;

namespace Transport
{
    public partial class Log : Form, ILogView
    {
        private LogPresenter _presenter;
        public Log()
        {
            InitializeComponent();
            _presenter = new LogPresenter(this);
        }

        public void SetLogs(List<string> LogString)
        {
            richTextBox1.Text = String.Join("\n ", LogString);
        }
    }
}
