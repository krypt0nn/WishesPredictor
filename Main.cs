using System;
using System.Drawing;
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
            int wishes, doneWishes;

            try
            {
                wishes = int.Parse(this.textBox1.Text) / 160;
                doneWishes = int.Parse(this.textBox2.Text);
            }

            catch(Exception)
            {
                wishes = 0;
                doneWishes = 0;
            }

            double anyChance = 0, eventChance = 0;

            if (this.checkBox2.Checked)
            {
                wishes += doneWishes;

                for (int i = 1; i <= Math.Min(wishes, 90); ++i)
                {
                    double currAnyChance = Main.WishProbability(i);

                    anyChance += currAnyChance;
                    eventChance += currAnyChance / 2;

                    for (int j = 1; j <= Math.Min(wishes - i, 90); ++j)
                        eventChance += Main.WishProbability(j) * currAnyChance / 2;
                }
            }

            else
            {
                for (int i = doneWishes + 1; i <= Math.Min(wishes + doneWishes, 90); ++i)
                {
                    double currAnyChance = Main.WishProbability(i);

                    anyChance += currAnyChance;
                    eventChance += currAnyChance / 2;

                    for (int j = 1; j <= Math.Min(wishes + doneWishes - i, 90); ++j)
                        eventChance += Main.WishProbability(j) * currAnyChance / 2;
                }
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total amount of primogems you have or want to spend on event banner", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Amount of made wishes in event banners after the last 5* character. If you're trying to count the whole probability this parameter will be counted as number of wishes you have or want to use on event banner", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enable this if you previously got a non-event 5* character from an event banner. This will change calculation results because you'll have 100% probability that your next 5* character will be event one", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can calculate two types of probability:\n\nIf disabled - you will calculate probability of getting a 5* character for next some wishes you can do with your primogems\n\nIf enabled - you will calculate probability of getting a 5* character for all primogems and wishes you have\n\nThat's not quite clear difference so I'll give you an example: if you have already done 88 wishes and have 160 primogems\n\nWith disabled option you will see 0.35% probability to get 5* character\nWith enabled - 41.47%\n\nThat's because probability to get any 5* character for 89 wishes is 41.47%, but to get it for 1 wish after 88 ones is 0.35%", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.label7.Text = this.checkBox2.Checked ?
                "Amount of available wishes:" :
                "Amount of made wishes:";

            this.UpdateProbabilities(sender, e);
        }
    }
}
