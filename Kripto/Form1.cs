using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kripto
{
    public partial class Kripto : Form
    {
        public Kripto()
        {
            InitializeComponent();

        }

        public void fillDataGridView(char[,] matrix)
        {

            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);

            this.dgw_matrix.ColumnCount = width;

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dgw_matrix);

                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = matrix[r, c];
                }

                this.dgw_matrix.Rows.Add(row);
            }
            dgw_matrix.AutoSize = true;
        }

        private async void btn_start_ClickAsync(object sender, EventArgs e)
        {

            char[,] matrix = new char[26, 26];
            for (int i = 0; i < 26; i++)
            {
                int start = 65 + i;
                for (int j = 0; j < 26; j++)
                {
                    if (start > 90)
                    {
                        start = 65;
                    }
                    matrix[i, j] = (char)start;
                    start++;
                }
            }

            fillDataGridView(matrix);
            string text = tb_text.Text.ToUpper();
            text = text.Trim();
            string keyword = tb_keyword.Text.ToUpper();
            keyword = keyword.Trim();
            text = text.Replace(" ", String.Empty);

            string key = keyword;
            for (int i = 0; i < text.Length; i += keyword.Length)
            {
                key = key + keyword;
            }
            if (key.Length + keyword.Length > text.Length)
            {
                key = key.Substring(0, text.Length);
            }
            int x;
            int y;
            string crypted = "";
            lbl_key.Text = "Kulcs:\n " + key;
            lbl_crypted.Text = "";
            for (int i = 0; i < text.Length; i++)
            {
                dgw_matrix.ClearSelection();
                x = 0;
                y = 0;
                while (text[i] != matrix[0, y])
                {
                    y++;
                }

                dgw_matrix.Rows[0].Cells[y].Style.BackColor = Color.Aqua;
                lbl_description.Text = "Kiválaszom a(z) " + matrix[0, y] + ".-ik oszlopot\n a szöveg következő betűje alapján.";
                //dgw_matrix.Rows[0].Cells[y].Selected = true;
                await Task.Delay(5000);
                while (key[i] != matrix[x, 0])
                {
                    x++;
                }

                dgw_matrix.Rows[x].Cells[0].Style.BackColor = Color.Yellow;
                lbl_description.Text = "Kiválaszom a(z) " + matrix[x, 0] + ".-ik sort\n a kulcs következő betűje alapján.";
                //dgw_matrix.Rows[x].Cells[0].Selected = true;
                await Task.Delay(5000);

                
                //dgw_matrix.Rows[x].Cells[y].Selected = true;
                dgw_matrix.Rows[x].Cells[y].Style.BackColor = Color.LightGreen;

                lbl_description.Text = "A(z) " + matrix[x, 0] + ".-ik sor " + matrix[0, y] + ".-ik \n eleme lesz " + text[i] + " helyettese, azaz " + matrix[x, y];
                await Task.Delay(5000);


                dgw_matrix.Rows[0].Cells[y].Style.BackColor = Color.White;
                dgw_matrix.Rows[x].Cells[0].Style.BackColor = Color.White;
                dgw_matrix.Rows[x].Cells[y].Style.BackColor = Color.White;

                crypted = crypted + matrix[x, y];
                lbl_crypted.Text = crypted;
            }
        }

    }
}
