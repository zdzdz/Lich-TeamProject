using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichtOut
{
    class Game
    {
        //create matrix of tiles
        //print buttons depending on mode
        //method to check if all lights are off

        private const int EASY_MODE = 3;
        private const int CLASSIC_MODE = 5;
        
        private int fieldSize;
        

        public Game(int gameMode)
        {
            if (gameMode == 0)
            {
                this.FieldSize = EASY_MODE;
            }
            else
            {
                this.FieldSize = CLASSIC_MODE;
            }
        }

        public int FieldSize
        {
            get
            {
                return this.fieldSize;
            }
            private set
            {
                this.fieldSize = value;
            }
        }

        public LightTile[,] GetField()
        {
            int buttonSize = (this.FieldSize == EASY_MODE) ? 150 : 100;
            int distance = 10;
            int startPosition = 5;

            LightTile[,] tileMatrix = new LightTile[this.fieldSize, this.fieldSize];

            for (int row = 0; row < this.FieldSize; row++)
            {
                for (int col = 0; col < this.FieldSize; col++)
                {
                    LightTile tempTile = new LightTile();
                    tempTile.Top = startPosition + (row * (buttonSize + distance));
                    tempTile.Left = startPosition + (col * (buttonSize + distance));
                    tileMatrix[row, col] = tempTile;
                }
            }

            return tileMatrix;
        }
    }
}
