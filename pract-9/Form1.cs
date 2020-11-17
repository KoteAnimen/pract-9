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

    struct Person
    {
        string firstName;
        string secondName;
        string middleName;
        bool genderMale;
        bool genderFemale;
        int yearBorn;
        string placeBorn;
        string nationality;

        public Person(string namePerson, string surname, string middleNamePerson, bool male, bool female, int year, string place, string nation)
        {
            firstName = namePerson;
            secondName = surname;
            middleName = middleNamePerson;
            genderMale = male;
            genderFemale = female;
            yearBorn = year;
            placeBorn = place;
            nationality = nation;
        }
       
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
