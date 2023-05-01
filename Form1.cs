using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Loto
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }
        private void frmGame_Load(object sender, EventArgs e)
        {
            dgPcLayer.RowCount = dgPlayerLayer.RowCount = 3;
            dgPcLayer.ColumnCount = dgPlayerLayer.ColumnCount = 9;
            btnLeaveGame.Enabled = false;

            for (int i = 0; i < dgPcLayer.RowCount; i++)
            {
                dgPcLayer.Rows[i].Height = dgPlayerLayer.Rows[i].Height = 60;

            }
            for (int i = 0; i < dgPcLayer.ColumnCount; i++)
            {
                dgPcLayer.Columns[i].Width = dgPlayerLayer.Columns[i].Width = 55;
                dgPcLayer.Columns[i].DefaultCellStyle.Font =
                    dgPlayerLayer.Columns[i].DefaultCellStyle.Font =
                    new Font("MS Reference Sans Serif", 16, FontStyle.Regular);

            }
            dgPlayerLayer.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgPcLayer.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private Random rnd = new Random();
        private Thread thread;
        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            btnLeaveGame.Enabled = true;
            btnPlayGame.Enabled = false;
            gbNumbers.Enabled = true;

            dgPlayerLayer = generateDg(rnd, dgPlayerLayer);
            dgPcLayer = generateDg(rnd, dgPcLayer);

            generateArrOfRandomNums();

            thread = new Thread(generateNumber);

            thread.Start();
        }
        private void dgPcLayer_SelectionChanged(object sender, EventArgs e)
        {
            dgPcLayer.ClearSelection();
        }
        private void dgPlayerLayer_SelectionChanged(object sender, EventArgs e)
        {
            dgPlayerLayer.ClearSelection();
        }
        private DataGridView generateDg(Random rnd, DataGridView dg)
        {
            byte row;
            HashSet<byte> randomNumbers = new HashSet<byte>();
            byte number = 0;
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                row = (byte)rnd.Next(3, 4);
                for (int j = 0; j < row; j += rnd.Next(1, 3))
                {
                    if (i == 0)
                    {
                        number = (byte)rnd.Next(1, 10);
                        if (!randomNumbers.Contains(number))
                        {
                            randomNumbers.Add(number);
                            dg.Rows[j].Cells[i].Value = number;
                        }
                    }
                    else
                    {
                        number = (byte)rnd.Next(i * 10, i * 10 + 10);
                        if (!randomNumbers.Contains(number))
                        {
                            randomNumbers.Add(number);
                            dg.Rows[j].Cells[i].Value = number;
                        }
                    }
                }
            }
            return dg;
        }
        private void btnLeaveGame_Click(object sender, EventArgs e)
        {
            leave();
        }
        private void leave()
        {
            playersCount = 0;
            pcsCount = 0;

            lblCurrNumber.Invoke((MethodInvoker)delegate
            {
                lblCurrNumber.Text = "";
            });

            btnLeaveGame.Invoke((MethodInvoker)delegate
            {
                btnLeaveGame.Enabled = false;
            });

            btnPlayGame.Invoke((MethodInvoker)delegate
            {
                btnPlayGame.Enabled = true;
            });

            gbNumbers.Invoke((MethodInvoker)delegate
            {
                gbNumbers.Enabled = false;
            });

            clearDg(dgPcLayer);
            clearDg(dgPlayerLayer);

            thread.Abort();
        }
        private DataGridView clearDg(DataGridView dg)
        {
            for (int i = 0; i < dg.RowCount; i++)
            {
                for (int j = 0; j < dg.ColumnCount; j++)
                {
                    dg.Rows[i].Cells[j].Value = null;
                    dg.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
            return dg;
        }
        private byte playersCount = 0;
        private byte pcsCount = 0;
        private void dgPlayerLayer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (number == (byte)dgPlayerLayer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                {
                    dgPlayerLayer.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Blue;
                    playersCount++;
                }
            }
        }
        private byte number;
        private List<byte> numbers;
        private void generateArrOfRandomNums()
        {
            numbers = new List<byte>();
            Random rnd = new Random();
            byte k = 0;
            while (k < 90)
            {
                number = (byte)rnd.Next(1, 91);
                if (!numbers.Contains(number))
                {
                    numbers.Add(number);
                    k++;
                }
            }
        }
        private void generateNumber()
        {
            byte pcNumbersCount = countOfDgNumbers(dgPcLayer);
            byte playerNumbersCount = countOfDgNumbers(dgPlayerLayer);
            byte k = 0;
            while (true)
            {
                foreach (var item in numbers)
                {
                    number = item;
                    lblCurrNumber.Invoke((MethodInvoker)delegate
                    {
                        lblCurrNumber.Text = item.ToString();
                    });
                    checkBelateds(k);
                    checkPcNumber();
                    if (playersCount == playerNumbersCount)
                    {
                        MessageBox.Show("Player Wins!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        leave();
                    }
                    else if (pcsCount == pcNumbersCount)
                    {
                        MessageBox.Show("PC Wins!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        leave();
                    }
                    k++;
                    Thread.Sleep(2200);
                }
            }
        }
        private void checkPcNumber() // yntaciq stugum e PC-i tveric voreve meky havasar e generacvacin?
        {
            for (int i = 0; i < dgPcLayer.RowCount; i++)
            {
                for (int j = 0; j < dgPcLayer.ColumnCount; j++)
                {
                    if (dgPcLayer.Rows[i].Cells[j].Value != null && (byte)dgPcLayer.Rows[i].Cells[j].Value == number)
                    {
                        dgPcLayer.Rows[i].Cells[j].Style.BackColor = Color.Red;
                        pcsCount++;
                        return;
                    }
                }
            }
        }
        private byte countOfDgNumbers(DataGridView dg) // hashvum e dg-um exac tveri qanaky
        {
            byte count = 0;
            for (int i = 0; i < dg.RowCount; i++)
            {
                for (int j = 0; j < dg.ColumnCount; j++)
                {
                    if (dg.Rows[i].Cells[j].Value != null)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        private void checkBelateds(byte k)//xaxacoxi ushacrac tveri fixum, 1 ushacumic partutyun
        {
            for (int i = 0; i < dgPlayerLayer.RowCount; i++)
            {
                for (int j = 0; j < dgPlayerLayer.ColumnCount; j++)
                {
                    if (k > 0 && dgPlayerLayer.Rows[i].Cells[j].Value != null && dgPlayerLayer.Rows[i].Cells[j].Style.BackColor != Color.Blue && dgPlayerLayer.Rows[i].Cells[j].Style.BackColor != Color.Red && (byte)dgPlayerLayer.Rows[i].Cells[j].Value == numbers[k - 1])
                    #region comment 
                        // ete generacvac tivy ka, bayc chi nshvel` texadrvum e karmir X (stuguvum e ete kapuyt back chuni, ete karmir back chuni, ete null che, ev k>0, vor -1-i depqum sxal chta) 
                    #endregion
                    {
                        dgPlayerLayer.Rows[i].Cells[j].Value = "X";
                        dgPlayerLayer.Rows[i].Cells[j].Style.BackColor = Color.Red;
                        MessageBox.Show("PC Wins!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        leave();
                        return;
                    }
                }
            }
        }
    }
}
