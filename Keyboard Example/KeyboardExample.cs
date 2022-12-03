using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard_Example
{
    public partial class KeyboardExample : Form
    {
        public KeyboardExample()
        {
            InitializeComponent();
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'k'|| e.KeyChar == 'K') 
                e.Handled = true; // 별도 처리 설정(이미 처리 완료 지시: 키 무시 됨 ) 
            //복사 붙여 넣기하면 입력됨
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            //TextChanged를 이용하여 복사 붙여넣기 한 k를 막을 수 있음

        }
    }
}
