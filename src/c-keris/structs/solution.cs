using System;
using System.Collections.Generic;

namespace ckeris.structs{
    class Solution{
        private (int,int)[] listPoint;
        private string[] listDirection;

        public Solution(){
            listPoint = new (int,int)[0];
            listDirection = new string[0];
        }

        public void addSolution(Point point){
            //list point
            (int,int)[] newSolution = new (int,int)[point.getListPrevPointLength() + 1];
            for(int i =0; i < point.getListPrevPointLength(); i++) {
                newSolution[i] = point.getListPrevPoint()[i];
            }
            newSolution[point.getListPrevPointLength()] = point.getPoint();
            listPoint = newSolution;

            //list direction
            string[] newDirections = new string[point.getDirectionsLength()];
            
            for(int i =0; i <point.getListPrevPointLength(); i++) {
                newDirections[i] = point.getDirections()[i];
            }
            listDirection = newDirections;
        }

        public (int,int)[] getPointList(){
            return listPoint;
        }

        public string[] getListDirections(){
            return listDirection;
        }
    }
}