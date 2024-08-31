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
    partial class DBEditDlg {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBEditDlg));
            mainMenu = new System.Windows.Forms.MenuStrip();
            menu_File = new System.Windows.Forms.ToolStripMenuItem();
            menu_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            menu_File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            menu_File_Load = new System.Windows.Forms.ToolStripMenuItem();
            menu_File_Sep1 = new System.Windows.Forms.ToolStripSeparator();
            menu_File_Clear = new System.Windows.Forms.ToolStripMenuItem();
            menu_File_Sep2 = new System.Windows.Forms.ToolStripSeparator();
            menu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            cmdFetch = new System.Windows.Forms.Button();
            cmdUpdateNew = new System.Windows.Forms.Button();
            cmdUpdateSelected = new System.Windows.Forms.Button();
            cmdEditGame = new System.Windows.Forms.Button();
            cmdDeleteGame = new System.Windows.Forms.Button();
            cmdAddGame = new System.Windows.Forms.Button();
            grpTypes = new System.Windows.Forms.GroupBox();
            chkTypeUnknown = new System.Windows.Forms.CheckBox();
            chkTypeOther = new System.Windows.Forms.CheckBox();
            chkTypeDLC = new System.Windows.Forms.CheckBox();
            chkTypeGame = new System.Windows.Forms.CheckBox();
            chkTypeAll = new System.Windows.Forms.CheckBox();
            cmdStore = new System.Windows.Forms.Button();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            statusMsg = new System.Windows.Forms.ToolStripStatusLabel();
            statSelected = new System.Windows.Forms.ToolStripStatusLabel();
            cmdUpdateAppInfo = new System.Windows.Forms.Button();
            grpWebUpdate = new System.Windows.Forms.GroupBox();
            radWebNo = new System.Windows.Forms.RadioButton();
            radWebSince = new System.Windows.Forms.RadioButton();
            radWebYes = new System.Windows.Forms.RadioButton();
            radWebAll = new System.Windows.Forms.RadioButton();
            dateWeb = new System.Windows.Forms.DateTimePicker();
            grpAppInfo = new System.Windows.Forms.GroupBox();
            radAppNo = new System.Windows.Forms.RadioButton();
            radAppYes = new System.Windows.Forms.RadioButton();
            radAppAll = new System.Windows.Forms.RadioButton();
            chkOwned = new System.Windows.Forms.CheckBox();
            txtSearch = new System.Windows.Forms.TextBox();
            lblSearch = new System.Windows.Forms.Label();
            cmdSearchClear = new System.Windows.Forms.Button();
            numIdRangeMax = new System.Windows.Forms.NumericUpDown();
            numIdRangeMin = new System.Windows.Forms.NumericUpDown();
            lblIdRangeSep = new System.Windows.Forms.Label();
            chkIdRange = new System.Windows.Forms.CheckBox();
            lstGames = new Lib.ExtListView();
            colID = new System.Windows.Forms.ColumnHeader();
            colName = new System.Windows.Forms.ColumnHeader();
            colGenre = new System.Windows.Forms.ColumnHeader();
            colType = new System.Windows.Forms.ColumnHeader();
            colScraped = new System.Windows.Forms.ColumnHeader();
            colAppInfo = new System.Windows.Forms.ColumnHeader();
            colParent = new System.Windows.Forms.ColumnHeader();
            colHLTBID = new System.Windows.Forms.ColumnHeader();
            cmdUpdateHltb = new System.Windows.Forms.Button();
            CheckShowIgnored = new System.Windows.Forms.CheckBox();
            chkCommunityInsteadStore = new System.Windows.Forms.CheckBox();
            mainMenu.SuspendLayout();
            grpTypes.SuspendLayout();
            statusStrip1.SuspendLayout();
            grpWebUpdate.SuspendLayout();
            grpAppInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numIdRangeMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIdRangeMin).BeginInit();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { menu_File });
            resources.ApplyResources(mainMenu, "mainMenu");
            mainMenu.Name = "mainMenu";
            // 
            // menu_File
            // 
            menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menu_File_Save, menu_File_SaveAs, menu_File_Load, menu_File_Sep1, menu_File_Clear, menu_File_Sep2, menu_File_Exit });
            menu_File.Name = "menu_File";
            resources.ApplyResources(menu_File, "menu_File");
            // 
            // menu_File_Save
            // 
            menu_File_Save.Name = "menu_File_Save";
            resources.ApplyResources(menu_File_Save, "menu_File_Save");
            menu_File_Save.Click += menu_File_Save_Click;
            // 
            // menu_File_SaveAs
            // 
            menu_File_SaveAs.Name = "menu_File_SaveAs";
            resources.ApplyResources(menu_File_SaveAs, "menu_File_SaveAs");
            menu_File_SaveAs.Click += menu_File_SaveAs_Click;
            // 
            // menu_File_Load
            // 
            menu_File_Load.Name = "menu_File_Load";
            resources.ApplyResources(menu_File_Load, "menu_File_Load");
            menu_File_Load.Click += menu_File_Load_Click;
            // 
            // menu_File_Sep1
            // 
            menu_File_Sep1.Name = "menu_File_Sep1";
            resources.ApplyResources(menu_File_Sep1, "menu_File_Sep1");
            // 
            // menu_File_Clear
            // 
            menu_File_Clear.Name = "menu_File_Clear";
            resources.ApplyResources(menu_File_Clear, "menu_File_Clear");
            menu_File_Clear.Click += menu_File_Clear_Click;
            // 
            // menu_File_Sep2
            // 
            menu_File_Sep2.Name = "menu_File_Sep2";
            resources.ApplyResources(menu_File_Sep2, "menu_File_Sep2");
            // 
            // menu_File_Exit
            // 
            menu_File_Exit.Name = "menu_File_Exit";
            resources.ApplyResources(menu_File_Exit, "menu_File_Exit");
            menu_File_Exit.Click += menu_File_Exit_Click;
            // 
            // cmdFetch
            // 
            resources.ApplyResources(cmdFetch, "cmdFetch");
            cmdFetch.Name = "cmdFetch";
            cmdFetch.UseVisualStyleBackColor = true;
            cmdFetch.Click += cmdFetch_Click;
            // 
            // cmdUpdateNew
            // 
            resources.ApplyResources(cmdUpdateNew, "cmdUpdateNew");
            cmdUpdateNew.Name = "cmdUpdateNew";
            cmdUpdateNew.UseVisualStyleBackColor = true;
            cmdUpdateNew.Click += cmdUpdateUnchecked_Click;
            // 
            // cmdUpdateSelected
            // 
            resources.ApplyResources(cmdUpdateSelected, "cmdUpdateSelected");
            cmdUpdateSelected.Name = "cmdUpdateSelected";
            cmdUpdateSelected.UseVisualStyleBackColor = true;
            cmdUpdateSelected.Click += cmdUpdateSelected_Click;
            // 
            // cmdEditGame
            // 
            resources.ApplyResources(cmdEditGame, "cmdEditGame");
            cmdEditGame.Name = "cmdEditGame";
            cmdEditGame.UseVisualStyleBackColor = true;
            cmdEditGame.Click += cmdEditGame_Click;
            // 
            // cmdDeleteGame
            // 
            resources.ApplyResources(cmdDeleteGame, "cmdDeleteGame");
            cmdDeleteGame.Name = "cmdDeleteGame";
            cmdDeleteGame.UseVisualStyleBackColor = true;
            cmdDeleteGame.Click += cmdDeleteGame_Click;
            // 
            // cmdAddGame
            // 
            resources.ApplyResources(cmdAddGame, "cmdAddGame");
            cmdAddGame.Name = "cmdAddGame";
            cmdAddGame.UseVisualStyleBackColor = true;
            cmdAddGame.Click += cmdAddGame_Click;
            // 
            // grpTypes
            // 
            resources.ApplyResources(grpTypes, "grpTypes");
            grpTypes.Controls.Add(chkTypeUnknown);
            grpTypes.Controls.Add(chkTypeOther);
            grpTypes.Controls.Add(chkTypeDLC);
            grpTypes.Controls.Add(chkTypeGame);
            grpTypes.Controls.Add(chkTypeAll);
            grpTypes.Name = "grpTypes";
            grpTypes.TabStop = false;
            // 
            // chkTypeUnknown
            // 
            resources.ApplyResources(chkTypeUnknown, "chkTypeUnknown");
            chkTypeUnknown.Name = "chkTypeUnknown";
            chkTypeUnknown.UseVisualStyleBackColor = true;
            chkTypeUnknown.CheckedChanged += chkType_CheckedChanged;
            // 
            // chkTypeOther
            // 
            resources.ApplyResources(chkTypeOther, "chkTypeOther");
            chkTypeOther.Name = "chkTypeOther";
            chkTypeOther.UseVisualStyleBackColor = true;
            chkTypeOther.CheckedChanged += chkType_CheckedChanged;
            // 
            // chkTypeDLC
            // 
            resources.ApplyResources(chkTypeDLC, "chkTypeDLC");
            chkTypeDLC.Name = "chkTypeDLC";
            chkTypeDLC.UseVisualStyleBackColor = true;
            chkTypeDLC.CheckedChanged += chkType_CheckedChanged;
            // 
            // chkTypeGame
            // 
            resources.ApplyResources(chkTypeGame, "chkTypeGame");
            chkTypeGame.Name = "chkTypeGame";
            chkTypeGame.UseVisualStyleBackColor = true;
            chkTypeGame.CheckedChanged += chkType_CheckedChanged;
            // 
            // chkTypeAll
            // 
            resources.ApplyResources(chkTypeAll, "chkTypeAll");
            chkTypeAll.Checked = true;
            chkTypeAll.CheckState = System.Windows.Forms.CheckState.Checked;
            chkTypeAll.Name = "chkTypeAll";
            chkTypeAll.UseVisualStyleBackColor = true;
            chkTypeAll.CheckedChanged += chkAll_CheckedChanged;
            // 
            // cmdStore
            // 
            resources.ApplyResources(cmdStore, "cmdStore");
            cmdStore.Name = "cmdStore";
            cmdStore.UseVisualStyleBackColor = true;
            cmdStore.Click += cmdStore_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusMsg, statSelected });
            resources.ApplyResources(statusStrip1, "statusStrip1");
            statusStrip1.Name = "statusStrip1";
            // 
            // statusMsg
            // 
            statusMsg.Name = "statusMsg";
            resources.ApplyResources(statusMsg, "statusMsg");
            statusMsg.Spring = true;
            // 
            // statSelected
            // 
            statSelected.Name = "statSelected";
            resources.ApplyResources(statSelected, "statSelected");
            // 
            // cmdUpdateAppInfo
            // 
            resources.ApplyResources(cmdUpdateAppInfo, "cmdUpdateAppInfo");
            cmdUpdateAppInfo.Name = "cmdUpdateAppInfo";
            cmdUpdateAppInfo.UseVisualStyleBackColor = true;
            cmdUpdateAppInfo.Click += cmdUpdateAppInfo_Click;
            // 
            // grpWebUpdate
            // 
            resources.ApplyResources(grpWebUpdate, "grpWebUpdate");
            grpWebUpdate.Controls.Add(radWebNo);
            grpWebUpdate.Controls.Add(radWebSince);
            grpWebUpdate.Controls.Add(radWebYes);
            grpWebUpdate.Controls.Add(radWebAll);
            grpWebUpdate.Controls.Add(dateWeb);
            grpWebUpdate.Name = "grpWebUpdate";
            grpWebUpdate.TabStop = false;
            // 
            // radWebNo
            // 
            resources.ApplyResources(radWebNo, "radWebNo");
            radWebNo.Name = "radWebNo";
            radWebNo.UseVisualStyleBackColor = true;
            radWebNo.CheckedChanged += radWeb_CheckedChanged;
            // 
            // radWebSince
            // 
            resources.ApplyResources(radWebSince, "radWebSince");
            radWebSince.Name = "radWebSince";
            radWebSince.UseVisualStyleBackColor = true;
            radWebSince.CheckedChanged += radWeb_CheckedChanged;
            // 
            // radWebYes
            // 
            resources.ApplyResources(radWebYes, "radWebYes");
            radWebYes.Name = "radWebYes";
            radWebYes.UseVisualStyleBackColor = true;
            radWebYes.CheckedChanged += radWeb_CheckedChanged;
            // 
            // radWebAll
            // 
            resources.ApplyResources(radWebAll, "radWebAll");
            radWebAll.Checked = true;
            radWebAll.Name = "radWebAll";
            radWebAll.TabStop = true;
            radWebAll.UseVisualStyleBackColor = true;
            radWebAll.CheckedChanged += radWeb_CheckedChanged;
            // 
            // dateWeb
            // 
            dateWeb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(dateWeb, "dateWeb");
            dateWeb.Name = "dateWeb";
            dateWeb.ValueChanged += dateWeb_ValueChanged;
            // 
            // grpAppInfo
            // 
            resources.ApplyResources(grpAppInfo, "grpAppInfo");
            grpAppInfo.Controls.Add(radAppNo);
            grpAppInfo.Controls.Add(radAppYes);
            grpAppInfo.Controls.Add(radAppAll);
            grpAppInfo.Name = "grpAppInfo";
            grpAppInfo.TabStop = false;
            // 
            // radAppNo
            // 
            resources.ApplyResources(radAppNo, "radAppNo");
            radAppNo.Name = "radAppNo";
            radAppNo.UseVisualStyleBackColor = true;
            radAppNo.CheckedChanged += radApp_CheckedChanged;
            // 
            // radAppYes
            // 
            resources.ApplyResources(radAppYes, "radAppYes");
            radAppYes.Name = "radAppYes";
            radAppYes.UseVisualStyleBackColor = true;
            radAppYes.CheckedChanged += radApp_CheckedChanged;
            // 
            // radAppAll
            // 
            resources.ApplyResources(radAppAll, "radAppAll");
            radAppAll.Checked = true;
            radAppAll.Name = "radAppAll";
            radAppAll.TabStop = true;
            radAppAll.UseVisualStyleBackColor = true;
            radAppAll.CheckedChanged += radApp_CheckedChanged;
            // 
            // chkOwned
            // 
            resources.ApplyResources(chkOwned, "chkOwned");
            chkOwned.Checked = true;
            chkOwned.CheckState = System.Windows.Forms.CheckState.Checked;
            chkOwned.Name = "chkOwned";
            chkOwned.UseVisualStyleBackColor = true;
            chkOwned.CheckedChanged += chkOwned_CheckedChanged;
            // 
            // txtSearch
            // 
            resources.ApplyResources(txtSearch, "txtSearch");
            txtSearch.Name = "txtSearch";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            resources.ApplyResources(lblSearch, "lblSearch");
            lblSearch.Name = "lblSearch";
            // 
            // cmdSearchClear
            // 
            resources.ApplyResources(cmdSearchClear, "cmdSearchClear");
            cmdSearchClear.Name = "cmdSearchClear";
            cmdSearchClear.UseVisualStyleBackColor = true;
            cmdSearchClear.Click += cmdSearchClear_Click;
            // 
            // numIdRangeMax
            // 
            resources.ApplyResources(numIdRangeMax, "numIdRangeMax");
            numIdRangeMax.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numIdRangeMax.Name = "numIdRangeMax";
            numIdRangeMax.Value = new decimal(new int[] { 9999999, 0, 0, 0 });
            numIdRangeMax.ValueChanged += IdFilter_Changed;
            // 
            // numIdRangeMin
            // 
            resources.ApplyResources(numIdRangeMin, "numIdRangeMin");
            numIdRangeMin.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numIdRangeMin.Name = "numIdRangeMin";
            numIdRangeMin.ValueChanged += IdFilter_Changed;
            // 
            // lblIdRangeSep
            // 
            resources.ApplyResources(lblIdRangeSep, "lblIdRangeSep");
            lblIdRangeSep.Name = "lblIdRangeSep";
            // 
            // chkIdRange
            // 
            resources.ApplyResources(chkIdRange, "chkIdRange");
            chkIdRange.Name = "chkIdRange";
            chkIdRange.UseVisualStyleBackColor = true;
            chkIdRange.CheckedChanged += IdFilter_Changed;
            // 
            // lstGames
            // 
            resources.ApplyResources(lstGames, "lstGames");
            lstGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { colID, colName, colGenre, colType, colScraped, colAppInfo, colParent, colHLTBID });
            lstGames.FullRowSelect = true;
            lstGames.GridLines = true;
            lstGames.Name = "lstGames";
            lstGames.UseCompatibleStateImageBehavior = false;
            lstGames.View = System.Windows.Forms.View.Details;
            lstGames.VirtualMode = true;
            lstGames.SelectionChanged += lstGames_SelectedIndexChanged;
            lstGames.ColumnClick += lstGames_ColumnClick;
            lstGames.RetrieveVirtualItem += lstGames_RetrieveVirtualItem;
            lstGames.SearchForVirtualItem += lstGames_SearchForVirtualItem;
            lstGames.DoubleClick += lstGames_DoubleClick;
            lstGames.KeyDown += lstGames_KeyDown;
            // 
            // colID
            // 
            resources.ApplyResources(colID, "colID");
            // 
            // colName
            // 
            resources.ApplyResources(colName, "colName");
            // 
            // colGenre
            // 
            resources.ApplyResources(colGenre, "colGenre");
            // 
            // colType
            // 
            resources.ApplyResources(colType, "colType");
            // 
            // colScraped
            // 
            resources.ApplyResources(colScraped, "colScraped");
            // 
            // colAppInfo
            // 
            resources.ApplyResources(colAppInfo, "colAppInfo");
            // 
            // colParent
            // 
            resources.ApplyResources(colParent, "colParent");
            // 
            // colHLTBID
            // 
            resources.ApplyResources(colHLTBID, "colHLTBID");
            // 
            // cmdUpdateHltb
            // 
            resources.ApplyResources(cmdUpdateHltb, "cmdUpdateHltb");
            cmdUpdateHltb.Name = "cmdUpdateHltb";
            cmdUpdateHltb.UseVisualStyleBackColor = true;
            cmdUpdateHltb.Click += cmdUpdateHltb_Click;
            // 
            // CheckShowIgnored
            // 
            resources.ApplyResources(CheckShowIgnored, "CheckShowIgnored");
            CheckShowIgnored.Name = "CheckShowIgnored";
            CheckShowIgnored.UseVisualStyleBackColor = true;
            CheckShowIgnored.CheckedChanged += CheckShowIgnored_CheckedChanged;
            // 
            // chkCommunityInsteadStore
            // 
            resources.ApplyResources(chkCommunityInsteadStore, "chkCommunityInsteadStore");
            chkCommunityInsteadStore.Checked = true;
            chkCommunityInsteadStore.CheckState = System.Windows.Forms.CheckState.Checked;
            chkCommunityInsteadStore.Name = "chkCommunityInsteadStore";
            chkCommunityInsteadStore.UseVisualStyleBackColor = true;
            chkCommunityInsteadStore.CheckedChanged += ChkCommunityInsteadStore_CheckedChanged;
            // 
            // DBEditDlg
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(chkCommunityInsteadStore);
            Controls.Add(CheckShowIgnored);
            Controls.Add(cmdUpdateHltb);
            Controls.Add(chkIdRange);
            Controls.Add(lblIdRangeSep);
            Controls.Add(numIdRangeMin);
            Controls.Add(numIdRangeMax);
            Controls.Add(cmdSearchClear);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(chkOwned);
            Controls.Add(grpAppInfo);
            Controls.Add(grpWebUpdate);
            Controls.Add(cmdUpdateAppInfo);
            Controls.Add(statusStrip1);
            Controls.Add(cmdStore);
            Controls.Add(grpTypes);
            Controls.Add(cmdAddGame);
            Controls.Add(cmdDeleteGame);
            Controls.Add(cmdEditGame);
            Controls.Add(cmdUpdateSelected);
            Controls.Add(cmdUpdateNew);
            Controls.Add(cmdFetch);
            Controls.Add(lstGames);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            MinimizeBox = false;
            Name = "DBEditDlg";
            ShowIcon = false;
            ShowInTaskbar = false;
            FormClosing += DBEditDlg_FormClosing;
            Load += MainForm_Load;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            grpTypes.ResumeLayout(false);
            grpTypes.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            grpWebUpdate.ResumeLayout(false);
            grpWebUpdate.PerformLayout();
            grpAppInfo.ResumeLayout(false);
            grpAppInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numIdRangeMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIdRangeMin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menu_File;
        private System.Windows.Forms.ToolStripMenuItem menu_File_Load;
        private System.Windows.Forms.ToolStripMenuItem menu_File_Save;
        private System.Windows.Forms.ToolStripMenuItem menu_File_Exit;
        private Depressurizer.Lib.ExtListView lstGames;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colGenre;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.Button cmdFetch;
        private System.Windows.Forms.Button cmdUpdateNew;
        private System.Windows.Forms.Button cmdUpdateSelected;
        private System.Windows.Forms.Button cmdEditGame;
        private System.Windows.Forms.Button cmdDeleteGame;
        private System.Windows.Forms.Button cmdAddGame;
        private System.Windows.Forms.ToolStripSeparator menu_File_Sep1;
        private System.Windows.Forms.ToolStripMenuItem menu_File_Clear;
        private System.Windows.Forms.ToolStripSeparator menu_File_Sep2;
        private System.Windows.Forms.GroupBox grpTypes;
        private System.Windows.Forms.CheckBox chkTypeOther;
        private System.Windows.Forms.CheckBox chkTypeDLC;
        private System.Windows.Forms.CheckBox chkTypeGame;
        private System.Windows.Forms.CheckBox chkTypeAll;
        private System.Windows.Forms.Button cmdStore;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statSelected;
        private System.Windows.Forms.CheckBox chkTypeUnknown;
        private System.Windows.Forms.ToolStripStatusLabel statusMsg;
        private System.Windows.Forms.ToolStripMenuItem menu_File_SaveAs;
        private System.Windows.Forms.Button cmdUpdateAppInfo;
        private System.Windows.Forms.GroupBox grpWebUpdate;
        private System.Windows.Forms.RadioButton radWebNo;
        private System.Windows.Forms.RadioButton radWebSince;
        private System.Windows.Forms.RadioButton radWebYes;
        private System.Windows.Forms.RadioButton radWebAll;
        private System.Windows.Forms.DateTimePicker dateWeb;
        private System.Windows.Forms.GroupBox grpAppInfo;
        private System.Windows.Forms.RadioButton radAppYes;
        private System.Windows.Forms.RadioButton radAppAll;
        private System.Windows.Forms.ColumnHeader colScraped;
        private System.Windows.Forms.ColumnHeader colAppInfo;
        private System.Windows.Forms.ColumnHeader colParent;
        private System.Windows.Forms.RadioButton radAppNo;
        private System.Windows.Forms.CheckBox chkOwned;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button cmdSearchClear;
        private System.Windows.Forms.NumericUpDown numIdRangeMax;
        private System.Windows.Forms.NumericUpDown numIdRangeMin;
        private System.Windows.Forms.Label lblIdRangeSep;
        private System.Windows.Forms.CheckBox chkIdRange;
        private System.Windows.Forms.Button cmdUpdateHltb;
        private System.Windows.Forms.CheckBox CheckShowIgnored;
        private System.Windows.Forms.CheckBox chkCommunityInsteadStore;
        private System.Windows.Forms.ColumnHeader colHLTBID;
    }
}

