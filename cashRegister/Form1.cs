using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace cashRegister
{
    public partial class Form1 : Form
    {
        //global variables
        double freakCalls;
        double calls;
        double diddyTickets;
        double tickets;
        double johnMeat;
        double slabs;
        double subtotal;
        double tax;
        double total;
        double tendered;
        double change;

        //global sound players
        SoundPlayer fein = new SoundPlayer(Properties.Resources.fein);
        SoundPlayer whysoserious = new SoundPlayer(Properties.Resources.whysoserious);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void freakBobCalls_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {

                calls = Convert.ToDouble(freakBobCalls.Text);
                freakCalls = 6.99;


                tickets = Convert.ToDouble(diddyPartyTickets.Text);
                diddyTickets = 49.99;


                slabs = Convert.ToDouble(meatSlabs.Text);
                johnMeat = 22.49;


                subtotal = calls * freakCalls + tickets * diddyTickets + slabs * johnMeat;
                subtotalLabel.Text = $"{subtotal.ToString("C")}";

                tax = subtotal * 0.13;
                taxLabel.Text = $"{tax.ToString("C")}";

                total = subtotal + tax;
                totalLabel.Text = $"{total.ToString("C")}";
            }
            catch
            {
                subtotalLabel.Text = "Error";
            }
        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            fein.Play();
            try
            {
                tendered = Convert.ToDouble(tenderedBox.Text);
                change = tendered - total;
                changeLabel.Text = $"{change.ToString("C")}";
            }
            catch
            {
                changeLabel.Text = "Error";
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            whysoserious.Play();

            receiptLabel.Text += $"\n{calls} Freak Bobs Calls....                               {calls * freakCalls}";
            Thread.Sleep(200);
            Refresh();
            receiptLabel.Text += $"\n{tickets} Diddy Party Tickets....                          {tickets * diddyTickets}";
            Thread.Sleep(200);
            Refresh();
            receiptLabel.Text += $"\n{slabs} John Pork Meat Slabs....                      {slabs * johnMeat}";
            Thread.Sleep(200);
            Refresh();

            receiptLabel.Text += $"\nSubtotal....                                            {subtotal.ToString("C")}";
            Thread.Sleep(200);
            Refresh();
            receiptLabel.Text += $"\nTax....                                                   {tax.ToString("C")}";
            Thread.Sleep(200);
            Refresh();
            receiptLabel.Text += $"\nTotal....                                                 {total.ToString("C")}";
            Thread.Sleep(200);
            Refresh();
            receiptLabel.Text += $"\nPayed....                                               {tendered.ToString("C")}";
            Thread.Sleep(200);
            Refresh();
            receiptLabel.Text += $"\nChange....                                             {change.ToString("C")}";
            Thread.Sleep(200);
            Refresh();
            receiptLabel.Text += "Have A Good Day!";
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            receiptLabel.Text = "";
            changeLabel.Text = "";
            totalLabel.Text = "";
            taxLabel.Text = "";
            subtotalLabel.Text = "";
            freakBobCalls.Text = "";
            diddyPartyTickets.Text = "";
            meatSlabs.Text = "";
            tenderedBox.Text = "";
            calls = 0;
            tickets = 0;
            slabs = 0;
            subtotal = 0;
            total = 0;
            tax = 0;
            change = 0;
            tendered = 0;
        }
    }
}
