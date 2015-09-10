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

    /// <summary>
    /// Class for one column editable data grid.
    /// </summary>
    public partial class CiselnikyDesign : SmartISLib.Modules.EditableGrid.StandardEditableGridControl
    {
        private string dataPropName;
        private string colHeaderText;
        private bool setWidth = false;

        /// <summary>
        /// Constructor for ///SmartISLib.Modules.EditableGrid.StandardEditableGridControl 
        /// with one column
        /// </summary>
        /// <param name="sqlTableName">¨Part of the sql command, TAble name or table plus condition.</param>
        /// <param name="dataPropertyName">DataPropertz identifies  column from table.</param>
        public CiselnikyDesign(String sqlTableName, string dataPropertyName, string colHeaderText)
        {
            //Create new befor assigment data property name
            this.gridView = new SmartISLib.Controls.FastDataGridView();
            this.colGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SqlSelect = "Select * from " + sqlTableName;
            this.colGrid.DataPropertyName = dataPropertyName;
            this.dataPropName = dataPropertyName;
            this.colGrid.HeaderText = colHeaderText;

            InitializeComponent();
        }

        public CiselnikyDesign(String sqlTableName, string dataPropertyName, string colHeaderText, int width) 
            : this(sqlTableName, dataPropertyName, colHeaderText)
        {
            this.setWidth = true;
            this.colGrid.Width = width;
        
        }
    }
}

