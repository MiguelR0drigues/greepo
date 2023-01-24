using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greepo
{
    public partial class project : Form
    {
        private int _projectId;
        public project(int projectId)
        {
            InitializeComponent();
            _projectId = projectId;
        }

        private void lblProjectTitle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
