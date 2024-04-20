using System.Diagnostics;
using AI_ImageGeneration.Services;
using System.Net;

namespace AI_ImageGeneration
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            List<GptModel> models = new List<GptModel>
            {
                new()
                {
                    Name = "[OpenAI] Dall-E 3",
                    Value = "dall-e-3"
                }
            };

            cbModel.ValueMember = nameof(GptModel.Value);
            cbModel.DisplayMember = nameof(GptModel.Name);
            cbModel.DataSource = models;
        }

        private async void btnGenerate_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApiKey.Text))
            {
                MessageBox.Show("API key is not provided");
                return;
            }

            if (string.IsNullOrWhiteSpace(cbModel.Text))
            {
                MessageBox.Show("Model is not selected");
                return;
            }

            var service = new OpenAiService();
            var response = await service.GenerateImageAsync(txtApiKey.Text, txtUserPrompt.Text, cbModel.SelectedValue!.ToString()!);
            var imagePath = DownloadImage(response.Data[0].Url);
            pictureBox1.ImageLocation = imagePath;
            txtGeneratedPrompt.Text = response.Data[0].RevisedPrompt;
        }

        private string DownloadImage(string url)
        {
            string imageName = $"{Guid.NewGuid()}.png";

            string imagesDirectory = Path.Combine(Directory.GetCurrentDirectory(), "images");
            if (!Directory.Exists(imagesDirectory))
                Directory.CreateDirectory(imagesDirectory);

            string imagePath = Path.Combine(imagesDirectory, imageName);

            WebClient webClient = new WebClient();
            webClient.DownloadFile(url, imagePath);

            return imagePath;
        }

        private void pictureBox1_DoubleClick(object? sender, EventArgs e)
        {
            Process.Start(pictureBox1.ImageLocation);
        }
    }
}