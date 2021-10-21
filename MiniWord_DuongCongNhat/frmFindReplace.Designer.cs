﻿
namespace MiniWord_DuongCongNhat
{
    partial class frmFindReplace
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
            this.gbDirections = new System.Windows.Forms.GroupBox();
            this.rBtnDown = new System.Windows.Forms.RadioButton();
            this.rBtnUp = new System.Windows.Forms.RadioButton();
            this.checkWholeWord = new System.Windows.Forms.CheckBox();
            this.checkCase = new System.Windows.Forms.CheckBox();
            this.btnRelaceAll = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.lbReplace = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.lbFind = new System.Windows.Forms.Label();
            this.gbDirections.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDirections
            // 
            this.gbDirections.Controls.Add(this.rBtnDown);
            this.gbDirections.Controls.Add(this.rBtnUp);
            this.gbDirections.Location = new System.Drawing.Point(147, 114);
            this.gbDirections.Name = "gbDirections";
            this.gbDirections.Size = new System.Drawing.Size(166, 52);
            this.gbDirections.TabIndex = 14;
            this.gbDirections.TabStop = false;
            this.gbDirections.Text = "Hướng tìm";
            // 
            // rBtnDown
            // 
            this.rBtnDown.AutoSize = true;
            this.rBtnDown.Checked = true;
            this.rBtnDown.Location = new System.Drawing.Point(87, 19);
            this.rBtnDown.Name = "rBtnDown";
            this.rBtnDown.Size = new System.Drawing.Size(56, 17);
            this.rBtnDown.TabIndex = 1;
            this.rBtnDown.TabStop = true;
            this.rBtnDown.Text = "Xuống";
            this.rBtnDown.UseVisualStyleBackColor = true;
            // 
            // rBtnUp
            // 
            this.rBtnUp.AutoSize = true;
            this.rBtnUp.Location = new System.Drawing.Point(25, 19);
            this.rBtnUp.Name = "rBtnUp";
            this.rBtnUp.Size = new System.Drawing.Size(43, 17);
            this.rBtnUp.TabIndex = 0;
            this.rBtnUp.Text = "Lên";
            this.rBtnUp.UseVisualStyleBackColor = true;
            // 
            // checkWholeWord
            // 
            this.checkWholeWord.AutoSize = true;
            this.checkWholeWord.Location = new System.Drawing.Point(21, 137);
            this.checkWholeWord.Name = "checkWholeWord";
            this.checkWholeWord.Size = new System.Drawing.Size(90, 17);
            this.checkWholeWord.TabIndex = 13;
            this.checkWholeWord.Text = "Trùng cả chữ";
            this.checkWholeWord.UseVisualStyleBackColor = true;
            // 
            // checkCase
            // 
            this.checkCase.AutoSize = true;
            this.checkCase.Location = new System.Drawing.Point(21, 114);
            this.checkCase.Name = "checkCase";
            this.checkCase.Size = new System.Drawing.Size(80, 17);
            this.checkCase.TabIndex = 12;
            this.checkCase.Text = "Trùng case";
            this.checkCase.UseVisualStyleBackColor = true;
            // 
            // btnRelaceAll
            // 
            this.btnRelaceAll.Location = new System.Drawing.Point(322, 85);
            this.btnRelaceAll.Name = "btnRelaceAll";
            this.btnRelaceAll.Size = new System.Drawing.Size(75, 23);
            this.btnRelaceAll.TabIndex = 17;
            this.btnRelaceAll.Text = "Thay tất cả";
            this.btnRelaceAll.UseVisualStyleBackColor = true;
            this.btnRelaceAll.Click += new System.EventHandler(this.btnRelaceAll_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(322, 56);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 16;
            this.btnReplace.Text = "Thay";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(322, 13);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(75, 23);
            this.btnFindNext.TabIndex = 15;
            this.btnFindNext.Text = "Kế tiếp";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(94, 58);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(206, 20);
            this.txtReplace.TabIndex = 11;
            // 
            // lbReplace
            // 
            this.lbReplace.AutoSize = true;
            this.lbReplace.Location = new System.Drawing.Point(18, 61);
            this.lbReplace.Name = "lbReplace";
            this.lbReplace.Size = new System.Drawing.Size(59, 13);
            this.lbReplace.TabIndex = 8;
            this.lbReplace.Text = "Thay Bằng";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(94, 15);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(206, 20);
            this.txtFind.TabIndex = 9;
            // 
            // lbFind
            // 
            this.lbFind.AutoSize = true;
            this.lbFind.Location = new System.Drawing.Point(18, 18);
            this.lbFind.Name = "lbFind";
            this.lbFind.Size = new System.Drawing.Size(49, 13);
            this.lbFind.TabIndex = 10;
            this.lbFind.Text = "Tìm kiếm";
            // 
            // frmFindReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 178);
            this.Controls.Add(this.gbDirections);
            this.Controls.Add(this.checkWholeWord);
            this.Controls.Add(this.checkCase);
            this.Controls.Add(this.btnRelaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.lbReplace);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.lbFind);
            this.Name = "frmFindReplace";
            this.Text = "Tìm Kiếm";
            this.gbDirections.ResumeLayout(false);
            this.gbDirections.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDirections;
        private System.Windows.Forms.RadioButton rBtnDown;
        private System.Windows.Forms.RadioButton rBtnUp;
        private System.Windows.Forms.CheckBox checkWholeWord;
        private System.Windows.Forms.CheckBox checkCase;
        private System.Windows.Forms.Button btnRelaceAll;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Label lbReplace;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label lbFind;
    }
}

