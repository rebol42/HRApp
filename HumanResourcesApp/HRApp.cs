using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourcesApp
{
    public partial class frmHR : Form
    {

        private HRFunctions<List<Employee>> _hrFunctions = new HRFunctions<List<Employee>>(Program.FilePath);
    //    List<EmplStatus> _emplStatus = EmplStatus;

        public frmHR()
        {
            InitializeComponent();
            RefreshDiary();
            SetColumnsHeader();
            InitSelectEmpl();

        }

        private void InitSelectEmpl()
        {
            cbSelectEmpl.Items.Add("Wszyscy");
            cbSelectEmpl.Items.Add(EmplStatus.zatrudniony);
            cbSelectEmpl.Items.Add(EmplStatus.zwolniony);
        }

        private void SetColumnsHeader()
        {
            dgfHR.Columns[0].HeaderText = "Numer";
            dgfHR.Columns[1].HeaderText = "Imię";
            dgfHR.Columns[2].HeaderText = "Nazwisko";
            dgfHR.Columns[3].HeaderText = "Pesel";
            dgfHR.Columns[4].HeaderText = "Data urodzenia";
            dgfHR.Columns[5].HeaderText = "Ulica";
            dgfHR.Columns[6].HeaderText = "Kod pocztowy";
            dgfHR.Columns[7].HeaderText = "Miasto";
            dgfHR.Columns[8].HeaderText = "Data zatrudnienia";
            dgfHR.Columns[9].HeaderText = "Data zwolnienia";
            dgfHR.Columns[10].HeaderText = "Status pracy";
           // dgfHR.Columns[11].HeaderText = "Data zwolnienia";

        }

        private void RefreshDiary()
        { 
            var employee = _hrFunctions.DeserializeFromFile();
            dgfHR.DataSource = employee;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddFireEmployee addFireEmpl = new frmAddFireEmployee();
            addFireEmpl.ShowDialog();
            RefreshDiary();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddFireEmployee addFireEmpl = new frmAddFireEmployee(
                Convert.ToInt32(dgfHR.SelectedRows[0].Cells[0].Value));
            addFireEmpl.ShowDialog();
            RefreshDiary();
        }

        private void cbSelectEmpl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = cbSelectEmpl.SelectedIndex;
          
            SelectEmplByStatus(value);
        }

        private void SelectEmplByStatus(int value)
        {
            var employees = _hrFunctions.DeserializeFromFile();

            switch(value)
            {
                case 2:
                    employees = employees.Where(x => x.EmplStatus == EmplStatus.zwolniony).ToList();
                break;

                case 1:
                    employees = employees.Where(x => x.EmplStatus == EmplStatus.zatrudniony).ToList();
                break;
            }

            dgfHR.DataSource = employees;
        }
    }
}
