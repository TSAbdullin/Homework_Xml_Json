using Homework_Xml_Json.Models;
using Homework_Xml_Json.Services.Interfaces;

namespace Homework_Xml_Json
{
    public partial class FormMain : Form
    {
        private readonly IPlayerService _playerService;
        private readonly IGameService _gameService;
        private readonly IBetService _betService;
        private readonly IFileServiceFactory _factory;

        private const string _games = "Все игры";
        private const string _players = "Все игроки";
        private const string _bets = "Все ставки";
        private const string _allTables = "Все таблицы";


        public FormMain(IFileServiceFactory factory, IBetService betService, IPlayerService playerService, IGameService gameService)
        {
            _factory = factory;
            _betService = betService;
            _gameService = gameService;
            _playerService = playerService;

            InitializeComponent();
            SetupTree();
        }

        private void SetupTree()
        {
            treeView.Font = new Font("Segoe UI", 10F);

            treeView.BackColor = Color.FromArgb(245, 245, 245);
            treeView.HideSelection = false;

            var root = new TreeNode(_allTables);
            root.Nodes.Add(_games);
            root.Nodes.Add(_players);
            root.Nodes.Add(_bets);

            treeView.Nodes.Add(root);
            root.Expand();

            treeView.AfterSelect -= TreeView_AfterSelect;
            treeView.AfterSelect += TreeView_AfterSelect;
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                switch (e.Node.Text)
                {
                    case _games:
                        mainDgv.DataSource = _gameService.GetGames();
                        break;

                    case _players:
                        mainDgv.DataSource = _playerService.GetPlayers();
                        break;

                    case _bets:
                        mainDgv.DataSource = _betService.GetBets();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private async void loadInfoBtn_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Filter = "JSON и XML|*.json;*.xml",
                Title = "Выберите файл"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var path = dialog.FileName;

                try
                {
                    var fileService = _factory.Create(path);
                    var data = await fileService.Load(path);

                    _gameService.SetData(data.Games);
                    _playerService.SetData(data.Players);
                    _betService.SetData(data.Bets);

                    MessageBox.Show("Данные загружены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
        }
    }
}