namespace Homework_Xml_Json
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            treeView = new TreeView();
            mainDgv = new DataGridView();
            loadInfoBtn = new Button();
            showInfoBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)mainDgv).BeginInit();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.BorderStyle = BorderStyle.None;
            treeView.Dock = DockStyle.Left;
            treeView.FullRowSelect = true;
            treeView.ItemHeight = 26;
            treeView.Location = new Point(0, 0);
            treeView.Name = "treeView";
            treeView.ShowLines = false;
            treeView.ShowRootLines = false;
            treeView.Size = new Size(207, 554);
            treeView.TabIndex = 0;
            // 
            // mainDgv
            // 
            mainDgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mainDgv.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            mainDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            mainDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            mainDgv.DefaultCellStyle = dataGridViewCellStyle2;
            mainDgv.Location = new Point(207, 101);
            mainDgv.MultiSelect = false;
            mainDgv.Name = "mainDgv";
            mainDgv.ReadOnly = true;
            mainDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mainDgv.Size = new Size(749, 453);
            mainDgv.TabIndex = 1;
            // 
            // loadInfoBtn
            // 
            loadInfoBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loadInfoBtn.Location = new Point(213, 12);
            loadInfoBtn.Name = "loadInfoBtn";
            loadInfoBtn.Size = new Size(197, 83);
            loadInfoBtn.TabIndex = 2;
            loadInfoBtn.Text = "Загрузить информацию";
            loadInfoBtn.UseVisualStyleBackColor = true;
            loadInfoBtn.Click += loadInfoBtn_Click;
            // 
            // showInfoBtn
            // 
            showInfoBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            showInfoBtn.Location = new Point(416, 12);
            showInfoBtn.Name = "showInfoBtn";
            showInfoBtn.Size = new Size(197, 83);
            showInfoBtn.TabIndex = 3;
            showInfoBtn.Text = "Показать информацию о сущности";
            showInfoBtn.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(956, 554);
            Controls.Add(showInfoBtn);
            Controls.Add(loadInfoBtn);
            Controls.Add(mainDgv);
            Controls.Add(treeView);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)mainDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView;
        private DataGridView mainDgv;
        private Button loadInfoBtn;
        private Button showInfoBtn;
    }
}
