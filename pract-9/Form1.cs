using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract_9
{
    public enum gender
    {
        male, 
        female
    }
    public struct Person
    {
        string firstName;
        string secondName;
        string middleName;
        gender gender;        
        int yearBorn;
        string placeBorn;
        string nationality;

        public Person(string namePerson, string surname, string middleNamePerson, gender genderPerson, int year, string place, string nation)
        {
            firstName = namePerson;
            secondName = surname;
            middleName = middleNamePerson;
            gender = genderPerson;
            yearBorn = year;
            placeBorn = place;
            nationality = nation;            
        }

        public void ThrowAnswer(DataGridView dgv, int row)
        {
            dgv[0, row].Value = firstName;
            dgv[1, row].Value = secondName;
            dgv[2, row].Value = middleName;
            dgv[3, row].Value = gender;
            dgv[4, row].Value = yearBorn;
            dgv[5, row].Value = placeBorn;
            dgv[6, row].Value = nationality;
        }
       
    }

    public partial class Form1 : Form
    {
        public List<Person> persons = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void GetAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
