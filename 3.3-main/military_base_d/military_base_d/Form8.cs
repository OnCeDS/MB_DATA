using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace military_base_d
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\onfox\Desktop\3.3-main\MORGENSHTERN - Дуло.wav");
            simpleSound.Play();
        }
    }
}
