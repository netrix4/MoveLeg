using MoveLegRef.Bussines;
using MoveLegRef.Forms;
using MoveLegRef.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveLegRef
{
    public partial class MoveLegMain : Form
    {
        private SeleccionMenu _seleccionMenu = new SeleccionMenu();

        public MoveLegMain()
        {
            InitializeComponent();
            _seleccionMenu.FormClosed += (s, args) => this.Close();
        }
        private async void MoveLegMain_Load(object sender, EventArgs e)
        {
            await Task.Delay(4000);

            this.Hide();
            _seleccionMenu.Show();
        }
    }
}
