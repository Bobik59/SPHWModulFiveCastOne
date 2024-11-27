using System.Text.RegularExpressions;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        private bool isAnalysisRunning = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if (isAnalysisRunning)
            {
                MessageBox.Show("Анализ уже запущен. Остановите его перед повторным запуском.", "Предупреждение");
                return;
            }

            isAnalysisRunning = true;

            string text = txtInput.Text;

            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Введите текст для анализа.", "Ошибка");
                isAnalysisRunning = false;
                return;
            }

            listReport.Items.Clear();

            // Выполняем анализ по выбранным параметрам
            if (chkSentences.Checked)
                listReport.Items.Add($"Количество предложений: {GetSentenceCount(text)}");

            if (chkWords.Checked)
                listReport.Items.Add($"Количество слов: {GetWordCount(text)}");

            if (chkCharacters.Checked)
                listReport.Items.Add($"Количество символов: {text.Length}");

            if (chkQuestionSentences.Checked)
                listReport.Items.Add($"Количество вопросительных предложений: {GetSpecificSentenceCount(text, "?")}");

            if (chkExclamatorySentences.Checked)
                listReport.Items.Add($"Количество восклицательных предложений: {GetSpecificSentenceCount(text, "!")}");

            if (listReport.Items.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы один параметр для анализа.", "Ошибка");
            }

            isAnalysisRunning = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (isAnalysisRunning)
            {
                isAnalysisRunning = false;
                MessageBox.Show("Анализ остановлен.", "Информация");
            }
            else
            {
                MessageBox.Show("Анализ не запущен.", "Информация");
            }
        }

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            if (listReport.Items.Count == 0)
            {
                MessageBox.Show("Отчет пуст. Проведите анализ перед сохранением.", "Ошибка");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt",
                Title = "Сохранить отчет"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllLines(saveFileDialog.FileName, listReport.Items.Cast<string>());
                    MessageBox.Show("Отчет успешно сохранен.", "Информация");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка");
                }
            }
        }

        private int GetSentenceCount(string text)
        {
            return Regex.Split(text, @"(?<=[.!?])").Where(s => !string.IsNullOrWhiteSpace(s)).Count();
        }

        private int GetWordCount(string text)
        {
            return Regex.Matches(text, @"\b\w+\b").Count;
        }

        private int GetSpecificSentenceCount(string text, string endChar)
        {
            return Regex.Matches(text, $@"[^.!?]*\{endChar}").Count;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
