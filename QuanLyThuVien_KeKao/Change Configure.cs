using Microsoft.Win32;
using QuanLyThuVien_KeKao.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_KeKao
{
    public partial class Change_Configure : Form
    {
        public Change_Configure()
        {
            InitializeComponent();
            string ServerName = Environment.MachineName;
            string str;
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            List<string> x = new List<string>();
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {

                        str = ServerName + @"\" + instanceName;
                        x.Add(str);
                    }
                }

            }
            cboServer.DataSource = x;
            cboServer.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            string x = cboServer.SelectedValue.ToString();
            DataProvider.Thuc_Thi.Set_Data_Source(x);

            Form_Dang_Nhap f = new Form_Dang_Nhap();
            this.Hide();
            f.Show();
            //this.Show();
        }
    }
}
