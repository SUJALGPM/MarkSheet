using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xml_ReadD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable t1 = new DataTable();
            t1.TableName = "Student";

            DataColumn c1 = new DataColumn("Name");
            DataColumn c2 = new DataColumn("age");
            DataColumn c3 = new DataColumn("course");
            DataColumn c4 = new DataColumn("marks");

            t1.Columns.Add(c1);
            t1.Columns.Add(c2);
            t1.Columns.Add(c3);
            t1.Columns.Add(c4);


            t1.Rows.Add("sujal", "18", "AWD", "75");
            t1.Rows.Add("shreeya", "16", "NGD", "85");
            t1.Rows.Add("harsha", "17", "MAD", "90");
            t1.Rows.Add("faisal", "17", "AJP", "60");

            DataSet ds = new DataSet();
            ds.Tables.Add(t1);

            ds.WriteXml("Student.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet d2 = new DataSet();
            d2.ReadXml("Student.xml");

            dataGridView1.DataSource = d2.Tables[0];
        }
    }
}
