using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escape_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void catchmebtn_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            catchmebtn.BackColor = Color.FromArgb(r.Next(0, 256),
                 r.Next(0, 256), r.Next(0, 256));

            this.BackColor = catchmebtn.BackColor;

            if (sender is Button bt)
            {
                bt.Dispose();

                Button button = new Button();
                button.Font = new Font("Segoe Script", 16, FontStyle.Bold);
                button.Text = "Catch me";
                button.AutoSize = true;
                button.MouseEnter += Button_MouseEnter;

                Random random = new Random();
                int randomX = random.Next(this.Size.Width - 100);
                int randomY = random.Next(this.Size.Height - 100);
                button.Location = new Point(randomX, randomY);

                this.Controls.Add(button);


            }          

            
        }

       
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            catchmebtn.BackColor = Color.FromArgb(r.Next(0, 256),
                 r.Next(0, 256), r.Next(0, 256));

            this.BackColor = catchmebtn.BackColor;

            if (sender is Button bt)
            {
                bt.Dispose();

                Button button = new Button();
                button.Font = new Font("Segoe Script", 16, FontStyle.Bold);
                button.Text = "Catch me";
                button.AutoSize = true;
                button.MouseEnter += Button_MouseEnter;

                Random random = new Random();
                int randomX = random.Next(this.Size.Width - 100);
                int randomY = random.Next(this.Size.Height - 100);
                button.Location = new Point(randomX, randomY);

                this.Controls.Add(button);


            }
        }

       
    }
}
