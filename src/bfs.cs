using System;
using System.Collections.Generic;

namespace map{
    class Bfs{
        private Queue<(int,int)> antrian;
        private Map map;
        private (int,int)[] checkedPoint;
        private int countTreasure;
        private (int,int)[] listTreasure;

        //Constructor
        public Bfs(string mapString){
            antrian = new Queue<(int, int)>();
            map = new Map();
            map.makeMap(mapString);
            checkedPoint = new (int, int)[0];
            countTreasure = map.countTreasure();
            listTreasure = new (int, int)[0];
        }
        //Memeriksa apakah titik sudah pernah diperiksa
        public bool alreadyChecked((int,int) point){
            int i=0;
            bool found =false;
            while (i<checkedPoint.Length && !found){
                if (checkedPoint[i].Item1 == point.Item1 && checkedPoint[i].Item2 == point.Item2){
                    found = true;
                }
                i++;
            }
            return found;
        }
        //Menambahkan elemen yang akan dicek
        public void addSearch(int m, int n){
            if(m != -1 && n != -1){
                if (map.isJalan(m,n) && !alreadyChecked((m,n))){
                    antrian.Enqueue((m,n));
                }
            }
        }

        //Menambahkan point yang sudah dicek ke array
        public void insertChecked((int,int) point) {
            (int,int)[] newChecked = new (int,int)[checkedPoint.Length + 1];
            for(int i =0; i<checkedPoint.Length; i++) {
                newChecked[i] = checkedPoint[i];
            }
            newChecked[checkedPoint.Length] = point;
            checkedPoint = newChecked;
        }

        //Menambah lokasi treasure yang sudah ditemukan
        public void addTreasure((int,int) point){
            (int,int)[] newChecked = new (int,int)[listTreasure.Length + 1];
            for(int i =0; i<listTreasure.Length; i++) {
                newChecked[i] = listTreasure[i];
            }
            newChecked[listTreasure.Length] = point;
            listTreasure = newChecked;
        }

        /*getter*/
        //Memeriksa jumlah treasure
        public int getTreasure(){
            return countTreasure;
        }
        //Mendapatkan list treasure
        public (int,int)[] getListTreasure(){
            return listTreasure;
        }

        //Mendapatkan list path
        public (int,int)[] getListPath(){
            return checkedPoint;
        }

        //Mendapatkan total path
        public int gettotalPath(){
            return checkedPoint.Length;
        }

        //prosedur pengecekan
        public void bfsSearch(){
            (int,int) startPoint = map.startPoint();
            addSearch(startPoint.Item1, startPoint.Item2);
            while(countTreasure != 0 && antrian.Count !=0) {
                (int,int) point = antrian.Dequeue();
                if (map.isTreasure(point.Item1,point.Item2)){
                    countTreasure--;
                    addTreasure(point);
                }
                (int,int) up = map.getUp(point.Item1,point.Item2);
                (int,int) right = map.getRight(point.Item1,point.Item2);
                (int,int) down = map.getDown(point.Item1,point.Item2);
                (int,int) left = map.getLeft(point.Item1,point.Item2);
                addSearch(up.Item1,up.Item2);
                addSearch(right.Item1,right.Item2);
                addSearch(down.Item1,down.Item2);
                addSearch(left.Item1,left.Item2);
                insertChecked(point);
            }
            
        }

        //Display path
        public void displayPath(){
            for(int i=0; i<checkedPoint.Length; i++) {
                Console.WriteLine(checkedPoint[i]);
            }
        }

        //Display treasure
        public void displayTreasure(){
            for(int i=0; i<listTreasure.Length; i++) {
                Console.WriteLine(listTreasure[i]);
            }
        }

        //display queue
        public void displayQueue(){
            Console.WriteLine("Antrian: ");
            Queue<(int,int)> antrianNew = new Queue<(int, int)>();
            for(int i=0; i<antrian.Count; i++) {
                (int,int) x = antrian.Dequeue();
                Console.WriteLine(x);
                antrianNew.Enqueue(x);
            }
            antrian = antrianNew;
        }
    }
}