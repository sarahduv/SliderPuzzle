using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SliderPuzzle
{
    public partial class Form1 : Form
    {
        public bool completed;
        public PictureBox[] allTiles;
        public PictureBox[] allNumbers;
        public Image[] allImages;
        public Random random = new Random();
        public PictureBox currentBlankTile;

        public Form1()
        {
            InitializeComponent();

            allTiles = new PictureBox[9] { one, two, three, four, five, six, seven, eight, nine };
            allImages = new Image[9]
            {
                Properties.Resources.one,
                Properties.Resources.two,
                Properties.Resources.three,
                Properties.Resources.four,
                Properties.Resources.five,
                Properties.Resources.six,
                Properties.Resources.seven,
                Properties.Resources.eight,
                Properties.Resources.blank
            };
        }

        private void shuffleButton(object sender, EventArgs e)
        {
            for (var i = 0; i < allTiles.Length; i++)
            {
                allTiles[i].Image = null;
            }

            var shuffledImages = new Stack<Image>(allImages.OrderBy(x => Guid.NewGuid()).ToList());
            Image imageToPlace;

            for (var i = 0; i < allTiles.Length; i++)
            {
                imageToPlace = shuffledImages.Pop();
                allTiles[i].Image = imageToPlace;
                allTiles[i].Tag = imageToPlace.ToString();

                if (imageToPlace.ToString() == "blank")
                {
                    allTiles[i].Tag = "blank";
                    MessageBox.Show("Blank is: " + allTiles[i].Tag);
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
            }

            var blankTileToSwap = getBlankTile();
            var imageToPlace = tile.Image;
            blankTileToSwap.Image = imageToPlace;
            blankTileToSwap.Tag = tile.Tag.ToString();

            tile.Image = Properties.Resources.blank;
            tile.Tag = "blank";
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
    }
}
