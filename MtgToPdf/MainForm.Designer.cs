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
            this.jsonPath = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // destinationPath
            // 
            this.destinationPath.Location = new System.Drawing.Point(15, 74);
            this.destinationPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.destinationPath.Name = "destinationPath";
            this.destinationPath.Size = new System.Drawing.Size(300, 22);
            this.destinationPath.TabIndex = 1;
            this.destinationPath.DoubleClick += new System.EventHandler(this.destinationPath_DoubleClick);
            // 
            // jsonPath
            // 
            this.jsonPath.Enabled = false;
            this.jsonPath.Location = new System.Drawing.Point(124, 119);
            this.jsonPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jsonPath.Name = "jsonPath";
            this.jsonPath.Size = new System.Drawing.Size(191, 22);
            this.jsonPath.TabIndex = 3;
            this.jsonPath.DoubleClick += new System.EventHandler(this.jsonPath_DoubleClick);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(15, 288);
            this.createButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(301, 23);
            this.createButton.TabIndex = 11;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Set Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Json Path";
            // 
            // fontSize
            // 
            this.fontSize.Location = new System.Drawing.Point(15, 167);
            this.fontSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(80, 22);
            this.fontSize.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Font Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pdf Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pdf Height";
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(124, 167);
            this.width.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(80, 22);
            this.width.TabIndex = 5;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(235, 167);
            this.height.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(80, 22);
            this.height.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Margin Top";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Margin Left";
            // 
            // marginTop
            // 
            this.marginTop.Location = new System.Drawing.Point(15, 258);
            this.marginTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marginTop.Name = "marginTop";
            this.marginTop.Size = new System.Drawing.Size(145, 22);
            this.marginTop.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Margin Right";
            // 
            // marginLeft
            // 
            this.marginLeft.Location = new System.Drawing.Point(15, 213);
            this.marginLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marginLeft.Name = "marginLeft";
            this.marginLeft.Size = new System.Drawing.Size(145, 22);
            this.marginLeft.TabIndex = 7;
            // 
            // marginRight
            // 
            this.marginRight.Location = new System.Drawing.Point(171, 213);
            this.marginRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marginRight.Name = "marginRight";
            this.marginRight.Size = new System.Drawing.Size(145, 22);
            this.marginRight.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(167, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Margin Bottom";
            // 
            // marginBottom
            // 
            this.marginBottom.Location = new System.Drawing.Point(171, 258);
            this.marginBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marginBottom.Name = "marginBottom";
            this.marginBottom.Size = new System.Drawing.Size(145, 22);
            this.marginBottom.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Set Code";
            // 
            // boxSetName
            // 
            this.boxSetName.FormattingEnabled = true;
            this.boxSetName.Location = new System.Drawing.Point(15, 30);
            this.boxSetName.Name = "boxSetName";
            this.boxSetName.Size = new System.Drawing.Size(300, 24);
            this.boxSetName.TabIndex = 0;
            this.boxSetName.SelectedValueChanged += new System.EventHandler(this.boxSetName_SelectedValueChanged);
            // 
            // setCode
            // 
            this.setCode.Location = new System.Drawing.Point(15, 119);
            this.setCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setCode.Name = "setCode";
            this.setCode.Size = new System.Drawing.Size(80, 22);
            this.setCode.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 319);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.jsonPath);
            this.Controls.Add(this.destinationPath);
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
        private System.Windows.Forms.TextBox jsonPath;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
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
    }
}

