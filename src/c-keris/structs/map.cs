using System;
using System.IO;
using System.Text;

namespace ckeris.structs{
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

        public int countTreasure(){
            int count = 0;
            for(int i=0; i< N; i++){
                for(int j=0; j<N; j++){
                    if (isTreasure(i,j)){
                        count++;
                    }
                }
            }
            return count;
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

        public (int,int) getUp(int i, int j) {
            if(i==0){
                return (-1,-1);
            }
            else{
                return (i-1,j);
            }
        }

        public (int,int) getRight(int i, int j) {
            if(j==N-1){
                return (-1,-1);
            }
            else{
                return (i,j+1);
            }
        }

        public (int,int) getDown(int i, int j) {
            if(i==N-1){
                return (-1,-1);
            }
            else{
                return (i+1,j);
            }
        }

        public (int,int) getLeft(int i, int j) {
            if(j==0){
                return (-1,-1);
            }
            else{
                return (i,j-1);
            }
        }
        
        /* buat map dari file */
        public void makeMap(string filename){
            int n = 0;
            foreach (string line in System.IO.File.ReadLines("..\\..\\test\\" + filename)){
                n++;
            }
            setN(n);
            int i = 0;
            foreach (string line in System.IO.File.ReadLines("..\\..\\test\\" + filename)){
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
        /*
        public static void Main(){
            Map m = new Map();
            m.makeMap("exMap.txt");
            m.printMap();
            Bfs resultBFS = new Bfs("exMap.txt");
            Console.WriteLine("=======================BFS=======================");
            Console.Write("Terdapat ");
            Console.Write(resultBFS.getTreasure());
            Console.WriteLine(" treasure yang ditemukan yaitu");
            resultBFS.bfsSearch();
            Console.WriteLine("Treasure: ");
            resultBFS.displayTreasure();
            Console.Write("Terdapat ");
            Console.Write(resultBFS.getCheckedPointCount());
            Console.WriteLine(" titik yang diperiksa");
            Console.WriteLine("Path: ");
            resultBFS.displayPath();
            resultBFS.displayDirection();
            Console.WriteLine("==========TSP==========");
            resultBFS.bfsSearchTSP();
            Console.WriteLine("Path: ");
            resultBFS.displayPath();
            resultBFS.displayDirection();

            //DFS
            Dfs resultDFS = new Dfs("exMap.txt");
            Console.WriteLine("=======================DFS=======================");
            Console.Write("Terdapat ");
            Console.Write(resultDFS.getTreasure());
            Console.WriteLine(" treasure yang ditemukan yaitu");
            resultDFS.dfsSearch();
            Console.WriteLine("Treasure: ");
            resultDFS.displayTreasure();
            Console.Write("Terdapat ");
            Console.Write(resultDFS.getCheckedPointCount());
            Console.WriteLine(" titik yang diperiksa");
            Console.WriteLine("Path: ");
            resultDFS.displayPath();
            resultDFS.displayDirection();
            Console.WriteLine("==========TSP==========");
            resultDFS.dfsSearchTSP();
            Console.WriteLine("Path: ");
            resultDFS.displayPath();
            resultDFS.displayDirection();

        }
        */
    }
}