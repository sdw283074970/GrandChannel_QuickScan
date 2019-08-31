using Scanner_SDK_Sample_Application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrandChannel_QuickScan
{
    public partial class FormUpdate : Form
    {
        public delegate void UPCRegisteredeEventHandler(int rowIndex, string upc, string style, string color, string size);
        public UPCRegisteredeEventHandler UPCRegistered;
        public string baseUrl;

        public FormUpdate()
        {
            InitializeComponent();
        }

        private async void BtnRegister_Click(object sender, EventArgs e)
        {
            var rowIndex = int.Parse(txtRowIndex.Text);
            //执行服务器注册
            var url = baseUrl + "api/RegisteredRegularSKU/?upc=" + txtUPC.Text + "&style=" + txtStyle.Text + "&color=" + txtColor.Text + "&size=" + txtSize.Text;
            var result = await WebServiceManager.SendCreateRequestAsync(url, "", "POST");

            if (result != "Success")
            {
                MessageBox.Show(result);
            }
            else
            {
                UPCRegistered?.Invoke(rowIndex, txtUPC.Text, txtStyle.Text, txtColor.Text, txtSize.Text);
                this.Close();
            }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            var rowIndex = int.Parse(txtRowIndex.Text);
            //执行服务更新
            var url = baseUrl + "api/RegisteredRegularSKU/?upc=" + txtUPC.Text + "&style=" + txtStyle.Text + "&color=" + txtColor.Text + "&size=" + txtSize.Text;
            var result = await WebServiceManager.SendCreateRequestAsync(url, "", "PUT");

            if (result != "Success")
            {
                MessageBox.Show(result);
            }
            else
            {
                UPCRegistered?.Invoke(rowIndex, txtUPC.Text, txtStyle.Text, txtColor.Text, txtSize.Text);
                this.Close();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
