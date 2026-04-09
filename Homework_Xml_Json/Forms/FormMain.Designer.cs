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
            analyticsBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)mainDgv).BeginInit();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.BorderStyle = BorderStyle.None;
            treeView.Dock = DockStyle.Left;
            treeView.FullRowSelect = true;
            treeView.ItemHeight = 40;
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
            mainDgv.Location = new Point(200, 0);
            mainDgv.MultiSelect = false;
            mainDgv.Name = "mainDgv";
            mainDgv.ReadOnly = true;
            mainDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mainDgv.Size = new Size(756, 554);
            mainDgv.TabIndex = 1;
            // 
            // loadInfoBtn
            // 
            loadInfoBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            loadInfoBtn.BackColor = SystemColors.Control;
            loadInfoBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loadInfoBtn.Location = new Point(12, 463);
            loadInfoBtn.Name = "loadInfoBtn";
            loadInfoBtn.Size = new Size(182, 79);
            loadInfoBtn.TabIndex = 2;
            loadInfoBtn.Text = "Загрузить информацию";
            loadInfoBtn.UseVisualStyleBackColor = false;
            loadInfoBtn.Click += loadInfoBtn_Click;
            // 
            // analyticsBtn
            // 
            analyticsBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            analyticsBtn.BackColor = SystemColors.Control;
            analyticsBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            analyticsBtn.Location = new Point(12, 378);
            analyticsBtn.Name = "analyticsBtn";
            analyticsBtn.Size = new Size(182, 79);
            analyticsBtn.TabIndex = 3;
            analyticsBtn.Text = "Аналитика";
            analyticsBtn.UseVisualStyleBackColor = false;
            analyticsBtn.Click += analyticsBtn_Click;
            // 
            // FormMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(956, 554);
            Controls.Add(analyticsBtn);
            Controls.Add(loadInfoBtn);
            Controls.Add(mainDgv);
            Controls.Add(treeView);
            Name = "FormMain";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)mainDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView;
        private DataGridView mainDgv;
        private Button loadInfoBtn;
        private Button analyticsBtn;
    }
}
