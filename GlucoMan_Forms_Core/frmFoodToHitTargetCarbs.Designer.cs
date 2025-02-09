﻿
namespace GlucoMan_Forms_Core
{
    partial class frmFoodToHitTargetCarbs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFoodToHitTargetCarbs));
            this.TxtChoAlreadyTaken = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtTargetCho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtChoOfFood = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFoodToHitTarget = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReadTarget = new System.Windows.Forms.Button();
            this.btnCalculateGrams = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // TxtChoAlreadyTaken
            // 
            this.TxtChoAlreadyTaken.BackColor = System.Drawing.Color.PaleGreen;
            this.TxtChoAlreadyTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtChoAlreadyTaken.Location = new System.Drawing.Point(205, 44);
            this.TxtChoAlreadyTaken.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtChoAlreadyTaken.Name = "TxtChoAlreadyTaken";
            this.TxtChoAlreadyTaken.Size = new System.Drawing.Size(68, 26);
            this.TxtChoAlreadyTaken.TabIndex = 2;
            this.TxtChoAlreadyTaken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtChoAlreadyTaken.TextChanged += new System.EventHandler(this.TxtChoAlreadyTaken_TextChanged);
            this.TxtChoAlreadyTaken.Leave += new System.EventHandler(this.TxtChoAlreadyTaken_Leave);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(278, 47);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(18, 20);
            this.label33.TabIndex = 145;
            this.label33.Text = "g";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(166, 19);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(147, 20);
            this.label17.TabIndex = 147;
            this.label17.Text = "CHO already taken ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtTargetCho
            // 
            this.TxtTargetCho.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.TxtTargetCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTargetCho.Location = new System.Drawing.Point(49, 44);
            this.TxtTargetCho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTargetCho.Name = "TxtTargetCho";
            this.TxtTargetCho.Size = new System.Drawing.Size(68, 26);
            this.TxtTargetCho.TabIndex = 1;
            this.TxtTargetCho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtTargetCho.TextChanged += new System.EventHandler(this.TxtTargetCho_TextChanged);
            this.TxtTargetCho.Leave += new System.EventHandler(this.TxtTargetCho_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 149;
            this.label1.Text = "Target CHO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 150;
            this.label2.Text = "g";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 153;
            this.label3.Text = "CHO % of target food";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtChoOfFood
            // 
            this.TxtChoOfFood.BackColor = System.Drawing.Color.PaleGreen;
            this.TxtChoOfFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtChoOfFood.Location = new System.Drawing.Point(49, 120);
            this.TxtChoOfFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtChoOfFood.Name = "TxtChoOfFood";
            this.TxtChoOfFood.Size = new System.Drawing.Size(68, 26);
            this.TxtChoOfFood.TabIndex = 3;
            this.TxtChoOfFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtChoOfFood.TextChanged += new System.EventHandler(this.TxtChoOfFood_TextChanged);
            this.TxtChoOfFood.Leave += new System.EventHandler(this.TxtChoOfFood_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 152;
            this.label4.Text = "%";
            // 
            // TxtFoodToHitTarget
            // 
            this.TxtFoodToHitTarget.BackColor = System.Drawing.Color.SkyBlue;
            this.TxtFoodToHitTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFoodToHitTarget.Location = new System.Drawing.Point(205, 120);
            this.TxtFoodToHitTarget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFoodToHitTarget.Name = "TxtFoodToHitTarget";
            this.TxtFoodToHitTarget.ReadOnly = true;
            this.TxtFoodToHitTarget.Size = new System.Drawing.Size(68, 26);
            this.TxtFoodToHitTarget.TabIndex = 155;
            this.TxtFoodToHitTarget.TabStop = false;
            this.TxtFoodToHitTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 40);
            this.label5.TabIndex = 156;
            this.label5.Text = "Food to eat \r\nto hit target";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 157;
            this.label6.Text = "g";
            // 
            // btnReadTarget
            // 
            this.btnReadTarget.ForeColor = System.Drawing.Color.Black;
            this.btnReadTarget.Location = new System.Drawing.Point(46, 168);
            this.btnReadTarget.Name = "btnReadTarget";
            this.btnReadTarget.Size = new System.Drawing.Size(75, 50);
            this.btnReadTarget.TabIndex = 158;
            this.btnReadTarget.Text = "Read target";
            this.toolTip1.SetToolTip(this.btnReadTarget, "Read target CHO from bolus calculation window");
            this.btnReadTarget.UseVisualStyleBackColor = true;
            this.btnReadTarget.Click += new System.EventHandler(this.btnReadTarget_Click);
            // 
            // btnCalculateGrams
            // 
            this.btnCalculateGrams.ForeColor = System.Drawing.Color.Black;
            this.btnCalculateGrams.Location = new System.Drawing.Point(202, 168);
            this.btnCalculateGrams.Name = "btnCalculateGrams";
            this.btnCalculateGrams.Size = new System.Drawing.Size(75, 50);
            this.btnCalculateGrams.TabIndex = 159;
            this.btnCalculateGrams.Text = "Calc grams";
            this.toolTip1.SetToolTip(this.btnCalculateGrams, "Calculate grams of food to get target grams of CHO");
            this.btnCalculateGrams.UseVisualStyleBackColor = true;
            this.btnCalculateGrams.Click += new System.EventHandler(this.btnCalculateGrams_Click);
            // 
            // frmFoodToHitTargetCarbs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 230);
            this.Controls.Add(this.btnCalculateGrams);
            this.Controls.Add(this.btnReadTarget);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtFoodToHitTarget);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtChoOfFood);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTargetCho);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TxtChoAlreadyTaken);
            this.Controls.Add(this.label33);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFoodToHitTargetCarbs";
            this.Text = "Calculate CHO to hit target";
            this.Load += new System.EventHandler(this.frmFoodToHitTargetCarbs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtChoAlreadyTaken;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtTargetCho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtChoOfFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFoodToHitTarget;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReadTarget;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCalculateGrams;
    }
}