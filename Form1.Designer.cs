namespace Loto
{
    partial class frmGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.gbPlayers = new System.Windows.Forms.GroupBox();
            this.gbNumbers = new System.Windows.Forms.GroupBox();
            this.lblCurrNumber = new System.Windows.Forms.Label();
            this.btnLeaveGame = new System.Windows.Forms.Button();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPcImg = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGame = new System.Windows.Forms.GroupBox();
            this.dgPcLayer = new System.Windows.Forms.DataGridView();
            this.dgPlayerLayer = new System.Windows.Forms.DataGridView();
            this.lblCount = new System.Windows.Forms.Label();
            this.gbPlayers.SuspendLayout();
            this.gbNumbers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbPcImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPcLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayerLayer)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPlayers
            // 
            this.gbPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(187)))), ((int)(((byte)(100)))));
            this.gbPlayers.Controls.Add(this.lblCount);
            this.gbPlayers.Controls.Add(this.gbNumbers);
            this.gbPlayers.Controls.Add(this.btnLeaveGame);
            this.gbPlayers.Controls.Add(this.btnPlayGame);
            this.gbPlayers.Controls.Add(this.groupBox1);
            this.gbPlayers.Controls.Add(this.gbPcImg);
            this.gbPlayers.Location = new System.Drawing.Point(12, 12);
            this.gbPlayers.Name = "gbPlayers";
            this.gbPlayers.Size = new System.Drawing.Size(1380, 161);
            this.gbPlayers.TabIndex = 0;
            this.gbPlayers.TabStop = false;
            // 
            // gbNumbers
            // 
            this.gbNumbers.Controls.Add(this.lblCurrNumber);
            this.gbNumbers.Enabled = false;
            this.gbNumbers.Location = new System.Drawing.Point(406, 21);
            this.gbNumbers.Name = "gbNumbers";
            this.gbNumbers.Size = new System.Drawing.Size(231, 121);
            this.gbNumbers.TabIndex = 4;
            this.gbNumbers.TabStop = false;
            this.gbNumbers.Text = "Number";
            // 
            // lblCurrNumber
            // 
            this.lblCurrNumber.AutoSize = true;
            this.lblCurrNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrNumber.ForeColor = System.Drawing.Color.Blue;
            this.lblCurrNumber.Location = new System.Drawing.Point(53, 18);
            this.lblCurrNumber.Name = "lblCurrNumber";
            this.lblCurrNumber.Size = new System.Drawing.Size(0, 91);
            this.lblCurrNumber.TabIndex = 0;
            // 
            // btnLeaveGame
            // 
            this.btnLeaveGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(117)))), ((int)(((byte)(71)))));
            this.btnLeaveGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLeaveGame.Location = new System.Drawing.Point(787, 97);
            this.btnLeaveGame.Name = "btnLeaveGame";
            this.btnLeaveGame.Size = new System.Drawing.Size(146, 43);
            this.btnLeaveGame.TabIndex = 3;
            this.btnLeaveGame.Text = "Leave";
            this.btnLeaveGame.UseVisualStyleBackColor = false;
            this.btnLeaveGame.Click += new System.EventHandler(this.btnLeaveGame_Click);
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(167)))), ((int)(((byte)(71)))));
            this.btnPlayGame.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayGame.Location = new System.Drawing.Point(720, 27);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(262, 64);
            this.btnPlayGame.TabIndex = 2;
            this.btnPlayGame.Text = "Play";
            this.btnPlayGame.UseVisualStyleBackColor = false;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(1047, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player";
            // 
            // gbPcImg
            // 
            this.gbPcImg.Controls.Add(this.pictureBox1);
            this.gbPcImg.Controls.Add(this.label1);
            this.gbPcImg.Location = new System.Drawing.Point(192, 0);
            this.gbPcImg.Name = "gbPcImg";
            this.gbPcImg.Size = new System.Drawing.Size(153, 155);
            this.gbPcImg.TabIndex = 0;
            this.gbPcImg.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Computer";
            // 
            // gbGame
            // 
            this.gbGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(26)))));
            this.gbGame.Controls.Add(this.dgPcLayer);
            this.gbGame.Controls.Add(this.dgPlayerLayer);
            this.gbGame.Location = new System.Drawing.Point(12, 179);
            this.gbGame.Name = "gbGame";
            this.gbGame.Size = new System.Drawing.Size(1380, 323);
            this.gbGame.TabIndex = 1;
            this.gbGame.TabStop = false;
            // 
            // dgPcLayer
            // 
            this.dgPcLayer.AllowUserToAddRows = false;
            this.dgPcLayer.AllowUserToDeleteRows = false;
            this.dgPcLayer.AllowUserToResizeColumns = false;
            this.dgPcLayer.AllowUserToResizeRows = false;
            this.dgPcLayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgPcLayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPcLayer.ColumnHeadersVisible = false;
            this.dgPcLayer.Enabled = false;
            this.dgPcLayer.Location = new System.Drawing.Point(16, 51);
            this.dgPcLayer.MultiSelect = false;
            this.dgPcLayer.Name = "dgPcLayer";
            this.dgPcLayer.ReadOnly = true;
            this.dgPcLayer.RowHeadersVisible = false;
            this.dgPcLayer.RowHeadersWidth = 51;
            this.dgPcLayer.RowTemplate.Height = 24;
            this.dgPcLayer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgPcLayer.Size = new System.Drawing.Size(664, 225);
            this.dgPcLayer.TabIndex = 1;
            this.dgPcLayer.SelectionChanged += new System.EventHandler(this.dgPcLayer_SelectionChanged);
            // 
            // dgPlayerLayer
            // 
            this.dgPlayerLayer.AllowUserToAddRows = false;
            this.dgPlayerLayer.AllowUserToDeleteRows = false;
            this.dgPlayerLayer.AllowUserToResizeColumns = false;
            this.dgPlayerLayer.AllowUserToResizeRows = false;
            this.dgPlayerLayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgPlayerLayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlayerLayer.ColumnHeadersVisible = false;
            this.dgPlayerLayer.Location = new System.Drawing.Point(697, 51);
            this.dgPlayerLayer.MultiSelect = false;
            this.dgPlayerLayer.Name = "dgPlayerLayer";
            this.dgPlayerLayer.ReadOnly = true;
            this.dgPlayerLayer.RowHeadersVisible = false;
            this.dgPlayerLayer.RowHeadersWidth = 51;
            this.dgPlayerLayer.RowTemplate.Height = 24;
            this.dgPlayerLayer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgPlayerLayer.Size = new System.Drawing.Size(664, 225);
            this.dgPlayerLayer.TabIndex = 0;
            this.dgPlayerLayer.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgPlayerLayer_CellMouseClick);
            this.dgPlayerLayer.SelectionChanged += new System.EventHandler(this.dgPlayerLayer_SelectionChanged);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCount.Location = new System.Drawing.Point(675, 118);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(64, 25);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "label3";
            // 
            // frmGame
            // 
            this.AcceptButton = this.btnPlayGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 518);
            this.Controls.Add(this.gbGame);
            this.Controls.Add(this.gbPlayers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGame";
            this.Text = "Loto";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.gbPlayers.ResumeLayout(false);
            this.gbPlayers.PerformLayout();
            this.gbNumbers.ResumeLayout(false);
            this.gbNumbers.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbPcImg.ResumeLayout(false);
            this.gbPcImg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPcLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayerLayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayers;
        private System.Windows.Forms.GroupBox gbPcImg;
        private System.Windows.Forms.GroupBox gbGame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLeaveGame;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.DataGridView dgPcLayer;
        private System.Windows.Forms.DataGridView dgPlayerLayer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbNumbers;
        private System.Windows.Forms.Label lblCurrNumber;
        private System.Windows.Forms.Label lblCount;
    }
}

