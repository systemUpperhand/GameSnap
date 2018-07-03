namespace GameOfLife
{
    partial class frmMain
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
      this.components = new System.ComponentModel.Container();
      this.Canvas = new System.Windows.Forms.PictureBox();
      this.btnStart = new System.Windows.Forms.Button();
      this.createButton = new System.Windows.Forms.Button();
      this.btnDraw = new System.Windows.Forms.Button();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.label3 = new System.Windows.Forms.Label();
      this.cellSizeText = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.XText = new System.Windows.Forms.TextBox();
      this.YText = new System.Windows.Forms.TextBox();
      this.btnRandom = new System.Windows.Forms.Button();
      this.tmrLoad = new System.Windows.Forms.Timer(this.components);
      this.btnClear = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      this.SuspendLayout();
      // 
      // Canvas
      // 
      this.Canvas.BackColor = System.Drawing.Color.Black;
      this.Canvas.Location = new System.Drawing.Point(12, 12);
      this.Canvas.Name = "Canvas";
      this.Canvas.Size = new System.Drawing.Size(485, 250);
      this.Canvas.TabIndex = 0;
      this.Canvas.TabStop = false;
      // 
      // btnStart
      // 
      this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnStart.AutoSize = true;
      this.btnStart.Enabled = false;
      this.btnStart.Location = new System.Drawing.Point(524, 266);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(75, 23);
      this.btnStart.TabIndex = 1;
      this.btnStart.Text = "Start";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // createButton
      // 
      this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.createButton.Location = new System.Drawing.Point(25, 25);
      this.createButton.Name = "createButton";
      this.createButton.Size = new System.Drawing.Size(75, 23);
      this.createButton.TabIndex = 6;
      this.createButton.Text = "Create";
      this.createButton.UseVisualStyleBackColor = true;
      this.createButton.Visible = false;
      this.createButton.Click += new System.EventHandler(this.createButton_Click);
      // 
      // btnDraw
      // 
      this.btnDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDraw.Enabled = false;
      this.btnDraw.Location = new System.Drawing.Point(444, 266);
      this.btnDraw.Name = "btnDraw";
      this.btnDraw.Size = new System.Drawing.Size(74, 23);
      this.btnDraw.TabIndex = 7;
      this.btnDraw.Text = "Draw";
      this.btnDraw.UseVisualStyleBackColor = true;
      this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
      // 
      // trackBar1
      // 
      this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBar1.Location = new System.Drawing.Point(39, 268);
      this.trackBar1.Maximum = 1000;
      this.trackBar1.Minimum = 10;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(233, 45);
      this.trackBar1.SmallChange = 10;
      this.trackBar1.TabIndex = 8;
      this.trackBar1.Value = 250;
      this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(9, 271);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(38, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "Speed";
      // 
      // cellSizeText
      // 
      this.cellSizeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.cellSizeText.Location = new System.Drawing.Point(332, 268);
      this.cellSizeText.Name = "cellSizeText";
      this.cellSizeText.Size = new System.Drawing.Size(22, 20);
      this.cellSizeText.TabIndex = 10;
      this.cellSizeText.Text = "9";
      this.cellSizeText.TextChanged += new System.EventHandler(this.textCellSize_TextChanged);
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(278, 271);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(48, 13);
      this.label4.TabIndex = 11;
      this.label4.Text = "Cell size:";
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(45, 228);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Width:";
      this.label1.Visible = false;
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(169, 228);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(41, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Height:";
      this.label2.Visible = false;
      // 
      // XText
      // 
      this.XText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.XText.Location = new System.Drawing.Point(99, 224);
      this.XText.Name = "XText";
      this.XText.Size = new System.Drawing.Size(64, 20);
      this.XText.TabIndex = 2;
      this.XText.Text = "550";
      this.XText.Visible = false;
      // 
      // YText
      // 
      this.YText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.YText.Location = new System.Drawing.Point(216, 225);
      this.YText.Name = "YText";
      this.YText.Size = new System.Drawing.Size(64, 20);
      this.YText.TabIndex = 3;
      this.YText.Text = "250";
      this.YText.Visible = false;
      // 
      // btnRandom
      // 
      this.btnRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnRandom.Enabled = false;
      this.btnRandom.Location = new System.Drawing.Point(364, 266);
      this.btnRandom.Name = "btnRandom";
      this.btnRandom.Size = new System.Drawing.Size(74, 23);
      this.btnRandom.TabIndex = 12;
      this.btnRandom.Text = "Random";
      this.btnRandom.UseVisualStyleBackColor = true;
      this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
      // 
      // tmrLoad
      // 
      this.tmrLoad.Enabled = true;
      this.tmrLoad.Interval = 1000;
      this.tmrLoad.Tick += new System.EventHandler(this.tmrLoad_Tick);
      // 
      // btnClear
      // 
      this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClear.Enabled = false;
      this.btnClear.Location = new System.Drawing.Point(364, 290);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(154, 23);
      this.btnClear.TabIndex = 13;
      this.btnClear.Text = "Clear Screen";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(611, 335);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.btnRandom);
      this.Controls.Add(this.Canvas);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.cellSizeText);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.trackBar1);
      this.Controls.Add(this.btnDraw);
      this.Controls.Add(this.createButton);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.YText);
      this.Controls.Add(this.XText);
      this.Controls.Add(this.btnStart);
      this.Name = "frmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Game Of Life";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cellSizeText;
        private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox XText;
    private System.Windows.Forms.TextBox YText;
    private System.Windows.Forms.Button btnRandom;
    private System.Windows.Forms.Timer tmrLoad;
    private System.Windows.Forms.Button btnClear;
  }
}

