namespace SliderPuzzle
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nine = new System.Windows.Forms.PictureBox();
            this.eight = new System.Windows.Forms.PictureBox();
            this.seven = new System.Windows.Forms.PictureBox();
            this.six = new System.Windows.Forms.PictureBox();
            this.five = new System.Windows.Forms.PictureBox();
            this.four = new System.Windows.Forms.PictureBox();
            this.three = new System.Windows.Forms.PictureBox();
            this.two = new System.Windows.Forms.PictureBox();
            this.one = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.six)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.five)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.four)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.three)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.two)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.one)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.Controls.Add(this.nine, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.eight, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.seven, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.six, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.five, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.four, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.three, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.two, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.one, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(76, 23);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(311, 321);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // nine
            // 
            this.nine.Image = global::SliderPuzzle.Properties.Resources.blank;
            this.nine.Location = new System.Drawing.Point(210, 218);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(93, 96);
            this.nine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nine.TabIndex = 8;
            this.nine.TabStop = false;
            this.nine.Click += new System.EventHandler(this.swapTile);
            // 
            // eight
            // 
            this.eight.Image = global::SliderPuzzle.Properties.Resources.eight;
            this.eight.Location = new System.Drawing.Point(108, 218);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(93, 96);
            this.eight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eight.TabIndex = 7;
            this.eight.TabStop = false;
            this.eight.Click += new System.EventHandler(this.swapTile);
            // 
            // seven
            // 
            this.seven.Image = global::SliderPuzzle.Properties.Resources.seven;
            this.seven.Location = new System.Drawing.Point(6, 218);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(93, 96);
            this.seven.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.seven.TabIndex = 6;
            this.seven.TabStop = false;
            this.seven.Click += new System.EventHandler(this.swapTile);
            // 
            // six
            // 
            this.six.Image = global::SliderPuzzle.Properties.Resources.six;
            this.six.Location = new System.Drawing.Point(210, 112);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(93, 96);
            this.six.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.six.TabIndex = 5;
            this.six.TabStop = false;
            this.six.Click += new System.EventHandler(this.swapTile);
            // 
            // five
            // 
            this.five.Image = global::SliderPuzzle.Properties.Resources.five;
            this.five.Location = new System.Drawing.Point(108, 112);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(93, 96);
            this.five.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.five.TabIndex = 4;
            this.five.TabStop = false;
            this.five.Click += new System.EventHandler(this.swapTile);
            // 
            // four
            // 
            this.four.Image = global::SliderPuzzle.Properties.Resources.four;
            this.four.Location = new System.Drawing.Point(6, 112);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(93, 96);
            this.four.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.four.TabIndex = 3;
            this.four.TabStop = false;
            this.four.Click += new System.EventHandler(this.swapTile);
            // 
            // three
            // 
            this.three.Image = global::SliderPuzzle.Properties.Resources.three;
            this.three.Location = new System.Drawing.Point(210, 6);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(93, 96);
            this.three.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.three.TabIndex = 2;
            this.three.TabStop = false;
            this.three.Click += new System.EventHandler(this.swapTile);
            // 
            // two
            // 
            this.two.Image = global::SliderPuzzle.Properties.Resources.two;
            this.two.Location = new System.Drawing.Point(108, 6);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(93, 96);
            this.two.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.two.TabIndex = 1;
            this.two.TabStop = false;
            this.two.Click += new System.EventHandler(this.swapTile);
            // 
            // one
            // 
            this.one.Image = global::SliderPuzzle.Properties.Resources.one;
            this.one.Location = new System.Drawing.Point(6, 6);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(93, 96);
            this.one.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.one.TabIndex = 0;
            this.one.TabStop = false;
            this.one.Click += new System.EventHandler(this.swapTile);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(170, 369);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(116, 26);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Shuffle";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.shuffleButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(461, 423);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.swapTile);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.six)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.five)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.four)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.three)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.two)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.one)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox nine;
        private System.Windows.Forms.PictureBox eight;
        private System.Windows.Forms.PictureBox seven;
        private System.Windows.Forms.PictureBox six;
        private System.Windows.Forms.PictureBox five;
        private System.Windows.Forms.PictureBox four;
        private System.Windows.Forms.PictureBox three;
        private System.Windows.Forms.PictureBox two;
        private System.Windows.Forms.PictureBox one;
        private System.Windows.Forms.Button resetButton;
    }
}

