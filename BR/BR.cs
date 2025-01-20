using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BR
{
    public partial class BR : Form
    {
        public BR() 
        {
            InitializeComponent();
        }
        
        private void KolvoBoev() // Отнять 1 от количества боевых 
        {
            int x = int.Parse(KB.Text);
            x--;
            KB.Text = x.ToString();
        }
        
        private void KolvoBoevMinysHolost() // Отнять 1 от количества боевых и прибавить 1 к количеству холостых 
        {
            int x = int.Parse(KB.Text);
            x--;
            KB.Text = x.ToString();

            int y = int.Parse(KH.Text);
            y++;
            KH.Text = y.ToString();
        }

        private void KolvoHolost() // Отнять 1 от количества холостых 
        {
            int x = int.Parse(KH.Text);
            x--;
            KH.Text = x.ToString();
        }

        private void KolvoHolostMinysBoev() // Отнять 1 от количества холостых и прибавить 1 к количеству боевых 
        {
            int x = int.Parse(KH.Text);
            x--;
            KH.Text = x.ToString();

            int y = int.Parse(KB.Text);
            y++;
            KB.Text = y.ToString();
        }

        private void PlusBoev() // Прибавить боевой 
        {
            int x = int.Parse(KB.Text);
            x++;
            KB.Text = x.ToString();
        }

        private void PlusHolost() // Прибавить холостой 
        {
            int x = int.Parse(KH.Text);
            x++;
            KH.Text = x.ToString();
        }

        private void Clear_Click(object sender, EventArgs e) // Очистить всё 
        {
            R1.Text = "";
            R2.Text = "";
            R3.Text = "";
            R4.Text = "";
            R5.Text = "";
            R6.Text = "";
            R7.Text = "";
            R8.Text = "";
            KB.Text = "";
            KH.Text = "";
        }

        private void B1_Click(object sender, EventArgs e) // Проверить ячейку, поставить боевой, отнять боевой из количества и прибавить холостой если был раньше в ячейке
        {    
            if (R1.Text != "Б")
            {
                if  (R1.Text == "Х")
                {
                    if (KB.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R1.Text = "Б";

                            KolvoBoevMinysHolost();
                        }
                        else
                        {
                            MessageBox.Show("Количество боевых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество боевых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (KB.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R1.Text = "Б";

                            KolvoBoev();
                        }
                        else
                        {
                            MessageBox.Show("Количество боевых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество боевых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }            
        }

        private void H1_Click(object sender, EventArgs e) // Проверить ячейку, поставить холостой, отнять холостой из количества и прибавить боевой если был раньше в ячейке 
        {
            if (R1.Text != "Х")
            {
                if (R1.Text == "Б")
                {
                    if (KH.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R1.Text = "Х";

                            KolvoHolostMinysBoev();
                        }
                        else
                        {
                            MessageBox.Show("Количество холостых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество холостых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (KH.MaskFull)
                    {
                        int B = int.Parse(KH.Text);
                        if (B > 0)
                        {
                            R1.Text = "Х";

                            KolvoHolost();
                        }
                        else
                        {
                            MessageBox.Show("Количество холостых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество холостых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void B2_Click(object sender, EventArgs e) // Проверить ячейку, поставить боевой, отнять боевой из количества и прибавить холостой если был раньше в ячейке
        {
            if (R2.Text != "Б")
            {
                if (R2.Text == "Х")
                {
                    if (KB.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R2.Text = "Б";

                            KolvoBoevMinysHolost();
                        }
                        else
                        {
                            MessageBox.Show("Количество боевых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество боевых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (KB.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R2.Text = "Б";

                            KolvoBoev();
                        }
                        else
                        {
                            MessageBox.Show("Количество боевых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество боевых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void H2_Click(object sender, EventArgs e) // Проверить ячейку, поставить холостой, отнять холостой из количества и прибавить боевой если был раньше в ячейке 
        {
            if (R2.Text != "Х")
            {
                if (R2.Text == "Б")
                {
                    if (KH.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R2.Text = "Х";

                            KolvoHolostMinysBoev();
                        }
                        else
                        {
                            MessageBox.Show("Количество холостых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество холостых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (KH.MaskFull)
                    {
                        int B = int.Parse(KH.Text);
                        if (B > 0)
                        {
                            R2.Text = "Х";

                            KolvoHolost();
                        }
                        else
                        {
                            MessageBox.Show("Количество холостых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество холостых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void B3_Click(object sender, EventArgs e) // Проверить ячейку, поставить боевой, отнять боевой из количества и прибавить холостой если был раньше в ячейке 
        {
            if (R3.Text != "Б")
            {
                if (R3.Text == "Х")
                {
                    if (KB.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R3.Text = "Б";

                            KolvoBoevMinysHolost();
                        }
                        else
                        {
                            MessageBox.Show("Количество боевых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество боевых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (KB.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R3.Text = "Б";

                            KolvoBoev();
                        }
                        else
                        {
                            MessageBox.Show("Количество боевых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество боевых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void H3_Click(object sender, EventArgs e) // Проверить ячейку, поставить холостой, отнять холостой из количества и прибавить боевой если был раньше в ячейке 
        {
            if (R3.Text != "Х")
            {
                if (R3.Text == "Б")
                {
                    if (KH.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R3.Text = "Х";

                            KolvoHolostMinysBoev();
                        }
                        else
                        {
                            MessageBox.Show("Количество холостых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество холостых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (KH.MaskFull)
                    {
                        int B = int.Parse(KH.Text);
                        if (B > 0)
                        {
                            R3.Text = "Х";

                            KolvoHolost();
                        }
                        else
                        {
                            MessageBox.Show("Количество холостых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество холостых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void B4_Click(object sender, EventArgs e) // Проверить ячейку, поставить боевой, отнять боевой из количества и прибавить холостой если был раньше в ячейке 
        {
            if (R4.Text != "Б")
            {
                if (R4.Text == "Х")
                {
                    if (KB.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R4.Text = "Б";

                            KolvoBoevMinysHolost();
                        }
                        else
                        {
                            MessageBox.Show("Количество боевых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество боевых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (KB.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R4.Text = "Б";

                            KolvoBoev();
                        }
                        else
                        {
                            MessageBox.Show("Количество боевых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество боевых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void H4_Click(object sender, EventArgs e) // Проверить ячейку, поставить холостой, отнять холостой из количества и прибавить боевой если был раньше в ячейке 
        {
            if (R4.Text != "Х")
            {
                if (R4.Text == "Б")
                {
                    if (KH.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R4.Text = "Х";

                            KolvoHolostMinysBoev();
                        }
                        else
                        {
                            MessageBox.Show("Количество холостых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество холостых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (KH.MaskFull)
                    {
                        int B = int.Parse(KH.Text);
                        if (B > 0)
                        {
                            R4.Text = "Х";

                            KolvoHolost();
                        }
                        else
                        {
                            MessageBox.Show("Количество холостых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество холостых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void B5_Click(object sender, EventArgs e) // Проверить ячейку, поставить боевой, отнять боевой из количества и прибавить холостой если был раньше в ячейке 
        {
            if (R5.Text != "Б")
            {
                if (R5.Text == "Х")
                {
                    if (KB.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R5.Text = "Б";

                            KolvoBoevMinysHolost();
                        }
                        else
                        {
                            MessageBox.Show("Количество боевых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество боевых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (KB.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R5.Text = "Б";

                            KolvoBoev();
                        }
                        else
                        {
                            MessageBox.Show("Количество боевых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество боевых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void H5_Click(object sender, EventArgs e) // Проверить ячейку, поставить холостой, отнять холостой из количества и прибавить боевой если был раньше в ячейке 
        {
            if (R5.Text != "Х")
            {
                if (R5.Text == "Б")
                {
                    if (KH.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R5.Text = "Х";

                            KolvoHolostMinysBoev();
                        }
                        else
                        {
                            MessageBox.Show("Количество холостых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество холостых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (KH.MaskFull)
                    {
                        int B = int.Parse(KH.Text);
                        if (B > 0)
                        {
                            R5.Text = "Х";

                            KolvoHolost();
                        }
                        else
                        {
                            MessageBox.Show("Количество холостых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество холостых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void B6_Click(object sender, EventArgs e) // Проверить ячейку, поставить боевой, отнять боевой из количества и прибавить холостой если был раньше в ячейке 
        {
            if (R6.Text != "Б")
            {
                if (R6.Text == "Х")
                {
                    if (KB.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R6.Text = "Б";

                            KolvoBoevMinysHolost();
                        }
                        else
                        {
                            MessageBox.Show("Количество боевых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество боевых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (KB.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R6.Text = "Б";

                            KolvoBoev();
                        }
                        else
                        {
                            MessageBox.Show("Количество боевых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество боевых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void H6_Click(object sender, EventArgs e) // Проверить ячейку, поставить холостой, отнять холостой из количества и прибавить боевой если был раньше в ячейке 
        {
            if (R6.Text != "Х")
            {
                if (R6.Text == "Б")
                {
                    if (KH.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R6.Text = "Х";

                            KolvoHolostMinysBoev();
                        }
                        else
                        {
                            MessageBox.Show("Количество холостых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество холостых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (KH.MaskFull)
                    {
                        int B = int.Parse(KH.Text);
                        if (B > 0)
                        {
                            R6.Text = "Х";

                            KolvoHolost();
                        }
                        else
                        {
                            MessageBox.Show("Количество холостых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество холостых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void B7_Click(object sender, EventArgs e) // Проверить ячейку, поставить боевой, отнять боевой из количества и прибавить холостой если был раньше в ячейке 
        {
            if (R7.Text != "Б")
            {
                if (R7.Text == "Х")
                {
                    if (KB.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R7.Text = "Б";

                            KolvoBoevMinysHolost();
                        }
                        else
                        {
                            MessageBox.Show("Количество боевых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество боевых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (KB.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R7.Text = "Б";

                            KolvoBoev();
                        }
                        else
                        {
                            MessageBox.Show("Количество боевых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество боевых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void H7_Click(object sender, EventArgs e) // Проверить ячейку, поставить холостой, отнять холостой из количества и прибавить боевой если был раньше в ячейке 
        {
            if (R7.Text != "Х")
            {
                if (R7.Text == "Б")
                {
                    if (KH.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R7.Text = "Х";

                            KolvoHolostMinysBoev();
                        }
                        else
                        {
                            MessageBox.Show("Количество холостых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество холостых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (KH.MaskFull)
                    {
                        int B = int.Parse(KH.Text);
                        if (B > 0)
                        {
                            R7.Text = "Х";

                            KolvoHolost();
                        }
                        else
                        {
                            MessageBox.Show("Количество холостых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество холостых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void B8_Click(object sender, EventArgs e) // Проверить ячейку, поставить боевой, отнять боевой из количества и прибавить холостой если был раньше в ячейке 
        {
            if (R8.Text != "Б")
            {
                if (R8.Text == "Х")
                {
                    if (KB.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R8.Text = "Б";

                            KolvoBoevMinysHolost();
                        }
                        else
                        {
                            MessageBox.Show("Количество боевых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество боевых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (KB.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R8.Text = "Б";

                            KolvoBoev();
                        }
                        else
                        {
                            MessageBox.Show("Количество боевых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество боевых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void H8_Click(object sender, EventArgs e) // Проверить ячейку, поставить холостой, отнять холостой из количества и прибавить боевой если был раньше в ячейке 
        {
            if (R8.Text != "Х")
            {
                if (R8.Text == "Б")
                {
                    if (KH.MaskFull)
                    {
                        int B = int.Parse(KB.Text);
                        if (B > 0)
                        {
                            R8.Text = "Х";

                            KolvoHolostMinysBoev();
                        }
                        else
                        {
                            MessageBox.Show("Количество холостых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество холостых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (KH.MaskFull)
                    {
                        int B = int.Parse(KH.Text);
                        if (B > 0)
                        {
                            R8.Text = "Х";

                            KolvoHolost();
                        }
                        else
                        {
                            MessageBox.Show("Количество холостых не может быть 0 или меньше!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите количество холостых патронов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void CR1_Click(object sender, EventArgs e) // Вернуть патрон и очистить ячейку 
        {
            if (R1.Text != "")
            {
                if (R1.Text == "Б")
                {
                    PlusBoev();
                    R1.Text = "";
                }
                else
                {
                    PlusHolost();
                    R1.Text = "";
                }
            }
        }

        private void CR2_Click(object sender, EventArgs e) // Вернуть патрон и очистить ячейку 
        {
            if (R2.Text != "")
            {
                if (R2.Text == "Б")
                {
                    PlusBoev();
                    R2.Text = "";
                }
                else
                {
                    PlusHolost();
                    R2.Text = "";
                }
            }
        }

        private void CR3_Click(object sender, EventArgs e) // Вернуть патрон и очистить ячейку 
        {
            if (R3.Text != "")
            {
                if (R3.Text == "Б")
                {
                    PlusBoev();
                    R3.Text = "";
                }
                else
                {
                    PlusHolost();
                    R3.Text = "";
                }
            }
        }

        private void CR4_Click(object sender, EventArgs e) // Вернуть патрон и очистить ячейку 
        {
            if (R4.Text != "")
            {
                if (R4.Text == "Б")
                {
                    PlusBoev();
                    R4.Text = "";
                }
                else
                {
                    PlusHolost();
                    R4.Text = "";
                }
            }
        }

        private void CR5_Click(object sender, EventArgs e) // Вернуть патрон и очистить ячейку 
        {
            if (R5.Text != "")
            {
                if (R5.Text == "Б")
                {
                    PlusBoev();
                    R5.Text = "";
                }
                else
                {
                    PlusHolost();
                    R5.Text = "";
                }
            }
        }

        private void CR6_Click(object sender, EventArgs e) // Вернуть патрон и очистить ячейку 
        {
            if (R6.Text != "")
            {
                if (R6.Text == "Б")
                {
                    PlusBoev();
                    R6.Text = "";
                }
                else
                {
                    PlusHolost();
                    R6.Text = "";
                }
            }
        }

        private void CR7_Click(object sender, EventArgs e) // Вернуть патрон и очистить ячейку 
        {
            if (R7.Text != "")
            {
                if (R7.Text == "Б")
                {
                    PlusBoev();
                    R7.Text = "";
                }
                else
                {
                    PlusHolost();
                    R7.Text = "";
                }
            }
        }

        private void CR8_Click(object sender, EventArgs e) // Вернуть патрон и очистить ячейку 
        {
            if (R8.Text != "")
            {
                if (R8.Text == "Б")
                {
                    PlusBoev();
                    R8.Text = "";
                }
                else
                {
                    PlusHolost();
                    R8.Text = "";
                }
            }
        }
    }
}
