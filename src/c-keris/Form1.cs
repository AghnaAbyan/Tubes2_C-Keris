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
using ckeris.structs;
using ckeris.algoritma;
using System.IO;
using ckeris.algoritma;
using ckeris.structs;

namespace ckeris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string currentMethod;

        public void LoadMap(object sender, EventArgs e)
        {
           
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            dataGridViewMap.Visible = true;
            /*
            dataGridViewMap.ColumnCount = 5;
            for (int i = 0; i < 5; i++)
            {
                string[] row = new string[5];
                for (int j = 0; j < 5; j++)
                {
                    row[j] = 0.ToString();
                }
                dataGridViewMap.Rows.Add(row);
            } */
            dataGridViewMap.ColumnCount = 0;
            // Loading map
            if (textFilename.Text != "")
            {
                Map m = new Map();
                try
                {
                    m.makeMap(textFilename.Text);
                }
                catch(FileNotFoundException er)
                {
                    labelNotif.Text = "File not found!";
                }
                dataGridViewMap.ColumnCount = m.getN();

                dataGridViewMap.Size = new System.Drawing.Size(22 * m.getN(), 22 * m.getN());

                for (int i = 0; i < m.getN(); i++)
                {
                    string[] row = new string[m.getN()];
                    for (int j = 0; j < m.getN(); j++)
                    {
                        row[j] = m.get(i, j).ToString();
                    }
                    dataGridViewMap.Rows.Add(row);
                }
                int size;
                // Change value
                foreach (DataGridViewRow row in dataGridViewMap.Rows)
                {
                    for (int i = 0; i < m.getN(); i++)
                    {
                        if (row.Cells[i].Value != null)
                        {
                            if (row.Cells[i].Value.ToString() == "K")
                            {
                                row.Cells[i].Value = "";
                                row.Cells[i].Style.BackColor = Color.Blue;
                            }
                            if (row.Cells[i].Value.ToString() == "X")
                            {
                                row.Cells[i].Value = "";
                                row.Cells[i].Style.BackColor = Color.Black;
                            }
                            if (row.Cells[i].Value.ToString() == "T")
                            {
                                row.Cells[i].Value = "";
                                row.Cells[i].Style.BackColor = Color.Yellow;
                            }
                            if (row.Cells[i].Value.ToString() == "R")
                            {
                                row.Cells[i].Value = "";
                                row.Cells[i].Style.BackColor = Color.White;
                            }
                        }
                    }
                }

                labelNotif.Text = currentMethod;
                // show Path
                if (currentMethod == "BFS")
                {
                    Bfs result = new Bfs(textFilename.Text);
                    result.bfsSearch();
                    labelNotif.Text = "Path: " + result.getCheckedPointCount().ToString();
                    for (int i = 0; i < result.getSolution().getPointList().Length; i++)
                    {
                        int row = result.getSolution().getPointList()[i].Item1;
                        int col = result.getSolution().getPointList()[i].Item2;
                        labelNotif.Text = row.ToString() + ", " + col.ToString();
                        dataGridViewMap.Rows[row].Cells[col].Style.BackColor = Color.Green;
                        Thread.Sleep(1000);
                    }
                }
                if (currentMethod == "DFS")
                {
                    Dfs result = new Dfs(textFilename.Text);
                    
                }
                if (currentMethod == "TSP")
                {

                }
            }
        }

        private void buttonBFS_CheckedChanged(object sender, EventArgs e)
        {
            currentMethod = "BFS";
        }

        private void buttonDFS_CheckedChanged(object sender, EventArgs e)
        {
            currentMethod = "DFS";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            currentMethod = "TSP";
        }
    }
}
