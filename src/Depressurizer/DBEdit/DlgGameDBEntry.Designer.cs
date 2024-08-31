/*
Copyright 2011, 2012, 2013 Steve Labbe.

This file is part of Depressurizer.

Depressurizer is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Depressurizer is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Depressurizer.  If not, see <http://www.gnu.org/licenses/>.
*/
namespace Depressurizer {
    partial class GameDBEntryDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameDBEntryDialog));
            lblId = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblGenre = new System.Windows.Forms.Label();
            lblType = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtGenres = new System.Windows.Forms.TextBox();
            cmbType = new System.Windows.Forms.ComboBox();
            cmdCancel = new System.Windows.Forms.Button();
            cmdSave = new System.Windows.Forms.Button();
            txtFlags = new System.Windows.Forms.TextBox();
            lblFlags = new System.Windows.Forms.Label();
            lblParent = new System.Windows.Forms.Label();
            txtParent = new System.Windows.Forms.TextBox();
            chkPlatWin = new System.Windows.Forms.CheckBox();
            chkPlatMac = new System.Windows.Forms.CheckBox();
            chkPlatLinux = new System.Windows.Forms.CheckBox();
            lblDev = new System.Windows.Forms.Label();
            lblPub = new System.Windows.Forms.Label();
            txtDev = new System.Windows.Forms.TextBox();
            txtPub = new System.Windows.Forms.TextBox();
            lblMCName = new System.Windows.Forms.Label();
            txtMCName = new System.Windows.Forms.TextBox();
            lblRelease = new System.Windows.Forms.Label();
            grpPlat = new System.Windows.Forms.GroupBox();
            txtRelease = new System.Windows.Forms.TextBox();
            dateWeb = new System.Windows.Forms.DateTimePicker();
            dateAppInfo = new System.Windows.Forms.DateTimePicker();
            chkWebUpdate = new System.Windows.Forms.CheckBox();
            chkAppInfoUpdate = new System.Windows.Forms.CheckBox();
            lblTags = new System.Windows.Forms.Label();
            txtTags = new System.Windows.Forms.TextBox();
            lblReviewCount = new System.Windows.Forms.Label();
            lblReviewScore = new System.Windows.Forms.Label();
            numReviewScore = new System.Windows.Forms.NumericUpDown();
            numReviewCount = new System.Windows.Forms.NumericUpDown();
            lblReviewScorePct = new System.Windows.Forms.Label();
            lblAchievements = new System.Windows.Forms.Label();
            numAchievements = new System.Windows.Forms.NumericUpDown();
            grpHltb = new System.Windows.Forms.GroupBox();
            numHltbCompletionist = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            numHltbExtras = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            numHltbMain = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            lblHLTBId = new System.Windows.Forms.Label();
            txtHLTBId = new System.Windows.Forms.TextBox();
            grpPlat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numReviewScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReviewCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAchievements).BeginInit();
            grpHltb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHltbCompletionist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHltbExtras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHltbMain).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            resources.ApplyResources(lblId, "lblId");
            lblId.Name = "lblId";
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.Name = "lblTitle";
            // 
            // lblGenre
            // 
            resources.ApplyResources(lblGenre, "lblGenre");
            lblGenre.Name = "lblGenre";
            // 
            // lblType
            // 
            resources.ApplyResources(lblType, "lblType");
            lblType.Name = "lblType";
            // 
            // txtId
            // 
            resources.ApplyResources(txtId, "txtId");
            txtId.Name = "txtId";
            // 
            // txtName
            // 
            resources.ApplyResources(txtName, "txtName");
            txtName.Name = "txtName";
            // 
            // txtGenres
            // 
            resources.ApplyResources(txtGenres, "txtGenres");
            txtGenres.Name = "txtGenres";
            // 
            // cmbType
            // 
            resources.ApplyResources(cmbType, "cmbType");
            cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Name = "cmbType";
            // 
            // cmdCancel
            // 
            resources.ApplyResources(cmdCancel, "cmdCancel");
            cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cmdCancel.Name = "cmdCancel";
            cmdCancel.UseVisualStyleBackColor = true;
            cmdCancel.Click += cmdCancel_Click;
            // 
            // cmdSave
            // 
            resources.ApplyResources(cmdSave, "cmdSave");
            cmdSave.Name = "cmdSave";
            cmdSave.UseVisualStyleBackColor = true;
            cmdSave.Click += cmdSave_Click;
            // 
            // txtFlags
            // 
            resources.ApplyResources(txtFlags, "txtFlags");
            txtFlags.Name = "txtFlags";
            // 
            // lblFlags
            // 
            resources.ApplyResources(lblFlags, "lblFlags");
            lblFlags.Name = "lblFlags";
            // 
            // lblParent
            // 
            resources.ApplyResources(lblParent, "lblParent");
            lblParent.Name = "lblParent";
            // 
            // txtParent
            // 
            resources.ApplyResources(txtParent, "txtParent");
            txtParent.Name = "txtParent";
            // 
            // chkPlatWin
            // 
            resources.ApplyResources(chkPlatWin, "chkPlatWin");
            chkPlatWin.Name = "chkPlatWin";
            chkPlatWin.UseVisualStyleBackColor = true;
            // 
            // chkPlatMac
            // 
            resources.ApplyResources(chkPlatMac, "chkPlatMac");
            chkPlatMac.Name = "chkPlatMac";
            chkPlatMac.UseVisualStyleBackColor = true;
            // 
            // chkPlatLinux
            // 
            resources.ApplyResources(chkPlatLinux, "chkPlatLinux");
            chkPlatLinux.Name = "chkPlatLinux";
            chkPlatLinux.UseVisualStyleBackColor = true;
            // 
            // lblDev
            // 
            resources.ApplyResources(lblDev, "lblDev");
            lblDev.Name = "lblDev";
            // 
            // lblPub
            // 
            resources.ApplyResources(lblPub, "lblPub");
            lblPub.Name = "lblPub";
            // 
            // txtDev
            // 
            resources.ApplyResources(txtDev, "txtDev");
            txtDev.Name = "txtDev";
            // 
            // txtPub
            // 
            resources.ApplyResources(txtPub, "txtPub");
            txtPub.Name = "txtPub";
            // 
            // lblMCName
            // 
            resources.ApplyResources(lblMCName, "lblMCName");
            lblMCName.Name = "lblMCName";
            // 
            // txtMCName
            // 
            resources.ApplyResources(txtMCName, "txtMCName");
            txtMCName.Name = "txtMCName";
            // 
            // lblRelease
            // 
            resources.ApplyResources(lblRelease, "lblRelease");
            lblRelease.Name = "lblRelease";
            // 
            // grpPlat
            // 
            resources.ApplyResources(grpPlat, "grpPlat");
            grpPlat.Controls.Add(chkPlatLinux);
            grpPlat.Controls.Add(chkPlatMac);
            grpPlat.Controls.Add(chkPlatWin);
            grpPlat.Name = "grpPlat";
            grpPlat.TabStop = false;
            // 
            // txtRelease
            // 
            resources.ApplyResources(txtRelease, "txtRelease");
            txtRelease.Name = "txtRelease";
            // 
            // dateWeb
            // 
            resources.ApplyResources(dateWeb, "dateWeb");
            dateWeb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateWeb.MaxDate = new System.DateTime(2035, 1, 19, 0, 0, 0, 0);
            dateWeb.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateWeb.Name = "dateWeb";
            // 
            // dateAppInfo
            // 
            resources.ApplyResources(dateAppInfo, "dateAppInfo");
            dateAppInfo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateAppInfo.Name = "dateAppInfo";
            // 
            // chkWebUpdate
            // 
            resources.ApplyResources(chkWebUpdate, "chkWebUpdate");
            chkWebUpdate.Name = "chkWebUpdate";
            chkWebUpdate.UseVisualStyleBackColor = true;
            // 
            // chkAppInfoUpdate
            // 
            resources.ApplyResources(chkAppInfoUpdate, "chkAppInfoUpdate");
            chkAppInfoUpdate.Name = "chkAppInfoUpdate";
            chkAppInfoUpdate.UseVisualStyleBackColor = true;
            // 
            // lblTags
            // 
            resources.ApplyResources(lblTags, "lblTags");
            lblTags.Name = "lblTags";
            // 
            // txtTags
            // 
            resources.ApplyResources(txtTags, "txtTags");
            txtTags.Name = "txtTags";
            // 
            // lblReviewCount
            // 
            resources.ApplyResources(lblReviewCount, "lblReviewCount");
            lblReviewCount.Name = "lblReviewCount";
            // 
            // lblReviewScore
            // 
            resources.ApplyResources(lblReviewScore, "lblReviewScore");
            lblReviewScore.Name = "lblReviewScore";
            // 
            // numReviewScore
            // 
            resources.ApplyResources(numReviewScore, "numReviewScore");
            numReviewScore.Name = "numReviewScore";
            // 
            // numReviewCount
            // 
            resources.ApplyResources(numReviewCount, "numReviewCount");
            numReviewCount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numReviewCount.Name = "numReviewCount";
            // 
            // lblReviewScorePct
            // 
            resources.ApplyResources(lblReviewScorePct, "lblReviewScorePct");
            lblReviewScorePct.Name = "lblReviewScorePct";
            // 
            // lblAchievements
            // 
            resources.ApplyResources(lblAchievements, "lblAchievements");
            lblAchievements.Name = "lblAchievements";
            // 
            // numAchievements
            // 
            resources.ApplyResources(numAchievements, "numAchievements");
            numAchievements.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numAchievements.Name = "numAchievements";
            // 
            // grpHltb
            // 
            resources.ApplyResources(grpHltb, "grpHltb");
            grpHltb.Controls.Add(numHltbCompletionist);
            grpHltb.Controls.Add(label3);
            grpHltb.Controls.Add(numHltbExtras);
            grpHltb.Controls.Add(label2);
            grpHltb.Controls.Add(numHltbMain);
            grpHltb.Controls.Add(label1);
            grpHltb.ForeColor = System.Drawing.SystemColors.ControlText;
            grpHltb.Name = "grpHltb";
            grpHltb.TabStop = false;
            // 
            // numHltbCompletionist
            // 
            resources.ApplyResources(numHltbCompletionist, "numHltbCompletionist");
            numHltbCompletionist.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numHltbCompletionist.Name = "numHltbCompletionist";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // numHltbExtras
            // 
            resources.ApplyResources(numHltbExtras, "numHltbExtras");
            numHltbExtras.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numHltbExtras.Name = "numHltbExtras";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // numHltbMain
            // 
            resources.ApplyResources(numHltbMain, "numHltbMain");
            numHltbMain.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numHltbMain.Name = "numHltbMain";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // lblHLTBId
            // 
            resources.ApplyResources(lblHLTBId, "lblHLTBId");
            lblHLTBId.Name = "lblHLTBId";
            // 
            // txtHLTBId
            // 
            resources.ApplyResources(txtHLTBId, "txtHLTBId");
            txtHLTBId.Name = "txtHLTBId";
            // 
            // GameDBEntryDialog
            // 
            AcceptButton = cmdSave;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = cmdCancel;
            ControlBox = false;
            Controls.Add(grpHltb);
            Controls.Add(numAchievements);
            Controls.Add(lblAchievements);
            Controls.Add(lblReviewScorePct);
            Controls.Add(numReviewCount);
            Controls.Add(numReviewScore);
            Controls.Add(lblReviewScore);
            Controls.Add(lblReviewCount);
            Controls.Add(txtTags);
            Controls.Add(lblTags);
            Controls.Add(chkAppInfoUpdate);
            Controls.Add(chkWebUpdate);
            Controls.Add(dateAppInfo);
            Controls.Add(dateWeb);
            Controls.Add(txtRelease);
            Controls.Add(grpPlat);
            Controls.Add(lblRelease);
            Controls.Add(txtMCName);
            Controls.Add(lblMCName);
            Controls.Add(txtPub);
            Controls.Add(txtDev);
            Controls.Add(lblPub);
            Controls.Add(lblDev);
            Controls.Add(txtParent);
            Controls.Add(lblParent);
            Controls.Add(lblFlags);
            Controls.Add(txtFlags);
            Controls.Add(cmdSave);
            Controls.Add(cmdCancel);
            Controls.Add(cmbType);
            Controls.Add(txtGenres);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lblType);
            Controls.Add(lblGenre);
            Controls.Add(lblTitle);
            Controls.Add(lblId);
            Controls.Add(lblHLTBId);
            Controls.Add(txtHLTBId);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "GameDBEntryDialog";
            ShowInTaskbar = false;
            Load += GameDBEntryForm_Load;
            grpPlat.ResumeLayout(false);
            grpPlat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numReviewScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReviewCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAchievements).EndInit();
            grpHltb.ResumeLayout(false);
            grpHltb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHltbCompletionist).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHltbExtras).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHltbMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGenres;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox txtFlags;
        private System.Windows.Forms.Label lblFlags;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.TextBox txtParent;
        private System.Windows.Forms.CheckBox chkPlatWin;
        private System.Windows.Forms.CheckBox chkPlatMac;
        private System.Windows.Forms.CheckBox chkPlatLinux;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Label lblPub;
        private System.Windows.Forms.TextBox txtDev;
        private System.Windows.Forms.TextBox txtPub;
        private System.Windows.Forms.Label lblMCName;
        private System.Windows.Forms.TextBox txtMCName;
        private System.Windows.Forms.Label lblRelease;
        private System.Windows.Forms.GroupBox grpPlat;
        private System.Windows.Forms.TextBox txtRelease;
        private System.Windows.Forms.DateTimePicker dateWeb;
        private System.Windows.Forms.DateTimePicker dateAppInfo;
        private System.Windows.Forms.CheckBox chkWebUpdate;
        private System.Windows.Forms.CheckBox chkAppInfoUpdate;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.Label lblReviewCount;
        private System.Windows.Forms.Label lblReviewScore;
        private System.Windows.Forms.NumericUpDown numReviewScore;
        private System.Windows.Forms.NumericUpDown numReviewCount;
        private System.Windows.Forms.Label lblReviewScorePct;
        private System.Windows.Forms.Label lblAchievements;
        private System.Windows.Forms.NumericUpDown numAchievements;
        private System.Windows.Forms.GroupBox grpHltb;
        private System.Windows.Forms.NumericUpDown numHltbCompletionist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numHltbExtras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numHltbMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHLTBId;
        private System.Windows.Forms.TextBox txtHLTBId;
    }
}