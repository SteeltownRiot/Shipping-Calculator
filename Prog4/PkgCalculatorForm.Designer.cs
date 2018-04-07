namespace Prog4
{
    partial class PackageCalculator
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
            this.shippingLB = new System.Windows.Forms.ListBox();
            this.shippingGB = new System.Windows.Forms.GroupBox();
            this.widthTB = new System.Windows.Forms.TextBox();
            this.originZipTB = new System.Windows.Forms.TextBox();
            this.destinationZipTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lengthTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.heightTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.weightTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addPackageButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.detailsButton = new System.Windows.Forms.Button();
            this.toUofLButton = new System.Windows.Forms.Button();
            this.fromUofLButton = new System.Windows.Forms.Button();
            this.shippingGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // shippingLB
            // 
            this.shippingLB.FormattingEnabled = true;
            this.shippingLB.ItemHeight = 20;
            this.shippingLB.Location = new System.Drawing.Point(323, 28);
            this.shippingLB.Name = "shippingLB";
            this.shippingLB.Size = new System.Drawing.Size(197, 284);
            this.shippingLB.TabIndex = 1;
            // 
            // shippingGB
            // 
            this.shippingGB.Controls.Add(this.widthTB);
            this.shippingGB.Controls.Add(this.originZipTB);
            this.shippingGB.Controls.Add(this.destinationZipTB);
            this.shippingGB.Controls.Add(this.label6);
            this.shippingGB.Controls.Add(this.lengthTB);
            this.shippingGB.Controls.Add(this.label5);
            this.shippingGB.Controls.Add(this.heightTB);
            this.shippingGB.Controls.Add(this.label4);
            this.shippingGB.Controls.Add(this.weightTB);
            this.shippingGB.Controls.Add(this.label3);
            this.shippingGB.Controls.Add(this.addPackageButton);
            this.shippingGB.Controls.Add(this.label2);
            this.shippingGB.Controls.Add(this.label1);
            this.shippingGB.Location = new System.Drawing.Point(14, 17);
            this.shippingGB.Name = "shippingGB";
            this.shippingGB.Size = new System.Drawing.Size(303, 295);
            this.shippingGB.TabIndex = 0;
            this.shippingGB.TabStop = false;
            this.shippingGB.Text = "Enter shipping data";
            // 
            // widthTB
            // 
            this.widthTB.Location = new System.Drawing.Point(186, 129);
            this.widthTB.Name = "widthTB";
            this.widthTB.Size = new System.Drawing.Size(100, 26);
            this.widthTB.TabIndex = 3;
            // 
            // originZipTB
            // 
            this.originZipTB.Location = new System.Drawing.Point(186, 27);
            this.originZipTB.Name = "originZipTB";
            this.originZipTB.Size = new System.Drawing.Size(100, 26);
            this.originZipTB.TabIndex = 0;
            // 
            // destinationZipTB
            // 
            this.destinationZipTB.Location = new System.Drawing.Point(186, 61);
            this.destinationZipTB.Name = "destinationZipTB";
            this.destinationZipTB.Size = new System.Drawing.Size(100, 26);
            this.destinationZipTB.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Weight in Pounds:";
            // 
            // lengthTB
            // 
            this.lengthTB.Location = new System.Drawing.Point(186, 95);
            this.lengthTB.Name = "lengthTB";
            this.lengthTB.Size = new System.Drawing.Size(100, 26);
            this.lengthTB.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Height in Inches:";
            // 
            // heightTB
            // 
            this.heightTB.Location = new System.Drawing.Point(186, 164);
            this.heightTB.Name = "heightTB";
            this.heightTB.Size = new System.Drawing.Size(100, 26);
            this.heightTB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Width in Inches:";
            // 
            // weightTB
            // 
            this.weightTB.Location = new System.Drawing.Point(186, 199);
            this.weightTB.Name = "weightTB";
            this.weightTB.Size = new System.Drawing.Size(100, 26);
            this.weightTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Length in Inches:";
            // 
            // addPackageButton
            // 
            this.addPackageButton.Location = new System.Drawing.Point(74, 240);
            this.addPackageButton.Name = "addPackageButton";
            this.addPackageButton.Size = new System.Drawing.Size(161, 37);
            this.addPackageButton.TabIndex = 6;
            this.addPackageButton.Text = "Add Package";
            this.addPackageButton.UseVisualStyleBackColor = true;
            this.addPackageButton.Click += new System.EventHandler(this.addPackageButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Destination Zip Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Origination Zip Code:";
            // 
            // detailsButton
            // 
            this.detailsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.detailsButton.Location = new System.Drawing.Point(541, 91);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(140, 37);
            this.detailsButton.TabIndex = 2;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // toUofLButton
            // 
            this.toUofLButton.Location = new System.Drawing.Point(541, 151);
            this.toUofLButton.Name = "toUofLButton";
            this.toUofLButton.Size = new System.Drawing.Size(140, 37);
            this.toUofLButton.TabIndex = 3;
            this.toUofLButton.Text = "Send to UofL";
            this.toUofLButton.UseVisualStyleBackColor = true;
            this.toUofLButton.Click += new System.EventHandler(this.toUofLButton_Click);
            // 
            // fromUofLButton
            // 
            this.fromUofLButton.Location = new System.Drawing.Point(541, 211);
            this.fromUofLButton.Name = "fromUofLButton";
            this.fromUofLButton.Size = new System.Drawing.Size(140, 37);
            this.fromUofLButton.TabIndex = 4;
            this.fromUofLButton.Text = "Send from UofL";
            this.fromUofLButton.UseVisualStyleBackColor = true;
            this.fromUofLButton.Click += new System.EventHandler(this.fromUofLButton_Click);
            // 
            // PackageCalculator
            // 
            this.AcceptButton = this.addPackageButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.detailsButton;
            this.ClientSize = new System.Drawing.Size(703, 339);
            this.Controls.Add(this.fromUofLButton);
            this.Controls.Add(this.toUofLButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.shippingGB);
            this.Controls.Add(this.shippingLB);
            this.Name = "PackageCalculator";
            this.Text = "Ground Package Calculator";
            this.shippingGB.ResumeLayout(false);
            this.shippingGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox shippingLB;
        private System.Windows.Forms.GroupBox shippingGB;
        private System.Windows.Forms.TextBox widthTB;
        private System.Windows.Forms.TextBox originZipTB;
        private System.Windows.Forms.TextBox destinationZipTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lengthTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox heightTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox weightTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addPackageButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button toUofLButton;
        private System.Windows.Forms.Button fromUofLButton;
    }
}

