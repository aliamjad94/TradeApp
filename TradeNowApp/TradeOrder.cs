using System;
using System.Drawing;
using System.Windows.Forms;
using TradeNowLibrary;
using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;

namespace TradeNow
{
    public partial class TradeOrder : MaterialForm
    {
        private readonly IOrderWriterService orderWriterService;
   
        public TradeOrder(IOrderWriterService orderWriterService)
        {
            InitializeComponent();
            this.orderWriterService = orderWriterService;
        }

        private void TradeOrder_Load(object sender, EventArgs e)
        {
            // Initializing default Values //
            StartTime.Start();
            orderBox.SelectedIndex = 0;
            ordertypeBox.SelectedIndex = 0;
            tifBox.SelectedIndex = 0;
        }

        private void createOrder_Click(object sender, EventArgs e)
        {
            if (!(string.Compare(orderBox.Text, "Select Order...") == 0)
                && !string.IsNullOrEmpty(symbolBox.Text) 
                && !string.IsNullOrEmpty(quantityBox.Text)
                && !string.IsNullOrEmpty(routeBox.Text)
                && !string.IsNullOrEmpty(ordertypeBox.Text))
            {

                TraderTicket newOrder = new TraderTicket
                {
                    OrderID = orderIDbox.TabIndex.ToString(),
                    Order = orderBox.Text,
                    Symbol = symbolBox.Text,
                    Quantity = quantityBox.Text,
                    Price = priceBox.Text,
                    Route = routeBox.Text,
                    OrderType = ordertypeBox.Text,
                    Tif = tifBox.Text,
                    OrderDate = dateView.Text
                };

                JObject jTicket = JObject.FromObject(newOrder);

                orderWriterService.saveOrder(jTicket);

                // Read Data from Json file //

                var readOnGrid = orderWriterService.readOrder();

                dataGridView1.DataSource = readOnGrid;

                // Increasing index of OrderID //

                orderIDbox.TabIndex++;

                // Formatting dataGridview //

                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);

                MessageBox.Show("Order has been created!");
            }

            else
            {
             MessageBox.Show("Please Enter All Required attributes!");
            }            
        }

        // Resetting values when New Order Button is clicked //
        private void NewOrder_Click(object sender, EventArgs e)
        {
            orderBox.SelectedIndex = 0;
            symbolBox.ResetText();
            quantityBox.ResetText();
            priceBox.ResetText();
            routeBox.ResetText();
            ordertypeBox.SelectedIndex = 0;
            tifBox.SelectedIndex = 0;
        }

        // Log-out From TradeOrder form and Display Log-in again //

        private void logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful!");
            this.Close();
            LoginForm main = new LoginForm(orderWriterService);
            main.Show();
        }

        // Run Time //
        private void StartTime_Tick(object sender, EventArgs e)
        {
            dateView.Text = DateTime.Now.ToString();
        }
    }
}
