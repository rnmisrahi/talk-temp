using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Levenshtein
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnCompare_Click(object sender, EventArgs e)
    {
      int d = LevenshteinDistance.Compute(textBox1.Text, textBox2.Text);
      label1.Text = "Levenshtein Distance: " + d;
    }
  }
}
