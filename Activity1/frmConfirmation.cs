using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity1
{
    public partial class frmConfirmation : Form
    {
        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = frmRegistration.StudentInformationClass.SetStudentNo.ToString();
            lblName.Text = frmRegistration.StudentInformationClass.SetFullName;
            lblProgram.Text = frmRegistration.StudentInformationClass.SetProgram;
            lblBirthday.Text = frmRegistration.StudentInformationClass.SetBirthday;
            lblGender.Text = frmRegistration.StudentInformationClass.SetGender;
            lblContactNo.Text = frmRegistration.StudentInformationClass.SetContactNo.ToString();
            lblAge.Text = frmRegistration.StudentInformationClass.SetAge.ToString();
        }
    }
 }

