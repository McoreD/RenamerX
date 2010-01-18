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
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RenamerX
{
    public class ListViewX : ListView
    {
        public ListViewX()
        {
            this.FullRowSelect = true;
            this.HideSelection = false;
            this.MultiSelect = false;
            this.View = View.Details;
        }

        private void AutoResizeLastColumn()
        {
            if (this.View == View.Details && this.Columns.Count > 0)
            {
                if (this.Columns.Count == 1)
                {
                    if (this.Columns[0].Width != this.ClientRectangle.Width)
                    {
                        this.Columns[0].Width = this.ClientRectangle.Width;
                    }
                }
                else
                {
                    this.Columns[this.Columns.Count - 1].Width = -2;
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
    }
}