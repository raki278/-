using System;
using System.Windows.Forms;

class Kadai2 : Form
{
    private Label lb;



    public static void Main()
    {
        Application.Run(new Kadai2());
    }
    public Kadai2()
    {
        this.Text = "課題です。";
        this.Width = 450; this.Height = 300;

        lb = new Label();
        lb.Text = "カーソルをこの枠に入れてください。";

        lb.Parent = this;

        this.MouseEnter += new EventHandler(fm_MouseEnter);
        this.MouseLeave += new EventHandler(fm_MouseLeave);

    }
    public void fm_MouseEnter(Object sender, EventArgs e)
    {
        lb.Text = "参考書を";
    }
    public void fm_MouseLeave(Object sender, EventArgs e)
    {
        lb.Text = "見ながらやりました。";

    }
}
  