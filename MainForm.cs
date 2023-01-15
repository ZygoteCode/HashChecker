using MetroSuite;
using System.Windows.Forms;

public partial class MainForm : MetroForm
{
    private byte[] fileBytes;

    public MainForm()
    {
        InitializeComponent();
    }

    private void guna2Button1_Click(object sender, System.EventArgs e)
    {
        if (openFileDialog1.ShowDialog().Equals(DialogResult.OK))
        {
            fileBytes = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
            guna2TextBox1.Text = GetHash("MD2");
            guna2TextBox2.Text = GetHash("MD4");
            guna2TextBox3.Text = GetHash("MD5");
            guna2TextBox4.Text = GetHash("SHA1");
            guna2TextBox5.Text = GetHash("SHA256");
            guna2TextBox6.Text = GetHash("SHA384");
            guna2TextBox7.Text = GetHash("SHA512");
        }
    }

    private string GetHash(string type)
    {
        Chilkat.Crypt2 crypt = new Chilkat.Crypt2();
        crypt.EncodingMode = "hex";
        crypt.HashAlgorithm = type.ToLower();
        return crypt.HashBytesENC(fileBytes).ToLower();
    }

    private void guna2Button2_Click(object sender, System.EventArgs e)
    {
        if (guna2TextBox1.Text == "")
        {
            return;
        }

        Clipboard.SetText(guna2TextBox1.Text);
    }

    private void guna2Button3_Click(object sender, System.EventArgs e)
    {
        if (guna2TextBox2.Text == "")
        {
            return;
        }

        Clipboard.SetText(guna2TextBox2.Text);
    }

    private void guna2Button4_Click(object sender, System.EventArgs e)
    {
        if (guna2TextBox3.Text == "")
        {
            return;
        }

        Clipboard.SetText(guna2TextBox3.Text);
    }

    private void guna2Button5_Click(object sender, System.EventArgs e)
    {
        if (guna2TextBox4.Text == "")
        {
            return;
        }

        Clipboard.SetText(guna2TextBox4.Text);
    }

    private void guna2Button6_Click(object sender, System.EventArgs e)
    {
        if (guna2TextBox5.Text == "")
        {
            return;
        }

        Clipboard.SetText(guna2TextBox5.Text);
    }

    private void guna2Button7_Click(object sender, System.EventArgs e)
    {
        if (guna2TextBox6.Text == "")
        {
            return;
        }

        Clipboard.SetText(guna2TextBox6.Text);
    }

    private void guna2Button8_Click(object sender, System.EventArgs e)
    {
        if (guna2TextBox7.Text == "")
        {
            return;
        }

        Clipboard.SetText(guna2TextBox7.Text);
    }

    private void guna2TextBox1_MouseClick(object sender, MouseEventArgs e)
    {
        guna2TextBox1.SelectAll();
    }

    private void guna2TextBox2_MouseClick(object sender, MouseEventArgs e)
    {
        guna2TextBox2.SelectAll();
    }

    private void guna2TextBox3_MouseClick(object sender, MouseEventArgs e)
    {
        guna2TextBox3.SelectAll();
    }

    private void guna2TextBox4_MouseClick(object sender, MouseEventArgs e)
    {
        guna2TextBox4.SelectAll();
    }

    private void guna2TextBox5_MouseClick(object sender, MouseEventArgs e)
    {
        guna2TextBox5.SelectAll();
    }

    private void guna2TextBox6_MouseClick(object sender, MouseEventArgs e)
    {
        guna2TextBox6.SelectAll();
    }

    private void guna2TextBox7_MouseClick(object sender, MouseEventArgs e)
    {
        guna2TextBox7.SelectAll();
    }

    private void guna2Button9_Click(object sender, System.EventArgs e)
    {
        if (fileBytes == null || guna2TextBox1.Text == "")
        {
            MessageBox.Show("Please, upload a file to check in order to save the hash results.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
        {
            System.IO.File.WriteAllText(saveFileDialog1.FileName,
                $"MD2 Hash: {guna2TextBox1.Text}\r\n" +
                $"MD4 Hash: {guna2TextBox2.Text}\r\n" +
                $"MD5 Hash: {guna2TextBox3.Text}\r\n" +
                $"SHA1 Hash: {guna2TextBox4.Text}\r\n" +
                $"SHA256 Hash: {guna2TextBox5.Text}\r\n" +
                $"SHA384 Hash: {guna2TextBox6.Text}\r\n" +
                $"SHA512 Hash: {guna2TextBox7.Text}\r\n");
            MessageBox.Show("Succesfully saved the results to file!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}