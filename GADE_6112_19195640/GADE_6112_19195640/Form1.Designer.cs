namespace GADE_6112_19195640
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
            this.components = new System.ComponentModel.Container();
            this.MAPBOX = new System.Windows.Forms.RichTextBox();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnLEFT = new System.Windows.Forms.Button();
            this.btnRIGHT = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.lblMC = new System.Windows.Forms.Label();
            this.STATBOX = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BATTLEBOX = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBenemies = new System.Windows.Forms.ComboBox();
            this.AttackButton = new System.Windows.Forms.Button();
            this.LOADbtn = new System.Windows.Forms.Button();
            this.SAVEbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MAPBOX
            // 
            this.MAPBOX.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAPBOX.Location = new System.Drawing.Point(13, 13);
            this.MAPBOX.Name = "MAPBOX";
            this.MAPBOX.Size = new System.Drawing.Size(433, 437);
            this.MAPBOX.TabIndex = 1;
            this.MAPBOX.Text = "";
            // 
            // btnUP
            // 
            this.btnUP.Location = new System.Drawing.Point(534, 77);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(99, 32);
            this.btnUP.TabIndex = 2;
            this.btnUP.Text = "UP";
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnLEFT
            // 
            this.btnLEFT.Location = new System.Drawing.Point(467, 128);
            this.btnLEFT.Name = "btnLEFT";
            this.btnLEFT.Size = new System.Drawing.Size(99, 32);
            this.btnLEFT.TabIndex = 3;
            this.btnLEFT.Text = "LEFT";
            this.btnLEFT.UseVisualStyleBackColor = true;
            this.btnLEFT.Click += new System.EventHandler(this.btnLEFT_Click);
            // 
            // btnRIGHT
            // 
            this.btnRIGHT.Location = new System.Drawing.Point(604, 128);
            this.btnRIGHT.Name = "btnRIGHT";
            this.btnRIGHT.Size = new System.Drawing.Size(99, 32);
            this.btnRIGHT.TabIndex = 4;
            this.btnRIGHT.Text = "RIGHT";
            this.btnRIGHT.UseVisualStyleBackColor = true;
            this.btnRIGHT.Click += new System.EventHandler(this.btnRIGHT_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(534, 182);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(99, 32);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // lblMC
            // 
            this.lblMC.AutoSize = true;
            this.lblMC.Location = new System.Drawing.Point(535, 34);
            this.lblMC.Name = "lblMC";
            this.lblMC.Size = new System.Drawing.Size(98, 13);
            this.lblMC.TabIndex = 6;
            this.lblMC.Text = "Movement Controls";
            // 
            // STATBOX
            // 
            this.STATBOX.Location = new System.Drawing.Point(467, 262);
            this.STATBOX.Name = "STATBOX";
            this.STATBOX.Size = new System.Drawing.Size(236, 159);
            this.STATBOX.TabIndex = 7;
            this.STATBOX.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(815, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Attacking Controls";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BATTLEBOX
            // 
            this.BATTLEBOX.Location = new System.Drawing.Point(747, 262);
            this.BATTLEBOX.Name = "BATTLEBOX";
            this.BATTLEBOX.Size = new System.Drawing.Size(236, 159);
            this.BATTLEBOX.TabIndex = 13;
            this.BATTLEBOX.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(836, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Battle Info";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Player Info";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CBenemies
            // 
            this.CBenemies.FormattingEnabled = true;
            this.CBenemies.Location = new System.Drawing.Point(747, 77);
            this.CBenemies.Name = "CBenemies";
            this.CBenemies.Size = new System.Drawing.Size(236, 21);
            this.CBenemies.TabIndex = 16;
            // 
            // AttackButton
            // 
            this.AttackButton.Location = new System.Drawing.Point(818, 137);
            this.AttackButton.Name = "AttackButton";
            this.AttackButton.Size = new System.Drawing.Size(90, 23);
            this.AttackButton.TabIndex = 17;
            this.AttackButton.Text = "ATTACK";
            this.AttackButton.UseVisualStyleBackColor = true;
            this.AttackButton.Click += new System.EventHandler(this.AttackButton_Click);
            // 
            // LOADbtn
            // 
            this.LOADbtn.Location = new System.Drawing.Point(884, 427);
            this.LOADbtn.Name = "LOADbtn";
            this.LOADbtn.Size = new System.Drawing.Size(99, 23);
            this.LOADbtn.TabIndex = 18;
            this.LOADbtn.Text = "Load";
            this.LOADbtn.UseVisualStyleBackColor = true;
            this.LOADbtn.Click += new System.EventHandler(this.LOADbtn_Click);
            // 
            // SAVEbtn
            // 
            this.SAVEbtn.Location = new System.Drawing.Point(771, 427);
            this.SAVEbtn.Name = "SAVEbtn";
            this.SAVEbtn.Size = new System.Drawing.Size(99, 23);
            this.SAVEbtn.TabIndex = 19;
            this.SAVEbtn.Text = "Save";
            this.SAVEbtn.UseVisualStyleBackColor = true;
            this.SAVEbtn.Click += new System.EventHandler(this.SAVEbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 462);
            this.Controls.Add(this.SAVEbtn);
            this.Controls.Add(this.LOADbtn);
            this.Controls.Add(this.AttackButton);
            this.Controls.Add(this.CBenemies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BATTLEBOX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.STATBOX);
            this.Controls.Add(this.lblMC);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRIGHT);
            this.Controls.Add(this.btnLEFT);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.MAPBOX);
            this.Name = "Form1";
            this.Text = "Battle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox MAPBOX;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnLEFT;
        private System.Windows.Forms.Button btnRIGHT;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label lblMC;
        private System.Windows.Forms.RichTextBox STATBOX;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox BATTLEBOX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBenemies;
        private System.Windows.Forms.Button AttackButton;
        private System.Windows.Forms.Button LOADbtn;
        private System.Windows.Forms.Button SAVEbtn;
    }
}

