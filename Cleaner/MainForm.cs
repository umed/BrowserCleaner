using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cleaner
{
    public partial class MainForm : Form
    {
        Worker worker = new Worker();
        public MainForm()
        {
            InitializeComponent();

            foreach (var cleaner in worker.Cleaners)
                cleanersCB.Items.Add(cleaner);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            try
            {
                IBrowserCleaner cleaner = (IBrowserCleaner)cleanersCB.SelectedItem;
                cleaner?.Clear();

                MessageBox.Show("Кеш, куки и история браузера успешно очищены.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Не удалось очистить кеш, куки и историю браузера." + Environment.NewLine +
                    "Произошла ошибка:" + Environment.NewLine +
                    exception.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cleanersCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearButton.Enabled = true;

            IBrowserCleaner cleaner = (IBrowserCleaner)cleanersCB.SelectedItem;
            if (cleaner == null)
            {
                filesToRemoveLB.Items.Clear();
                return;
            }

            filesToRemoveLB.Items.Clear();
            filesToRemoveLB.Items.AddRange(cleaner.FilesToRemove());
        }
    }
}
