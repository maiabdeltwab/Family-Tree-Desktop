using FamilyTree.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyTree
{
    public partial class PersonControl : UserControl
    {
        public static EventHandler SelectPersonEvent { get; set; }
        public Person Person { get; set; }
        public bool Selected { get; set; }

        public PersonControl(Person person)
        {
            InitializeComponent();

            Person = person;

            NameLbl.Text = person.FirstName + " " + person.LastName;
            int age = DateTime.Now.Year - ((DateTime)person.Birthdate).Year;
            AgeLbl.Text = person.Birthdate.Value.ToShortDateString() + $"  ({age} years) ";
            GenderLbl.Text = person.Gender ? "Male" : "Female";

            if (!person.Gender)
            {
                personPhoto.Image = Image.FromFile(Program.ImagePath + @"\user icon vector female.png");
                NameLbl.ForeColor = Color.FromArgb(182, 63, 108);
            }

            if (person.ImagePath != null)
            {
                try
                {
                    personPhoto.Image = Image.FromFile(person.ImagePath);
                }
                catch
                {
                }
            }
        }

        private void SelectPerson(object sender, EventArgs e)
        {
            Selected = !Selected;

            if (Selected)
            {
                BackColor = Color.FromArgb(218, 245, 236);

                if (HomeForm.SelectedItem != null && HomeForm.SelectedItem != this)
                {
                    HomeForm.SelectedItem.SelectPerson(null, null);
                }

                HomeForm.SelectedItem = this;
            }
            else
            {
                HomeForm.SelectedItem = null;
                BackColor = Color.White;
            }

            SelectPersonEvent(null, null);
        }

        private void PersonControl_MouseEnter(object sender, EventArgs e)
        {
            if (!Selected)
                BackColor = Color.FromArgb(251, 251, 251);
        }

        private void PersonControl_MouseLeave(object sender, EventArgs e)
        {
            if (!Selected)
                BackColor = Color.White;
        }
    }
}