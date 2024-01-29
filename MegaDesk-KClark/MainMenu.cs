using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_KClark
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = new AddQuote();
            addQuoteForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuoteList viewQuoteList = new QuoteList();
            viewQuoteList.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchQuote searchQuoteForm = new SearchQuote();
            searchQuoteForm.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
