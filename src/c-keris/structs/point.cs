using System;
using System.Collections.Generic;

namespace ckeris.structs{
    class Point{
        private (int,int) thisPoint;
        private (int,int)[] listpreviousPoint;
        private string[] directions;

        public Point((int,int) pointnow){
            thisPoint = pointnow;
            listpreviousPoint = new (int,int)[0];
            directions = new string[0];
        }

        public Point((int,int) pointnow, Point otherpoint, string direction){
            thisPoint = pointnow;
            (int,int)[] listpreviousPointnew = new (int,int)[otherpoint.getListPrevPointLength()+1];
            for(int i = 0; i<otherpoint.getListPrevPointLength(); i++) {
                listpreviousPointnew[i] = otherpoint.getListPrevPoint()[i];
            }
            listpreviousPointnew[otherpoint.getListPrevPointLength()] = otherpoint.getPoint();
            listpreviousPoint = listpreviousPointnew;

            string[] directionsnew = new string[otherpoint.getDirectionsLength()+1];
            for(int i = 0; i<otherpoint.getDirectionsLength(); i++) {
                directionsnew[i] = otherpoint.getDirections()[i];
            }
            directionsnew[otherpoint.getDirectionsLength()] = direction;
            directions = directionsnew;
        }

        public (int,int) getPoint() {
            return thisPoint;
        }
        public (int,int)[] getListPrevPoint(){
            return listpreviousPoint;
        }

        public string[] getDirections(){
            return directions;
        }

        public int getListPrevPointLength(){
            return listpreviousPoint.Length;
        }
        public int getDirectionsLength(){
            return directions.Length;
        }
    }
}