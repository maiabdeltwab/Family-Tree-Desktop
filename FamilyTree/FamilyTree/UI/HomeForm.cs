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
    public partial class HomeForm : Form
    {
        //private List<PersonControl> PersonControlList = new List<PersonControl>();
        public static PersonControl SelectedItem { get; set; }

        private readonly PersonBao personBao = new PersonBao();

        private readonly Pen pen = new Pen(Color.Gray, 50);
        private Point point1 = new Point(0, 0);
        private Point point2 = new Point(0, 0);
        private Point point3 = new Point(0, 0);

        public HomeForm()
        {
            PersonControl.SelectPersonEvent += PersonSelected;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //first find person hasn't parents and her partner (if exists) hasn't parent
            var parents = personBao.Parents();

            BuildTree(parents, 30, 130);
        }

        private int BuildTree(List<Person> parents, int x, int y)
        {
            int x1 = x, y1 = y, x2 = 0, y2 = y1;

            for (int i = 0; i < parents.Count; i++)
            {
                var person = parents[i];

                PersonControl personControl = new PersonControl(person);
                PersonControl personControl2 = null;

                if (person.MarriageFrom != null)
                {
                    y2 = y1 + 70;
                    parents.Remove(parents.Where(p => p.Id == person.MarriageFrom)
                            .FirstOrDefault());

                    personControl2 = new PersonControl(person.MarraigeFrom);
                }

                personControl.Location = new Point(x1, y1);
                personControl.Visible = true;
                Controls.Add(personControl);
                point1 = new Point(x1 + 230, y1);

                if (personControl2 != null)
                {
                    personControl2.Location = new Point(x1, y2);
                    personControl2.Visible = true;
                    Controls.Add(personControl2);
                    point2 = new Point(x1 + 230, y2);
                }
                else
                {
                    point2 = new Point(x1 + 230, y1 + 66);
                }

                var childs = person.Gender ?
                             person.FatherChilds.ToList()
                             : person.MotherChilds.ToList();

                if (childs.Count != 0)
                {
                    if (person.MarriageFrom != null)
                        y2 = childs.Count > 1 ? y1 - 30 : y1 + 20;
                    else
                        y2 = y1;

                    x2 = x1 + 290;
                    y1 = BuildTree(childs, x2, y2);
                    if (person.MarriageFrom != null && childs.Count > 2)
                        y1 -= 40;
                }

                if (i < parents.Count - 1)
                {
                    if (person.MarriageFrom == null)
                        y1 += 90;
                    else
                        y1 += 200;
                }
            }

            return y1;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm
            {
                TopLevel = false
            };
            Program.MainForm.mainPanel.Controls.Clear();
            Program.MainForm.mainPanel.Controls.Add(createForm);
            createForm.Dock = DockStyle.Fill;
            createForm.Show();
        }

        private void CreateBtn_MouseEnter(object sender, EventArgs e)
        {
            CreateBtn.Image = Image.FromFile(Program.ImagePath + @"\icon_add_user_active.png");
        }

        private void CreateBtn_MouseLeave(object sender, EventArgs e)
        {
            CreateBtn.Image = Image.FromFile(Program.ImagePath + @"\icon_add_user.png");
        }

        private void EditBtn_MouseEnter(object sender, EventArgs e)
        {
            if (EditBtn.Enabled)
            {
                EditBtn.Image =
                    Image.FromFile(Program.ImagePath + @"\icon_edit_user_active.png");
            }
        }

        private void EditBtn_MouseLeave(object sender, EventArgs e)
        {
            if (EditBtn.Enabled)
            {
                EditBtn.Image =
                    Image.FromFile(Program.ImagePath + @"\icon_edit_user.png");
            }
        }

        private void DeleteBtn_MouseEnter(object sender, EventArgs e)
        {
            if (DeleteBtn.Enabled)
            {
                DeleteBtn.Image =
                    Image.FromFile(Program.ImagePath + @"\icon_delete_user_active.png");
            }
        }

        private void DeleteBtn_MouseLeave(object sender, EventArgs e)
        {
            if (DeleteBtn.Enabled)
            {
                DeleteBtn.Image =
                    Image.FromFile(Program.ImagePath + @"\icon_delete_user.png");
            }
        }

        public void PersonSelected(object sender, EventArgs e)
        {
            if (SelectedItem != null)
            {
                EditBtn.Enabled = true;
                DeleteBtn.Enabled = true;

                EditBtn_MouseLeave(null, null);
                DeleteBtn_MouseLeave(null, null);
            }
            else
            {
                EditBtn.Enabled = false;
                DeleteBtn.Enabled = false;

                EditBtn.Image =
                    Image.FromFile(Program.ImagePath + @"\icon_edit_user_disabled.png");

                DeleteBtn.Image =
                  Image.FromFile(Program.ImagePath + @"\icon_delete_user_disabled.png");
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm(SelectedItem.Person)
            {
                TopLevel = false
            };
            Program.MainForm.mainPanel.Controls.Clear();
            Program.MainForm.mainPanel.Controls.Add(createForm);
            createForm.Dock = DockStyle.Fill;
            createForm.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(null,
                "Are you sure you want to delete this person ?",
                "Delete person", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (personBao.Delete(SelectedItem.Person))
                {
                    MessageBox.Show(null, "Person has been deleted successfully",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Controls.Remove(SelectedItem);
                }
                else
                {
                    MessageBox.Show(null, "Can't delete person who is parent for others.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}