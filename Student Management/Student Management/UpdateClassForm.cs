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
    public partial class UpdateClassForm : Form
    {
        private int ClassId;
        private ClassManagement Business;
        public UpdateClassForm(int id)
        {
            InitializeComponent();
            this.ClassId = id;
            this.Business = new ClassManagement();
            this.btnSave.Click += btnSave_Click;
            this.btnCannel.Click += btnCannel_Click;
            this.Load += UpdateClassForm_Load;
        }

        void UpdateClassForm_Load(object sender, EventArgs e)
        {
            var @class = this.Business.GetClass(this.ClassId);
            this.txtClassName.Text = @class.Name;
            this.txtDescription.Text = @class.Description;
        }

        void btnCannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtClassName.Text;
            var description = txtDescription.Text;
            this.Business.EditClass(this.ClassId, name, description);
            MessageBox.Show("Update class successfully");
            this.Close();
        }
    }
}
