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
        мужчина, 
        женщина
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
        public int id = 0;

        public Form1()
        {
            InitializeComponent();
            tablePeople.ColumnCount = 7;
            tablePeople.RowCount = 1;
            tablePeople.Columns[0].Name = "Имя";
            tablePeople.Columns[1].Name = "Фамилия";
            tablePeople.Columns[2].Name = "Отчество";
            tablePeople.Columns[3].Name = "Пол";
            tablePeople.Columns[4].Name = "Год рождения";
            tablePeople.Columns[5].Name = "Место рождения";
            tablePeople.Columns[6].Name = "Национальность";
        }

        private void GetAnswer_Click(object sender, EventArgs e)
        {

        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            tablePeople.RowCount++;            
            gender maleFemale;            
            if (genderMale.Checked == true)
            {
                maleFemale = gender.мужчина;
            }
            else maleFemale = gender.женщина;
            Person man = new Person(firstName.Text, secondName.Text, middleName.Text, maleFemale, (int)yearBorn.Value, placeBorn.Text, nationality.Text);
            man.ThrowAnswer(tablePeople, id);            
            persons.Add(man);
            id++;

        }
    }
}
