using System;
using System.Reflection;
using System.Windows.Forms;
using UIGeneratorApp.Helper;

namespace UIGeneratorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private PropertyInfo[] NavigateIntoClass(object obj)
        {
            Type type = obj.GetType();
            return type.GetProperties();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbNone.Checked = true;

        }

        private void rbPerson_CheckedChanged(object sender, EventArgs e)
        {

            rbNone.Visible = false;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(clsHelper.PaintUI(NavigateIntoClass(new Person())));
        }

        private void rbOrder_CheckedChanged(object sender, EventArgs e)
        {

            rbNone.Visible = false;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(clsHelper.PaintUI(NavigateIntoClass(new Order())));
        }

        private void rbEmployee_CheckedChanged(object sender, EventArgs e)
        {

            rbNone.Visible = false;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(clsHelper.PaintUI(NavigateIntoClass(new Employee())));
        }

      
    }
}
