﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using Depressurizer.Core.Enums;
using Depressurizer.Core.Models;

namespace Depressurizer
{
    public partial class GameDBEntryDialog : Form
    {
        #region Fields

        public DatabaseEntry Game;

        private readonly char[] SPLIT_CHAR =
        {
            ','
        };

        #endregion

        #region Constructors and Destructors

        public GameDBEntryDialog() : this(null) { }

        public GameDBEntryDialog(DatabaseEntry game)
        {
            InitializeComponent();
            Game = game;
        }

        #endregion

        #region Public Methods and Operators

        public static T Clamp<T>(T val, T min, T max) where T : IComparable<T>
        {
            if (val.CompareTo(min) < 0)
            {
                return min;
            }

            if (val.CompareTo(max) > 0)
            {
                return max;
            }

            return val;
        }

        #endregion

        #region Methods

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (!SaveToGame())
            {
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void GameDBEntryForm_Load(object sender, EventArgs e)
        {
            foreach (object appType in Enum.GetValues(typeof(AppType)))
            {
                cmbType.Items.Add(appType);
            }

            InitializeFields(Game);
        }

        private void InitializeFields(DatabaseEntry entry = null)
        {
            if (entry == null)
            {
                cmdSave.Text = GlobalStrings.DlgGameDBEntry_Add;
                cmbType.SelectedIndex = 0;
            }
            else
            {
                txtId.Text = Game.AppId.ToString(CultureInfo.CurrentCulture);

                txtParent.Text = Game.ParentId < 0 ? "" : Game.ParentId.ToString(CultureInfo.CurrentCulture);

                cmbType.SelectedItem = Game.AppType;

                txtName.Text = Game.Name;
                if (Game.Genres != null)
                {
                    txtGenres.Text = string.Join(",", Game.Genres);
                }

                if (Game.Flags != null)
                {
                    txtFlags.Text = string.Join(",", Game.Flags);
                }

                if (Game.Tags != null)
                {
                    txtTags.Text = string.Join(",", Game.Tags);
                }

                if (Game.Developers != null)
                {
                    txtDev.Text = string.Join(",", Game.Developers);
                }

                if (Game.Publishers != null)
                {
                    txtPub.Text = string.Join(",", Game.Publishers);
                }

                if (Game.MetacriticUrl != null)
                {
                    txtMCName.Text = Game.MetacriticUrl;
                }

                if (Game.SteamReleaseDate != null)
                {
                    txtRelease.Text = Game.SteamReleaseDate;
                }

                numAchievements.Value = Clamp(Game.TotalAchievements, (int) numAchievements.Minimum, (int) numAchievements.Maximum);
                numReviewScore.Value = Clamp(Game.ReviewPositivePercentage, (int) numReviewScore.Minimum, (int) numReviewScore.Maximum);
                numReviewCount.Value = Clamp(Game.ReviewTotal, (int) numReviewCount.Minimum, (int) numReviewCount.Maximum);
                numHltbMain.Value = Clamp(Game.HltbMain, (int) numHltbMain.Minimum, (int) numHltbMain.Maximum);
                numHltbExtras.Value = Clamp(Game.HltbExtras, (int) numHltbExtras.Minimum, (int) numHltbExtras.Maximum);
                numHltbCompletionist.Value = Clamp(Game.HltbCompletionists, (int) numHltbCompletionist.Minimum, (int) numHltbCompletionist.Maximum);
                chkPlatWin.Checked = Game.Platforms.HasFlag(AppPlatforms.Windows);
                chkPlatMac.Checked = Game.Platforms.HasFlag(AppPlatforms.Mac);
                chkPlatLinux.Checked = Game.Platforms.HasFlag(AppPlatforms.Linux);

                chkWebUpdate.Checked = Game.LastStoreScrape > 0;
                chkAppInfoUpdate.Checked = Game.LastAppInfoUpdate > 0;

                dateWeb.Value = DateTimeOffset.FromUnixTimeSeconds(Math.Max(0, Game.LastStoreScrape)).DateTime;
                dateAppInfo.Value = DateTimeOffset.FromUnixTimeSeconds(Math.Max(0, Game.LastAppInfoUpdate)).DateTime;
                txtHLTBId.Text = Game.HLTBId.ToString(CultureInfo.CurrentCulture);
            }
        }

        private bool SaveToGame()
        {
            if (!ValidateEntries(out int id, out int parent))
            {
                return false;
            }

            if (Game == null)
            {
                Game = new DatabaseEntry(id);
            }

            Game.AppId = id;

            Game.ParentId = parent;

            Game.AppType = (AppType?) cmbType.SelectedItem ?? AppType.Unknown;
            Game.Name = txtName.Text;

            Game.Genres = SplitAndTrim(txtGenres.Text);
            Game.Flags = SplitAndTrim(txtFlags.Text);
            Game.Tags = SplitAndTrim(txtTags.Text);
            Game.Developers = SplitAndTrim(txtDev.Text);
            Game.Publishers = SplitAndTrim(txtPub.Text);

            Game.TotalAchievements = (int) numAchievements.Value;
            Game.ReviewPositivePercentage = (int) numReviewScore.Value;
            Game.ReviewTotal = (int) numReviewCount.Value;

            Game.HltbMain = (int) numHltbMain.Value;
            Game.HltbExtras = (int) numHltbExtras.Value;
            Game.HltbCompletionists = (int) numHltbCompletionist.Value;
            Game.HLTBId = Convert.ToInt32(txtHLTBId.Text);

            Game.MetacriticUrl = txtMCName.Text;
            Game.SteamReleaseDate = txtRelease.Text;

            Game.Platforms = AppPlatforms.None;
            if (chkPlatWin.Checked)
            {
                Game.Platforms |= AppPlatforms.Windows;
            }

            if (chkPlatMac.Checked)
            {
                Game.Platforms |= AppPlatforms.Mac;
            }

            if (chkPlatLinux.Checked)
            {
                Game.Platforms |= AppPlatforms.Linux;
            }

            Game.LastStoreScrape = chkWebUpdate.Checked ? ((DateTimeOffset) dateWeb.Value).ToUnixTimeSeconds() : 0;
            Game.LastAppInfoUpdate = chkAppInfoUpdate.Checked ? ((DateTimeOffset) dateAppInfo.Value).ToUnixTimeSeconds() : 0;

            return true;
        }

        private SortedSet<string> SplitAndTrim(string s)
        {
            SortedSet<string> result = new SortedSet<string>();

            if (string.IsNullOrWhiteSpace(s))
            {
                return result;
            }

            string[] split = s.Split(SPLIT_CHAR, StringSplitOptions.RemoveEmptyEntries);

            foreach (string sp in split)
            {
                if (string.IsNullOrWhiteSpace(sp))
                {
                    continue;
                }

                result.Add(sp.Trim());
            }

            return result;
        }

        private bool ValidateEntries(out int id, out int parent)
        {
            parent = -1;
            if (!int.TryParse(txtId.Text, out id) || id <= 0)
            {
                MessageBox.Show(GlobalStrings.DlgGameDBEntry_IDMustBeInteger);
                return false;
            }

            if (!string.IsNullOrEmpty(txtParent.Text) && !int.TryParse(txtParent.Text, out parent))
            {
                MessageBox.Show(GlobalStrings.DlgGameDBEntry_ParentMustBeInt);
            }

            return true;
        }

        #endregion
    }
}
