using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayattheraces
    {
    private System.ComponentModel.IContainer components = null;

     protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

       
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.raceTrackPictureBox = new System.Windows.Forms.PictureBox();
            this.bettingParlour = new System.Windows.Forms.GroupBox();
            this.betButton = new System.Windows.Forms.Button();
            this.dogNumber = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.betValue = new System.Windows.Forms.NumericUpDown();
            this.nameLabel = new System.Windows.Forms.Label();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.betlabel2 = new System.Windows.Forms.Label();
            this.raceButton = new System.Windows.Forms.Button();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.minBetLabel = new System.Windows.Forms.Label();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.Greyhound1 = new System.Windows.Forms.PictureBox();
            this.Greyhound2 = new System.Windows.Forms.PictureBox();
            this.GreyHound3 = new System.Windows.Forms.PictureBox();
            this.GreyHound4 = new System.Windows.Forms.PictureBox();
            this.raceTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).BeginInit();
            this.bettingParlour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreyHound3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreyHound4)).BeginInit();
            this.SuspendLayout();
            
            this.raceTrackPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("raceTrackPictureBox.Image")));
            this.raceTrackPictureBox.Location = new System.Drawing.Point(12, 12);
            this.raceTrackPictureBox.Name = "raceTrackPictureBox";
            this.raceTrackPictureBox.Size = new System.Drawing.Size(968, 305);
            this.raceTrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raceTrackPictureBox.TabIndex = 0;
            this.raceTrackPictureBox.TabStop = false;
            
            this.bettingParlour.Controls.Add(this.betButton);
            this.bettingParlour.Controls.Add(this.dogNumber);
            this.bettingParlour.Controls.Add(this.label8);
            this.bettingParlour.Controls.Add(this.betValue);
            this.bettingParlour.Controls.Add(this.nameLabel);
            this.bettingParlour.Controls.Add(this.alBetLabel);
            this.bettingParlour.Controls.Add(this.bobBetLabel);
            this.bettingParlour.Controls.Add(this.joeBetLabel);
            this.bettingParlour.Controls.Add(this.betlabel2);
            this.bettingParlour.Controls.Add(this.raceButton);
            this.bettingParlour.Controls.Add(this.alRadioButton);
            this.bettingParlour.Controls.Add(this.bobRadioButton);
            this.bettingParlour.Controls.Add(this.minBetLabel);
            this.bettingParlour.Controls.Add(this.joeRadioButton);
            this.bettingParlour.Location = new System.Drawing.Point(12, 324);
            this.bettingParlour.Name = "bettingParlour";
            this.bettingParlour.Size = new System.Drawing.Size(968, 137);
            this.bettingParlour.TabIndex = 1;
            this.bettingParlour.TabStop = false;
            this.bettingParlour.Text = "Betting Parlour";
            
            this.betButton.Location = new System.Drawing.Point(65, 106);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(52, 23);
            this.betButton.TabIndex = 14;
            this.betButton.Text = "Bets";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            
            this.dogNumber.Location = new System.Drawing.Point(348, 107);
            this.dogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumber.Name = "dogNumber";
            this.dogNumber.Size = new System.Drawing.Size(60, 20);
            this.dogNumber.TabIndex = 13;
            this.dogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
           
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "pounds on Dog number";
           
            this.betValue.Location = new System.Drawing.Point(122, 107);
            this.betValue.Name = "betValue";
            this.betValue.Size = new System.Drawing.Size(60, 20);
            this.betValue.TabIndex = 11;
            
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(28, 111);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "name";
            
            this.alBetLabel.AutoSize = true;
            this.alBetLabel.Location = new System.Drawing.Point(347, 83);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(57, 13);
            this.alBetLabel.TabIndex = 8;
            this.alBetLabel.Text = "alBetLabel";
           
            this.bobBetLabel.AutoSize = true;
            this.bobBetLabel.Location = new System.Drawing.Point(347, 62);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(67, 13);
            this.bobBetLabel.TabIndex = 7;
            this.bobBetLabel.Text = "bobBetLabel";
            
           
            this.joeBetLabel.AutoSize = true;
            this.joeBetLabel.Location = new System.Drawing.Point(347, 41);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(63, 13);
            this.joeBetLabel.TabIndex = 6;
            this.joeBetLabel.Text = "joeBetLabel";
           
            this.betlabel2.AutoSize = true;
            this.betlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betlabel2.Location = new System.Drawing.Point(347, 20);
            this.betlabel2.Name = "betlabel2";
            this.betlabel2.Size = new System.Drawing.Size(32, 13);
            this.betlabel2.TabIndex = 5;
            this.betlabel2.Text = "Bets";
            
            this.raceButton.Location = new System.Drawing.Point(798, 20);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(150, 100);
            this.raceButton.TabIndex = 4;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(16, 82);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(92, 17);
            this.alRadioButton.TabIndex = 3;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "alRadioButton";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(16, 60);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(102, 17);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
           
            this.minBetLabel.AutoSize = true;
            this.minBetLabel.Location = new System.Drawing.Point(16, 20);
            this.minBetLabel.Name = "minBetLabel";
            this.minBetLabel.Size = new System.Drawing.Size(89, 13);
            this.minBetLabel.TabIndex = 1;
            this.minBetLabel.Text = "minimumBetLabel";
            
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(16, 38);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(98, 17);
            this.joeRadioButton.TabIndex = 0;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
           
            this.Greyhound1.BackColor = System.Drawing.Color.Transparent;
            this.Greyhound1.Image = ((System.Drawing.Image)(resources.GetObject("Greyhound1.Image")));
            this.Greyhound1.Location = new System.Drawing.Point(12, 88);
            this.Greyhound1.Name = "Greyhound1";
            this.Greyhound1.Size = new System.Drawing.Size(100, 35);
            this.Greyhound1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Greyhound1.TabIndex = 2;
            this.Greyhound1.TabStop = false;
            
            this.Greyhound2.BackColor = System.Drawing.Color.Transparent;
            this.Greyhound2.Image = ((System.Drawing.Image)(resources.GetObject("Greyhound2.Image")));
            this.Greyhound2.Location = new System.Drawing.Point(12, 143);
            this.Greyhound2.Name = "Greyhound2";
            this.Greyhound2.Size = new System.Drawing.Size(100, 35);
            this.Greyhound2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Greyhound2.TabIndex = 3;
            this.Greyhound2.TabStop = false;
            
            this.GreyHound3.BackColor = System.Drawing.Color.Transparent;
            this.GreyHound3.Image = ((System.Drawing.Image)(resources.GetObject("GreyHound3.Image")));
            this.GreyHound3.Location = new System.Drawing.Point(12, 191);
            this.GreyHound3.Name = "GreyHound3";
            this.GreyHound3.Size = new System.Drawing.Size(100, 35);
            this.GreyHound3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GreyHound3.TabIndex = 4;
            this.GreyHound3.TabStop = false;
            
            this.GreyHound4.BackColor = System.Drawing.Color.Transparent;
            this.GreyHound4.Image = ((System.Drawing.Image)(resources.GetObject("GreyHound4.Image")));
            this.GreyHound4.Location = new System.Drawing.Point(12, 250);
            this.GreyHound4.Name = "GreyHound4";
            this.GreyHound4.Size = new System.Drawing.Size(100, 35);
            this.GreyHound4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GreyHound4.TabIndex = 5;
            this.GreyHound4.TabStop = false;
            
            this.raceTimer.Tick += new System.EventHandler(this.raceTimer_Tick);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 473);
            this.Controls.Add(this.GreyHound4);
            this.Controls.Add(this.GreyHound3);
            this.Controls.Add(this.Greyhound2);
            this.Controls.Add(this.Greyhound1);
            this.Controls.Add(this.bettingParlour);
            this.Controls.Add(this.raceTrackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Day At The Races";
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).EndInit();
            this.bettingParlour.ResumeLayout(false);
            this.bettingParlour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greyhound2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreyHound3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreyHound4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


    private System.Windows.Forms.PictureBox raceTrackPictureBox;
        private System.Windows.Forms.GroupBox bettingParlour;
        private System.Windows.Forms.NumericUpDown dogNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown betValue;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label betlabel2;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.Label minBetLabel;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.PictureBox Greyhound1;
        private System.Windows.Forms.PictureBox Greyhound2;
        private System.Windows.Forms.PictureBox GreyHound3;
        private System.Windows.Forms.PictureBox GreyHound4;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Timer raceTimer;
}
