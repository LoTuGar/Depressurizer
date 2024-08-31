﻿using System;
using System.Collections.Generic;
using System.Linq;
using Depressurizer.Core.Enums;
using Depressurizer.Core.Models;

namespace Depressurizer.Core.Helpers
{
    public class DatabaseEntrySorter : IComparer<DatabaseEntry>
    {
        #region Public Properties

        public int SortDirection { get; private set; } = 1;

        public SortModes SortMode { get; private set; } = SortModes.Id;

        #endregion

        #region Public Methods and Operators

        public static int CompareLists(SortedSet<string> sortedX, SortedSet<string> sortedY)
        {
            if (sortedX == null)
            {
                if (sortedY == null)
                {
                    return 0;
                }

                return 1;
            }

            if (sortedY == null)
            {
                return -1;
            }

            if (sortedX.Count == sortedY.Count && !sortedX.Except(sortedY).Any())
            {
                return 0;
            }

            List<string> listX = sortedX.ToList();
            List<string> listY = sortedY.ToList();

            for (int i = 0; i < sortedX.Count && i < sortedY.Count; i++)
            {
                int res = string.Compare(listX[i], listY[i], StringComparison.Ordinal);
                if (res == 0)
                {
                    continue;
                }

                return res;
            }

            return 0;
        }

        /// <inheritdoc />
        public int Compare(DatabaseEntry x, DatabaseEntry y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    return 0;
                }

                return -1;
            }

            if (y == null)
            {
                return 1;
            }

            int res = 0;
            switch (SortMode)
            {
                case SortModes.Id:
                    res = x.Id.CompareTo(y.Id);
                    break;
                case SortModes.Name:
                    res = string.Compare(x.Name, y.Name, StringComparison.CurrentCultureIgnoreCase);
                    break;
                case SortModes.Genre:
                    res = CompareLists(x.Genres, y.Genres);
                    break;
                case SortModes.Type:
                    res = x.AppType - y.AppType;
                    break;
                case SortModes.IsScraped:
                    res = (x.LastStoreScrape > 0 ? 1 : 0) - (y.LastStoreScrape > 0 ? 1 : 0);
                    break;
                case SortModes.HasAppInfo:
                    res = (x.LastAppInfoUpdate > 0 ? 1 : 0) - (y.LastAppInfoUpdate > 0 ? 1 : 0);
                    break;
                case SortModes.Parent:
                    res = x.ParentId.CompareTo(y.ParentId);
                    break;
                case SortModes.HLTBId:
                    res = x.HLTBId.CompareTo(y.HLTBId);
                    break;
            }

            return SortDirection * res;
        }

        public void SetSortMode(SortModes mode)
        {
            SetSortMode(mode, 0);
        }

        public void SetSortMode(SortModes mode, int forceDir)
        {
            if (mode == SortMode)
            {
                SortDirection = forceDir == 0 ? SortDirection *= -1 : forceDir;
            }
            else
            {
                SortMode = mode;
                SortDirection = forceDir == 0 ? 1 : forceDir;
            }
        }

        #endregion
    }
}
