﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void 새파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 닫기CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }
       
        private void 다른이름으로저장AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }
        private void 인쇄PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 미리보기VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // 응용 프로그램 종료
        }

        private void 잘라내기TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 복사CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 붙여넣기PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 도움말HToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 프로그램정보AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); listBox2.Items.Clear(); listBox3.Items.Clear();
        }
    }
}
