using ImagePositionGenerator;
using System;
using System.Windows.Forms;

namespace ImagePositionGeneratorUI
{
    public partial class Form1 : Form
    {
        private LocationGenerator locationGenerator { get; set; }
        public Form1()
        {
            InitializeComponent();

            locationGenerator = new LocationGenerator();
        }

        //Run the main process
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";

            var imagelocation = textBox1.Text;

            var result = locationGenerator.Execute(imagelocation);

            textBox2.Text = result;
        }
    }
}
