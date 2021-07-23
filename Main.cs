using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GenshinWishesPredictor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void UpdateProbabilities(object sender, EventArgs e)
        {
            int wishes;

            try
            {
                wishes = int.Parse(this.textBox2.Text) + int.Parse(this.textBox1.Text) / 160;
            }

            catch(Exception)
            {
                wishes = 0;
            }

            double anyChance = 0, eventChance = 0;

            for (int i = 1; i <= Math.Min(wishes, 90); ++i)
            {
                double currAnyChance = Main.WishProbability(i);

                anyChance += currAnyChance;
                eventChance += currAnyChance / 2;

                for (int j = 1; j <= Math.Min(wishes - i, 90); ++j)
                    eventChance += Main.WishProbability(j) * currAnyChance / 2;
            }

            anyChance = Math.Max(Math.Min(anyChance, 1), 0);
            eventChance = Math.Max(Math.Min(eventChance, 1), 0);

            if (this.checkBox1.Checked)
            {
                this.eventChance.Text = (Math.Round(anyChance, 4) * 100).ToString() + "%";
                this.eventChance.ForeColor = Main.GetProbabilityColor(anyChance);
            }

            else
            {
                this.anyChance.Text = (Math.Round(anyChance, 4) * 100).ToString() + "%";
                this.eventChance.Text = (Math.Round(eventChance, 4) * 100).ToString() + "%";

                this.anyChance.ForeColor = Main.GetProbabilityColor(anyChance);
                this.eventChance.ForeColor = Main.GetProbabilityColor(eventChance);
            }
        }

        public static double WishProbability(int wish)
        {
            return wish < 90 ? Math.Pow(0.994, wish - 1) * 0.006 : 1;
        }

        public static Color GetProbabilityColor(double probability)
        {
            return probability <= 0.15 ? Color.Red :
                probability <= 0.3 ? Color.Orange :
                probability <= 0.45 ? Color.SteelBlue :
                Color.Green;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.label4.Visible = false;
                this.anyChance.Visible = false;

                this.label5.Top -= 40;
                this.eventChance.Top -= 40;

                this.Height -= 40;
            }

            else
            {
                this.label4.Visible = true;
                this.anyChance.Visible = true;

                this.label5.Top += 40;
                this.eventChance.Top += 40;

                this.Height += 40;
            }

            this.UpdateProbabilities(sender, e);
        }
    }
}
