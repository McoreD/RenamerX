#region License Information (GPL v2)
/*
    TVDBLibTest - C# Library for TVDB Services
    Copyright (C) 2009  TVDBLibTest Developers

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
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace TVDBLibTest
{
    public partial class PropertyListView : UserControl
    {
        public object SelectedObject
        {
            set
            {
                SelectObject(value);
            }
        }

        public PropertyListView()
        {
            InitializeComponent();
            ContextMenu contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add("Copy name").Click += new EventHandler(PropertyListView_Click_Name);
            contextMenu.MenuItems.Add("Copy value").Click += new EventHandler(PropertyListView_Click_Value);
            lvProperty.ContextMenu = contextMenu;
        }

        private void PropertyListView_Click_Name(object sender, EventArgs e)
        {
            if (lvProperty.SelectedItems.Count > 0)
            {
                string text = lvProperty.SelectedItems[0].SubItems[0].Text;
                if (!string.IsNullOrEmpty(text))
                {
                    Clipboard.SetText(text);
                }
            }
        }

        private void PropertyListView_Click_Value(object sender, EventArgs e)
        {
            if (lvProperty.SelectedItems.Count > 0)
            {
                string text = lvProperty.SelectedItems[0].SubItems[1].Text;
                if (!string.IsNullOrEmpty(text))
                {
                    Clipboard.SetText(text);
                }
            }
        }

        private void SelectObject(object obj)
        {
            lvProperty.Items.Clear();
            if (obj != null)
            {
                Type type = obj.GetType();
                foreach (PropertyInfo property in type.GetProperties())
                {
                    object value = property.GetValue(obj, null);
                    if (value != null)
                    {
                        string value2 = null;
                        if (value.GetType() == typeof(string) && !string.IsNullOrEmpty((string)value))
                        {
                            value2 = (string)value;
                        }
                        else if (value.GetType() == typeof(int) && (int)value > -1)
                        {
                            value2 = ((int)value).ToString();
                        }
                        if (!string.IsNullOrEmpty(value2))
                        {
                            lvProperty.Items.Add(property.Name).SubItems.Add(value2);
                        }
                    }
                }
            }
            AutoSizeColumns();
        }

        private void AutoSizeColumns()
        {
            int size = lvProperty.ClientSize.Width - lvProperty.Columns[0].Width;
            if (size > 0)
            {
                lvProperty.Columns[1].Width = size;
            }
            else
            {
                lvProperty.Columns[1].Width = -2;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            AutoSizeColumns();
            base.OnPaint(e);
        }
    }
}