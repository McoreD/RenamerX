﻿#region License Information (GPL v2)

/*
    RenamerX - Rename your files eXpressly
    Copyright (C) 2009  RenamerX Developers

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v2)

using System;
using System.Collections.Generic;

[Serializable]
public class ShowItem
{
    public string ShowName { get; set; }
    public string ShowDirectory { get; set; }
    public List<PathInfo> ShowInfos = new List<PathInfo>();

    public ShowItem() { }

    public ShowItem(string showName, string showDirectory)
    {
        ShowName = showName;
        ShowDirectory = showDirectory;
    }

    public override string ToString()
    {
        return ShowName + ": " + ShowDirectory.Remove(0, ShowDirectory.LastIndexOf("\\") + 1);
    }
}