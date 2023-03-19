using System;
using System.IO;
using System.Text;

namespace map{
    class Map{
        private int N;
        private char[,] data;

        /* default ctor */
        public Map(){
            N = 0;
            data = new char[1,1];
        }

        /* ctor with parameter */
        public Map(int n){
            N = n;
            data = new char[n,n];
            for(int i = 0; i < N; i++){
                for(int j = 0; j < N; j++){
                    data[i,j] = '.';
                }
            }
        }

        /* set nilai N */
        public void setN(int n){
            N = n;
            data = new char[n,n];
            for(int i = 0; i < N; i++){
                for(int j = 0; j < N; j++){
                    data[i,j] = '.';
                }
            }
        }

        public char get(int i, int j){
            return data[i,j];
        }

        /* return nilai N */
        public int getN(){
            return N;
        }

        public bool isTreasure(int i, int j){
            return get(i,j) == 'T';
        }

        public bool isStart(int i, int j){
            return get(i,j) == 'K';
        }

        public bool isJalan(int i, int j){
            return get(i,j) == 'R' || get(i,j) ==  'T' || get(i,j) == 'K';
        }

        public bool isNotJalan(int i, int j){
            return get(i,j) == 'X';
        }

        public (int, int) startPoint(){
            int i;
            int j;
            i = 0;
            j = 0;
            bool found = false;
            while(i < N && !found){
                j = 0;
                while(j < N && !found){
                    if (isStart(i,j)){
                        found = true;
                    }
                    if (!found){
                        j++;
                    }
                }
                if (!found){
                    i++;
                }
            }
            return (i,j);
        }
        
        /* buat map dari file */
        public void makeMap(string filename){
            int n = 0;
            foreach (string line in System.IO.File.ReadLines("test\\" + filename)){
                n++;
            }
            setN(n);
            int i = 0;
            foreach (string line in System.IO.File.ReadLines("test\\" + filename)){
                int j = 0;
                foreach(char c in line){
                    if(c != ' '){
                        data[i,j] = c;
                        j++;
                    }
                }
                i++;
            }
        }

        public void printMap(){
            for(int i = 0; i < N; i++){
                for(int j = 0; j < N; j++){
                    Console.Write(data[i,j]);
                }
                Console.WriteLine();
            }
        }

        public static void Main(){
            Map m = new Map();
            m.makeMap("exMap.txt");
            m.printMap();
        }
    }
}