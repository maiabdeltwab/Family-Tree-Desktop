using FamilyTree.BAO;
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
    public partial class CreateForm : Form
    {
        private readonly PersonBao personBao = new PersonBao();
        private Person Person;
        private bool Edit = false;
        private string imagePath;

        public CreateForm(Person person = null)
        {
            InitializeComponent();

            if (person != null)
            {
                Person = person;
                Edit = true;
                CreateBtn.Text = "Update";
                FormTitleLbl.Text = "Update family member";
            }
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = FormTitleLbl;
            LoadData();

            if (Person != null)
                SetPersonData();
            else
                ClearData();
        }

        private void LoadData()
        {
            MotherCB.DataSource = personBao.GetFemales();
            MotherCB.DisplayMember = "FullName";
            MotherCB.ValueMember = "Id";

            FatherCB.DataSource = personBao.GetMales();
            FatherCB.DisplayMember = "FullName";
            FatherCB.ValueMember = "Id";
        }

        private void SetPersonData()
        {
            FNameTB.Text = Person.FirstName;
            LNameTB.Text = Person.LastName;
            GenderCB.SelectedIndex = Person.Gender ? 0 : 1;
            dateTimePicker.Value = (DateTime)Person.Birthdate;

            if (Person.FatherID != null)
            {
                string FatherFullName = Person.Father.FatherID != null ?
                       Person.Father.FirstName + " " + Person.Father.LastName
                        + " " + Person.Father.Father.LastName
                        : Person.Father.FirstName + " " + Person.Father.LastName;

                FatherCB.SelectedIndex = FatherCB.FindStringExact(FatherFullName);
            }
            else
            {
                FatherCB.SelectedIndex = -1;
            }

            if (Person.MotherId != null)
            {
                string MotherFullName = Person.Mother.FatherID != null ?
                       Person.Mother.FirstName + " " + Person.Mother.LastName
                        + " " + Person.Mother.Father.LastName
                        : Person.Mother.FirstName + " " + Person.Mother.LastName;

                MotherCB.SelectedIndex = MotherCB.FindStringExact(MotherFullName);
            }
            else
            {
                MotherCB.SelectedIndex = -1;
            }

            if (Person.MarriageFrom != null)
            {
                MarriageCB_Enter(null, null);

                string FullName = Person.MarraigeFrom.FatherID != null ?
                      Person.MarraigeFrom.FirstName + " " + Person.MarraigeFrom.LastName
                       + " " + Person.MarraigeFrom.Father.LastName
                       : Person.MarraigeFrom.FirstName + " " + Person.MarraigeFrom.LastName;

                MarriageCB.SelectedIndex = MarriageCB.FindStringExact(FullName);
            }
            else
            {
                MarriageCB.SelectedIndex = -1;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        /// <summary>
        /// This method for reset create form
        /// </summary>
        private void ClearData()
        {
            DefaultText(FNameTB, "Enter first name", 0);
            DefaultText(LNameTB, "Enter last name", 0);
            DefaultText(GenderCB, "Select gender", 0);

            GenderError.Visible = false;
            dateTimePicker.Value = DateTime.Now;

            FatherCB.SelectedIndex = -1;
            MotherCB.SelectedIndex = -1;
            MarriageCB.SelectedIndex = -1;

            Edit = false;
            CreateBtn.Text = "Create";
            FormTitleLbl.Text = "Add new family member";
        }

        public void ClearDefaults()
        {
            DefaultText(FNameTB, "Enter first name", 1);
            DefaultText(LNameTB, "Enter last name", 1);
            DefaultText(GenderCB, "Select gender", 1);
        }

        /// <summary>
        /// this method to control when delete or set
        /// default text for text/combo boxes
        /// </summary>
        /// <param name="sender"> the text/combo box </param>
        /// <param name="defaultText"> Text to delete or justify </param>
        /// <param name="state">
        /// 0 => reset default text
        /// 1 => delete default text (if exists)
        /// other => set the default if the box is empty
        /// </param>
        private void DefaultText(dynamic sender, string defaultText, int state)
        {
            if (state == 1)
            {
                if (sender.Text == defaultText)
                {
                    sender.Text = "";
                    sender.ForeColor = Color.Black;
                }
            }
            else
            {
                if (state == 0 || sender.Text == "" || string.IsNullOrWhiteSpace(sender.Text))
                {
                    sender.Text = defaultText;
                    sender.ForeColor = Color.Gray;
                }
            }
        }

        private void FNameTB_Enter(object sender, EventArgs e)
        {
            DefaultText(sender, "Enter first name", 1);
        }

        private void FNameTB_Leave(object sender, EventArgs e)
        {
            DefaultText(sender, "Enter first name", 2);
        }

        private void LNameTB_Enter(object sender, EventArgs e)
        {
            DefaultText(sender, "Enter last name", 1);
        }

        private void LNameTB_Leave(object sender, EventArgs e)
        {
            DefaultText(sender, "Enter last name", 2);
        }

        private void GenderCB_Enter(object sender, EventArgs e)
        {
            DefaultText(sender, "Select gender", 1);
        }

        private void GenderCB_Leave(object sender, EventArgs e)
        {
            DefaultText(sender, "Select gender", 2);
        }

        private bool ValidateName(dynamic sender, Label Errorlabel)
        {
            var text = sender.Text;

            if (!Validation.IsName(text))
            {
                if (text == "")
                    Errorlabel.Text = "this field is required";
                else
                    Errorlabel.Text = "name must not contain special characters";

                Errorlabel.Visible = true;

                return false;
            }
            else
            {
                Errorlabel.Visible = false;

                return true;
            }
        }

        private void FNameTB_TextChanged(object sender, EventArgs e)
        {
            ValidateName(sender, FNameError);
        }

        private void LNameTB_TextChanged(object sender, EventArgs e)
        {
            ValidateName(sender, LNameError);
        }

        private bool ValidateDate()
        {
            if (dateTimePicker.Value > DateTime.Now)
            {
                DateError.Visible = true;
                return false;
            }
            else
            {
                DateError.Visible = false;
                return true;
            }
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ValidateDate();
        }

        private bool ValidateGender()
        {
            var value = GenderCB.Text;
            if (!Validation.IsGender(value))
            {
                GenderError.Visible = true;
                return false;
            }
            else
            {
                GenderError.Visible = false;
                return true;
            }
        }

        private void GenderCB_TextUpdate(object sender, EventArgs e)
        {
            ValidateGender();
        }

        private void GenderCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateGender();
        }

        private bool ValidateForm()
        {
            bool IsFname = ValidateName(FNameTB, FNameError);
            bool IsLname = ValidateName(LNameTB, LNameError);
            bool IsBirthdate = ValidateDate();
            bool IsGender = ValidateGender();

            return IsFname && IsLname && IsBirthdate && IsGender;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            ClearDefaults();

            if (ValidateForm())
            {
                Person person = new Person();
                GetFormData(person);

                if (Edit)
                {
                    person.Id = Person.Id;

                    if (personBao.Update(person))
                    {
                        MessageBox.Show(null, "Person has been updated successfully",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(null, "Something went wrong",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (personBao.Create(person))
                    {
                        MessageBox.Show(null, "Person has been created successfully",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Person = person;

                        Edit = true;
                        CreateBtn.Text = "Update";
                        FormTitleLbl.Text = "Update family member";
                    }
                    else
                    {
                        MessageBox.Show(null, "Something went wrong",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(null, "Please check your input", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetFormData(Person person)
        {
            person.FirstName = FNameTB.Text;
            person.LastName = LNameTB.Text;
            person.Birthdate = dateTimePicker.Value;

            string gender = GenderCB.Text;

            if (gender[0] == 'f' || gender[0] == 'F')
                person.Gender = false;
            else
                person.Gender = true;

            if (FatherCB.SelectedIndex != -1)
                person.FatherID = int.Parse(FatherCB.SelectedValue.ToString());

            if (MotherCB.SelectedIndex != -1)
                person.MotherId = int.Parse(MotherCB.SelectedValue.ToString());

            if (MarriageCB.SelectedIndex != -1)
                person.MarriageFrom = int.Parse(MarriageCB.SelectedValue.ToString());

            if (imagePath != null)
                person.ImagePath = imagePath;
        }

        private void MarriageCB_Enter(object sender, EventArgs e)
        {
            if (ValidateGender())
            {
                if ((GenderCB.Text[0] == 'f' || GenderCB.Text[0] == 'F'))
                {
                    MarriageCB.DataSource = personBao.GetMales()
                        .Where(p => !p.IsMarriage).ToList();
                    MarriageCB.DisplayMember = "FullName";
                    MarriageCB.ValueMember = "Id";
                }
                else
                {
                    MarriageCB.DataSource = personBao.GetFemales()
                          .Where(p => !p.IsMarriage).ToList();
                    MarriageCB.DisplayMember = "FullName";
                    MarriageCB.ValueMember = "Id";
                }
            }
            else
            {
                var people = personBao.GetMales().Where(p => !p.IsMarriage).ToList(); ;
                people.AddRange(personBao.GetFemales().Where(p => !p.IsMarriage).ToList());
                MarriageCB.DataSource = people;
                MarriageCB.DisplayMember = "FullName";
                MarriageCB.ValueMember = "Id";
            }
        }

        private void BackToHomeBtn_Click(object sender, EventArgs e)
        {
            HomeForm objForm = new HomeForm
            {
                TopLevel = false
            };
            Program.MainForm.mainPanel.Controls.Clear();
            Program.MainForm.mainPanel.Controls.Add(objForm);
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // open file dialog
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                Bitmap bmp1 = new Bitmap(open.FileName);
                pictureBox1.Image = bmp1;
                imagePath = open.FileName;
            }
        }
    }
}