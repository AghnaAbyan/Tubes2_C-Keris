using System;
using System.IO;

namespace map{
    class Map{
        private int N;
        private char[,] data;

        /* default ctor */
        public Map(){
            N = 0;
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

        /* return nilai N */
        public int getN(){
            return N;
        }
        
        /* buat map dari file */
        public void makeMap(string filename){
            string[] lns = File.ReadAllLines(filename);
            setN(lns.Length);
            int i = 0;
            foreach(string ln in lns){
                int j = 0;
                foreach(char c in ln){
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