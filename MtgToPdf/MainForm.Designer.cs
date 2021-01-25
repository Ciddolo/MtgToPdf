namespace MtgToPdf
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.destinationPath = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fontSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.marginTop = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.marginLeft = new System.Windows.Forms.TextBox();
            this.marginRight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.marginBottom = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.boxSetName = new System.Windows.Forms.ComboBox();
            this.setCode = new System.Windows.Forms.TextBox();
            this.checkSingle = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.startBlank = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.endBlank = new System.Windows.Forms.TextBox();
            this.checkBoxSet = new System.Windows.Forms.CheckBox();
            this.checkBoxBlank = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // destinationPath
            // 
            this.destinationPath.Location = new System.Drawing.Point(12, 100);
            this.destinationPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.destinationPath.Name = "destinationPath";
            this.destinationPath.Size = new System.Drawing.Size(300, 22);
            this.destinationPath.TabIndex = 2;
            this.destinationPath.DoubleClick += new System.EventHandler(this.destinationPath_DoubleClick);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(12, 384);
            this.createButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(301, 23);
            this.createButton.TabIndex = 12;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Set Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination Path";
            // 
            // fontSize
            // 
            this.fontSize.Location = new System.Drawing.Point(12, 263);
            this.fontSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(80, 22);
            this.fontSize.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Font Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pdf Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pdf Height";
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(121, 263);
            this.width.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(80, 22);
            this.width.TabIndex = 6;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(232, 263);
            this.height.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(80, 22);
            this.height.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Margin Top";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Margin Left";
            // 
            // marginTop
            // 
            this.marginTop.Location = new System.Drawing.Point(12, 354);
            this.marginTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marginTop.Name = "marginTop";
            this.marginTop.Size = new System.Drawing.Size(145, 22);
            this.marginTop.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Margin Right";
            // 
            // marginLeft
            // 
            this.marginLeft.Location = new System.Drawing.Point(12, 309);
            this.marginLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marginLeft.Name = "marginLeft";
            this.marginLeft.Size = new System.Drawing.Size(145, 22);
            this.marginLeft.TabIndex = 8;
            // 
            // marginRight
            // 
            this.marginRight.Location = new System.Drawing.Point(168, 309);
            this.marginRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marginRight.Name = "marginRight";
            this.marginRight.Size = new System.Drawing.Size(145, 22);
            this.marginRight.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(164, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Margin Bottom";
            // 
            // marginBottom
            // 
            this.marginBottom.Location = new System.Drawing.Point(168, 354);
            this.marginBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marginBottom.Name = "marginBottom";
            this.marginBottom.Size = new System.Drawing.Size(145, 22);
            this.marginBottom.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Set Code";
            // 
            // boxSetName
            // 
            this.boxSetName.FormattingEnabled = true;
            this.boxSetName.Location = new System.Drawing.Point(12, 56);
            this.boxSetName.Name = "boxSetName";
            this.boxSetName.Size = new System.Drawing.Size(301, 24);
            this.boxSetName.TabIndex = 0;
            this.boxSetName.SelectedValueChanged += new System.EventHandler(this.boxSetName_SelectedValueChanged);
            // 
            // setCode
            // 
            this.setCode.Location = new System.Drawing.Point(12, 145);
            this.setCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setCode.Name = "setCode";
            this.setCode.Size = new System.Drawing.Size(145, 22);
            this.setCode.TabIndex = 3;
            // 
            // checkSingle
            // 
            this.checkSingle.AutoSize = true;
            this.checkSingle.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkSingle.Location = new System.Drawing.Point(294, 149);
            this.checkSingle.Name = "checkSingle";
            this.checkSingle.Size = new System.Drawing.Size(18, 17);
            this.checkSingle.TabIndex = 1;
            this.checkSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkSingle.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(182, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Create singles?";
            // 
            // startBlank
            // 
            this.startBlank.Location = new System.Drawing.Point(12, 220);
            this.startBlank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startBlank.Name = "startBlank";
            this.startBlank.Size = new System.Drawing.Size(50, 22);
            this.startBlank.TabIndex = 25;
            this.startBlank.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "From";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(68, 196);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 17);
            this.label15.TabIndex = 27;
            this.label15.Text = "To";
            // 
            // endBlank
            // 
            this.endBlank.Location = new System.Drawing.Point(71, 220);
            this.endBlank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endBlank.Name = "endBlank";
            this.endBlank.Size = new System.Drawing.Size(50, 22);
            this.endBlank.TabIndex = 28;
            this.endBlank.Text = "1";
            // 
            // checkBoxSet
            // 
            this.checkBoxSet.AutoSize = true;
            this.checkBoxSet.Checked = true;
            this.checkBoxSet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSet.Location = new System.Drawing.Point(12, 12);
            this.checkBoxSet.Name = "checkBoxSet";
            this.checkBoxSet.Size = new System.Drawing.Size(99, 21);
            this.checkBoxSet.TabIndex = 29;
            this.checkBoxSet.Text = "SET CARD";
            this.checkBoxSet.UseVisualStyleBackColor = true;
            this.checkBoxSet.CheckedChanged += new System.EventHandler(this.checkBoxSet_CheckedChanged);
            // 
            // checkBoxBlank
            // 
            this.checkBoxBlank.AutoSize = true;
            this.checkBoxBlank.Location = new System.Drawing.Point(12, 172);
            this.checkBoxBlank.Name = "checkBoxBlank";
            this.checkBoxBlank.Size = new System.Drawing.Size(117, 21);
            this.checkBoxBlank.TabIndex = 30;
            this.checkBoxBlank.Text = "BLANK CARD";
            this.checkBoxBlank.UseVisualStyleBackColor = true;
            this.checkBoxBlank.CheckedChanged += new System.EventHandler(this.checkBoxBlank_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 423);
            this.Controls.Add(this.checkBoxBlank);
            this.Controls.Add(this.checkBoxSet);
            this.Controls.Add(this.endBlank);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.startBlank);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.setCode);
            this.Controls.Add(this.boxSetName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.marginBottom);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.marginRight);
            this.Controls.Add(this.marginLeft);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.marginTop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fontSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.destinationPath);
            this.Controls.Add(this.checkSingle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mtg To Pdf";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox destinationPath;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fontSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox marginTop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox marginLeft;
        private System.Windows.Forms.TextBox marginRight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox marginBottom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox boxSetName;
        private System.Windows.Forms.TextBox setCode;
        private System.Windows.Forms.CheckBox checkSingle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox startBlank;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox endBlank;
        private System.Windows.Forms.CheckBox checkBoxSet;
        private System.Windows.Forms.CheckBox checkBoxBlank;
    }
}

