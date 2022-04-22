using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TICARIOTOMASYON
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }

        public string mail;
        private void Mail_Load(object sender, EventArgs e)
        {
            txtmailgönder.Text = mail;
        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            MailMessage mesajim = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("uzeyir.aycel@hotmail.com","erzurum2525");
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesajim.To.Add(txtmailgönder.Text);
            mesajim.From = new MailAddress("uzeyir.aycel@hotmail.com");
            mesajim.Subject = txtkonu.Text;
            mesajim.Body = rchmesaj.Text;
            istemci.Send(mesajim);
            MessageBox.Show("Mail Gönderildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
