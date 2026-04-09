namespace Homework_Xml_Json.Forms
{
    partial class FormAnalytics
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            AnalyticsLabel = new Label();
            bestPlayerPanel = new Panel();
            picturePlayer = new PictureBox();
            infoBestPlayerLabel = new Label();
            topPlayerLabel = new Label();
            totalSumPanel = new Panel();
            pictureMoney = new PictureBox();
            infoTotalSumLabel = new Label();
            totalSumLabel = new Label();
            popularGamePanel = new Panel();
            popularGameLabel = new Label();
            pictureGame = new PictureBox();
            infoPopularGame = new Label();
            totalWinRatePanel = new Panel();
            pictureWinRate = new PictureBox();
            infoWinRate = new Label();
            winRateLabel = new Label();
            topPlayersDgv = new DataGridView();
            bestPlayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePlayer).BeginInit();
            totalSumPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureMoney).BeginInit();
            popularGamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureGame).BeginInit();
            totalWinRatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureWinRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topPlayersDgv).BeginInit();
            SuspendLayout();
            // 
            // AnalyticsLabel
            // 
            AnalyticsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AnalyticsLabel.AutoSize = true;
            AnalyticsLabel.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold);
            AnalyticsLabel.Location = new Point(365, 25);
            AnalyticsLabel.Name = "AnalyticsLabel";
            AnalyticsLabel.Size = new Size(262, 40);
            AnalyticsLabel.TabIndex = 0;
            AnalyticsLabel.Text = "Аналитика казино";
            AnalyticsLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // bestPlayerPanel
            // 
            bestPlayerPanel.BackColor = SystemColors.ButtonHighlight;
            bestPlayerPanel.BorderStyle = BorderStyle.FixedSingle;
            bestPlayerPanel.Controls.Add(picturePlayer);
            bestPlayerPanel.Controls.Add(infoBestPlayerLabel);
            bestPlayerPanel.Controls.Add(topPlayerLabel);
            bestPlayerPanel.Location = new Point(22, 82);
            bestPlayerPanel.Name = "bestPlayerPanel";
            bestPlayerPanel.Size = new Size(228, 109);
            bestPlayerPanel.TabIndex = 1;
            // 
            // picturePlayer
            // 
            picturePlayer.Image = Properties.Resources.Player;
            picturePlayer.Location = new Point(3, 3);
            picturePlayer.Name = "picturePlayer";
            picturePlayer.Size = new Size(93, 101);
            picturePlayer.TabIndex = 2;
            picturePlayer.TabStop = false;
            // 
            // infoBestPlayerLabel
            // 
            infoBestPlayerLabel.AutoSize = true;
            infoBestPlayerLabel.Font = new Font("Segoe UI", 12F);
            infoBestPlayerLabel.Location = new Point(133, 58);
            infoBestPlayerLabel.Name = "infoBestPlayerLabel";
            infoBestPlayerLabel.Size = new Size(48, 21);
            infoBestPlayerLabel.TabIndex = 1;
            infoBestPlayerLabel.Text = "None";
            // 
            // topPlayerLabel
            // 
            topPlayerLabel.AutoSize = true;
            topPlayerLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            topPlayerLabel.Location = new Point(119, 11);
            topPlayerLabel.Name = "topPlayerLabel";
            topPlayerLabel.Size = new Size(80, 20);
            topPlayerLabel.TabIndex = 0;
            topPlayerLabel.Text = "Топ игрок";
            // 
            // totalSumPanel
            // 
            totalSumPanel.BackColor = SystemColors.ButtonHighlight;
            totalSumPanel.BorderStyle = BorderStyle.FixedSingle;
            totalSumPanel.Controls.Add(pictureMoney);
            totalSumPanel.Controls.Add(infoTotalSumLabel);
            totalSumPanel.Controls.Add(totalSumLabel);
            totalSumPanel.Location = new Point(274, 82);
            totalSumPanel.Name = "totalSumPanel";
            totalSumPanel.Size = new Size(228, 109);
            totalSumPanel.TabIndex = 2;
            // 
            // pictureMoney
            // 
            pictureMoney.Image = Properties.Resources.Money;
            pictureMoney.Location = new Point(3, 3);
            pictureMoney.Name = "pictureMoney";
            pictureMoney.Size = new Size(93, 101);
            pictureMoney.TabIndex = 3;
            pictureMoney.TabStop = false;
            // 
            // infoTotalSumLabel
            // 
            infoTotalSumLabel.AutoSize = true;
            infoTotalSumLabel.Font = new Font("Segoe UI", 12F);
            infoTotalSumLabel.Location = new Point(134, 58);
            infoTotalSumLabel.Name = "infoTotalSumLabel";
            infoTotalSumLabel.Size = new Size(48, 21);
            infoTotalSumLabel.TabIndex = 2;
            infoTotalSumLabel.Text = "None";
            // 
            // totalSumLabel
            // 
            totalSumLabel.AutoSize = true;
            totalSumLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            totalSumLabel.Location = new Point(102, 11);
            totalSumLabel.Name = "totalSumLabel";
            totalSumLabel.Size = new Size(111, 20);
            totalSumLabel.TabIndex = 2;
            totalSumLabel.Text = "Общая сумма";
            // 
            // popularGamePanel
            // 
            popularGamePanel.BackColor = SystemColors.ButtonHighlight;
            popularGamePanel.BorderStyle = BorderStyle.FixedSingle;
            popularGamePanel.Controls.Add(popularGameLabel);
            popularGamePanel.Controls.Add(pictureGame);
            popularGamePanel.Controls.Add(infoPopularGame);
            popularGamePanel.Location = new Point(782, 82);
            popularGamePanel.Name = "popularGamePanel";
            popularGamePanel.Size = new Size(228, 109);
            popularGamePanel.TabIndex = 2;
            // 
            // popularGameLabel
            // 
            popularGameLabel.AutoSize = true;
            popularGameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            popularGameLabel.Location = new Point(93, 11);
            popularGameLabel.Name = "popularGameLabel";
            popularGameLabel.Size = new Size(134, 20);
            popularGameLabel.TabIndex = 4;
            popularGameLabel.Text = "Популярная игра";
            // 
            // pictureGame
            // 
            pictureGame.Image = Properties.Resources.Game;
            pictureGame.Location = new Point(-1, 3);
            pictureGame.Name = "pictureGame";
            pictureGame.Size = new Size(93, 101);
            pictureGame.TabIndex = 4;
            pictureGame.TabStop = false;
            // 
            // infoPopularGame
            // 
            infoPopularGame.AutoSize = true;
            infoPopularGame.Font = new Font("Segoe UI", 12F);
            infoPopularGame.Location = new Point(123, 58);
            infoPopularGame.Name = "infoPopularGame";
            infoPopularGame.Size = new Size(48, 21);
            infoPopularGame.TabIndex = 3;
            infoPopularGame.Text = "None";
            // 
            // totalWinRatePanel
            // 
            totalWinRatePanel.BackColor = SystemColors.ButtonHighlight;
            totalWinRatePanel.BorderStyle = BorderStyle.FixedSingle;
            totalWinRatePanel.Controls.Add(pictureWinRate);
            totalWinRatePanel.Controls.Add(infoWinRate);
            totalWinRatePanel.Controls.Add(winRateLabel);
            totalWinRatePanel.Location = new Point(530, 82);
            totalWinRatePanel.Name = "totalWinRatePanel";
            totalWinRatePanel.Size = new Size(228, 109);
            totalWinRatePanel.TabIndex = 3;
            // 
            // pictureWinRate
            // 
            pictureWinRate.Image = Properties.Resources.WinRate;
            pictureWinRate.Location = new Point(3, 3);
            pictureWinRate.Name = "pictureWinRate";
            pictureWinRate.Size = new Size(93, 101);
            pictureWinRate.TabIndex = 4;
            pictureWinRate.TabStop = false;
            // 
            // infoWinRate
            // 
            infoWinRate.AutoSize = true;
            infoWinRate.Font = new Font("Segoe UI", 12F);
            infoWinRate.Location = new Point(139, 58);
            infoWinRate.Name = "infoWinRate";
            infoWinRate.Size = new Size(48, 21);
            infoWinRate.TabIndex = 5;
            infoWinRate.Text = "None";
            // 
            // winRateLabel
            // 
            winRateLabel.AutoSize = true;
            winRateLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            winRateLabel.ForeColor = SystemColors.ControlText;
            winRateLabel.Location = new Point(103, 11);
            winRateLabel.Name = "winRateLabel";
            winRateLabel.Size = new Size(120, 20);
            winRateLabel.TabIndex = 3;
            winRateLabel.Text = "Процент побед";
            // 
            // topPlayersDgv
            // 
            topPlayersDgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            topPlayersDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            topPlayersDgv.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            topPlayersDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            topPlayersDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            topPlayersDgv.DefaultCellStyle = dataGridViewCellStyle2;
            topPlayersDgv.Location = new Point(22, 197);
            topPlayersDgv.MultiSelect = false;
            topPlayersDgv.Name = "topPlayersDgv";
            topPlayersDgv.ReadOnly = true;
            topPlayersDgv.Size = new Size(988, 358);
            topPlayersDgv.TabIndex = 4;
            // 
            // FormAnalytics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 567);
            Controls.Add(topPlayersDgv);
            Controls.Add(totalWinRatePanel);
            Controls.Add(popularGamePanel);
            Controls.Add(totalSumPanel);
            Controls.Add(bestPlayerPanel);
            Controls.Add(AnalyticsLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAnalytics";
            Text = "Analytics";
            bestPlayerPanel.ResumeLayout(false);
            bestPlayerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picturePlayer).EndInit();
            totalSumPanel.ResumeLayout(false);
            totalSumPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureMoney).EndInit();
            popularGamePanel.ResumeLayout(false);
            popularGamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureGame).EndInit();
            totalWinRatePanel.ResumeLayout(false);
            totalWinRatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureWinRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)topPlayersDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AnalyticsLabel;
        private Panel bestPlayerPanel;
        private Panel totalSumPanel;
        private Panel popularGamePanel;
        private Panel totalWinRatePanel;
        private Label infoBestPlayerLabel;
        private Label topPlayerLabel;
        private Label infoTotalSumLabel;
        private Label totalSumLabel;
        private Label infoPopularGame;
        private Label popularGameLabel;
        private Label winRateLabel;
        private Label infoWinRate;
        private PictureBox picturePlayer;
        private PictureBox pictureMoney;
        private PictureBox pictureWinRate;
        private PictureBox pictureGame;
        private DataGridView topPlayersDgv;
    }
}