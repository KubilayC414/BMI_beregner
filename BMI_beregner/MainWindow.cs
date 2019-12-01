using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void on_clicked(object sender, EventArgs e)
    {
        string vaegtAsaString = textBox_vaegt.Text;
        string hoejdeAsaString = textBox_hoejde.Text;

        bool isVaegtANumber = double.TryParse(vaegtAsaString, out double vaegt);
        bool isHoejdeANumber = double.TryParse(hoejdeAsaString, out double hoejde);

        if (isHoejdeANumber == true && isVaegtANumber == true)
        {
            double BMI = vaegt / Math.Pow(hoejde / 100.0, 2);
            textBox_bmi.Text = BMI.ToString();
        }
    }
}
