using System.Windows.Forms;

namespace SmartMart
{
    public partial class AllDetailsForm : Form
    {
        public AllDetailsForm(int type)
        {
            InitializeComponent();
            if (type == 1)
            {
                lbDetails.Text = $"Full Details Of All Sellers";
                int i = 0;
                foreach (var item in Program.AdminInstance.GetSellers())
                {
                    RichTextBox tb = new RichTextBox
                    {
                        Multiline = true,
                        Width = pnDetails.Width,
                        Height = 100,
                        ReadOnly = true,
                        Text = item.StringView(),
                        Top = i * (130)
                    };
                    pnDetails.Controls.Add(tb);
                    i++;
                }
            }
            else if (type == 2)
            {
                lbDetails.Text = $"Full Details Of All Buyers";
                int i = 0;
                foreach (var item in Program.AdminInstance.GetBuyers())
                {
                    RichTextBox tb = new RichTextBox
                    {
                        Multiline = true,
                        Width = pnDetails.Width,
                        Height = 100,
                        ReadOnly = true,
                        Text = item.ToString(),
                        Top = i * (130)
                    };
                    pnDetails.Controls.Add(tb);
                    i++;
                }
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
