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
        private bool useTSP = false;

        public void LoadMap(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonVisualize_Click(sender, e);
                labelNotif.Text = currentMethod;
                // show Path

                if (currentMethod == "BFS")
                {
                    Bfs result = new Bfs(textFilename.Text);

                    if (useTSP)
                    {
                        result.bfsSearchTSP();
                    }
                    else
                    {
                        result.bfsSearch();
                    }
                Thread t = new Thread(() => changeWarnaBfs(result));
                t.Start();
                labelNotif.Text = "Using " + currentMethod + "\nUsing TSP: " + useTSP.ToString() + "\n" + "Route: " + result.getSolution().getdirectionString() + "\n" + "Nodes: " + result.getCheckedPointCount().ToString() + "\n" + "Steps: " + (result.getSolution().getPointList().Length-1).ToString()+ "\n" + "Execution time: " + result.getexectime().ToString() + " ms";
                }
            if (currentMethod == "DFS")
            {
                Dfs result = new Dfs(textFilename.Text);
                if (useTSP)
                {
                    result.dfsSearchTSP();
                }
                else
                {
                    result.dfsSearch();
                }
                Thread t = new Thread(() => changeWarnaDfs(result));
                t.Start();
                labelNotif.Text = "Using " + currentMethod + "\nUsing TSP: " + useTSP.ToString() + "\n" + "Route: " + result.getSolution().getdirectionString() + "\n" + "Nodes: " + result.getCheckedPointCount().ToString() + "\n" + "Steps: " + (result.getSolution().getPointList().Length - 1).ToString() + "\n" + "Execution time: " + result.getExecTime().ToString() + " ms";
            }
        }

        private void changeWarnaBfs(Bfs result)
        {
            Map m = new Map();
            m.makeMap(textFilename.Text);
            for (int i = 0; i < result.getSolution().getPointList().Length; i++)
            {
                int row = result.getSolution().getPointList()[i].Item1;
                int col = result.getSolution().getPointList()[i].Item2;
                dataGridViewMap.Rows[row].Cells[col].Style.BackColor = Color.Green;
                dataGridViewMap.Rows[row].Cells[col].Style.ForeColor = Color.White;
                dataGridViewMap.Rows[row].Cells[col].Value = "X";
                Thread.Sleep(500);
                if (m.isStart(result.getSolution().getPointList()[i].Item1, result.getSolution().getPointList()[i].Item2))
                {
                    dataGridViewMap.Rows[row].Cells[col].Value = "S";
                }
                else if (m.isTreasure(result.getSolution().getPointList()[i].Item1, result.getSolution().getPointList()[i].Item2))
                {
                    dataGridViewMap.Rows[row].Cells[col].Value = "T";
                }
                else
                {
                    dataGridViewMap.Rows[row].Cells[col].Value = "";
                }
            }
        }

        private void changeWarnaDfs(Dfs result)
        {
            Map m = new Map();
            m.makeMap(textFilename.Text);
            for (int i = 0; i < result.getSolution().getPointList().Length; i++)
            {
                int row = result.getSolution().getPointList()[i].Item1;
                int col = result.getSolution().getPointList()[i].Item2;
                dataGridViewMap.Rows[row].Cells[col].Style.BackColor = Color.Green;
                dataGridViewMap.Rows[row].Cells[col].Style.ForeColor = Color.White;
                dataGridViewMap.Rows[row].Cells[col].Value = "X";
                Thread.Sleep(500);
                if (m.isStart(result.getSolution().getPointList()[i].Item1, result.getSolution().getPointList()[i].Item2))
                {
                    dataGridViewMap.Rows[row].Cells[col].Value = "S";
                }
                else if (m.isTreasure(result.getSolution().getPointList()[i].Item1, result.getSolution().getPointList()[i].Item2))
                {
                    dataGridViewMap.Rows[row].Cells[col].Value = "T";
                }
                else
                {
                    dataGridViewMap.Rows[row].Cells[col].Value = "";
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            useTSP = !useTSP;
        }

        private void buttonVisualize_Click(object sender, EventArgs e)
        {
            dataGridViewMap.ColumnCount = 0;
            // Loading map
            if (textFilename.Text != "")
            {
                bool filenotfound = false;
                Map m = new Map();
                try
                {
                    m.makeMap(textFilename.Text);
                }
                catch (FileNotFoundException er)
                {
                    labelNotif.Text = "File tidak ditemukan!";
                    filenotfound = true;
                }
                dataGridViewMap.ColumnCount = m.getN();

                if (!m.isValid())
                {
                    labelNotif.Text = "Map tidak valid!";
                }
                else {
                    //dataGridViewMap.Size = new System.Drawing.Size(22 * m.getM(), 22 * m.getN());
                    if (!filenotfound)
                    {
                        labelNotif.Text = "";
                    }
                    for (int i = 0; i < m.getM(); i++)
                    {
                        string[] row = new string[m.getN()];
                        for (int j = 0; j < m.getN(); j++)
                        {
                            row[j] = m.get(i, j).ToString();
                        }
                        dataGridViewMap.Rows.Add(row);
                    }
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
                }
            }
        }

        private void labelJudul_Click(object sender, EventArgs e)
        {

        }

        // button visualize end
    }
}