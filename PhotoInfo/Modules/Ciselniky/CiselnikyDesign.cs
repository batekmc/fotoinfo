using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoInfo.Modules.Ciselniky
{
    public partial class CiselnikyDesign : SmartISLib.Modules.EditableGrid.StandardEditableGridControl
    {
        private string dataPropName;

        public CiselnikyDesign(String sqlTableName, string dataPropertyName)
        {
            //Create new befor assigment data property name
            this.gridView = new SmartISLib.Controls.FastDataGridView();
            this.colGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SqlSelect = "Select * from " + sqlTableName;
            this.colGrid.DataPropertyName = dataPropertyName;
            this.dataPropName = dataPropertyName;

            InitializeComponent();
        }
    }
}
