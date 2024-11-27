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
                MessageBox.Show("������ ��� �������. ���������� ��� ����� ��������� ��������.", "��������������");
                return;
            }

            isAnalysisRunning = true;

            string text = txtInput.Text;

            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("������� ����� ��� �������.", "������");
                isAnalysisRunning = false;
                return;
            }

            listReport.Items.Clear();

            // ��������� ������ �� ��������� ����������
            if (chkSentences.Checked)
                listReport.Items.Add($"���������� �����������: {GetSentenceCount(text)}");

            if (chkWords.Checked)
                listReport.Items.Add($"���������� ����: {GetWordCount(text)}");

            if (chkCharacters.Checked)
                listReport.Items.Add($"���������� ��������: {text.Length}");

            if (chkQuestionSentences.Checked)
                listReport.Items.Add($"���������� �������������� �����������: {GetSpecificSentenceCount(text, "?")}");

            if (chkExclamatorySentences.Checked)
                listReport.Items.Add($"���������� ��������������� �����������: {GetSpecificSentenceCount(text, "!")}");

            if (listReport.Items.Count == 0)
            {
                MessageBox.Show("�������� ���� �� ���� �������� ��� �������.", "������");
            }

            isAnalysisRunning = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (isAnalysisRunning)
            {
                isAnalysisRunning = false;
                MessageBox.Show("������ ����������.", "����������");
            }
            else
            {
                MessageBox.Show("������ �� �������.", "����������");
            }
        }

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            if (listReport.Items.Count == 0)
            {
                MessageBox.Show("����� ����. ��������� ������ ����� �����������.", "������");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "��������� ����� (*.txt)|*.txt",
                Title = "��������� �����"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllLines(saveFileDialog.FileName, listReport.Items.Cast<string>());
                    MessageBox.Show("����� ������� ��������.", "����������");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������ ��� ���������� �����: {ex.Message}", "������");
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
