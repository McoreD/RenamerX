#region License Information (GPL v2)

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
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace RenamerX
{
    public class PropertyListView : ListView
    {
        public enum ObjectType { Fields, Properties }

        public bool ConstantColumnSize { get; set; }
        public ObjectType SetObjectType { get; set; }
        public bool AllowEmptyObjects { get; set; }
        public int NameColumnSize { get; set; }

        public object SelectedObject
        {
            set
            {
                SelectObject(value);
            }
        }

        public PropertyListView()
        {
            this.ConstantColumnSize = true;
            this.SetObjectType = ObjectType.Properties;
            this.AllowEmptyObjects = false;
            this.FullRowSelect = true;
            this.HideSelection = false;
            this.MultiSelect = false;
            this.GridLines = true;
            this.View = View.Details;
            this.NameColumnSize = 125;
            this.Columns.Add("Name", this.NameColumnSize);
            this.Columns.Add("Value", 200);
            ContextMenu contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add("Copy name").Click += new EventHandler(PropertyListView_Click_Name);
            contextMenu.MenuItems.Add("Copy value").Click += new EventHandler(PropertyListView_Click_Value);
            this.ContextMenu = contextMenu;
        }

        private void PropertyListView_Click_Name(object sender, EventArgs e)
        {
            if (this.SelectedItems.Count > 0)
            {
                string text = this.SelectedItems[0].SubItems[0].Text;
                if (!string.IsNullOrEmpty(text))
                {
                    Clipboard.SetText(text);
                }
            }
        }

        private void PropertyListView_Click_Value(object sender, EventArgs e)
        {
            if (this.SelectedItems.Count > 0)
            {
                string text = this.SelectedItems[0].SubItems[1].Text;
                if (!string.IsNullOrEmpty(text))
                {
                    Clipboard.SetText(text);
                }
            }
        }

        public void SelectObject(object obj)
        {
            this.Items.Clear();
            if (obj != null)
            {
                Type type = obj.GetType();
                if (SetObjectType == ObjectType.Fields)
                {
                    foreach (FieldInfo property in type.GetFields())
                    {
                        AddObject(property.GetValue(obj), property.Name);
                    }
                }
                else if (SetObjectType == ObjectType.Properties)
                {
                    foreach (PropertyInfo property in type.GetProperties())
                    {
                        AddObject(property.GetValue(obj, null), property.Name);
                    }
                }
            }
        }

        private void AddObject(object obj, string name)
        {
            string value = ObjectToString(obj);
            if (!string.IsNullOrEmpty(value) || AllowEmptyObjects)
            {
                ListViewItem lvi = new ListViewItem(name);
                lvi.Tag = obj;
                if (value == null)
                {
                    lvi.SubItems.Add(obj.GetType().ToString());
                    lvi.BackColor = Color.LightGray;
                }
                else
                {
                    lvi.SubItems.Add(value);
                }
                this.Items.Add(lvi);
            }
        }

        private string ObjectToString(object obj)
        {
            if (obj != null)
            {
                Type type = obj.GetType();
                if (type == typeof(string) || type == typeof(byte) || type == typeof(short) || type == typeof(int) ||
                    type == typeof(long) || type == typeof(bool) || type == typeof(char))
                {
                    return obj.ToString();
                }
            }
            return null;
        }

        private void AutoResizeLastColumn()
        {
            if (this.View == View.Details && this.Columns.Count > 0)
            {
                if (ConstantColumnSize)
                {
                    this.Columns[0].Width = this.NameColumnSize;
                }
                int size = this.ClientSize.Width - this.Columns[0].Width;
                if (size > 0)
                {
                    this.Columns[1].Width = size;
                }
                else
                {
                    this.Columns[1].Width = -2;
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (!this.DesignMode && m.Msg == 0xf)
            {
                AutoResizeLastColumn();
            }
            base.WndProc(ref m);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
        }
    }
}