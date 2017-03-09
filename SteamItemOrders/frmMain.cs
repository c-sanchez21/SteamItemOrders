using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SteamAPI;

namespace SteamItemOrders
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {                        
            //Use the Steam Web API to download item listings
            ItemOrderInfo orderInfo = API.GetItemOrders(tbItemName.Text.Trim());
            wbSaleListings.DocumentText = orderInfo.sell_order_table;
            wbBuyOrders.DocumentText = orderInfo.buy_order_table;                                    
        }
    }
}
