using System.Collections;
using System.Drawing;
using System.IO;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int day = 1; day <= 31; day++)
            {
                DayBox.Items.Add(day.ToString());
            }
            string[] months =
            {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            };

            for (int month = 0; month < months.Length; month++)
            {
                MonthBox.Items.Add(months[month]);
            }

            for (int year = 2026; year >= 1990; year--)
            {
                YearBox.Items.Add(year.ToString());
            }

            ArrayList course = new ArrayList();
            course.Add("Bachelor of Science in Computer Science");
            course.Add("Bachelor of Science in Computer Engineering");
            course.Add("Bachelor of Science in Information Technology");
            course.Add("Bachelor of Science in Information Systems");

            foreach (string prog in course)
            {
                ProgramBox.Items.Add(prog);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LnameBox_TextChanged(object sender, EventArgs e)
        {
            String lname = (String)LnameBox.Text;
        }

        private void FnameBox_TextChanged(object sender, EventArgs e)
        {
            String fname = (String)FnameBox.Text;
        }
        private void MnameBox_TextChanged(object sender, EventArgs e)
        {
            String mname = (String)MnameBox.Text;
        }

        string gender = " ";

        private void MaleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MaleButton.Checked)
            {
                gender = "Male";
            }
        }

        private void FemaleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FemaleButton.Checked)
            {
                gender = "Female";
            }
        }

        private void DayBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void YearBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProgramBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string overloadOutput(string fname, string mname, string lname, string gender, string birthDate, string programCourse)
        {
            return $"Student Name: {fname} {mname} {lname}\n" +
                $"Gender: {gender}\n" +
                $"Date of Birth: {birthDate}\n" +
                $"Program: {programCourse}";
        }

        private string overloadOutput(string fname, string lname, string gender, string birthDate, string programCourse)
        {
            return $"Student Name: {fname} {lname}\n" +
                $"Gender: {gender}\n" +
                $"Date of Birth: {birthDate}\n" +
                $"Program: {programCourse}";
        }

        private string overloadOutput(string fname, string mname, string lname, string programCourse)
        {
            return $"Student Name: {fname} {mname} {lname}\n" +
                $"Program: {programCourse}";
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string fname = FnameBox.Text;
            string mname = MnameBox.Text;
            string lname = LnameBox.Text;

            string day = DayBox.SelectedItem?.ToString() ?? "";
            string month = MonthBox.SelectedItem?.ToString() ?? "";
            string year = YearBox.SelectedItem?.ToString() ?? "";

            string birthDate = $"{month}/{day}/{year}";

            string programCourse = ProgramBox.SelectedItem?.ToString() ?? "";

            string fullInfo = overloadOutput(fname, mname, lname, gender, birthDate, programCourse);
            string noMiddle = overloadOutput(fname, lname, gender, birthDate, programCourse);
            string minimal = overloadOutput(fname, mname, lname, programCourse);

            Thread t1 = new Thread(() => MessageBox.Show(fullInfo));
            Thread t2 = new Thread(() => MessageBox.Show(noMiddle));
            Thread t3 = new Thread(() => MessageBox.Show(minimal));

            t1.SetApartmentState(ApartmentState.STA);
            t2.SetApartmentState(ApartmentState.STA);
            t3.SetApartmentState(ApartmentState.STA);

            t1.Start();
            t2.Start();
            t3.Start();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\CompLab209-PC1\Pictures",
                Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png",
                FilterIndex = 1, 
                RestoreDirectory = true

            };

            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}
