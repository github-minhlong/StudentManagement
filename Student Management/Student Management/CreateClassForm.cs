using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class CreateClassForm : Form
    {
        private ClassManagement Business;
        public CreateClassForm()
        {
            this.Business = new ClassManagement();
            InitializeComponent();
            this.btnSave.Click += btnSave_Click;
            this.btnCannel.Click += btnCannel_Click;
        }

        void btnCannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var name = this.txtClassName.Text;
            var description = this.txtDescription.Text;
            this.Business.AddClass(name, description);
            MessageBox.Show("Create class successfully");
        }
    }
}
