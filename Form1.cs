using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelManagementApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime itime = DateTime.Now;
            lb_time.Text = itime.ToLongTimeString();


            DateTime idate = DateTime.Now;
            lb_date.Text = idate.ToLongDateString();


        }

        //below creating an array


        double[] TravelCost = new double[20];
        double[] TaxCost = new double[20];


        double Total;

        private void bt_receipt_Click(object sender, EventArgs e)
        {

            int num1;
            Random rnd = new Random();
            num1 = rnd.Next(4238, 34238);
            num1 = 1325 + num1;
            String refs = Convert.ToString(num1);


            //*************************************
            String Firstname = (tb_firstname.Text);
            String LastName = (tb_lastname.Text);
            String Address = (tb_address.Text);
            String NIC = (tb_nic.Text);
            String Telephone = (tb_telephone.Text);
            String Email = (tb_email.Text);
            String Tax = (tb_tax.Text);
            String SubTotal = (tb_subtotal.Text);
            String Total = (tb_total.Text);

            tb_receiptwindows.AppendText("\tTravel Management System:\n\n"
                + "Ref:\t\t\t\t" + refs
                + "\n----------------------------------------------------"
                + "\nFirstName:\t\t\t" + tb_firstname.Text
                + "\nLastName:\t\t\t" + tb_lastname.Text
                + "\n----------------------------------------------------"
                + "\n" + lb_date.Text + "\t\t\t" + lb_time.Text
                + "\n\n\tThanks For Using \n\tTravel Management System"
                );





        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to Exit", "TMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(iExit==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_isAirportTax.Checked = true;
            cb_isOverMiles.Checked = true;
            cb_isTravelIns.Checked = true;
            cb_travelLaugage.Checked = true;

 





            //    public partial class Form1 : Form
            //{
            //    private static double Total { get; set; }

            //    private void Form1_Load(object sender, EventArgs e)
            //    {
            //        var ctrl = groupBox1;
            //        foreach (var checkBox in ctrl.Controls.OfType<CheckBox>())
            //        {
            //            Total = checkBox.Checked ? (Total + Convert.ToDouble(checkBox.Tag)) : Total;
            //        }
            //    }
            //}
        }

        private void bt_total_Click(object sender, EventArgs e)
        {
            cPrice Travelprice = new cPrice() ;
            itax AirTax = new itax();

            //below creating an array

            //double[] TravelCost = new double[20];
            //double[] TaxCost = new double[20];


            //double Total;


            if (combp_destination.Text == "Dubai - 7 days in Burj Khalifa")
            {
                var ctrl = gb_additionalcharges;
                foreach (var checkBox in ctrl.Controls.OfType<CheckBox>())
                {
                    TravelCost[0] =  checkBox.Checked ? (Total + Convert.ToDouble(checkBox.Tag)) : TravelCost[0];
                }

                TravelCost[0] = Travelprice.cpDubaiDes + Travelprice.cpAirportTax;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                tb_subtotal.Text = string.Format("{0:C}", TravelCost[0]);
                tb_tax.Text = string.Format("{0:C}", TaxCost[0]);
                tb_total.Text = string.Format("{0:C}", Total);

            }


            if (combp_destination.Text == "Dubai - 7 days in Burj Khalifa")

            {
                foreach (var control in this.Controls) // I guess this is your form
                {
                    if (control is CheckBox)
                    {
                        if (((CheckBox)control).Checked)
                        {
                            //update
                        }
                        else
                        {
                            //update another
                        }
                    }
                }
            }
            {
                var ctrl = gb_additionalcharges;
                foreach (var checkBox in ctrl.Controls.OfType<CheckBox>())
                {
                    TravelCost[0] = checkBox.Checked ? (Total + Convert.ToDouble(checkBox.Tag)) : TravelCost[0];
                }

                TravelCost[0] = Travelprice.cpDubaiDes + Travelprice.cpAirportTax;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                tb_subtotal.Text = string.Format("{0:C}", TravelCost[0]);
                tb_tax.Text = string.Format("{0:C}", TaxCost[0]);
                tb_total.Text = string.Format("{0:C}", Total);

            }

            if (combp_destination.Text == "New South Wales")
            {

                TravelCost[0] = Travelprice.cpNewSWDes + Travelprice.cpAirportTax +
                    Travelprice.cpAirMiles + Travelprice.cpInsurance +
                    Travelprice.cpExitLaggage; ;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                tb_subtotal.Text = string.Format("{0:C}", TravelCost[0]);
                tb_tax.Text = string.Format("{0:C}", TaxCost[0]);
                tb_total.Text = string.Format("{0:C}", Total);

            }

            if (combp_destination.Text == "Italy - 5 Days in Roam")
            {
                TravelCost[0] = Travelprice.cpItalyDes + Travelprice.cpAirportTax +
                    Travelprice.cpAirMiles + Travelprice.cpInsurance +
                    Travelprice.cpExitLaggage; ;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                tb_subtotal.Text = string.Format("{0:C}", TravelCost[0]);
                tb_tax.Text = string.Format("{0:C}", TaxCost[0]);
                tb_total.Text = string.Format("{0:C}", Total);

            }

            if (combp_destination.Text == "Check Republic")
            {
                TravelCost[0] = Travelprice.cpCheckRDes + Travelprice.cpAirportTax +
                    Travelprice.cpAirMiles + Travelprice.cpInsurance +
                    Travelprice.cpExitLaggage; ;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                tb_subtotal.Text = string.Format("{0:C}", TravelCost[0]);
                tb_tax.Text = string.Format("{0:C}", TaxCost[0]);
                tb_total.Text = string.Format("{0:C}", Total);

            }

        

        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            tb_receiptwindows.Clear();
            tb_firstname.Clear();
            tb_lastname.Clear();
            tb_telephone.Clear();
            tb_email.Clear();
            tb_address.Clear();
            tb_nic.Clear();
            tb_total.Clear();
            tb_subtotal.Clear();
            tb_tax.Clear();
            combo_accomodation.Text = "None";
            combo_depature.Text = "None";
            combp_destination.Text = "None";

            cb_adult.Checked = false;
            cb_child.Checked = false;
            rb_flight_standerd.Checked = false;
            rb_flight_economy.Checked = false;
            rb_flight_firstclass.Checked = false;
            cb_isAirportTax.Checked = true;
            cb_isOverMiles.Checked = true;
            cb_isTravelIns.Checked = true;
            cb_ticket_oneway.Checked = false;
            cb_ticket_special.Checked = false;
            cb_ticket_twoway.Checked = false;
            cb_travelLaugage.Checked = true;

        }

        private void cb_isAirportTax_CheckedChanged(object sender, EventArgs e)
        {
            cPrice forTax = new cPrice();

            if(cb_isAirportTax.Checked == true)
            {
                Total = Total + forTax.cpAirportTax;
            }
            
        }
    }
}
