using System;
using System.Collections.Generic;
using ckeris.structs;

namespace ckeris.algoritma
{
    class Dfs
    {
        private Stack<Point> antrian;
        private Map map;
        private Point[] checkedPoint;
        private int countTreasure;
        private (int, int)[] listTreasure;
        private Solution solution;
        private int checkedPointCount;
        private double exectime;

        // Konstruktor
        public Dfs(string mapString)
        {
            antrian = new Stack<Point>();
            map = new Map();
            map.makeMap(mapString);
            checkedPoint = new Point[0];
            countTreasure = map.countTreasure();
            listTreasure = new (int, int)[0];
            solution = new Solution();
            checkedPointCount = 0;
            exectime = 0;
        }

        // Boolean Titik Sudah Diperiksa
        public bool alreadyChecked(Point point)
        {
            int i = 0;
            bool found = false;
            while (i < checkedPoint.Length && !found)
            {
                if (checkedPoint[i].getPoint().Item1 == point.getPoint().Item1 && checkedPoint[i].getPoint().Item2 == point.getPoint().Item2)
                {
                    found = true;
                }
                i++;
            }
            return found;
        }

        //Memeriksa apakah treasure sudah pernah ditemukan sebelumnya
        public bool alreadyFound((int, int) point)
        {
            int i = 0;
            bool found = false;
            while (i < listTreasure.Length && !found)
            {
                if (listTreasure[i].Item1 == point.Item1 && listTreasure[i].Item2 == point.Item2)
                {
                    found = true;
                }
                i++;
            }
            return found;
        }

        // Menambah Elemen Yang Akan Dicek
        public void addSearch(int m, int n)
        {
            if (m != -1 && n != -1)
            {
                Point add = new Point((m, n));
                if (map.isJalan(m, n) && !alreadyChecked(add))
                {
                    antrian.Push(add);
                }
            }
        }
        public void addSearch(int m, int n, string direction, Point otherpoint)
        {
            if (m != -1 && n != -1)
            {
                Point add = new Point((m, n), otherpoint, direction);
                if (map.isJalan(m, n) && !alreadyChecked(add))
                {
                    antrian.Push(add);
                }
            }
        }

        // Menambah Point Yang Sudah Dicek
        public void insertChecked(Point point)
        {
            Point[] newChecked = new Point[checkedPoint.Length + 1];
            for (int i = 0; i < checkedPoint.Length; i++)
            {
                newChecked[i] = checkedPoint[i];
            }
            newChecked[checkedPoint.Length] = point;
            checkedPoint = newChecked;
        }

        // Menambah Lokasi Treasure Yang Terdeteksi
        public void addTreasure((int, int) point)
        {
            (int, int)[] newChecked = new (int, int)[listTreasure.Length + 1];
            for (int i = 0; i < listTreasure.Length; i++)
            {
                newChecked[i] = listTreasure[i];
            }
            newChecked[listTreasure.Length] = point;
            listTreasure = newChecked;
        }

        // Menambah Path Solusi
        public void addSolution(Point point)
        {
            solution.addSolution(point);
        }

        // Getter
        // Jumlah Treasure
        public int getTreasure()
        {
            return countTreasure;
        }

        // List Treasure
        public (int, int)[] getListTreasure()
        {
            return listTreasure;
        }

        // List Path
        public Point[] getListPath()
        {
            return checkedPoint;
        }

        // Total Path
        public int gettotalPath()
        {
            return checkedPoint.Length;
        }

        public Solution getSolution()
        {
            return solution;
        }

        public int getCheckedPointCount()
        {
            return checkedPointCount;
        }

        public double getExecTime()
        {
            return exectime;
        }

        // Prosedur Pengecekan
        public void dfsSearch()
        {
            DateTime start = DateTime.Now;
            (int, int) startPoint = map.startPoint();
            addSearch(startPoint.Item1, startPoint.Item2);
            while (countTreasure != 0)
            {
                Point point = antrian.Pop();
                checkedPointCount++;
                if (map.isTreasure(point.getPoint().Item1, point.getPoint().Item2) && !alreadyFound(point.getPoint()))
                {
                    countTreasure--;
                    addTreasure(point.getPoint());
                    //emptyCheckedPoint();
                    antrian.Clear();
                    //addSearch(point.getPoint().Item1,point.getPoint().Item2);
                    addSolution(point);
                }
                (int, int) left = map.getLeft(point.getPoint().Item1, point.getPoint().Item2);
                (int, int) down = map.getDown(point.getPoint().Item1, point.getPoint().Item2);
                (int, int) right = map.getRight(point.getPoint().Item1, point.getPoint().Item2);
                (int, int) up = map.getUp(point.getPoint().Item1, point.getPoint().Item2);
                addSearch(up.Item1, up.Item2, "U", point);
                addSearch(left.Item1, left.Item2, "L", point);
                addSearch(down.Item1, down.Item2, "D", point);
                addSearch(right.Item1, right.Item2, "R", point);
                if (antrian.Count == 0)
                {
                    emptyCheckedPoint();
                    addSearch(up.Item1, up.Item2, "U", point);
                    addSearch(left.Item1, left.Item2, "L", point);
                    addSearch(down.Item1, down.Item2, "D", point);
                    addSearch(right.Item1, right.Item2, "R", point);
                    //insertChecked(point);
                }
                insertChecked(point);
            }
            DateTime end = DateTime.Now;
            TimeSpan ts = end - start;
            exectime = ts.TotalMilliseconds;

        }

        // Travelling Salesman Problem
        public void dfsSearchTSP()
        {
            DateTime start = DateTime.Now;
            (int, int) startPoint = map.startPoint();
            addSearch(startPoint.Item1, startPoint.Item2);
            Point point = new Point((0, 0));
            while (countTreasure != 0)
            {
                point = antrian.Pop();
                checkedPointCount++;
                if (map.isTreasure(point.getPoint().Item1, point.getPoint().Item2) && !alreadyFound(point.getPoint()))
                {
                    countTreasure--;
                    addTreasure(point.getPoint());
                    emptyCheckedPoint();
                    antrian.Clear();
                    //addSearch(point.getPoint().Item1,point.getPoint().Item2);
                    addSolution(point);
                }
                (int, int) up = map.getUp(point.getPoint().Item1, point.getPoint().Item2);
                (int, int) right = map.getRight(point.getPoint().Item1, point.getPoint().Item2);
                (int, int) down = map.getDown(point.getPoint().Item1, point.getPoint().Item2);
                (int, int) left = map.getLeft(point.getPoint().Item1, point.getPoint().Item2);
                addSearch(up.Item1, up.Item2, "U", point);
                addSearch(left.Item1, left.Item2, "L", point);
                addSearch(down.Item1, down.Item2, "D", point);
                addSearch(right.Item1, right.Item2, "R", point);
                if (antrian.Count == 0)
                {
                    emptyCheckedPoint();
                    addSearch(up.Item1, up.Item2, "U", point);
                    addSearch(left.Item1, left.Item2, "L", point);
                    addSearch(down.Item1, down.Item2, "D", point);
                    addSearch(right.Item1, right.Item2, "R", point);
                    //insertChecked(point);
                }
                insertChecked(point);
            }
            (int, int) startPointBack = solution.getPointList()[solution.getPointList().Length - 1];
            antrian.Clear();
            emptyCheckedPoint();
            //addSearch(startPointBack.Item1,startPointBack.Item2);
            antrian.Push(point);
            bool found = false;
            while (!found)
            {
                point = antrian.Pop();
                if (map.isStart(point.getPoint().Item1, point.getPoint().Item2))
                {
                    found = true;
                    addSolution(point);
                }
                (int, int) left = map.getLeft(point.getPoint().Item1, point.getPoint().Item2);
                (int, int) right = map.getRight(point.getPoint().Item1, point.getPoint().Item2);
                (int, int) down = map.getDown(point.getPoint().Item1, point.getPoint().Item2);
                (int, int) up = map.getUp(point.getPoint().Item1, point.getPoint().Item2);
                addSearch(right.Item1, right.Item2, "R", point);
                addSearch(down.Item1, down.Item2, "D", point);
                addSearch(left.Item1, left.Item2, "L", point);
                addSearch(up.Item1, up.Item2, "U", point);
                insertChecked(point);
            }
            DateTime end = DateTime.Now;
            TimeSpan ts = end - start;
            exectime = ts.TotalMilliseconds;
        }

        // Display Path
        public void displayPath()
        {
            for (int i = 0; i < solution.getPointList().Length; i++)
            {
                Console.WriteLine(solution.getPointList()[i]);
            }
        }

        // Display TSP
        public void displayTSP()
        {
            for (int i = 0; i < checkedPoint.Length; i++)
            {
                Console.WriteLine(checkedPoint[i].getPoint());
            }
        }

        // Display Treasure
        public void displayTreasure()
        {
            for (int i = 0; i < listTreasure.Length; i++)
            {
                Console.WriteLine(listTreasure[i]);
            }
        }

        public void displayDirection()
        {
            for (int i = 0; i < solution.getListDirections().Length - 1; i++)
            {
                Console.Write(solution.getListDirections()[i]);
                Console.Write("-");
            }
            Console.WriteLine(solution.getListDirections()[solution.getListDirections().Length - 1]);
        }

        // Display Stack
        public void displayStack()
        {
            Console.WriteLine("Antrian: ");
            Stack<Point> antrianNew = new Stack<Point>();
            for (int i = 0; i < antrian.Count; i++)
            {
                Point x = antrian.Pop();
                (int, int) xpoint = x.getPoint();
                Console.Write(xpoint);
                Console.Write(" ");
                antrianNew.Push(x);
            }
            Console.WriteLine();
            antrian = antrianNew;
        }

        // Empty Checked Point
        public void emptyCheckedPoint()
        {
            checkedPoint = new Point[0];
        }
    }
}