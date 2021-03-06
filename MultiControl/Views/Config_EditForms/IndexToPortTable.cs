﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiControl.Functions;
using XMLDocHelperNamespace;

namespace MultiControl
{
    public partial class IndexToPortTable : Form
    {

        public IndexToPortTable()
        {
            InitializeComponent();

            DataTable node_table = PortToIndexFactory.Node_Table;
            DataTable show_table = node_table.Clone();
            foreach (DataRow node in node_table.Rows)
            {
                show_table.Rows.Add(node.ItemArray);
            }
            show_table.Columns["Port"].ColumnName = "USB Port No.";
            this.dgv_index2port.Columns.Clear();
            this.dgv_index2port.DataSource = show_table;
            this.dgv_index2port.Columns["USB Port No."].Width = 470;
        }
    }
}
