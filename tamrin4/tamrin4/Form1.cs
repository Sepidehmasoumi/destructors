using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamrin4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncreatcar_Click(object sender, EventArgs e)
        {
            string brand = txtbrand.Text;
            int speed = Convert.ToInt32(txtspeed.Text);
            car Car = new car(brand, speed);
            lblinfo.Text = Car.Getcarinfo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
    public class car
    {
    private string brand;
    private int speed;
    public car (string brandName, int speedValue)
    {
        brand = brandName;
        speed = speedValue;
    }
    ~car()
    {
        MessageBox.Show("اطلاعات خودرو:\n" + "برند: " + brand + "\n" + "سرعت: " + speed + "کیلومتر بر ساعت");
    }
    public string Getcarinfo()
    {
        return "برند:\n " + brand + "\n" +  "سرعت:\n " + speed + "کیلومتر بر ساعت";
    }
    }
