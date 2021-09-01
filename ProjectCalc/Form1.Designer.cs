namespace ProjectCalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.copiesUpDown = new System.Windows.Forms.NumericUpDown();
            this.cornerStapleCB = new System.Windows.Forms.CheckBox();
            this.saddleCB = new System.Windows.Forms.CheckBox();
            this.DrillTB = new System.Windows.Forms.CheckBox();
            this.cuttingTB = new System.Windows.Forms.CheckBox();
            this.letterRadio = new System.Windows.Forms.RadioButton();
            this.tabloidRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.simplexRadio = new System.Windows.Forms.RadioButton();
            this.duplexRadio = new System.Windows.Forms.RadioButton();
            this.sizeGroup = new System.Windows.Forms.GroupBox();
            this.pagesUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.finishingGroup = new System.Windows.Forms.GroupBox();
            this.inkGroup = new System.Windows.Forms.GroupBox();
            this.noInkRadio = new System.Windows.Forms.RadioButton();
            this.blackRadio = new System.Windows.Forms.RadioButton();
            this.colorRadio = new System.Windows.Forms.RadioButton();
            this.blackColorRadio = new System.Windows.Forms.RadioButton();
            this.sidesGroup = new System.Windows.Forms.GroupBox();
            this.coverRadio = new System.Windows.Forms.RadioButton();
            this.textRadio = new System.Windows.Forms.RadioButton();
            this.typesGroup = new System.Windows.Forms.GroupBox();
            this.textBrightRadio = new System.Windows.Forms.RadioButton();
            this.slipRegRadio = new System.Windows.Forms.RadioButton();
            this.slipBrightRadio = new System.Windows.Forms.RadioButton();
            this.quantitiesGroup = new System.Windows.Forms.GroupBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.displayCostLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.copiesUpDown)).BeginInit();
            this.sizeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagesUpDown)).BeginInit();
            this.finishingGroup.SuspendLayout();
            this.inkGroup.SuspendLayout();
            this.sidesGroup.SuspendLayout();
            this.typesGroup.SuspendLayout();
            this.quantitiesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // copiesUpDown
            // 
            this.copiesUpDown.Location = new System.Drawing.Point(198, 116);
            this.copiesUpDown.Name = "copiesUpDown";
            this.copiesUpDown.Size = new System.Drawing.Size(138, 39);
            this.copiesUpDown.TabIndex = 1;
            // 
            // cornerStapleCB
            // 
            this.cornerStapleCB.AutoSize = true;
            this.cornerStapleCB.Location = new System.Drawing.Point(48, 65);
            this.cornerStapleCB.Name = "cornerStapleCB";
            this.cornerStapleCB.Size = new System.Drawing.Size(190, 36);
            this.cornerStapleCB.TabIndex = 2;
            this.cornerStapleCB.Text = "Corner Staple";
            this.cornerStapleCB.UseVisualStyleBackColor = true;
            this.cornerStapleCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // saddleCB
            // 
            this.saddleCB.AutoSize = true;
            this.saddleCB.Location = new System.Drawing.Point(48, 117);
            this.saddleCB.Name = "saddleCB";
            this.saddleCB.Size = new System.Drawing.Size(184, 36);
            this.saddleCB.TabIndex = 3;
            this.saddleCB.Text = "Saddle Stitch";
            this.saddleCB.UseVisualStyleBackColor = true;
            this.saddleCB.CheckedChanged += new System.EventHandler(this.saddleCB_CheckedChanged);
            // 
            // DrillTB
            // 
            this.DrillTB.AutoSize = true;
            this.DrillTB.Location = new System.Drawing.Point(280, 65);
            this.DrillTB.Name = "DrillTB";
            this.DrillTB.Size = new System.Drawing.Size(166, 36);
            this.DrillTB.TabIndex = 4;
            this.DrillTB.Text = "3 Hole Drill";
            this.DrillTB.UseVisualStyleBackColor = true;
            this.DrillTB.CheckedChanged += new System.EventHandler(this.DrillTB_CheckedChanged);
            // 
            // cuttingTB
            // 
            this.cuttingTB.AutoSize = true;
            this.cuttingTB.Location = new System.Drawing.Point(280, 117);
            this.cuttingTB.Name = "cuttingTB";
            this.cuttingTB.Size = new System.Drawing.Size(125, 36);
            this.cuttingTB.TabIndex = 5;
            this.cuttingTB.Text = "Cutting";
            this.cuttingTB.UseVisualStyleBackColor = true;
            this.cuttingTB.CheckedChanged += new System.EventHandler(this.cuttingTB_CheckedChanged);
            // 
            // letterRadio
            // 
            this.letterRadio.AutoSize = true;
            this.letterRadio.Location = new System.Drawing.Point(18, 52);
            this.letterRadio.Name = "letterRadio";
            this.letterRadio.Size = new System.Drawing.Size(113, 36);
            this.letterRadio.TabIndex = 6;
            this.letterRadio.TabStop = true;
            this.letterRadio.Text = "8.5x11";
            this.letterRadio.UseVisualStyleBackColor = true;
            this.letterRadio.CheckedChanged += new System.EventHandler(this.letterRadio_CheckedChanged);
            // 
            // tabloidRadio
            // 
            this.tabloidRadio.AutoSize = true;
            this.tabloidRadio.Location = new System.Drawing.Point(250, 52);
            this.tabloidRadio.Name = "tabloidRadio";
            this.tabloidRadio.Size = new System.Drawing.Size(108, 36);
            this.tabloidRadio.TabIndex = 7;
            this.tabloidRadio.TabStop = true;
            this.tabloidRadio.Text = "11x17";
            this.tabloidRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 9;
            // 
            // simplexRadio
            // 
            this.simplexRadio.AutoSize = true;
            this.simplexRadio.Location = new System.Drawing.Point(41, 68);
            this.simplexRadio.Name = "simplexRadio";
            this.simplexRadio.Size = new System.Drawing.Size(178, 36);
            this.simplexRadio.TabIndex = 6;
            this.simplexRadio.TabStop = true;
            this.simplexRadio.Text = "Single Sided";
            this.simplexRadio.UseVisualStyleBackColor = true;
            this.simplexRadio.CheckedChanged += new System.EventHandler(this.simplexRadio_CheckedChanged);
            // 
            // duplexRadio
            // 
            this.duplexRadio.AutoSize = true;
            this.duplexRadio.Location = new System.Drawing.Point(273, 68);
            this.duplexRadio.Name = "duplexRadio";
            this.duplexRadio.Size = new System.Drawing.Size(190, 36);
            this.duplexRadio.TabIndex = 7;
            this.duplexRadio.TabStop = true;
            this.duplexRadio.Text = "Double Sided";
            this.duplexRadio.UseVisualStyleBackColor = true;
            this.duplexRadio.CheckedChanged += new System.EventHandler(this.duplexRadio_CheckedChanged);
            // 
            // sizeGroup
            // 
            this.sizeGroup.Controls.Add(this.tabloidRadio);
            this.sizeGroup.Controls.Add(this.letterRadio);
            this.sizeGroup.Location = new System.Drawing.Point(37, 205);
            this.sizeGroup.Name = "sizeGroup";
            this.sizeGroup.Size = new System.Drawing.Size(458, 132);
            this.sizeGroup.TabIndex = 10;
            this.sizeGroup.TabStop = false;
            this.sizeGroup.Text = "Paper Size";
            this.sizeGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pagesUpDown
            // 
            this.pagesUpDown.Location = new System.Drawing.Point(198, 51);
            this.pagesUpDown.Name = "pagesUpDown";
            this.pagesUpDown.Size = new System.Drawing.Size(138, 39);
            this.pagesUpDown.TabIndex = 1;
            this.pagesUpDown.ValueChanged += new System.EventHandler(this.pagesRadio_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Page Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Copies Req";
            // 
            // finishingGroup
            // 
            this.finishingGroup.Controls.Add(this.cornerStapleCB);
            this.finishingGroup.Controls.Add(this.saddleCB);
            this.finishingGroup.Controls.Add(this.DrillTB);
            this.finishingGroup.Controls.Add(this.cuttingTB);
            this.finishingGroup.Location = new System.Drawing.Point(553, 51);
            this.finishingGroup.Name = "finishingGroup";
            this.finishingGroup.Size = new System.Drawing.Size(488, 200);
            this.finishingGroup.TabIndex = 11;
            this.finishingGroup.TabStop = false;
            this.finishingGroup.Text = "Finishing";
            // 
            // inkGroup
            // 
            this.inkGroup.Controls.Add(this.noInkRadio);
            this.inkGroup.Controls.Add(this.blackRadio);
            this.inkGroup.Controls.Add(this.colorRadio);
            this.inkGroup.Controls.Add(this.blackColorRadio);
            this.inkGroup.Location = new System.Drawing.Point(578, 280);
            this.inkGroup.Name = "inkGroup";
            this.inkGroup.Size = new System.Drawing.Size(463, 144);
            this.inkGroup.TabIndex = 12;
            this.inkGroup.TabStop = false;
            this.inkGroup.Text = "Ink";
            // 
            // noInkRadio
            // 
            this.noInkRadio.AutoSize = true;
            this.noInkRadio.Location = new System.Drawing.Point(345, 94);
            this.noInkRadio.Name = "noInkRadio";
            this.noInkRadio.Size = new System.Drawing.Size(104, 36);
            this.noInkRadio.TabIndex = 6;
            this.noInkRadio.TabStop = true;
            this.noInkRadio.Text = "None";
            this.noInkRadio.UseVisualStyleBackColor = true;
            this.noInkRadio.CheckedChanged += new System.EventHandler(this.blackRadio_CheckedChanged);
            // 
            // blackRadio
            // 
            this.blackRadio.AutoSize = true;
            this.blackRadio.Location = new System.Drawing.Point(48, 35);
            this.blackRadio.Name = "blackRadio";
            this.blackRadio.Size = new System.Drawing.Size(100, 36);
            this.blackRadio.TabIndex = 6;
            this.blackRadio.TabStop = true;
            this.blackRadio.Text = "Black";
            this.blackRadio.UseVisualStyleBackColor = true;
            this.blackRadio.CheckedChanged += new System.EventHandler(this.blackRadio_CheckedChanged);
            // 
            // colorRadio
            // 
            this.colorRadio.AutoSize = true;
            this.colorRadio.Location = new System.Drawing.Point(343, 35);
            this.colorRadio.Name = "colorRadio";
            this.colorRadio.Size = new System.Drawing.Size(102, 36);
            this.colorRadio.TabIndex = 7;
            this.colorRadio.TabStop = true;
            this.colorRadio.Text = "Color";
            this.colorRadio.UseVisualStyleBackColor = true;
            this.colorRadio.CheckedChanged += new System.EventHandler(this.colorRadio_CheckedChanged);
            // 
            // blackColorRadio
            // 
            this.blackColorRadio.AutoSize = true;
            this.blackColorRadio.Location = new System.Drawing.Point(48, 94);
            this.blackColorRadio.Name = "blackColorRadio";
            this.blackColorRadio.Size = new System.Drawing.Size(276, 36);
            this.blackColorRadio.TabIndex = 7;
            this.blackColorRadio.TabStop = true;
            this.blackColorRadio.Text = "Black on Color Copier";
            this.blackColorRadio.UseVisualStyleBackColor = true;
            // 
            // sidesGroup
            // 
            this.sidesGroup.Controls.Add(this.duplexRadio);
            this.sidesGroup.Controls.Add(this.simplexRadio);
            this.sidesGroup.Location = new System.Drawing.Point(543, 440);
            this.sidesGroup.Name = "sidesGroup";
            this.sidesGroup.Size = new System.Drawing.Size(498, 144);
            this.sidesGroup.TabIndex = 13;
            this.sidesGroup.TabStop = false;
            this.sidesGroup.Text = "Duplexing";
            // 
            // coverRadio
            // 
            this.coverRadio.AutoSize = true;
            this.coverRadio.Location = new System.Drawing.Point(250, 52);
            this.coverRadio.Name = "coverRadio";
            this.coverRadio.Size = new System.Drawing.Size(107, 36);
            this.coverRadio.TabIndex = 7;
            this.coverRadio.TabStop = true;
            this.coverRadio.Text = "Cover";
            this.coverRadio.UseVisualStyleBackColor = true;
            this.coverRadio.CheckedChanged += new System.EventHandler(this.coverRadio_CheckedChanged);
            // 
            // textRadio
            // 
            this.textRadio.AutoSize = true;
            this.textRadio.Location = new System.Drawing.Point(18, 52);
            this.textRadio.Name = "textRadio";
            this.textRadio.Size = new System.Drawing.Size(88, 36);
            this.textRadio.TabIndex = 6;
            this.textRadio.TabStop = true;
            this.textRadio.Text = "Text";
            this.textRadio.UseVisualStyleBackColor = true;
            this.textRadio.CheckedChanged += new System.EventHandler(this.textRadio_CheckedChanged);
            // 
            // typesGroup
            // 
            this.typesGroup.Controls.Add(this.textBrightRadio);
            this.typesGroup.Controls.Add(this.slipRegRadio);
            this.typesGroup.Controls.Add(this.slipBrightRadio);
            this.typesGroup.Controls.Add(this.coverRadio);
            this.typesGroup.Controls.Add(this.textRadio);
            this.typesGroup.Location = new System.Drawing.Point(37, 370);
            this.typesGroup.Name = "typesGroup";
            this.typesGroup.Size = new System.Drawing.Size(458, 214);
            this.typesGroup.TabIndex = 10;
            this.typesGroup.TabStop = false;
            this.typesGroup.Text = "Paper Type";
            this.typesGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBrightRadio
            // 
            this.textBrightRadio.AutoSize = true;
            this.textBrightRadio.Location = new System.Drawing.Point(19, 105);
            this.textBrightRadio.Name = "textBrightRadio";
            this.textBrightRadio.Size = new System.Drawing.Size(176, 36);
            this.textBrightRadio.TabIndex = 7;
            this.textBrightRadio.TabStop = true;
            this.textBrightRadio.Text = "Text - Bright";
            this.textBrightRadio.UseVisualStyleBackColor = true;
            this.textBrightRadio.CheckedChanged += new System.EventHandler(this.textBrightRadio_CheckedChanged);
            // 
            // slipRegRadio
            // 
            this.slipRegRadio.AutoSize = true;
            this.slipRegRadio.Location = new System.Drawing.Point(19, 159);
            this.slipRegRadio.Name = "slipRegRadio";
            this.slipRegRadio.Size = new System.Drawing.Size(188, 36);
            this.slipRegRadio.TabIndex = 6;
            this.slipRegRadio.TabStop = true;
            this.slipRegRadio.Text = "Slip - Regular";
            this.slipRegRadio.UseVisualStyleBackColor = true;
            this.slipRegRadio.CheckedChanged += new System.EventHandler(this.slipRegRadio_CheckedChanged);
            // 
            // slipBrightRadio
            // 
            this.slipBrightRadio.AutoSize = true;
            this.slipBrightRadio.Location = new System.Drawing.Point(250, 159);
            this.slipBrightRadio.Name = "slipBrightRadio";
            this.slipBrightRadio.Size = new System.Drawing.Size(172, 36);
            this.slipBrightRadio.TabIndex = 7;
            this.slipBrightRadio.TabStop = true;
            this.slipBrightRadio.Text = "Slip - Bright";
            this.slipBrightRadio.UseVisualStyleBackColor = true;
            this.slipBrightRadio.CheckedChanged += new System.EventHandler(this.slipBrightRadio_CheckedChanged);
            // 
            // quantitiesGroup
            // 
            this.quantitiesGroup.Controls.Add(this.label2);
            this.quantitiesGroup.Controls.Add(this.copiesUpDown);
            this.quantitiesGroup.Controls.Add(this.pagesUpDown);
            this.quantitiesGroup.Controls.Add(this.label3);
            this.quantitiesGroup.Location = new System.Drawing.Point(37, 26);
            this.quantitiesGroup.Name = "quantitiesGroup";
            this.quantitiesGroup.Size = new System.Drawing.Size(458, 173);
            this.quantitiesGroup.TabIndex = 14;
            this.quantitiesGroup.TabStop = false;
            this.quantitiesGroup.Text = "Quantities";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateBtn.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateBtn.Location = new System.Drawing.Point(846, 618);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Padding = new System.Windows.Forms.Padding(5);
            this.calculateBtn.Size = new System.Drawing.Size(195, 78);
            this.calculateBtn.TabIndex = 16;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // displayCostLbl
            // 
            this.displayCostLbl.AutoSize = true;
            this.displayCostLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.displayCostLbl.Location = new System.Drawing.Point(37, 606);
            this.displayCostLbl.Name = "displayCostLbl";
            this.displayCostLbl.Size = new System.Drawing.Size(225, 45);
            this.displayCostLbl.TabIndex = 17;
            this.displayCostLbl.Text = "Project Cost: $";
            this.displayCostLbl.Click += new System.EventHandler(this.displayCostLbl_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(846, 734);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 84);
            this.button1.TabIndex = 18;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 882);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.displayCostLbl);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.quantitiesGroup);
            this.Controls.Add(this.typesGroup);
            this.Controls.Add(this.sidesGroup);
            this.Controls.Add(this.inkGroup);
            this.Controls.Add(this.finishingGroup);
            this.Controls.Add(this.sizeGroup);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculate";
            ((System.ComponentModel.ISupportInitialize)(this.copiesUpDown)).EndInit();
            this.sizeGroup.ResumeLayout(false);
            this.sizeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagesUpDown)).EndInit();
            this.finishingGroup.ResumeLayout(false);
            this.finishingGroup.PerformLayout();
            this.inkGroup.ResumeLayout(false);
            this.inkGroup.PerformLayout();
            this.sidesGroup.ResumeLayout(false);
            this.sidesGroup.PerformLayout();
            this.typesGroup.ResumeLayout(false);
            this.typesGroup.PerformLayout();
            this.quantitiesGroup.ResumeLayout(false);
            this.quantitiesGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown copiesUpDown;
        private System.Windows.Forms.CheckBox cornerStapleCB;
        private System.Windows.Forms.CheckBox saddleCB;
        private System.Windows.Forms.CheckBox DrillTB;
        private System.Windows.Forms.CheckBox cuttingTB;
        private System.Windows.Forms.RadioButton letterRadio;
        private System.Windows.Forms.RadioButton tabloidRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton simplexRadio;
        private System.Windows.Forms.RadioButton duplexRadio;
        private System.Windows.Forms.GroupBox sizeGroup;
        private System.Windows.Forms.NumericUpDown pagesUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox finishingGroup;
        private System.Windows.Forms.GroupBox inkGroup;
        private System.Windows.Forms.GroupBox sidesGroup;
        private System.Windows.Forms.RadioButton coverRadio;
        private System.Windows.Forms.RadioButton textRadio;
        private System.Windows.Forms.GroupBox typesGroup;
        private System.Windows.Forms.RadioButton textBrightRadio;
        private System.Windows.Forms.RadioButton slipRegRadio;
        private System.Windows.Forms.RadioButton slipBrightRadio;
        private System.Windows.Forms.RadioButton blackRadio;
        private System.Windows.Forms.RadioButton colorRadio;
        private System.Windows.Forms.RadioButton blackColorRadio;
        private System.Windows.Forms.GroupBox quantitiesGroup;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label displayCostLbl;
        private System.Windows.Forms.RadioButton noInkRadio;
        private System.Windows.Forms.Button button1;
    }
}

