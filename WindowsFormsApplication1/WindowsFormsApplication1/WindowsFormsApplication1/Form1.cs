using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        clsResize _form_resize;

        public Form1()
        {
            InitializeComponent();

            _form_resize = new clsResize(this);//I put this after the initialize event to be sure that all controls are initialized properly
           this.Load += new EventHandler(_Load); //This will be called after the initialization // form_load
           this.Resize += new EventHandler(_Resize); //form_resize
        }
        private void _Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }

        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Form2();
            f.Show();
        }
    }
}
