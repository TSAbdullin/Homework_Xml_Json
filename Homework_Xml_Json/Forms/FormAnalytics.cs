using Homework_Xml_Json.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace Homework_Xml_Json.Forms
{
    public partial class FormAnalytics : Form
    {
        private readonly IAnalyticsService _analyticsService;

        public FormAnalytics(IAnalyticsService analyticsService)
        {
            InitializeComponent();
            _analyticsService = analyticsService;

            LoadTopPlayers();
            LoadInfo();

            topPlayersDgv.Columns["Rank"].HeaderText = "№";
            topPlayersDgv.Columns["Name"].HeaderText = "Игрок";
            topPlayersDgv.Columns["TotalAmount"].HeaderText = "Сумма ставок";
        }

        private void LoadTopPlayers()
        {
            var topPlayers = _analyticsService.GetTopPlayers(100);
            topPlayersDgv.DataSource = topPlayers;
        }

        private void LoadInfo()
        {
            infoTotalSumLabel.Text = _analyticsService.GetTotalAmount().ToString();
            infoWinRate.Text = _analyticsService.GetWinRateBet().ToString() + "%";
            infoPopularGame.Text = _analyticsService.GetMostPopularGame();

            if (_analyticsService.GetTopPlayers(100).Count > 0 )
            {
                infoBestPlayerLabel.Text = _analyticsService.GetTopPlayers(100)[0].Name;
            }
        }
    }
}