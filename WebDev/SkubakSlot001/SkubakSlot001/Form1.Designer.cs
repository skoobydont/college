namespace SkubakSlot001
{
    partial class frmSlotMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSlotMachine));
            this.lblCounter1 = new System.Windows.Forms.Label();
            this.tmrWindow1 = new System.Windows.Forms.Timer(this.components);
            this.btnLever = new System.Windows.Forms.Button();
            this.picWindow1 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.picWindow2 = new System.Windows.Forms.PictureBox();
            this.lblCounter2 = new System.Windows.Forms.Label();
            this.picWindow3 = new System.Windows.Forms.PictureBox();
            this.lblCounter3 = new System.Windows.Forms.Label();
            this.tmrWindow2 = new System.Windows.Forms.Timer(this.components);
            this.tmrWindow3 = new System.Windows.Forms.Timer(this.components);
            this.picFlasher1 = new System.Windows.Forms.PictureBox();
            this.picFlasher2 = new System.Windows.Forms.PictureBox();
            this.picFlasher3 = new System.Windows.Forms.PictureBox();
            this.tmrFlasher = new System.Windows.Forms.Timer(this.components);
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblWager = new System.Windows.Forms.Label();
            this.lblWinnings = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBet100 = new System.Windows.Forms.Button();
            this.btnBet200 = new System.Windows.Forms.Button();
            this.btnBetMax = new System.Windows.Forms.Button();
            this.picStorage1 = new System.Windows.Forms.PictureBox();
            this.picStorage2 = new System.Windows.Forms.PictureBox();
            this.picStorage3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWindow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWindow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWindow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlasher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlasher2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlasher3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStorage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStorage3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCounter1
            // 
            this.lblCounter1.AutoSize = true;
            this.lblCounter1.Location = new System.Drawing.Point(124, 102);
            this.lblCounter1.Name = "lblCounter1";
            this.lblCounter1.Size = new System.Drawing.Size(13, 13);
            this.lblCounter1.TabIndex = 0;
            this.lblCounter1.Text = "1";
            this.lblCounter1.Visible = false;
            // 
            // tmrWindow1
            // 
            this.tmrWindow1.Tick += new System.EventHandler(this.tmrWindow1_Tick);
            // 
            // btnLever
            // 
            this.btnLever.BackColor = System.Drawing.Color.Transparent;
            this.btnLever.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLever.BackgroundImage")));
            this.btnLever.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLever.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLever.Location = new System.Drawing.Point(467, 209);
            this.btnLever.Name = "btnLever";
            this.btnLever.Size = new System.Drawing.Size(119, 109);
            this.btnLever.TabIndex = 1;
            this.btnLever.TabStop = false;
            this.btnLever.UseVisualStyleBackColor = false;
            this.btnLever.Click += new System.EventHandler(this.btnLever_Click);
            // 
            // picWindow1
            // 
            this.picWindow1.BackColor = System.Drawing.Color.Transparent;
            this.picWindow1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWindow1.Location = new System.Drawing.Point(65, 60);
            this.picWindow1.Name = "picWindow1";
            this.picWindow1.Size = new System.Drawing.Size(110, 76);
            this.picWindow1.TabIndex = 2;
            this.picWindow1.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic1.BackgroundImage")));
            this.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic1.Location = new System.Drawing.Point(0, 332);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(16, 16);
            this.pic1.TabIndex = 3;
            this.pic1.TabStop = false;
            this.pic1.Visible = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic2
            // 
            this.pic2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic2.BackgroundImage")));
            this.pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic2.Location = new System.Drawing.Point(12, 329);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(15, 19);
            this.pic2.TabIndex = 4;
            this.pic2.TabStop = false;
            this.pic2.Visible = false;
            // 
            // pic3
            // 
            this.pic3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic3.BackgroundImage")));
            this.pic3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic3.Location = new System.Drawing.Point(39, 328);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(27, 19);
            this.pic3.TabIndex = 5;
            this.pic3.TabStop = false;
            this.pic3.Visible = false;
            this.pic3.Click += new System.EventHandler(this.pic3_Click);
            // 
            // pic4
            // 
            this.pic4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic4.BackgroundImage")));
            this.pic4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic4.Location = new System.Drawing.Point(22, 329);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(20, 18);
            this.pic4.TabIndex = 6;
            this.pic4.TabStop = false;
            this.pic4.Visible = false;
            this.pic4.Click += new System.EventHandler(this.pic4_Click);
            // 
            // pic5
            // 
            this.pic5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic5.BackgroundImage")));
            this.pic5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic5.Location = new System.Drawing.Point(58, 329);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(20, 18);
            this.pic5.TabIndex = 7;
            this.pic5.TabStop = false;
            this.pic5.Visible = false;
            // 
            // pic6
            // 
            this.pic6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic6.BackgroundImage")));
            this.pic6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic6.Location = new System.Drawing.Point(76, 332);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(19, 16);
            this.pic6.TabIndex = 8;
            this.pic6.TabStop = false;
            this.pic6.Visible = false;
            // 
            // pic7
            // 
            this.pic7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic7.BackgroundImage")));
            this.pic7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic7.Location = new System.Drawing.Point(84, 331);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(19, 17);
            this.pic7.TabIndex = 9;
            this.pic7.TabStop = false;
            this.pic7.Visible = false;
            this.pic7.Click += new System.EventHandler(this.pic7_Click);
            // 
            // picWindow2
            // 
            this.picWindow2.BackColor = System.Drawing.Color.Transparent;
            this.picWindow2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWindow2.Location = new System.Drawing.Point(273, 60);
            this.picWindow2.Name = "picWindow2";
            this.picWindow2.Size = new System.Drawing.Size(110, 76);
            this.picWindow2.TabIndex = 11;
            this.picWindow2.TabStop = false;
            // 
            // lblCounter2
            // 
            this.lblCounter2.AutoSize = true;
            this.lblCounter2.Location = new System.Drawing.Point(335, 102);
            this.lblCounter2.Name = "lblCounter2";
            this.lblCounter2.Size = new System.Drawing.Size(13, 13);
            this.lblCounter2.TabIndex = 10;
            this.lblCounter2.Text = "1";
            this.lblCounter2.Visible = false;
            // 
            // picWindow3
            // 
            this.picWindow3.BackColor = System.Drawing.Color.Transparent;
            this.picWindow3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWindow3.Location = new System.Drawing.Point(467, 60);
            this.picWindow3.Name = "picWindow3";
            this.picWindow3.Size = new System.Drawing.Size(110, 76);
            this.picWindow3.TabIndex = 13;
            this.picWindow3.TabStop = false;
            // 
            // lblCounter3
            // 
            this.lblCounter3.AutoSize = true;
            this.lblCounter3.Location = new System.Drawing.Point(529, 102);
            this.lblCounter3.Name = "lblCounter3";
            this.lblCounter3.Size = new System.Drawing.Size(13, 13);
            this.lblCounter3.TabIndex = 12;
            this.lblCounter3.Text = "1";
            this.lblCounter3.Visible = false;
            // 
            // tmrWindow2
            // 
            this.tmrWindow2.Tick += new System.EventHandler(this.tmrWindow2_Tick);
            // 
            // tmrWindow3
            // 
            this.tmrWindow3.Tick += new System.EventHandler(this.tmrWindow3_Tick);
            // 
            // picFlasher1
            // 
            this.picFlasher1.BackColor = System.Drawing.Color.Transparent;
            this.picFlasher1.Location = new System.Drawing.Point(44, 44);
            this.picFlasher1.Name = "picFlasher1";
            this.picFlasher1.Size = new System.Drawing.Size(152, 111);
            this.picFlasher1.TabIndex = 14;
            this.picFlasher1.TabStop = false;
            // 
            // picFlasher2
            // 
            this.picFlasher2.BackColor = System.Drawing.Color.Transparent;
            this.picFlasher2.Location = new System.Drawing.Point(250, 44);
            this.picFlasher2.Name = "picFlasher2";
            this.picFlasher2.Size = new System.Drawing.Size(152, 111);
            this.picFlasher2.TabIndex = 15;
            this.picFlasher2.TabStop = false;
            this.picFlasher2.Click += new System.EventHandler(this.picFlasher2_Click);
            // 
            // picFlasher3
            // 
            this.picFlasher3.BackColor = System.Drawing.Color.Transparent;
            this.picFlasher3.Location = new System.Drawing.Point(449, 44);
            this.picFlasher3.Name = "picFlasher3";
            this.picFlasher3.Size = new System.Drawing.Size(152, 111);
            this.picFlasher3.TabIndex = 16;
            this.picFlasher3.TabStop = false;
            // 
            // tmrFlasher
            // 
            this.tmrFlasher.Tick += new System.EventHandler(this.tmrFlasher_Tick);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(270, 235);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(35, 13);
            this.lblBalance.TabIndex = 17;
            this.lblBalance.Text = "label1";
            // 
            // lblWager
            // 
            this.lblWager.AutoSize = true;
            this.lblWager.Location = new System.Drawing.Point(270, 264);
            this.lblWager.Name = "lblWager";
            this.lblWager.Size = new System.Drawing.Size(35, 13);
            this.lblWager.TabIndex = 18;
            this.lblWager.Text = "label2";
            this.lblWager.Click += new System.EventHandler(this.lblWager_Click);
            // 
            // lblWinnings
            // 
            this.lblWinnings.AutoSize = true;
            this.lblWinnings.Location = new System.Drawing.Point(214, 295);
            this.lblWinnings.Name = "lblWinnings";
            this.lblWinnings.Size = new System.Drawing.Size(35, 13);
            this.lblWinnings.TabIndex = 19;
            this.lblWinnings.Text = "label3";
            this.lblWinnings.Click += new System.EventHandler(this.lblWinnings_Click);
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(214, 235);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(31, 13);
            this.lblCash.TabIndex = 20;
            this.lblCash.Text = "Cash";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Location = new System.Drawing.Point(214, 264);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(23, 13);
            this.lblBet.TabIndex = 21;
            this.lblBet.Text = "Bet";
            this.lblBet.Click += new System.EventHandler(this.lblBet_Click);
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Location = new System.Drawing.Point(214, 295);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(26, 13);
            this.lblWin.TabIndex = 22;
            this.lblWin.Text = "Win";
            this.lblWin.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(489, 324);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBet100
            // 
            this.btnBet100.Location = new System.Drawing.Point(338, 230);
            this.btnBet100.Name = "btnBet100";
            this.btnBet100.Size = new System.Drawing.Size(75, 23);
            this.btnBet100.TabIndex = 24;
            this.btnBet100.Text = "Bet $100";
            this.btnBet100.UseVisualStyleBackColor = true;
            this.btnBet100.Click += new System.EventHandler(this.btnBet100_Click);
            // 
            // btnBet200
            // 
            this.btnBet200.Location = new System.Drawing.Point(338, 259);
            this.btnBet200.Name = "btnBet200";
            this.btnBet200.Size = new System.Drawing.Size(75, 23);
            this.btnBet200.TabIndex = 25;
            this.btnBet200.Text = "Bet $200";
            this.btnBet200.UseVisualStyleBackColor = true;
            this.btnBet200.Click += new System.EventHandler(this.btnBet300_Click);
            // 
            // btnBetMax
            // 
            this.btnBetMax.Location = new System.Drawing.Point(338, 290);
            this.btnBetMax.Name = "btnBetMax";
            this.btnBetMax.Size = new System.Drawing.Size(75, 23);
            this.btnBetMax.TabIndex = 26;
            this.btnBetMax.Text = "Bet All";
            this.btnBetMax.UseVisualStyleBackColor = true;
            this.btnBetMax.Click += new System.EventHandler(this.btnBetMax_Click);
            // 
            // picStorage1
            // 
            this.picStorage1.BackColor = System.Drawing.Color.Transparent;
            this.picStorage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picStorage1.BackgroundImage")));
            this.picStorage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStorage1.Location = new System.Drawing.Point(58, 217);
            this.picStorage1.Name = "picStorage1";
            this.picStorage1.Size = new System.Drawing.Size(117, 101);
            this.picStorage1.TabIndex = 27;
            this.picStorage1.TabStop = false;
            this.picStorage1.Visible = false;
            this.picStorage1.Click += new System.EventHandler(this.picStorageEmpty_Click);
            // 
            // picStorage2
            // 
            this.picStorage2.BackColor = System.Drawing.Color.Transparent;
            this.picStorage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picStorage2.BackgroundImage")));
            this.picStorage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStorage2.Location = new System.Drawing.Point(58, 217);
            this.picStorage2.Name = "picStorage2";
            this.picStorage2.Size = new System.Drawing.Size(117, 101);
            this.picStorage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStorage2.TabIndex = 28;
            this.picStorage2.TabStop = false;
            this.picStorage2.Visible = false;
            this.picStorage2.Click += new System.EventHandler(this.picStorageMedium_Click);
            // 
            // picStorage3
            // 
            this.picStorage3.BackColor = System.Drawing.Color.Transparent;
            this.picStorage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picStorage3.BackgroundImage")));
            this.picStorage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStorage3.Location = new System.Drawing.Point(58, 217);
            this.picStorage3.Name = "picStorage3";
            this.picStorage3.Size = new System.Drawing.Size(117, 101);
            this.picStorage3.TabIndex = 30;
            this.picStorage3.TabStop = false;
            this.picStorage3.Visible = false;
            this.picStorage3.Click += new System.EventHandler(this.picStorageFull_Click);
            // 
            // frmSlotMachine
            // 
            this.AcceptButton = this.btnLever;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(694, 347);
            this.Controls.Add(this.picStorage3);
            this.Controls.Add(this.picStorage1);
            this.Controls.Add(this.btnBetMax);
            this.Controls.Add(this.btnBet200);
            this.Controls.Add(this.btnBet100);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.lblWinnings);
            this.Controls.Add(this.lblWager);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.picWindow3);
            this.Controls.Add(this.lblCounter3);
            this.Controls.Add(this.picWindow2);
            this.Controls.Add(this.lblCounter2);
            this.Controls.Add(this.pic7);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.picWindow1);
            this.Controls.Add(this.btnLever);
            this.Controls.Add(this.lblCounter1);
            this.Controls.Add(this.picFlasher3);
            this.Controls.Add(this.picFlasher2);
            this.Controls.Add(this.picFlasher1);
            this.Controls.Add(this.picStorage2);
            this.Name = "frmSlotMachine";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSlotMachine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWindow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWindow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWindow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlasher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlasher2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlasher3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStorage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStorage3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCounter1;
        private System.Windows.Forms.Timer tmrWindow1;
        private System.Windows.Forms.Button btnLever;
        private System.Windows.Forms.PictureBox picWindow1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.PictureBox picWindow2;
        private System.Windows.Forms.Label lblCounter2;
        private System.Windows.Forms.PictureBox picWindow3;
        private System.Windows.Forms.Label lblCounter3;
        private System.Windows.Forms.Timer tmrWindow2;
        private System.Windows.Forms.Timer tmrWindow3;
        private System.Windows.Forms.PictureBox picFlasher1;
        private System.Windows.Forms.PictureBox picFlasher2;
        private System.Windows.Forms.PictureBox picFlasher3;
        private System.Windows.Forms.Timer tmrFlasher;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblWager;
        private System.Windows.Forms.Label lblWinnings;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBet100;
        private System.Windows.Forms.Button btnBet200;
        private System.Windows.Forms.Button btnBetMax;
        private System.Windows.Forms.PictureBox picStorage1;
        private System.Windows.Forms.PictureBox picStorage2;
        private System.Windows.Forms.PictureBox picStorage3;
    }
}

