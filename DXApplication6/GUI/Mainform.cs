using DevExpress.XtraEditors;
using DXApplication6.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication6
{
    public partial class Mainform : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
           
        private void ManageCourse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new ManageCourse();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void ManageStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new ManageStudent();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void ManageLecturer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new ManageLecturer();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

       
        private void SVThiMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new SVthimôn();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void GVDayMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new GVdaymon();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private bool ExistForm(Form form)
        {
            foreach( var child in MdiChildren)
            {
                if(child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
 
    }
}
