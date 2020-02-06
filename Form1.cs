using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SliderPuzzle
{
    public partial class Form1 : Form
    {
        public bool completed;
        public PictureBox[] allTiles;
        public PictureBox[] allNumbers;
        public Dictionary<string, Image> allImages;
        public Random random = new Random();
        public PictureBox currentBlankTile;

        public Form1()
        {
            InitializeComponent();

            allTiles = new PictureBox[9] { one, two, three, four, five, six, seven, eight, nine };
            
            allImages = new Dictionary<string, Image>()
            {
                { "one", Properties.Resources.one },
                { "two", Properties.Resources.two },
                { "three", Properties.Resources.three },
                { "four", Properties.Resources.four },
                { "five", Properties.Resources.five },
                { "six", Properties.Resources.six },
                { "seven", Properties.Resources.seven },
                { "eight", Properties.Resources.eight },
                { "blank", Properties.Resources.blank }
            };
        }

        private void shuffleButton(object sender, EventArgs e)
        {
            for (var i = 0; i < allTiles.Length; i++)
            {
                allTiles[i].Image = null;
            }

            var shuffledImages = new Stack<string>(allImages.Keys.OrderBy(x => Guid.NewGuid()).ToList());
            Image imageToPlace;

            for (var i = 0; i < allTiles.Length; i++)
            {
                var imageToPlaceKey = shuffledImages.Pop();
                imageToPlace = allImages[imageToPlaceKey];
                

                allTiles[i].Image = imageToPlace;
                allTiles[i].Tag = imageToPlaceKey;
                Debug.WriteLine("tag:      " + allTiles[i].Tag);

                if (imageToPlaceKey == "blank")
                {
                    allTiles[i].Tag = "blank";
                }
            }
            completed = false;
        }

        private void swapTile(object sender, EventArgs e)
        {
           var tile = (PictureBox)sender;

           if ((String)tile.Tag == "blank")
            {
                MessageBox.Show("Pick a tile that has a number");
                return;
            }

            var blankTileToSwap = getBlankTile();

            var blankTileRow = getTileRow(blankTileToSwap);
            var blankTileCol = getTileCol(blankTileToSwap);
            var tileRow = getTileRow(tile);
            var tileCol = getTileCol(tile);

            // here you need to have an if that checks if the tile is above/below/left/right adjacent to the blank.
            if (blankTileCol == tileCol)
            {
                if(tileRow + 1 == blankTileRow || blankTileRow + 1 == tileRow)
                {
                    helperSwapTile(tile, blankTileToSwap);
                    if (checkForComplete())
                    {
                        MessageBox.Show("Completed");
                        return;
                    }
                    return;
                }
            }

            if (blankTileRow == tileRow)
            {
                if(tileCol + 1 == blankTileCol || blankTileCol + 1 == tileCol)
                {
                    helperSwapTile(tile, blankTileToSwap);
                    if (checkForComplete())
                    {
                        MessageBox.Show("Completed");
                        return;
                    }
                    return;
                }
            }            
        }

        private void helperSwapTile(PictureBox tile, PictureBox blankTile)
        {
            var imageToPlace = tile.Image;
            blankTile.Image = imageToPlace;
            blankTile.Tag = tile.Tag;

            tile.Image = Properties.Resources.blank;
            tile.Tag = "blank";
        }

        private int getTileRow(PictureBox tile)
        {
            int tileIndex = Array.IndexOf(allTiles, tile);
            return tileIndex / 3;
            // 0/3 == 0. 1/3 == 0. 2/3 == 0.
            // 3/3 == 1. 4/3 == 1. 5/3 == 1.
            // 6/3 == 2. 7/3 == 2. 8/3 == 2.
        }

        private int getTileCol(PictureBox tile)
        {
            int tileIndex = Array.IndexOf(allTiles, tile);
            return tileIndex % 3;
            // 0%3 == 0. 1%3 == 1. 2%3 == 2
        }

        private PictureBox getBlankTile()
        {
            for (var i = 0; i < allTiles.Length; i++)
            {
                if((String)allTiles[i].Tag == "blank")
                {
                    currentBlankTile = allTiles[i];
                }
            }
            // fix this
            return currentBlankTile;
        }


        private bool checkForComplete()
        {
            var sortedKeys = new String[9] { "one", "two", "three", "four", "five", "six", "seven", "eight", "blank" };
            var index = 0;
            for(var i = 0; i < allTiles.Length; i++)
            {
                if((String)allTiles[i].Tag != sortedKeys[index])
                {
                    Debug.WriteLine((String)allTiles[i].Tag + "........." + sortedKeys[index]);
                    return false;
                }
                index++;
            }
            return true;
        }
    }
}
