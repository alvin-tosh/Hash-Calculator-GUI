﻿namespace Hash
{
    partial class HashForContext
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HashForContext));
            this.Copyright = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.HashSelecter = new System.Windows.Forms.ComboBox();
            this.HashOutputBox = new System.Windows.Forms.TextBox();
            this.HashFileURL = new System.Windows.Forms.TextBox();
            this.HashReset = new System.Windows.Forms.Button();
            this.HashCopy = new System.Windows.Forms.Button();
            this.CreatedBy = new System.Windows.Forms.Label();
            this.DL = new System.Windows.Forms.Label();
            this.DLGithub = new System.Windows.Forms.LinkLabel();
            this.StartHash = new System.Windows.Forms.Button();
            this.DebugUse = new System.Windows.Forms.Button();
            this.DebugUseDialog = new System.Windows.Forms.OpenFileDialog();
            this.UpperCheck = new System.Windows.Forms.CheckBox();
            this.HihunCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Copyright.Location = new System.Drawing.Point(9, 210);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(260, 15);
            this.Copyright.TabIndex = 1;
            this.Copyright.Text = "Copyright © 2022 Hibi_10000 All rights reserved.";
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.OK.Location = new System.Drawing.Point(435, 195);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(89, 30);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.Window;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F);
            this.Title.ForeColor = System.Drawing.Color.Lime;
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(357, 39);
            this.Title.TabIndex = 3;
            this.Title.Text = "Hash for ContextMenu v0.4";
            // 
            // HashSelecter
            // 
            this.HashSelecter.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HashSelecter.FormattingEnabled = true;
            this.HashSelecter.Items.AddRange(new object[] {
            "Hashを選択してください",
            "MD5",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512",
            "CRC16-IBM",
            "CRC32",
            "CRC64-ECMA-182"});
            this.HashSelecter.Location = new System.Drawing.Point(12, 107);
            this.HashSelecter.Name = "HashSelecter";
            this.HashSelecter.Size = new System.Drawing.Size(135, 23);
            this.HashSelecter.TabIndex = 4;
            this.HashSelecter.Text = "Hashを選択してください";
            this.HashSelecter.SelectedIndexChanged += new System.EventHandler(this.HashSelecter_Set);
            this.HashSelecter.TextChanged += new System.EventHandler(this.HashSelecter_Set);
            // 
            // HashOutputBox
            // 
            this.HashOutputBox.BackColor = System.Drawing.SystemColors.Window;
            this.HashOutputBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HashOutputBox.Location = new System.Drawing.Point(12, 136);
            this.HashOutputBox.Multiline = true;
            this.HashOutputBox.Name = "HashOutputBox";
            this.HashOutputBox.ReadOnly = true;
            this.HashOutputBox.Size = new System.Drawing.Size(512, 53);
            this.HashOutputBox.TabIndex = 5;
            this.HashOutputBox.Text = "ここにHash値が表示されます";
            // 
            // HashFileURL
            // 
            this.HashFileURL.BackColor = System.Drawing.SystemColors.Window;
            this.HashFileURL.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HashFileURL.Location = new System.Drawing.Point(12, 63);
            this.HashFileURL.Multiline = true;
            this.HashFileURL.Name = "HashFileURL";
            this.HashFileURL.ReadOnly = true;
            this.HashFileURL.Size = new System.Drawing.Size(512, 38);
            this.HashFileURL.TabIndex = 6;
            this.HashFileURL.Text = "ファイルのパス(※これが表示されている場合はバグまたは起動方法が間違っています)";
            // 
            // HashReset
            // 
            this.HashReset.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HashReset.ForeColor = System.Drawing.Color.Red;
            this.HashReset.Location = new System.Drawing.Point(414, 107);
            this.HashReset.Name = "HashReset";
            this.HashReset.Size = new System.Drawing.Size(110, 23);
            this.HashReset.TabIndex = 7;
            this.HashReset.Text = "Hashをリセット";
            this.HashReset.UseVisualStyleBackColor = true;
            this.HashReset.Click += new System.EventHandler(this.HashReset_Click);
            // 
            // HashCopy
            // 
            this.HashCopy.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.HashCopy.Location = new System.Drawing.Point(290, 107);
            this.HashCopy.Name = "HashCopy";
            this.HashCopy.Size = new System.Drawing.Size(118, 23);
            this.HashCopy.TabIndex = 8;
            this.HashCopy.Text = "Hashをコピー";
            this.HashCopy.UseVisualStyleBackColor = true;
            this.HashCopy.Click += new System.EventHandler(this.HashCopy_Click);
            // 
            // CreatedBy
            // 
            this.CreatedBy.AutoSize = true;
            this.CreatedBy.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CreatedBy.Location = new System.Drawing.Point(401, 9);
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Size = new System.Drawing.Size(123, 15);
            this.CreatedBy.TabIndex = 9;
            this.CreatedBy.Text = "CreatedBy: Hibi_10000";
            // 
            // DL
            // 
            this.DL.AutoSize = true;
            this.DL.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DL.Location = new System.Drawing.Point(417, 29);
            this.DL.Name = "DL";
            this.DL.Size = new System.Drawing.Size(58, 15);
            this.DL.TabIndex = 10;
            this.DL.Text = "配布場所:";
            // 
            // DLGithub
            // 
            this.DLGithub.AutoSize = true;
            this.DLGithub.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DLGithub.Location = new System.Drawing.Point(472, 29);
            this.DLGithub.Name = "DLGithub";
            this.DLGithub.Size = new System.Drawing.Size(43, 15);
            this.DLGithub.TabIndex = 11;
            this.DLGithub.TabStop = true;
            this.DLGithub.Text = "Github";
            this.DLGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DLGithub_LinkClicked);
            // 
            // StartHash
            // 
            this.StartHash.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.StartHash.Location = new System.Drawing.Point(290, 195);
            this.StartHash.Name = "StartHash";
            this.StartHash.Size = new System.Drawing.Size(139, 30);
            this.StartHash.TabIndex = 12;
            this.StartHash.Text = "Hash計算機を起動";
            this.StartHash.UseVisualStyleBackColor = true;
            this.StartHash.Click += new System.EventHandler(this.StartHash_Click);
            // 
            // DebugUse
            // 
            this.DebugUse.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DebugUse.Location = new System.Drawing.Point(449, 63);
            this.DebugUse.Name = "DebugUse";
            this.DebugUse.Size = new System.Drawing.Size(75, 23);
            this.DebugUse.TabIndex = 13;
            this.DebugUse.Text = "DebugUse";
            this.DebugUse.UseVisualStyleBackColor = true;
            this.DebugUse.Visible = false;
            this.DebugUse.Click += new System.EventHandler(this.DebugUse_Click);
            // 
            // UpperCheck
            // 
            this.UpperCheck.AutoSize = true;
            this.UpperCheck.Location = new System.Drawing.Point(153, 111);
            this.UpperCheck.Name = "UpperCheck";
            this.UpperCheck.Size = new System.Drawing.Size(60, 16);
            this.UpperCheck.TabIndex = 14;
            this.UpperCheck.Text = "大文字";
            this.UpperCheck.UseVisualStyleBackColor = true;
            this.UpperCheck.CheckedChanged += new System.EventHandler(this.HashSelecter_Set);
            // 
            // HihunCheck
            // 
            this.HihunCheck.AutoSize = true;
            this.HihunCheck.Location = new System.Drawing.Point(219, 111);
            this.HihunCheck.Name = "HihunCheck";
            this.HihunCheck.Size = new System.Drawing.Size(60, 16);
            this.HihunCheck.TabIndex = 15;
            this.HihunCheck.Text = "ハイフン";
            this.HihunCheck.UseVisualStyleBackColor = true;
            this.HihunCheck.CheckedChanged += new System.EventHandler(this.HashSelecter_Set);
            // 
            // HashForContext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 231);
            this.Controls.Add(this.HihunCheck);
            this.Controls.Add(this.UpperCheck);
            this.Controls.Add(this.DebugUse);
            this.Controls.Add(this.StartHash);
            this.Controls.Add(this.DLGithub);
            this.Controls.Add(this.DL);
            this.Controls.Add(this.CreatedBy);
            this.Controls.Add(this.HashCopy);
            this.Controls.Add(this.HashReset);
            this.Controls.Add(this.HashFileURL);
            this.Controls.Add(this.HashOutputBox);
            this.Controls.Add(this.HashSelecter);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Copyright);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HashForContext";
            this.Text = "Hash for ContextMenu v0.4.0-alpha";
            this.Load += new System.EventHandler(this.HashForContext_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ComboBox HashSelecter;
        private System.Windows.Forms.TextBox HashOutputBox;
        private System.Windows.Forms.TextBox HashFileURL;
        private System.Windows.Forms.Button HashReset;
        private System.Windows.Forms.Button HashCopy;
        private System.Windows.Forms.Label CreatedBy;
        private System.Windows.Forms.Label DL;
        private System.Windows.Forms.LinkLabel DLGithub;
        private System.Windows.Forms.Button StartHash;
        private System.Windows.Forms.Button DebugUse;
        private System.Windows.Forms.OpenFileDialog DebugUseDialog;
        private System.Windows.Forms.CheckBox UpperCheck;
        private System.Windows.Forms.CheckBox HihunCheck;
    }
}