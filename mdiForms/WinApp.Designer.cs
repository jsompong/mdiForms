
namespace mdiForms
{
    partial class WinApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label portLabel;
            System.Windows.Forms.Label baudLabel;
            System.Windows.Forms.Label databitLabel;
            System.Windows.Forms.Label parityLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinApp));
            this.rS232portDataSet = new mdiForms.RS232portDataSet();
            this.rs232comBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rs232comTableAdapter = new mdiForms.RS232portDataSetTableAdapters.rs232comTableAdapter();
            this.tableAdapterManager = new mdiForms.RS232portDataSetTableAdapters.TableAdapterManager();
            this.rs232comBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rs232comBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.baudTextBox = new System.Windows.Forms.TextBox();
            this.databitTextBox = new System.Windows.Forms.TextBox();
            this.parityTextBox = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            portLabel = new System.Windows.Forms.Label();
            baudLabel = new System.Windows.Forms.Label();
            databitLabel = new System.Windows.Forms.Label();
            parityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rS232portDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rs232comBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rs232comBindingNavigator)).BeginInit();
            this.rs232comBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Location = new System.Drawing.Point(21, 56);
            portLabel.Name = "portLabel";
            portLabel.Size = new System.Drawing.Size(58, 13);
            portLabel.TabIndex = 1;
            portLabel.Text = "COM port :";
            // 
            // baudLabel
            // 
            baudLabel.AutoSize = true;
            baudLabel.Location = new System.Drawing.Point(45, 82);
            baudLabel.Name = "baudLabel";
            baudLabel.Size = new System.Drawing.Size(34, 13);
            baudLabel.TabIndex = 3;
            baudLabel.Text = "baud:";
            // 
            // databitLabel
            // 
            databitLabel.AutoSize = true;
            databitLabel.Location = new System.Drawing.Point(37, 108);
            databitLabel.Name = "databitLabel";
            databitLabel.Size = new System.Drawing.Size(42, 13);
            databitLabel.TabIndex = 5;
            databitLabel.Text = "databit:";
            // 
            // parityLabel
            // 
            parityLabel.AutoSize = true;
            parityLabel.Location = new System.Drawing.Point(44, 134);
            parityLabel.Name = "parityLabel";
            parityLabel.Size = new System.Drawing.Size(35, 13);
            parityLabel.TabIndex = 7;
            parityLabel.Text = "parity:";
            // 
            // rS232portDataSet
            // 
            this.rS232portDataSet.DataSetName = "RS232portDataSet";
            this.rS232portDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rs232comBindingSource
            // 
            this.rs232comBindingSource.DataMember = "rs232com";
            this.rs232comBindingSource.DataSource = this.rS232portDataSet;
            // 
            // rs232comTableAdapter
            // 
            this.rs232comTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.rs232comTableAdapter = this.rs232comTableAdapter;
            this.tableAdapterManager.UpdateOrder = mdiForms.RS232portDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rs232comBindingNavigator
            // 
            this.rs232comBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rs232comBindingNavigator.BindingSource = this.rs232comBindingSource;
            this.rs232comBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rs232comBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rs232comBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.rs232comBindingNavigatorSaveItem});
            this.rs232comBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rs232comBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rs232comBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rs232comBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rs232comBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rs232comBindingNavigator.Name = "rs232comBindingNavigator";
            this.rs232comBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rs232comBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.rs232comBindingNavigator.TabIndex = 0;
            this.rs232comBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // rs232comBindingNavigatorSaveItem
            // 
            this.rs232comBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rs232comBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rs232comBindingNavigatorSaveItem.Image")));
            this.rs232comBindingNavigatorSaveItem.Name = "rs232comBindingNavigatorSaveItem";
            this.rs232comBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rs232comBindingNavigatorSaveItem.Text = "Save Data";
            this.rs232comBindingNavigatorSaveItem.Click += new System.EventHandler(this.rs232comBindingNavigatorSaveItem_Click);
            // 
            // portTextBox
            // 
            this.portTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rs232comBindingSource, "port", true));
            this.portTextBox.Location = new System.Drawing.Point(85, 53);
            this.portTextBox.MaxLength = 32;
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(69, 20);
            this.portTextBox.TabIndex = 2;
            // 
            // baudTextBox
            // 
            this.baudTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rs232comBindingSource, "baud", true));
            this.baudTextBox.Location = new System.Drawing.Point(85, 79);
            this.baudTextBox.Name = "baudTextBox";
            this.baudTextBox.Size = new System.Drawing.Size(69, 20);
            this.baudTextBox.TabIndex = 4;
            // 
            // databitTextBox
            // 
            this.databitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rs232comBindingSource, "databit", true));
            this.databitTextBox.Location = new System.Drawing.Point(85, 105);
            this.databitTextBox.Name = "databitTextBox";
            this.databitTextBox.Size = new System.Drawing.Size(69, 20);
            this.databitTextBox.TabIndex = 6;
            // 
            // parityTextBox
            // 
            this.parityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rs232comBindingSource, "parity", true));
            this.parityTextBox.Location = new System.Drawing.Point(85, 131);
            this.parityTextBox.Name = "parityTextBox";
            this.parityTextBox.Size = new System.Drawing.Size(69, 20);
            this.parityTextBox.TabIndex = 8;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DtrEnable = true;
            this.serialPort1.PortName = "COM6";
            this.serialPort1.ReadBufferSize = 1024;
            this.serialPort1.RtsEnable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "COM Available ";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.Blue;
            this.textBox.Location = new System.Drawing.Point(185, 90);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(92, 85);
            this.textBox.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Blue;
            this.textBox2.Location = new System.Drawing.Point(356, 28);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(232, 250);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Blue;
            this.textBox1.Location = new System.Drawing.Point(612, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(166, 250);
            this.textBox1.TabIndex = 12;
            // 
            // WinApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(parityLabel);
            this.Controls.Add(this.parityTextBox);
            this.Controls.Add(databitLabel);
            this.Controls.Add(this.databitTextBox);
            this.Controls.Add(baudLabel);
            this.Controls.Add(this.baudTextBox);
            this.Controls.Add(portLabel);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.rs232comBindingNavigator);
            this.Name = "WinApp";
            this.Text = "WinApp";
            this.Load += new System.EventHandler(this.WinApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rS232portDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rs232comBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rs232comBindingNavigator)).EndInit();
            this.rs232comBindingNavigator.ResumeLayout(false);
            this.rs232comBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RS232portDataSet rS232portDataSet;
        private System.Windows.Forms.BindingSource rs232comBindingSource;
        private RS232portDataSetTableAdapters.rs232comTableAdapter rs232comTableAdapter;
        private RS232portDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rs232comBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton rs232comBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox baudTextBox;
        private System.Windows.Forms.TextBox databitTextBox;
        private System.Windows.Forms.TextBox parityTextBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}