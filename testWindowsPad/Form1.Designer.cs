namespace WindowsFormsApplication1
{
    partial class FormTestGamePad
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTestGamePad));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbFrontButtons = new System.Windows.Forms.GroupBox();
            this.gbDPad = new System.Windows.Forms.GroupBox();
            this.cbA = new System.Windows.Forms.CheckBox();
            this.cbB = new System.Windows.Forms.CheckBox();
            this.cbX = new System.Windows.Forms.CheckBox();
            this.cbY = new System.Windows.Forms.CheckBox();
            this.cbDPadRight = new System.Windows.Forms.CheckBox();
            this.cbDPadLeft = new System.Windows.Forms.CheckBox();
            this.cbDPadDown = new System.Windows.Forms.CheckBox();
            this.cbDPadUp = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbRightShoulder = new System.Windows.Forms.CheckBox();
            this.cbLeftShoulder = new System.Windows.Forms.CheckBox();
            this.pbRight = new System.Windows.Forms.ProgressBar();
            this.pbLeft = new System.Windows.Forms.ProgressBar();
            this.gbThumbsticksLeft = new System.Windows.Forms.GroupBox();
            this.gbThumbsticksRight = new System.Windows.Forms.GroupBox();
            this.tbThumLeftX = new System.Windows.Forms.TrackBar();
            this.tbThumLeftY = new System.Windows.Forms.TrackBar();
            this.tbThumRightY = new System.Windows.Forms.TrackBar();
            this.tbThumRightX = new System.Windows.Forms.TrackBar();
            this.lbThumbLeftX = new System.Windows.Forms.Label();
            this.lbThumbLeftY = new System.Windows.Forms.Label();
            this.lbThumbRightY = new System.Windows.Forms.Label();
            this.lbThumbRightX = new System.Windows.Forms.Label();
            this.cbThumbRight = new System.Windows.Forms.CheckBox();
            this.cbThumbLeft = new System.Windows.Forms.CheckBox();
            this.gbFrontButtons.SuspendLayout();
            this.gbDPad.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbThumbsticksLeft.SuspendLayout();
            this.gbThumbsticksRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbThumLeftX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbThumLeftY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbThumRightY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbThumRightX)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbFrontButtons
            // 
            this.gbFrontButtons.Controls.Add(this.cbY);
            this.gbFrontButtons.Controls.Add(this.cbX);
            this.gbFrontButtons.Controls.Add(this.cbB);
            this.gbFrontButtons.Controls.Add(this.cbA);
            this.gbFrontButtons.Location = new System.Drawing.Point(226, 112);
            this.gbFrontButtons.Name = "gbFrontButtons";
            this.gbFrontButtons.Size = new System.Drawing.Size(211, 159);
            this.gbFrontButtons.TabIndex = 0;
            this.gbFrontButtons.TabStop = false;
            this.gbFrontButtons.Text = "Top Buttons";
            // 
            // gbDPad
            // 
            this.gbDPad.Controls.Add(this.cbDPadRight);
            this.gbDPad.Controls.Add(this.cbDPadLeft);
            this.gbDPad.Controls.Add(this.cbDPadDown);
            this.gbDPad.Controls.Add(this.cbDPadUp);
            this.gbDPad.Location = new System.Drawing.Point(12, 112);
            this.gbDPad.Name = "gbDPad";
            this.gbDPad.Size = new System.Drawing.Size(208, 159);
            this.gbDPad.TabIndex = 1;
            this.gbDPad.TabStop = false;
            this.gbDPad.Text = "DPad";
            // 
            // cbA
            // 
            this.cbA.AutoSize = true;
            this.cbA.Location = new System.Drawing.Point(22, 31);
            this.cbA.Name = "cbA";
            this.cbA.Size = new System.Drawing.Size(84, 21);
            this.cbA.TabIndex = 0;
            this.cbA.Text = "Button A";
            this.cbA.UseVisualStyleBackColor = true;
            // 
            // cbB
            // 
            this.cbB.AutoSize = true;
            this.cbB.Location = new System.Drawing.Point(22, 58);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(84, 21);
            this.cbB.TabIndex = 1;
            this.cbB.Text = "Button B";
            this.cbB.UseVisualStyleBackColor = true;
            // 
            // cbX
            // 
            this.cbX.AutoSize = true;
            this.cbX.Location = new System.Drawing.Point(22, 85);
            this.cbX.Name = "cbX";
            this.cbX.Size = new System.Drawing.Size(84, 21);
            this.cbX.TabIndex = 2;
            this.cbX.Text = "Button X";
            this.cbX.UseVisualStyleBackColor = true;
            // 
            // cbY
            // 
            this.cbY.AutoSize = true;
            this.cbY.Location = new System.Drawing.Point(22, 112);
            this.cbY.Name = "cbY";
            this.cbY.Size = new System.Drawing.Size(84, 21);
            this.cbY.TabIndex = 3;
            this.cbY.Text = "Button Y";
            this.cbY.UseVisualStyleBackColor = true;
            // 
            // cbDPadRight
            // 
            this.cbDPadRight.AutoSize = true;
            this.cbDPadRight.Location = new System.Drawing.Point(31, 109);
            this.cbDPadRight.Name = "cbDPadRight";
            this.cbDPadRight.Size = new System.Drawing.Size(63, 21);
            this.cbDPadRight.TabIndex = 7;
            this.cbDPadRight.Text = "Right";
            this.cbDPadRight.UseVisualStyleBackColor = true;
            // 
            // cbDPadLeft
            // 
            this.cbDPadLeft.AutoSize = true;
            this.cbDPadLeft.Location = new System.Drawing.Point(31, 82);
            this.cbDPadLeft.Name = "cbDPadLeft";
            this.cbDPadLeft.Size = new System.Drawing.Size(54, 21);
            this.cbDPadLeft.TabIndex = 6;
            this.cbDPadLeft.Text = "Left";
            this.cbDPadLeft.UseVisualStyleBackColor = true;
            // 
            // cbDPadDown
            // 
            this.cbDPadDown.AutoSize = true;
            this.cbDPadDown.Location = new System.Drawing.Point(31, 55);
            this.cbDPadDown.Name = "cbDPadDown";
            this.cbDPadDown.Size = new System.Drawing.Size(65, 21);
            this.cbDPadDown.TabIndex = 5;
            this.cbDPadDown.Text = "Down";
            this.cbDPadDown.UseVisualStyleBackColor = true;
            // 
            // cbDPadUp
            // 
            this.cbDPadUp.AutoSize = true;
            this.cbDPadUp.Location = new System.Drawing.Point(31, 28);
            this.cbDPadUp.Name = "cbDPadUp";
            this.cbDPadUp.Size = new System.Drawing.Size(48, 21);
            this.cbDPadUp.TabIndex = 4;
            this.cbDPadUp.Text = "Up";
            this.cbDPadUp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbLeft);
            this.groupBox1.Controls.Add(this.cbLeftShoulder);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 104);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Front Left";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbRight);
            this.groupBox2.Controls.Add(this.cbRightShoulder);
            this.groupBox2.Location = new System.Drawing.Point(226, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 104);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Front Right";
            // 
            // cbRightShoulder
            // 
            this.cbRightShoulder.AutoSize = true;
            this.cbRightShoulder.Location = new System.Drawing.Point(22, 31);
            this.cbRightShoulder.Name = "cbRightShoulder";
            this.cbRightShoulder.Size = new System.Drawing.Size(124, 21);
            this.cbRightShoulder.TabIndex = 0;
            this.cbRightShoulder.Text = "Right Shoulder";
            this.cbRightShoulder.UseVisualStyleBackColor = true;
            // 
            // cbLeftShoulder
            // 
            this.cbLeftShoulder.AutoSize = true;
            this.cbLeftShoulder.Location = new System.Drawing.Point(19, 31);
            this.cbLeftShoulder.Name = "cbLeftShoulder";
            this.cbLeftShoulder.Size = new System.Drawing.Size(115, 21);
            this.cbLeftShoulder.TabIndex = 4;
            this.cbLeftShoulder.Text = "Left Shoulder";
            this.cbLeftShoulder.UseVisualStyleBackColor = true;
            // 
            // pbRight
            // 
            this.pbRight.Location = new System.Drawing.Point(22, 58);
            this.pbRight.Maximum = 1000;
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(183, 23);
            this.pbRight.Step = 1;
            this.pbRight.TabIndex = 1;
            // 
            // pbLeft
            // 
            this.pbLeft.Location = new System.Drawing.Point(19, 58);
            this.pbLeft.Maximum = 1000;
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(183, 23);
            this.pbLeft.Step = 1;
            this.pbLeft.TabIndex = 5;
            // 
            // gbThumbsticksLeft
            // 
            this.gbThumbsticksLeft.Controls.Add(this.cbThumbLeft);
            this.gbThumbsticksLeft.Controls.Add(this.lbThumbLeftY);
            this.gbThumbsticksLeft.Controls.Add(this.lbThumbLeftX);
            this.gbThumbsticksLeft.Controls.Add(this.tbThumLeftY);
            this.gbThumbsticksLeft.Controls.Add(this.tbThumLeftX);
            this.gbThumbsticksLeft.Location = new System.Drawing.Point(12, 277);
            this.gbThumbsticksLeft.Name = "gbThumbsticksLeft";
            this.gbThumbsticksLeft.Size = new System.Drawing.Size(208, 277);
            this.gbThumbsticksLeft.TabIndex = 10;
            this.gbThumbsticksLeft.TabStop = false;
            this.gbThumbsticksLeft.Text = "Thumbsticks Left";
            // 
            // gbThumbsticksRight
            // 
            this.gbThumbsticksRight.Controls.Add(this.cbThumbRight);
            this.gbThumbsticksRight.Controls.Add(this.lbThumbRightX);
            this.gbThumbsticksRight.Controls.Add(this.lbThumbRightY);
            this.gbThumbsticksRight.Controls.Add(this.tbThumRightY);
            this.gbThumbsticksRight.Controls.Add(this.tbThumRightX);
            this.gbThumbsticksRight.Location = new System.Drawing.Point(226, 277);
            this.gbThumbsticksRight.Name = "gbThumbsticksRight";
            this.gbThumbsticksRight.Size = new System.Drawing.Size(205, 277);
            this.gbThumbsticksRight.TabIndex = 11;
            this.gbThumbsticksRight.TabStop = false;
            this.gbThumbsticksRight.Text = "Thumbsticks Right";
            // 
            // tbThumLeftX
            // 
            this.tbThumLeftX.Location = new System.Drawing.Point(6, 215);
            this.tbThumLeftX.Maximum = 1000;
            this.tbThumLeftX.Minimum = -1000;
            this.tbThumLeftX.Name = "tbThumLeftX";
            this.tbThumLeftX.Size = new System.Drawing.Size(196, 56);
            this.tbThumLeftX.TabIndex = 0;
            this.tbThumLeftX.TickFrequency = 100;
            // 
            // tbThumLeftY
            // 
            this.tbThumLeftY.Location = new System.Drawing.Point(19, 21);
            this.tbThumLeftY.Maximum = 1000;
            this.tbThumLeftY.Minimum = -1000;
            this.tbThumLeftY.Name = "tbThumLeftY";
            this.tbThumLeftY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbThumLeftY.Size = new System.Drawing.Size(56, 196);
            this.tbThumLeftY.TabIndex = 1;
            this.tbThumLeftY.TickFrequency = 100;
            // 
            // tbThumRightY
            // 
            this.tbThumRightY.Location = new System.Drawing.Point(16, 21);
            this.tbThumRightY.Maximum = 1000;
            this.tbThumRightY.Minimum = -1000;
            this.tbThumRightY.Name = "tbThumRightY";
            this.tbThumRightY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbThumRightY.Size = new System.Drawing.Size(56, 196);
            this.tbThumRightY.TabIndex = 3;
            this.tbThumRightY.TickFrequency = 100;
            // 
            // tbThumRightX
            // 
            this.tbThumRightX.Location = new System.Drawing.Point(3, 215);
            this.tbThumRightX.Maximum = 1000;
            this.tbThumRightX.Minimum = -1000;
            this.tbThumRightX.Name = "tbThumRightX";
            this.tbThumRightX.Size = new System.Drawing.Size(196, 56);
            this.tbThumRightX.TabIndex = 2;
            this.tbThumRightX.TickFrequency = 100;
            // 
            // lbThumbLeftX
            // 
            this.lbThumbLeftX.AutoSize = true;
            this.lbThumbLeftX.Location = new System.Drawing.Point(96, 186);
            this.lbThumbLeftX.Name = "lbThumbLeftX";
            this.lbThumbLeftX.Size = new System.Drawing.Size(17, 17);
            this.lbThumbLeftX.TabIndex = 2;
            this.lbThumbLeftX.Text = "X";
            // 
            // lbThumbLeftY
            // 
            this.lbThumbLeftY.AutoSize = true;
            this.lbThumbLeftY.Location = new System.Drawing.Point(67, 111);
            this.lbThumbLeftY.Name = "lbThumbLeftY";
            this.lbThumbLeftY.Size = new System.Drawing.Size(17, 17);
            this.lbThumbLeftY.TabIndex = 3;
            this.lbThumbLeftY.Text = "Y";
            // 
            // lbThumbRightY
            // 
            this.lbThumbRightY.AutoSize = true;
            this.lbThumbRightY.Location = new System.Drawing.Point(69, 111);
            this.lbThumbRightY.Name = "lbThumbRightY";
            this.lbThumbRightY.Size = new System.Drawing.Size(17, 17);
            this.lbThumbRightY.TabIndex = 4;
            this.lbThumbRightY.Text = "Y";
            // 
            // lbThumbRightX
            // 
            this.lbThumbRightX.AutoSize = true;
            this.lbThumbRightX.Location = new System.Drawing.Point(92, 186);
            this.lbThumbRightX.Name = "lbThumbRightX";
            this.lbThumbRightX.Size = new System.Drawing.Size(17, 17);
            this.lbThumbRightX.TabIndex = 5;
            this.lbThumbRightX.Text = "X";
            // 
            // cbThumbRight
            // 
            this.cbThumbRight.AutoSize = true;
            this.cbThumbRight.Location = new System.Drawing.Point(95, 60);
            this.cbThumbRight.Name = "cbThumbRight";
            this.cbThumbRight.Size = new System.Drawing.Size(66, 21);
            this.cbThumbRight.TabIndex = 6;
            this.cbThumbRight.Text = "Press";
            this.cbThumbRight.UseVisualStyleBackColor = true;
            // 
            // cbThumbLeft
            // 
            this.cbThumbLeft.AutoSize = true;
            this.cbThumbLeft.Location = new System.Drawing.Point(99, 60);
            this.cbThumbLeft.Name = "cbThumbLeft";
            this.cbThumbLeft.Size = new System.Drawing.Size(66, 21);
            this.cbThumbLeft.TabIndex = 7;
            this.cbThumbLeft.Text = "Press";
            this.cbThumbLeft.UseVisualStyleBackColor = true;
            // 
            // FormTestGamePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 568);
            this.Controls.Add(this.gbThumbsticksRight);
            this.Controls.Add(this.gbThumbsticksLeft);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDPad);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbFrontButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTestGamePad";
            this.Text = "Test GamePad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbFrontButtons.ResumeLayout(false);
            this.gbFrontButtons.PerformLayout();
            this.gbDPad.ResumeLayout(false);
            this.gbDPad.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbThumbsticksLeft.ResumeLayout(false);
            this.gbThumbsticksLeft.PerformLayout();
            this.gbThumbsticksRight.ResumeLayout(false);
            this.gbThumbsticksRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbThumLeftX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbThumLeftY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbThumRightY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbThumRightX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbFrontButtons;
        private System.Windows.Forms.CheckBox cbY;
        private System.Windows.Forms.CheckBox cbX;
        private System.Windows.Forms.CheckBox cbB;
        private System.Windows.Forms.CheckBox cbA;
        private System.Windows.Forms.GroupBox gbDPad;
        private System.Windows.Forms.CheckBox cbDPadRight;
        private System.Windows.Forms.CheckBox cbDPadLeft;
        private System.Windows.Forms.CheckBox cbDPadDown;
        private System.Windows.Forms.CheckBox cbDPadUp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbLeftShoulder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbRightShoulder;
        private System.Windows.Forms.ProgressBar pbLeft;
        private System.Windows.Forms.ProgressBar pbRight;
        private System.Windows.Forms.GroupBox gbThumbsticksLeft;
        private System.Windows.Forms.TrackBar tbThumLeftY;
        private System.Windows.Forms.TrackBar tbThumLeftX;
        private System.Windows.Forms.GroupBox gbThumbsticksRight;
        private System.Windows.Forms.TrackBar tbThumRightY;
        private System.Windows.Forms.TrackBar tbThumRightX;
        private System.Windows.Forms.Label lbThumbLeftY;
        private System.Windows.Forms.Label lbThumbLeftX;
        private System.Windows.Forms.Label lbThumbRightX;
        private System.Windows.Forms.Label lbThumbRightY;
        private System.Windows.Forms.CheckBox cbThumbLeft;
        private System.Windows.Forms.CheckBox cbThumbRight;

    }
}

