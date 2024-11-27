using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WinFormsApp7
{
    public partial class Form2 : Form
    {
        private List<string> selectedFiles = new List<string>();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Все файлы|*.*"
            })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFiles.AddRange(dialog.FileNames);
                    txtSelectedFiles.Text = string.Join(Environment.NewLine, dialog.FileNames);
                }
            }
        }

        private void btnSelectDestination_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtDestinationPath.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (selectedFiles.Count == 0 || string.IsNullOrWhiteSpace(txtDestinationPath.Text))
            {
                MessageBox.Show("Выберите файлы и укажите директорию назначения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string report = ProcessFiles(selectedFiles, txtDestinationPath.Text);
                txtReport.Text = report;
                MessageBox.Show("Обработка завершена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ProcessFiles(List<string> files, string destinationPath)
        {
            var processedFiles = new StringBuilder();
            var fileHashes = new HashSet<string>();
            var movedFiles = 0;

            foreach (var filePath in files)
            {
                string fileHash = ComputeFileHash(filePath);

                if (!fileHashes.Contains(fileHash))
                {
                    fileHashes.Add(fileHash);
                    string destFilePath = Path.Combine(destinationPath, Path.GetFileName(filePath));

                    File.Move(filePath, destFilePath);
                    processedFiles.AppendLine($"Перемещён: {filePath} -> {destFilePath}");
                    movedFiles++;
                }
                else
                {
                    processedFiles.AppendLine($"Дубликат найден: {filePath}, файл пропущен.");
                }
            }

            processedFiles.AppendLine($"Обработано файлов: {movedFiles}");
            return processedFiles.ToString();
        }

        private string ComputeFileHash(string filePath)
        {
            using (var sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    byte[] hash = sha256.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReport.Text))
            {
                MessageBox.Show("Нет данных для генерации отчёта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog { Filter = "Text Files|*.txt", DefaultExt = "txt" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, txtReport.Text);
                    MessageBox.Show("Отчёт сохранён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}