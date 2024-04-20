using System.Diagnostics;
using System.Text.Json;
using AI_ImageGeneration.Services;

namespace AI_ImageGeneration
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object? sender, EventArgs e)
        {
            cbModel.ValueMember = nameof(GptModel.Value);
            cbModel.DisplayMember = nameof(GptModel.Name);
            cbModel.DataSource = await GetModelsAsync();
        }

        private static async Task<IList<GptModel>> GetModelsAsync()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Config", "Models.json");
            string jsonString = await File.ReadAllTextAsync(filePath);
            List<GptModel>? models = JsonSerializer.Deserialize<List<GptModel>>(jsonString);
            return models!;
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
            var imagePath = await DownloadImageAsync(response.Data[0].Url);
            pictureBox1.ImageLocation = imagePath;
            txtGeneratedPrompt.Text = response.Data[0].RevisedPrompt;
        }

        private static async Task<string> DownloadImageAsync(string url)
        {
            string imageName = $"{Guid.NewGuid()}.png";
            string imagesDirectory = Path.Combine(Directory.GetCurrentDirectory(), "images");
            string imagePath = Path.Combine(imagesDirectory, imageName);

            using var client = new HttpClient();
            // Send a GET request to the specified Uri and get the response
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode(); // Throw if not a success code.

            // Read the content of the response as a byte array
            byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();

            // Save the byte array to a file
            await File.WriteAllBytesAsync(imagePath, fileBytes);

            return imagePath;
        }
        
        private void pictureBox1_DoubleClick(object? sender, EventArgs e)
        {
            Process.Start("explorer.exe", pictureBox1.ImageLocation);
        }
    }
}