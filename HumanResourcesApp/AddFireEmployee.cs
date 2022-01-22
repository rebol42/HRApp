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
    public partial class frmAddFireEmployee : Form
    {
        private HRFunctions<List<Employee>> _hrFunctions = new HRFunctions<List<Employee>>(Program.FilePath);
        private int _emplId;

        private Employee _editEmpl;


        public frmAddFireEmployee()
        {
            InitializeComponent();
            PopulateEmplData();
            tbId.Text = _emplId.ToString();
            InitEmplStatusComboBox();
            SetDefaultDates();
        }


        public frmAddFireEmployee(int emplId)
        {
            InitializeComponent();
            _emplId = emplId;
            InitEmplStatusComboBox();
            PopulateEmplData();

        }

        private void PopulateEmplData()
        {
            var employee = _hrFunctions.DeserializeFromFile();

            if (_emplId != 0)
            {
                
                _editEmpl = employee.FirstOrDefault(x => x.Id == _emplId);

                if (_editEmpl == null)
                    throw new Exception("Brak pracownika o podanym id");

                FillFields();
            }
            else
            {
                CheckMAxId(employee);
            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var emlpoyees = _hrFunctions.DeserializeFromFile();

            if (_editEmpl != null)
            {
                emlpoyees.RemoveAll(x => x.Id == _editEmpl.Id);
            }

            AddNewEmlpoyeeToList(emlpoyees);
        }


        private void FillFields()
        {
            tbId.Text = _editEmpl.Id.ToString();
            tbFirstName.Text = _editEmpl.FirstName;
            tbLastName.Text = _editEmpl.LastName;
            rtbComments.Text = _editEmpl.Comments;
            tbPersonalCode.Text = _editEmpl.Pesel;
            tbStreet.Text = _editEmpl.Street;
            tbCity.Text = _editEmpl.City;
            tbZipCode.Text = _editEmpl.ZipCode;
            dateEmploy.Value = _editEmpl.EmploymentDate;
            dateLayOff.Value = _editEmpl.LayOffDate;
            dateBirthDate.Value = _editEmpl.BirthDate;
            cmbEmplStatus.SelectedItem = _editEmpl.EmplStatus;
        }

        private void InitEmplStatusComboBox()
        {
            cmbEmplStatus.DataSource =  Enum.GetValues(typeof(EmplStatus));
          
        }

        private void AddNewEmlpoyeeToList(List<Employee> employees)
        {

            var employee = new Employee
            {
                Id = _emplId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Comments = rtbComments.Text,
                BirthDate = dateBirthDate.Value,
                Pesel = tbPersonalCode.Text,
                Street = tbStreet.Text,
                City = tbCity.Text,
                ZipCode = tbZipCode.Text,
                EmploymentDate = dateEmploy.Value,
                LayOffDate = dateLayOff.Value,
                EmplStatus = (EmplStatus)cmbEmplStatus.SelectedItem

            };

            employees.Add(employee);

            _hrFunctions.SerializeToFile(employees);
            Close();
        }


        private void CheckMAxId(List<Employee> employees)
        {
            var emplMaxid = employees.OrderByDescending(x => x.Id).FirstOrDefault();
            _emplId = emplMaxid == null ? 1 : emplMaxid.Id + 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

  

        private void cmbEmplStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime? clearDate = null;
            if(cmbEmplStatus.SelectedIndex == (int)EmplStatus.zwolniony)
            {
                dateLayOff.Value = DateTime.Now;
            }
            else
            {
                dateLayOff.Value = new DateTime(1901, 01, 01);
            }

        }

        private void SetDefaultDates()
        {
            dateLayOff.Value = new DateTime(1901, 01, 01);
            dateEmploy.Value = new DateTime(1901, 01, 01);
            dateBirthDate.Value = new DateTime(1901, 01, 01);

        }
    }
}
