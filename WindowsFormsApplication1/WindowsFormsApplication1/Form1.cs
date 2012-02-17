using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        int currentWorld = 0;
        string[] pic = new string[3] { "./world1.png", "./world2.png", "./world3.png" };
        string[] tube = new string[3] { "./tube1.png", "./tube2.png", "./tube3.png" };
        string[] pit = new string[3] { "./pit1.png", "./pit2.png", "./pit3.png" };
        string[] coin = new string[3] { "./coin1.png", "./coin2.png", "./coin3.png" };
        SoundPlayer tubeSound = new SoundPlayer(@"smb_pipe.wav");
        SoundPlayer coinSound = new SoundPlayer(@"smb_coin.wav");
        SoundPlayer[] theme = new SoundPlayer[3] { new SoundPlayer(@"smb-overworld.wav"), new SoundPlayer(@"smb-underwater.wav"), new SoundPlayer(@"smb-underground.wav") };
        

        public Form1()
        {
            
            InitializeComponent();
        }

        private void btnRight_MouseEnter(object sender, System.EventArgs e)
        {
            changeWorld ((currentWorld + 1) % 3);    
        }

        public void changeWorld(int w)
        {
            theme[currentWorld].Stop();
            tubeSound.Play();
            System.Threading.Thread.Sleep(1000);
            currentWorld = w;
            backPic.Load(pic[w]);
            picPit.Load(pit[w]);
            picCoin.Load(coin[w]);
            picTubeR.Load(tube[w]);
            picTubeL.Load(tube[w]);
            theme[currentWorld].Play();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            changeWorld(0);
            
        }

        private void backPic_MouseEnter(object sender, System.EventArgs e)
        {
           
        }
 
        private void picTubeR_Click(object sender, EventArgs e)
        {
        
        }
        private void picCoin_MouseEnter(object sender, EventArgs e)
        {
            theme[currentWorld].Stop();
            coinSound.Play();
            System.Threading.Thread.Sleep(1000);
            theme[currentWorld].Play();
        }
       
        private void picTubeR_MouseEnter(object sender, EventArgs e)
        {
            changeWorld((currentWorld + 1) % 3);
        }
        private void picTubeL_MouseEnter(object sender, EventArgs e)
        {
            changeWorld((currentWorld + 2) % 3);
        }
        private void backPic_Click(object sender, EventArgs e)
        {

        }

        private void picTubeL_Click(object sender, EventArgs e)
        {
           
        }
    }
}
